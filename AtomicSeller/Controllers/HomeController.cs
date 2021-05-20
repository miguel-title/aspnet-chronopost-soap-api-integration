using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtomicSeller.Helpers;
using AtomicSeller.ViewModels;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using AtomicSeller.Helpers.eCommerceConnectors;
using ChronopostAPI.Models;

namespace AtomicSeller.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendParcelInfo()
        {
            ResponseEnvelope getCreateShipmentResponse = new Chronopost().Chronopost_SendParcelInfo();

            return RedirectToAction("Index", "Home");
        }

        
    }
}