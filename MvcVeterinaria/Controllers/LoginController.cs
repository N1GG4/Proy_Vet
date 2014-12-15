using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcVeterinaria.Models;
namespace MvcVeterinaria.Controllers
{
    public class LoginController : Controller
    {
        VeterinariaDB db = new VeterinariaDB();

        public ActionResult Index()
        {
            return View();
        }

    }
}
