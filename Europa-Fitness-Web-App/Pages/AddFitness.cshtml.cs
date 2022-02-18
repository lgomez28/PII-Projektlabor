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

namespace newPII
{        
    public class AddFitnessModels : PageModel
    {
        bool isinEurope(String country){
            string[] europcountries = new string[] {"Austria" ,"Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic","Denmark" ,"Estonia" ,"Finland", "France", "Germany" , "Greece" ,"Hungary" ,"Ireland" ,"Italy" , "Latvia" ,"Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "Slovenia", "Spain", "Sweden", "United Kingdom"};
            if(europcountries.Contains(country)){
                return true;
            }
            else{
                return false;
            }
        }
        string secret="";
        string GetConnectionSQL(){
            
            AzureServiceTokenProvider azureServiceTokenProvider = new AzureServiceTokenProvider();
            KeyVaultClient keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
           
             if(isinEurope(User.FindFirstValue("country"))){
                string keyvault="https://kvfitnessappeu.vault.azure.net/";
                SecretBundle bundle= keyVaultClient.GetSecretAsync(keyvault, "sqlconnectioneuropa").Result; 
                secret=bundle.Value;
            }
            else if (User.FindFirstValue("country")=="United States"){
                string keyvault="https://kvfitnessappusa.vault.azure.net/"; 
                SecretBundle bundle= keyVaultClient.GetSecretAsync(keyvault, "sqlconnectionunitedstates").Result; 
                secret=bundle.Value;
            }
            return secret;
        }

        SqlConnection connection;

        SqlConnection setSqlConnection(string secret){
            connection = new SqlConnection(secret);
            return connection;
        }
        
        [BindProperty]

        public FitnessModels Fitness {get; set;}
        public String [] arraydata= new String []{};
        public UserDatabaseModel [] UserArray= new UserDatabaseModel []{};
        public UserDatabaseModel dbUser{get;set;}
        public void OnGet(){

        }
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
            return userExists;
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
            try{
                    String userID=(User.FindFirstValue(ClaimTypes.NameIdentifier)).Replace("-","");
                    DateTime timestamp= DateTime.Now;//utc zeit
                    CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE"); 
                    string format = "G";
                    Fitness.ID=timestamp.ToString(format,culture);
                    
                        if(doesUserAlreadyExist()==false){ //Wenn es keinen User gibt, dann erstelle eine Tabelle und füge den neuen Wert hinzu
                                            
                            //ADD USER
                            
                            SqlCommand cmd =GetConnection();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into userTable(userID,Region) values('" + userID + "','" + User.FindFirstValue("country") +"')";
                            cmd.ExecuteNonQuery();
                            
                            
                            //CREATE TABLE for Fitness-Data
                            
                            SqlCommand cmdneu = GetConnection();
                            cmdneu.CommandType = CommandType.Text;
                            cmdneu.CommandText =  "CREATE TABLE [" + userID + "_Fitness_Data](ID varchar(20), Gewicht int, Koerpergroesse int)";
                            cmdneu.ExecuteNonQuery();
                            
                            //CREATE TABLE for Workout-Data
                            
                            SqlCommand cmd_w = GetConnection();
                            cmd_w.CommandType = CommandType.Text;
                            cmd_w.CommandText =  "CREATE TABLE [" + userID + "_Workout_Data](ID varchar(20), Uebung varchar(100), count int)";
                            cmd_w.ExecuteNonQuery();
                            
                            
                            //'" + userID + "'
                            
                            SqlCommand cmda = GetConnection();
                            cmda.CommandType = CommandType.Text;
                            cmda.CommandText = "insert into [" + userID + "_Fitness_Data] values('" + Fitness.ID + "','" + Fitness.Gewicht + "','" + Fitness.Koerpergroesse+"')";
                            cmda.ExecuteNonQuery();
                           
                        
                            Fitness.ID = "";
                            Fitness.Gewicht = 0;
                            Fitness.Koerpergroesse = 0;
                        }
                    
                else{ //Wenn User da füge in seine Tabelle neue Werte
                    SqlCommand cmd = GetConnection();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [" + userID + "_Fitness_Data] values('" + Fitness.ID + "','" + Fitness.Gewicht + "','" + Fitness.Koerpergroesse+"')";
                    cmd.ExecuteNonQuery();
                    Fitness.ID = "";
                    Fitness.Gewicht = 0;
                    Fitness.Koerpergroesse = 0;
                    
                }
            }
            catch{
                ViewData["createTable"]="Create Table";
            }
        }


       public FitnessModels [] FitnessArray=new FitnessModels[]{};
        SqlCommand getDatafromDB(SqlCommand cmd){
            try{
                cmd.CommandType = CommandType.Text;
                String userID=(User.FindFirstValue(ClaimTypes.NameIdentifier)).Replace("-","");
                cmd.CommandText = "select * FROM [dbo].["+userID+"_Fitness_Data] ORDER BY CONVERT(DATETIME, ID,103)  ASC";                

                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd);
                return cmd;
            }
            catch{
                Console.WriteLine("Cant pull from db");
                return null;
            }
        }
        FitnessModels [] Arrayfunction(DataTable dt){
            try{
                FitnessModels [] Array=new FitnessModels[]{};
                foreach (DataRow dr in dt.Rows)
                {
                    var tempList = Array.ToList();
                    var newValue=GetRowDataFitnessTable(dr["ID"].ToString(), dr["Gewicht"].ToString(), dr["Koerpergroesse"].ToString());
                    tempList.Add(newValue);
                    Array = tempList.ToArray(); //Array mit FitnessModel als Objektwert
                    //allUserIDs.Add(newValue.userID);
                }
            return Array;
            }
            catch {
                Console.WriteLine("ARRAY Database false");
                return null;
            }
        }

    


        FitnessModels [] getDatabaseData(){
            
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
                //SqlCommand cmd1=new SqlCommand();

                cmd.CommandType = CommandType.Text;
                String userID=(User.FindFirstValue(ClaimTypes.NameIdentifier)).Replace("-","");
                cmd.CommandText = "select * FROM [dbo].["+userID+"_Fitness_Data] ORDER BY CONVERT(DATETIME, ID,103)  ASC";

                cmd.ExecuteNonQuery();

                Console.WriteLine(cmd);
            }catch{
                Console.WriteLine("sql_fail");
            }
                
            //getDatafromDB(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FitnessModels [] Array=new FitnessModels[]{};
            Array=Arrayfunction(dt);
            Console.WriteLine(Array);
            return Array;
            
        }
         FitnessModels GetRowDataFitnessTable(String timestampID,String Gewicht,String Koerpergroesse){
            FitnessModels fitnessdata=new FitnessModels();
            fitnessdata.ID=timestampID;
            fitnessdata.Gewicht=Int32.Parse(Gewicht);
            fitnessdata.Koerpergroesse=Int32.Parse(Koerpergroesse);
            return fitnessdata;
        }
       public object[] setValuesDatabase(){
           

           //Holen der sortierten werte aus der Datenbank
           try{
            FitnessArray =getDatabaseData();
            Console.WriteLine(FitnessArray[0].ID);

           }catch{
               Console.WriteLine("FitnessArray");
           }
            int [] gewichtlist = new int [FitnessArray.Length];
            int [] koerpergroesselist = new int [FitnessArray.Length];
            string [] timestamplist = new string [FitnessArray.Length];
            float [] bmilist = new float [FitnessArray.Length];

           for(int i=0;i<FitnessArray.Length;i++){
               
                try{
                    gewichtlist[i]=(FitnessArray[i].Gewicht);
                    koerpergroesselist[i]=(FitnessArray[i].Koerpergroesse);
                    timestamplist[i]=(FitnessArray[i].ID);
                    bmilist[i]=((float)FitnessArray[i].Gewicht)/(((float)FitnessArray[i].Koerpergroesse/100)*((float)FitnessArray[i].Koerpergroesse/100));
                    Console.WriteLine(bmilist[i]);
                    Console.WriteLine(bmilist[i].GetType());
                    
               }catch{
                    Console.WriteLine("append_fail1");
                    Console.WriteLine(FitnessArray[i].Gewicht);

               }
           }
            Object[] datalist = new Object[] {gewichtlist,koerpergroesselist,bmilist,timestamplist};

           return  datalist;
       }



    }
}
