using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shoestore.Models;

namespace Shoestore.Controllers
{

    public class Table_3Controller : Controller
    {
        private IIStore db;

        public Table_3Controller()
        {
            this.db = new EFStore();
        }

        public Table_3Controller(IIStore db)
        {
            this.db = db;
        }

        // GET: Table_3
        public ViewResult Index()
        {
            return View(db.Table_3.ToList());
        }

        // GET: Table_3/Details/5
        public ViewResult Details(int? id)
        {
            if (id == null)
            {
                return View ("Error");
            }
            Table_3 table_3 = db.Table_3.FirstOrDefault(a => a.footsize == id);

            if (table_3 == null)
            {
                return View("Error");
            }
            return View(table_3);
        }

       

        // POST: Table_3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ViewResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }

            Table_3 table_3 = db.Table_3.FirstOrDefault(a => a.footsize == id);

            if (table_3 == null)
            {
                return View("Error");
            }

            db.Delete(table_3);
            return NewMethod();
        }

        private ViewResult NewMethod()
        {
            return View("Index");
        }

       
    }
}
