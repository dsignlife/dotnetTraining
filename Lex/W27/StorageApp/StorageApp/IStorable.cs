using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp
{
    interface IStorable

    {

        int MaxVolumeCM2 { get; }
        int MaxWeightGram { get;  }
        string ItemID { get; set; }


          }
}
