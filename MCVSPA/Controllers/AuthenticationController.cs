using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MCVSPA.Controllers
{
    using MCVSPA.Models;

    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("_SignOn");
        }
        
        public IActionResult SignIn(SignOn model)
        {
            
            return PartialView("_SignOn");
        }
    }
}