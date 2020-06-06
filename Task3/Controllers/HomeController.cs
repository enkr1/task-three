using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost] 
        public ActionResult FormSubmit()
        {
            // Validate Google recaptcha
            var response = Request["g-recaptcha-response"];
            string secretKey = "6LfLlQAVAAAAAE6TsSbSxq_eGqTifNXjKMCyoGSf";
            var client = new WebClient();
            var result = client
                .DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));
            var obj = JObject.Parse(result);
            var status = (bool)obj.SelectToken("success");
            ViewBag.Message = status ? "reCAPTCHA validation success" : "reCAPTCHA validation failed";


            return View("Index");
        }

    }
}
