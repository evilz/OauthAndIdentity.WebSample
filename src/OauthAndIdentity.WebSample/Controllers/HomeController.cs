using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace OauthAndIdentity.WebSample.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var githubInfo = await HttpContext.Authentication.GetAuthenticateInfoAsync("Automatic");
            var tokens = githubInfo.Properties.GetTokens();
            return View(tokens);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
