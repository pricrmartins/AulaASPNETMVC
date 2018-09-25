using AulaASPNETMVC.Models;
using System.Web.Mvc;

namespace AulaASPNETMVC.Controllers
{
    public class PrimeiroController : Controller
    {
        // GET: Primeiro
        public ActionResult Index()
        {
            return View(new PrimeiroModel());
        }
        [HttpPost]
        public ActionResult Index(PrimeiroModel primeiroModel)
        {
            primeiroModel = new PrimeiroModel { Nome = "Priscilla" };
            return View(primeiroModel);
        }
    }
}