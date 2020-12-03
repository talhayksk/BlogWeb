﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogBusiness.Abstract;
using BlogEntities.Concreate;
using BlogWebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebUI.Areas.Admin.Controllers
{


    [Area("admin")]
    public class AdminKullaniciController : Controller

    {
        IKullaniciServis _kullaniciServis;
        IRolServis _rolServis;
        public AdminKullaniciController(IKullaniciServis kullaniciServis = null, IRolServis rolServis = null)
        {
            _kullaniciServis = kullaniciServis;
            _rolServis = rolServis;

        }

        public IActionResult index()
        {

            var model = new AdminKullaniciViewModel();
            model.KulId = HttpContext.Session.GetInt32("id");
            model.Roller = _rolServis.RolleriGetir();
            model.Kullanicilar = _kullaniciServis.KullanicilariGetir();
            return View(model);

        }
     
      
   [HttpGet]
        public IActionResult Guncelle(int id)
        {
           
         var   model = new AdminKullaniciViewModel()
            {
                Kullanici = _kullaniciServis.KullaniciGetir(id)

            };
          

            return View(model);
        }
        [HttpPost]
        public IActionResult Guncelle(Kullanici kullanici)
        {
            if (kullanici.FotoUrl==null)
            {
                kullanici.FotoUrl = "user.png";
            }

            if (ModelState.IsValid)
            {
                _kullaniciServis.Guncelle(kullanici);
             
                ViewBag.GuncellendiMi = true;
            }
            return RedirectToAction("index","AdminKullanici");


        }
        [HttpPost]
        public IActionResult Sil(int id)
        {
          

            if (ModelState.IsValid)
            {
                _kullaniciServis.Sil(id);

                ViewBag.silindiMi = true;
            }
            return RedirectToAction("index", "AdminKullanici");


        }

    }
}
