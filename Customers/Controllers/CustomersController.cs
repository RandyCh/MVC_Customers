using Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customers.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            NorthwindEntities dc = new NorthwindEntities();
            return View(dc.Customers);
        }

        public ActionResult Details(string CustomerID)
        {
            NorthwindEntities dc = new NorthwindEntities();
            Models.Customers c = dc.Customers.Find(CustomerID);
            if (c == null)
            {
                return HttpNotFound();//回傳404
            }
            return View(c);
        }
    }
}