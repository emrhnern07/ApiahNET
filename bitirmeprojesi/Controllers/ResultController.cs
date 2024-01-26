using bitirmeprojesi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bitirmeprojesi.Controllers
{
    public class ResultController : Controller
    {
        bitirme_projesiEntities8 db = new bitirme_projesiEntities8();

        [HttpGet]
        public ActionResult eimarSonuc(ozgurluk bilgiler)
        {
            var veriler = db.ozgurluk.Where(x => x.ada_no == bilgiler.ada_no && x.parsel_no == bilgiler.parsel_no ).ToList();

            var ozgurluk = veriler.FirstOrDefault();

            if (ozgurluk != null)
            {
                return View(ozgurluk);
            }
            else
            {
                return RedirectToAction("eimar", "Home");
            }
        }

        [HttpGet]
        public ActionResult insaatHesaplamaSonuc(ozgurluk bilgilerInsaat)
        {
            var veriler = db.ozgurluk.Where(x => x.ada_no == bilgilerInsaat.ada_no && x.parsel_no == bilgilerInsaat.parsel_no).ToList();

            var ozgurluk = veriler.FirstOrDefault();

            if (ozgurluk != null)
            {
                
                double hesaplananAlan;
                if(ozgurluk.ozgurluk_katlar.id==1 )
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 15 * 7;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                   
                }
                else if(ozgurluk.ozgurluk_katlar.id == 5)
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 15 * 7;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                else if (ozgurluk.ozgurluk_katlar.id == 2)
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 18 * 4;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                else if (ozgurluk.ozgurluk_katlar.id == 3)
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 18 * 3;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                else if (ozgurluk.ozgurluk_katlar.id == 4)
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 18 * 1;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                else if (ozgurluk.ozgurluk_katlar.id == 6)
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 18 * 5;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                else if (ozgurluk.ozgurluk_katlar.id == 7)
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 18 * 4;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                else if (ozgurluk.ozgurluk_katlar.id == 8)
                {
                    hesaplananAlan = (float)ozgurluk.insaat_cephesi * 18 * 3;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                else if (ozgurluk.ozgurluk_katlar.id == 9)
                {
                    hesaplananAlan = 0;
                    ozgurluk.hesaplananAlan = hesaplananAlan;
                    
                }
                return View("insaatHesaplamaSonuc", ozgurluk);


            }
            else
            {
                return RedirectToAction("insaatHesaplamaGiris", "Home");
            }
        }


    }
}




//double hesaplananAlan = (double)ozgurluk.alan_m2 * 5;

//