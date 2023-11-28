using Microsoft.AspNetCore.Mvc;
using Proje_Revize_.Models;
using System.Diagnostics;

namespace Proje_Revize_.Controllers
{
    public class Default : Controller
    {
       Context c=new Context();
        public IActionResult Index()
        {
            var degerler=c.Birims.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult yeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult yeniBirim(Birim b)
        {
            c.Birims.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult birimSil(int id)
        {
            var deg = c.Birims.Find(id);
            c.Birims.Remove(deg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult birimGetir(int id)
        {
            var brm = c.Birims.Find(id);
            return View("birimGetir", brm);
        }
        public IActionResult birimGuncelle(Birim d)
        {
            var brm = c.Birims.Find(d.BirimID);
            brm.BirimAd = d.BirimAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}