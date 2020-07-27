using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class HomeController : Controller // controller를 상속받고 있음
    {
        public IActionResult Student()
        {
            return View(); //View를 return
        }
    }
}
