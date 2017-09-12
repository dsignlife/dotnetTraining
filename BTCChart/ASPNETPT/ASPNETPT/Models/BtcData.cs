using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace ASPNETPT.Models
{
    public class BtcData
    {
        private Connector _context;

        public BtcData(Connector context)
        {
            _context = context;
        }


        public IQueryable<BtCprop> GetBtcs()
        {
            return _context.Set<BtCprop>();
        }


    }
}
