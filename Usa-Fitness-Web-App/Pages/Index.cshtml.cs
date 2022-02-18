using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Globalization;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Azure.KeyVault;
using  newPII.Models;
using Microsoft.Azure.KeyVault.Models;

using System.Collections.Generic;


//USA App

namespace newPII
{
    
    public class IndexModel : PageModel
    {
 

     
        string secret="";
 
        bool isinEurope(String country){
            string[] europcountries = new string[] {"Austria" ,"Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic","Denmark" ,"Estonia" ,"Finland", "France", "Germany" , "Greece" ,"Hungary" ,"Ireland" ,"Italy" , "Latvia" ,"Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "Slovenia", "Spain", "Sweden", "United Kingdom"};
            if(europcountries.Contains(country)){
                return true;
            }
            else{
                return false;
            }
        }



        string GetConnectionSQL(){
            
            AzureServiceTokenProvider azureServiceTokenProvider = new AzureServiceTokenProvider();
            KeyVaultClient keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
            
            if(isinEurope(User.FindFirstValue("country"))==true){
                string keyvault="https://kvfitnessappeu.vault.azure.net/";
                SecretBundle bundle= keyVaultClient.GetSecretAsync(keyvault, "sqlconnectioneuropa").Result; 
                secret=bundle.Value;
            }
            else if (User.FindFirstValue("country")=="United States"){
                string keyvault="https://kvfitnessappusa.vault.azure.net/";
                SecretBundle bundle= keyVaultClient.GetSecretAsync(keyvault, "sqlconnectionunitedstates").Result; 
                secret=bundle.Value;
            }
            ViewData["sqlKey"]=secret;
            return secret;
        }

        SqlConnection connection;

        SqlConnection setSqlConnection(string secret){
            connection = new SqlConnection(secret);
            return connection;
        }

[BindProperty]
        public WorkoutModel Workout {get; set;}
        public String [] arraydata= new String []{};
        public UserDatabaseModel [] UserArray= new UserDatabaseModel []{};
        public UserDatabaseModel dbUser{get;set;}

        
     
         protected void Page_Load()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Open();
     
            
         }
        public IActionResult OnPost(){
            secret=GetConnectionSQL();

            connection=setSqlConnection(secret);

            Page_Load();

            setValuesDatabase();

            
            if(User.Identity.IsAuthenticated){
             
              createTableForNewUser();                             
             
            }
            
            if (ModelState.IsValid==false){
                return Page();
            }
           return Page();
        }



   UserDatabaseModel GetRowDataUserTable(String UserID,String Region){
            UserDatabaseModel user=new UserDatabaseModel();
            user.UserID=UserID;
            user.Region=Region;
            return user;
        }


    bool doesUserAlreadyExist(){
        try{
            SqlCommand cmd=GetConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * FROM userTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bool userExists=false;
            //getAllUsers
            foreach (DataRow dr in dt.Rows)
            {
                var tempList = UserArray.ToList();
                var newValue=GetRowDataUserTable(dr["userID"].ToString(), dr["Region"].ToString());
                tempList.Add(newValue);
                UserArray = tempList.ToArray(); 
                //allUserIDs.Add(newValue.userID);
                if((User.FindFirstValue(ClaimTypes.NameIdentifier)).Replace("-","")==newValue.UserID ){
                    userExists=true;
                }
            }    
            Console.WriteLine(userExists);

            return userExists;
        }catch{            Console.WriteLine("doesUserAlreadyExist");

            return false;
        }
        }


        SqlCommand GetConnection(){
           
                SqlCommand cmd=new SqlCommand();
            try{
                cmd =connection.CreateCommand();
                return cmd;
            }
            catch{
                ViewData["GetConnection"]="GetConnection";
                return cmd;
            }
        }



        public void createTableForNewUser(){
                String userID=(User.FindFirstValue(ClaimTypes.NameIdentifier)).Replace("-","");
                DateTime timestamp= DateTime.Now;//utc zeit
                CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE"); 
                string format = "G";
                Workout.ID=timestamp.ToString(format,culture);

                    if(doesUserAlreadyExist()==false){ //Wenn es keinen User gibt, dann erstelle eine Tabelle und füge den neuen Wert hinzu
                        //ADD USER
                        try{
                        SqlCommand cmd =GetConnection();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into userTable(userID,Region) values('" + userID + "','" + User.FindFirstValue("country") +"')";
                        cmd.ExecuteNonQuery();
                        }catch{
                            Console.WriteLine("Add_User");
                        }
                        
                        //CREATE TABLE for Fitness-Data
                        try{
                        SqlCommand cmdneu = GetConnection();
                        cmdneu.CommandType = CommandType.Text;
                        cmdneu.CommandText =  "CREATE TABLE [" + userID + "_Fitness_Data](ID varchar(20), Gewicht int, Koerpergroesse int)";
                        cmdneu.ExecuteNonQuery();
                        }catch{
                            Console.WriteLine("create_table fitness_data");
                        }
                        //CREATE TABLE for Workout-Data
                        
                        try{
                        SqlCommand cmd_w = GetConnection();
                        cmd_w.CommandType = CommandType.Text;
                        cmd_w.CommandText =  "CREATE TABLE [" + userID + "_Workout_Data](ID varchar(20), Uebung varchar(100), count int)";
                        cmd_w.ExecuteNonQuery();
                        }catch{
                            Console.WriteLine("table for workoutdata");
                        }
                        try{
                        SqlCommand cmda = GetConnection();
                        cmda.CommandType = CommandType.Text;
                        cmda.CommandText = "insert into [" + userID + "_Workout_Data] values('" + Workout.ID + "','" + Workout.Uebung + "','" + Workout.Count +"')";
                        cmda.ExecuteNonQuery();
                        }catch{
                            Console.WriteLine("UserID");
                        }
                    
                        Workout.ID = "";
                        Workout.Uebung = "";
                        Workout.Count = 0;
                    }
                
                else{ //Wenn User da füge in seine Tabelle neue Werte
                    try{
                    SqlCommand cmd = GetConnection();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [" + userID + "_Workout_Data] values('" + Workout.ID + "','" + Workout.Uebung + "','" + Workout.Count+"')";
                    cmd.ExecuteNonQuery();
                    Workout.ID = "";
                    Workout.Uebung = "";
                    Workout.Count = 0;
                    }catch{
                        Console.WriteLine("else");
                    }
                }
        }

        public WorkoutModel [] WorkoutArray=new WorkoutModel[]{};



        SqlCommand getDatafromDB(SqlCommand cmd){
            try{
                cmd.CommandType = CommandType.Text;
                String userID=(User.FindFirstValue(ClaimTypes.NameIdentifier)).Replace("-","");
                cmd.CommandText = "select * FROM [dbo].["+userID+"_Workout_Data] ORDER BY CONVERT(DATETIME, ID,103)  ASC";                
                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd);
                return cmd;
            }
            catch{
                Console.WriteLine("Cant pull from db");
                return null;
            }
        }


        WorkoutModel [] Arrayfunction(DataTable dt){
            try{
                WorkoutModel [] Array=new WorkoutModel[]{};
                foreach (DataRow dr in dt.Rows)
                {
                    var tempList = Array.ToList();
                    var newValue=GetRowDataWorkoutTable(dr["ID"].ToString(), dr["Uebung"].ToString(), dr["Count"].ToString());
                    tempList.Add(newValue);
                    Array = tempList.ToArray(); //Array mit WorkoutModel als Objektwert
                    //allUserIDs.Add(newValue.userID);
                }
            return Array;
            }
            catch {
                Console.WriteLine("ARRAY Database false");
                return null;
            }
        }

        WorkoutModel [] getDatabaseData(){
            
            secret=GetConnectionSQL();
            connection=setSqlConnection(secret);
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Open();
            
            
            SqlCommand cmd=new SqlCommand();
            try{
                cmd =connection.CreateCommand();
                
            }
            catch{
                ViewData["GetConnection"]="GetConnection";
                
            }


            try{
                cmd.CommandType = CommandType.Text;
                String userID=(User.FindFirstValue(ClaimTypes.NameIdentifier)).Replace("-","");
                cmd.CommandText = "select * FROM [dbo].["+userID+"_Workout_Data] ORDER BY CONVERT(DATETIME, ID,103)  ASC";

                cmd.ExecuteNonQuery();

                Console.WriteLine(cmd);
            }catch{
                Console.WriteLine("sql_fail");
            }
                
            //getDatafromDB(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            WorkoutModel [] Array=new WorkoutModel[]{};
            Array=Arrayfunction(dt);
            return Array;
            
        }


        WorkoutModel GetRowDataWorkoutTable(String timestampID,String Uebung,String Count){
            WorkoutModel workoutdata=new WorkoutModel();
            workoutdata.ID=timestampID;
            workoutdata.Uebung=Uebung;
            workoutdata.Count=Int32.Parse(Count);
            return workoutdata;
        }

        public WorkoutModel[] add_ueb_count(WorkoutModel[] WorkoutArray){
            List<WorkoutModel> temp_list=WorkoutArray.ToList();
            for(int i=0;i<temp_list.Count();i++){   
                string timestamp=temp_list[i].ID;
                int position = timestamp.IndexOf(" ");
                timestamp=timestamp.Substring(0,position);  
                string ueb=temp_list[i].Uebung;
                for(int j=i+1;j<temp_list.Count();j++){
                    string timestamp_j=temp_list[j].ID;
                    int position_j = timestamp_j.IndexOf(" ");
                    timestamp_j=timestamp_j.Substring(0,position_j);  
                    if(timestamp==timestamp_j && ueb==temp_list[j].Uebung){
                        temp_list[i].Count=temp_list[i].Count+temp_list[j].Count;
                        temp_list.RemoveAt(j);
                        j=j-1;
                    }   
                }
            }
            WorkoutModel[] list=temp_list.ToArray();          
            return list;
        }

        public Dictionary<string,List<int>> setValuesDatabase(){

            List<String>ueb_list=get_ueb_list();
            var ueb_dict = new Dictionary<string, List<int>>();
            foreach (string ueb in ueb_list){
                ueb_dict[ueb] = new List<int>();
            }
            //Holen und sortieren der werte aus der Datenbank

            try{
                WorkoutArray =getDatabaseData();
                Console.WriteLine(WorkoutArray[0].ID);
            }
            catch{
               Console.WriteLine("WorkoutArray");
            }

            try{
                WorkoutArray=add_ueb_count(WorkoutArray);
            }
            catch{
                Console.WriteLine("addfail");
            }
            string temp_time="";
            bool same_day=false;
            for(int i=0;i<WorkoutArray.Length;i++){
                ueb_dict[WorkoutArray[i].Uebung].Add(WorkoutArray[i].Count);
                string new_time=WorkoutArray[i].ID;
                int poss = new_time.IndexOf(" ");
                new_time=new_time.Substring(0,poss);  
                if(new_time==temp_time){
                    same_day=true;
                }
                else{
                    same_day=false;
                }
                temp_time=WorkoutArray[i].ID;
                int pos = temp_time.IndexOf(" ");
                temp_time=temp_time.Substring(0,pos);  
                List<string> sameday=new List<string>();
                var sameday_dict = new Dictionary<string, int>();
                for(int j=0;j<WorkoutArray.Length;j++){
                    string time=WorkoutArray[j].ID;
                    int position = time.IndexOf(" ");
                    time=time.Substring(0,position);  
                    if(time==temp_time){
                        sameday.Add(WorkoutArray[j].Uebung);
                        sameday_dict[WorkoutArray[j].Uebung]=0;
                    }
                }
                List<string> sameday1=new List<string>();
                sameday1=sameday_dict.Keys.ToList();
                
                foreach (string ueb in ueb_list){
                    if(sameday_dict.ContainsKey(ueb) || same_day==true){
                        Console.WriteLine("sameday");
                    }
                    else{
                        ueb_dict[ueb].Add(0);
                    }
                }            
            }
            return ueb_dict;
       }

        public string[] get_timestamp(){
            var time_dict = new Dictionary<string, int>();
  
            //Holen der sortierten werte aus der Datenbank
            try{
                WorkoutArray =getDatabaseData();
                Console.WriteLine(WorkoutArray[0].ID);
            }
            catch{
                Console.WriteLine("WorkoutArray");
            }
            try{
                WorkoutArray=add_ueb_count(WorkoutArray);
            }
            catch{
                Console.WriteLine("addfail");
            }
            List<String> timestamplist = new List<String>();

            for(int i=0;i<WorkoutArray.Length;i++){   
                string temp_time=WorkoutArray[i].ID;
                int pos = temp_time.IndexOf(" ");
                temp_time = temp_time.Substring(0,pos);
                time_dict[temp_time]=0;
                // if(timestamplist.Contains(temp_time)){
                //     Console.WriteLine("schon da");
                // }
                // else{
                //     try{
                //         timestamplist.Append(temp_time);
                //         // int position = timestamplist[i].IndexOf(" ");
                //         // timestamplist[i]=timestamplist[i].Substring(0,position);
                //     }
                //     catch{
                //         Console.WriteLine("append_fail1");
                //         Console.WriteLine(WorkoutArray[i].Uebung);
                //     }
                // }
            }
            //String[] timestamplist_arr=timestamplist.ToArray();
            String[] timestamplist_arr=time_dict.Keys.ToArray();
            return timestamplist_arr;
        }

       
        public List<String> get_ueb_list(){
            var ueb_dict = new Dictionary<string, int>();

            try{
                WorkoutArray =getDatabaseData();
                Console.WriteLine(WorkoutArray[0].ID);
            }
            catch{
               Console.WriteLine("WorkoutArray");
            }
            int ges_ueb_count=0;
            List<String> ueb_list = new List<String>();

            for(int i=0;i<WorkoutArray.Length;i++){
                ueb_dict[WorkoutArray[i].Uebung]=0;
                // if(ueb_list.Contains(WorkoutArray[i].Uebung)){
                    
                // }
                // else{
                //     ueb_list.Add(WorkoutArray[i].Uebung);
                //     ges_ueb_count+=1;
                // }
                
                
            }
            ueb_list=ueb_dict.Keys.ToList();
            Object[] datalist = new Object[] {ges_ueb_count,ueb_list};
            return ueb_list;
        }

               public String[] get_uebungen(){
          //Holen der sortierten werte aus der Datenbank
           try{
            WorkoutArray =getDatabaseData();
            Console.WriteLine(WorkoutArray[0].ID);

           }catch{
               Console.WriteLine("WorkoutArray");
           }
            string [] uebunglist = new string [WorkoutArray.Length];

            for(int i=0;i<WorkoutArray.Length;i++){
                try{
                    uebunglist[i]=(WorkoutArray[i].Uebung);
                }
                catch{
                    Console.WriteLine("append_fail1");
                    Console.WriteLine(WorkoutArray[i].Uebung);
                }
           }
           return uebunglist;
       }

           public int[] get_count(){
            //Holen der sortierten werte aus der Datenbank
            try{
                WorkoutArray =getDatabaseData();
                Console.WriteLine(WorkoutArray[0].ID);
            }
            catch{
               Console.WriteLine("WorkoutArray");
            }
            int [] countlist = new int [WorkoutArray.Length];
            for(int i=0;i<WorkoutArray.Length;i++){
                try{
                    countlist[i]=(WorkoutArray[i].Count);
                }catch
                {
                    Console.WriteLine("append_fail1");
                    Console.WriteLine(WorkoutArray[i].Uebung);
                }
            }
            return countlist;
        }
 

 
        
 



    
    }
}