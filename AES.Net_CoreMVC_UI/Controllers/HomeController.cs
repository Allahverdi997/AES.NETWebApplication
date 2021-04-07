using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AES.Net_DataAccessLayer.Concrete.Ado.Net;
using Microsoft.AspNetCore.Mvc;

namespace AES.Net_CoreMVC_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
         {
            return View();
        }
    }
}
