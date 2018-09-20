using AulaASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulaASPNETMVC.Controllers
{
    public class PrimeiroController : Controller
    {
        // GET: Primeiro
        public ActionResult Index()
        {
            PrimeiroModel primeiroModel = new PrimeiroModel { Nome="Priscilla" };
            return View(primeiroModel);
        }
    }
}