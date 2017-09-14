using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BruteForcePassword
{
    class Program
    {
        static void Check(string pch, string charset)
        {
            charset.Split(new[] { ',' }).ToList<string>();
            foreach (char ch in charset)
            {
                string sch = Convert.ToString(ch);
                if (sch == pch)
                {
                    Console.WriteLine("[+] Trying... {0}", ch);
                    Console.WriteLine("[+][+] Matched ({0})", ch);
                    break;
                }
                else
                {
                    Console.WriteLine("[+] Trying... {0}", ch);
                }
            }
        }
        static string BruteForce()
        {
            Console.WriteLine("Insert Password: ");
            string pasw = Console.ReadLine();
            Console.WriteLine(pasw);
            string charset = "abcdefghijklmnopqrstuvwxyz";
            string charset1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string charset2 = "0123456789";
            string charset3 = "!@#$%^&*(~[-+:=;'{<>_?/,.|¿¡}'])";
            string result = "";
            Console.WriteLine("[+][+] Starting BruteForce...");
            pasw.Split(new[] { ',' }).ToList<string>();
            for (int x = 0; x <= pasw.Length - 1; x++)
            {
                string pch = Convert.ToString(pasw[x]);
                if (charset.Contains(pch))
                {
                    Check(pch, charset);
                    result += pch;
                }
                else if (charset1.Contains(pch))
                {
                    Check(pch, charset1);
                    result += pch;
                }
                else if (charset2.Contains(pch))
                {
                    Check(pch, charset2);
                    result += pch;
                }
                else
                {
                    Check(pch, charset3);
                    result += pch;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("[+][+] All Matched - Password Found: {0}", BruteForce());
            Console.ReadLine();
        }
    }
}

