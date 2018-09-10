using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rockstar.ViewModels;

namespace Rockstar.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LogIn()
        {
            return View(new LogInViewModel("hoi"));
        }
    }
}