using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newPII.Models;
using Microsoft.Identity.Web;
using System.Net.Http;
using System.Net.Http.Headers;


namespace newPII.Controllers
{

    // public static class Global {
    //     public static string token;

    // }
    [Authorize]
    public class HomeController : Controller
    {
        
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;

        // }
     //NEWTUT
//////////////////////////////////////////////////////////////////////////////////
        // readonly ITokenAcquisition tokenAcquisition;
    
        // public HomeController(ITokenAcquisition tokenAcquisition){
        //     this.tokenAcquisition=tokenAcquisition;
        // }

        // [AuthorizeForScopes(Scopes=new[]{"user.read"})]
        
        // public async Task<IActionResult> Profile()
        // {
        //     string[] scopes = new string []{"user.read"};
        //     string accessToken=await tokenAcquisition.GetAccessTokenForUserAsync(scopes);
        //     //Global.token=accessToken;
        //     //ViewData["Global.token"]=Global.token;
        //     //HttpClient client = new HttpClient();
        //     //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",accessToken);
        //     //string json = await client.GetStringAsync(Url);
        //     Console.WriteLine(accessToken);
        //     return View();
        // } 
////////////////////////////////////////////////////////////////////////////////////////
        
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
