using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp
{
    class StorageSpace<T, U> where T: IStorable
                                 where U : StorageObject
    {

        private List<T> storageList;


        public StorageSpace()
        {
            
        }


    }
}
