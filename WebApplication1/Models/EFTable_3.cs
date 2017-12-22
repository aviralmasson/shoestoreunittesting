using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shoestore.Models;
using Shoestore.Controllers;

namespace Shoestore.Models
{
    public class EFTable_3 : iTable_3
    {
        Model1 db = new Model1();

        public IQueryable<Table_3> Table_3 { get { return db.Table_3; } }

        public IQueryable<Table_4> Table_4 => throw new NotImplementedException();

        

        public void Delete(Table_3 table_3)
        {
            db.Table_3.Remove(table_3);
            db.SaveChanges();
        }

        public Table_3 Save(Table_3 table_3)
        {
            if (table_3.footsize == 0 )
            {
                db.Table_3.Add(table_3);
            }
            else
            {
                db.Entry(Table_3).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return table_3;
        }

        
    }
}