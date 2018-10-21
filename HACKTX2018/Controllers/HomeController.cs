// Name: Jerry Sun
// Date: Oct 15 2018
// HW4, MVC Supplier
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HACKTX2018.Models;

namespace Sun_Jerry_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult CompanyComponent()
        {
            return View();
        }
    }
}