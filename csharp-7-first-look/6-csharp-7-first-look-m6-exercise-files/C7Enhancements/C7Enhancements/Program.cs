﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C7Enhancements
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
      WriteLine(GetBigNumber());
      int[] numbers = { 2, 7, 1, 9, 12, 8, 15 };
      ref int position = ref Substitute(12, numbers);
      position = -12;
      WriteLine(numbers[4]);

      Employee joe = new Employee("Manager");
      WriteLine(joe.Position);

      Employee mary = new Employee(null);
      WriteLine(mary.Position);
    }

    public int GetBigNumber()
    {
      return 1_234_567;
    }

    public ref int Substitute(int value, int[] numbers)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] == value)
        {
          return ref numbers[i];
        }
      }
      throw new IndexOutOfRangeException("Not found!");
    }
  }
  public class Employee
  {
    public string Position { get; }
    public Employee(string position) => 
      Position = position ?? throw new ArgumentNullException();
  }
}
