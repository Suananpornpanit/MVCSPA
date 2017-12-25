using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MCVSPA.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("_SignOn");
        }

        [ActionName("SignOn")]
        public IActionResult SignIn(MCVSPA.Models.SignOn obj)
        {
            
            return PartialView("Home/_SignOn");
        }
    }
}