using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TayrasDb.Models;

namespace TayrasDb.Controllers
{
  
    public class AdminController : Controller
    {
        TayrasDbEntities db = new TayrasDbEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kullanicilars.ToList();
            return View(sorgu);
        }
    }
}