using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;

  namespace  MVC_EF_Db.Models
{
    public class CodeController : Controller
    {
        northwindEntities1 nw = new northwindEntities1();
        // GET: Code
        public ActionResult Index()
        {
            return View(nw.Customers.ToList());
        }
        public ActionResult In_Germany()
        {
            List<string> li = (from g in nw.Customers
                               where g.Country == "Germany"
                               select g.CustomerID).ToList();
            return View(li);
        }
        public ActionResult CustomersByOrderId(int orderId = 10248)
        {
            var cust = nw.Customers.Where(c => c.Orders.Any(o => o.OrderID == orderId));
            if (cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }
    }
}