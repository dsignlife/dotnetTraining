﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace ASPNETPT.Models
{
    public class BtcContextData
    {
        private BtcContext _context;

        public BtcContextData(BtcContext context)
        {
            _context = context;
        }


        public async Task seedData()
        {
            if (!_context.Btcs.Any())
            {
                var data = new BtCprop()
                {
                    Name = "Bitcoin USD",
                    Rate = 5000,
                    Date = "10/00/10",
                    Time = DateTime.UtcNow.ToString(),
                    Ask = 2900,
                    Bid = 3000

                };

                _context.Btcs.Add(data);

                await _context.SaveChangesAsync();

            }
        }

        public IEnumerable<BtCprop> GetBtcs()
        {
            return _context.Set<BtCprop>();
        }


    }
}
