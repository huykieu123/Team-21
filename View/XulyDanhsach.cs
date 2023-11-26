using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class XulyDanhsach
    {
        QUANLYBDS_21Entities db;
        public XulyDanhsach()
        {
            db = new QUANLYBDS_21Entities();
        }
        public IEnumerable<Full_Contract> GetFull_ConTract()
        {
            var sql = from objs in db.Full_Contract
                      orderby objs.ID
                      select objs;
            return sql;
        }
    }
}
