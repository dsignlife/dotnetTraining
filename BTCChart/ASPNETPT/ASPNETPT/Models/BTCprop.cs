using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPT.Models
{
    public class BtCprop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public decimal Ask { get; set; }
        public decimal Bid { get; set; }

        //public IQueryable<BtCprop> query { get; set; }
        //public ICollection<BtCprop> Btcs { get; set; }

    }
}
