using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of INT            : {0} bytes", sizeof(int));
            Console.WriteLine("Size of UNSIGNED INT   : {0} bytes \n", sizeof(uint));

            Console.WriteLine("Size of SHORT          : {0} bytes", sizeof(short));
            Console.WriteLine("Size of UNSIGNED SHORT : {0} bytes \n", sizeof(ushort));

            Console.WriteLine("Size of LONG           : {0} bytes", sizeof(long));
            Console.WriteLine("Size of UNSIGNED LONG  : {0} bytes \n", sizeof(ulong));

            Console.WriteLine("Size of BOOL           : {0} byte \n", sizeof(bool));

            Console.WriteLine("Size of CHAR           : {0} bytes \n", sizeof(char));

            Console.WriteLine("Size of FLOAT          : {0} bytes", sizeof(float));
            Console.WriteLine("Size of DOUBLE         : {0} bytes \n", sizeof(double));
        }
    }

}
