using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tuples
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
      var time = GetTime();
      WriteLine($"Time: {time.Item1}:{time.Item2}:{time.Item3}");

      var time2 = GetTime2();
      WriteLine($"Time: {time2.hour}:{time2.minutes}:{time2.seconds}");

      var tupleDictionary = new Dictionary<(int, int), string>();

      tupleDictionary.Add((100, 20), "Your room is #20 on the 100th floor");
      tupleDictionary.Add((50, 10), "Your room is on the 50th floor, room 10");

      var result = tupleDictionary[(50, 10)];
      WriteLine(result);

    }

    public (int, int, int) GetTime()
    {
      return (1, 30, 40);  //tuple literal
    }

    public(int hour, int minutes, int seconds) GetTime2()
    {
      return (1, 30, 40);
    }
  }
}
