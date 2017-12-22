using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoestore.Models
{
    public interface IIStore
    {
       IQueryable<Table_3> Table_3 { get;  }

       IQueryable<Table_4> Table_4 { get; }

        Table_3 Save(Table_3 table_3);

        void Delete(Table_3 table_3);
    }
}
