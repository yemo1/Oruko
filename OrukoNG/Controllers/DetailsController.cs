using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrukoNG.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index()
        {
            string names = string.Empty;
            if (!string.IsNullOrEmpty(Request.QueryString["name"]))
            {
                names = Request.QueryString["name"];
            }
            return View();
        }
    }
}