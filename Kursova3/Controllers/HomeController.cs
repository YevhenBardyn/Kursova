using Kursova3.Context;
using Kursova3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kursova3.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();
        public ActionResult Index()
        {

            return View((from c in db.Products select c).ToList());
        }
        public ActionResult AddProduct(int productID)
        {
            Product product = (from c in db.Products where c.ProductID == productID select c).FirstOrDefault();
            product.IsPrior = true;
            product.IsInStorage = true;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect("/Home");
        }
        public ActionResult ShowStorage()
        {

            return View((from c in db.Products select c).ToList());
        }
        public ActionResult DeleteProduct(int productID)
        {
            Product product = (from c in db.Products where c.ProductID == productID select c).FirstOrDefault();
            product.IsPrior = false;
            product.IsInStorage = false;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect("/Home/ShowStorage");
        }
        public ActionResult Buy()
        {
            db.Orders.Add(new Order());
            foreach (var item in (from c in db.Products select c).ToList())
            {
                item.IsInStorage = false;
                item.IsPrior = false;
                db.Entry(item).State = EntityState.Modified;
            }
            db.SaveChanges();
            return View();
        }
    }
}