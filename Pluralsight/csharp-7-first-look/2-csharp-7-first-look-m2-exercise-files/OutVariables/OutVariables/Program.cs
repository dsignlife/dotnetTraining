using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OutVariables
{
  class Program
  {
    static void Main(string[] args)
    {
      Runner runner = new Runner();
      runner.Run();
      runner.Run2();
    }
  }

  public class Runner
  {
    public void Run()
    {
      int hour;
      int minutes;
      int seconds;
      GetTime(out hour, out minutes, out seconds);
      WriteLine($"{hour}:{minutes}:{seconds}");
    }

    public void Run2()
    {
      GetTime(out int hour, out int minutes, out int seconds);
      WriteLine($"{hour}:{minutes}:{seconds}");
    }

    public void GetTime(out int hour, out int minutes, out int seconds)
    {
      hour = 1;
      minutes = 30;
      seconds = 20;
    }


  }
}
