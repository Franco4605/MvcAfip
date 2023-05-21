using Microsoft.AspNetCore.Mvc;
using MvcAfip.Models;
using System.Reflection;


namespace MvcAfip.Controllers
{
    public class AfipController : Controller
    {
        public static List<Afip> afipList = new List<Afip>();
        public IActionResult Index()
        {


            return View(afipList);
        }


        public ActionResult Create()
        {
            return View();
        }
        


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Afip pag)
        {
            try
            {

                afipList.Add(pag);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
       
    }
}
