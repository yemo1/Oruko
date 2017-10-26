using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrukoNG.Models;
using OrukoData;
using OrukoNG.Repositories;
using OrukoNG.Entities;
using PagedList;
using System.Configuration;

namespace OrukoNG.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        IName _name;
        public HomeController()
        {
            this._name = new Name(new OrukoContext());
        }

        [Route("{Network}")]
        public ActionResult Index()
        {
            Xters x = new Xters();
            //List<string> letters = new List<string>(new string[]
            //{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "ALL" 
            //});
            
            return View(x.All());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("MTN/Names/{name}")]
        public ActionResult Details(string currentFilter, int? page, string searchString)
        {
           
           string name = RouteData.Values["name"].ToString();
           //OrukoEntities db = new OrukoEntities();
           //var c = db.Tunes.Where(l => l.Names.StartsWith(name));
            try
            {
                
                if (searchString != null)
                {
                    page = 1;
                }
                else
                {
                    searchString = currentFilter;
                }
                var lists = from list in _name.GetTunes().Where(c=>c.Names.StartsWith(name))
                        select list;
                if (!string.IsNullOrEmpty(searchString))
                {
                    lists = lists.Where(c => c.Names.ToUpper() == searchString.ToUpper());
                    
                }
                int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
                int pageNumber = (page ?? 1);
                return View(lists.ToPagedList(pageNumber, pageSize));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return View();
        }
        //[Route("Etisalat/Names")]
        
        public ActionResult Filtered(string currentFilter, int? page, string searchString)
        {
            ////DataLayer dl = new DataLayer();
            //string name = RouteData.Values["name"].ToString();
            //OrukoEntities db = new OrukoEntities();
            //var c = db.ETunes.Where(l => l.Rbt_Name.StartsWith(name));
            //return View(c);

            //string name = RouteData.Values["name"].ToString();
            //OrukoEntities db = new OrukoEntities();
            //var c = db.Tunes.Where(l => l.Names.StartsWith(name));
            try
            {

                if (searchString != null)
                {
                    page = 1;
                }
                else
                {
                    searchString = currentFilter;
                }
                var lists = from list in _name.GetETunes()//.Where(c => c.Rbt_Name.StartsWith(name))
                            select list;
                if (!string.IsNullOrEmpty(searchString))
                {
                    lists = lists.Where(c => c.Rbt_Name.ToUpper() == searchString.ToUpper());

                }
                int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
                int pageNumber = (page ?? 1);
                return View(lists.ToPagedList(pageNumber, pageSize));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return View();
        }

        public ActionResult Landing()
        {
            return View();
        }
    }
}