using MVC_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2.Controllers
{
    public class CounterController : Controller
    {

        //web dünyasında veri tutmak veya veri aktarmak için mümkün olduğunca static KULLANMAKTAN KAÇIN!!!!
        //bunun yerine sessionlar kullanılır.

        // GET: Counter
        public ActionResult Index()
        {
            CounterModel model = new CounterModel();
            int sayi = 0;
            if (Session["Sayi"]==null)
            {
                Session.Add("Sayi", sayi);
            }
            sayi = (int)Session["Sayi"];
            model.Sayi = sayi + 1;
            Session["Sayi"] = model.Sayi;
            return View(model);
        }
    }
}