using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Deconstruction
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
      (int hour, int minutes, int seconds) = GetTime();

      if (minutes > 30)
      {
        hour++;
      }

      WriteLine($"{hour}:{minutes}:{seconds}");

    }

    public (int, int, int) GetTime()
    {
      return (1, 35, 40);
    }

    public void Run2()
    {
      int hour;
      int minutes;
      int seconds;
      (hour, minutes, seconds) = GetTime();
      WriteLine($"The time using local variables: {hour}:{minutes}:{seconds}");
    }
  }
}
