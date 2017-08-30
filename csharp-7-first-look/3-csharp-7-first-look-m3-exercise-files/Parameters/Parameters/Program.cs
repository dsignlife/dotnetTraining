using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parameters
{
  class Program
  {
    static void Main(string[] args)
    {
      Runner runner = new Runner();
      runner.Run();
    }
  }

  public class Runner
  {
    public void Run()
    {
      PrintSum(10);
      PrintSum2("10");
    }

    public void PrintSum(object o)
    {
      if (o is null) return;  // constant pattern
      if (!(o is int i)) return; // type pattern (int)

      int sum = 0;
      for (int j = 0; j <= i; j++)
      {
        sum += j;
      }

      WriteLine($"The sum of 1 to {i} is {sum}");
    }

    public void PrintSum2(object o)
    {
      if (o is int i || o is string s && int.TryParse(s, out i))
      {
        int sum = 0;
        for (int j = 0; j <= i; j++)
        {
          sum += j;
        }

        WriteLine($"The sum of 1 to {i} is {sum}");
      }
    }
  }
}
