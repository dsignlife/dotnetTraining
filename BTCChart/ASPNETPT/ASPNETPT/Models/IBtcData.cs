using System.Collections.Generic;

namespace ASPNETPT.Models
{
    public interface IBtcData
    {
        IEnumerable<BtCprop> GetBtcs();
    }
}