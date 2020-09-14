using System;

namespace Friday.ConsoleClient
{
  public class FizzBuzz
  {
    //private short _upperBound;
    //public short Count = default(short); // security risk

    public short Count { get; private set; }  

    public FizzBuzz(short upperBound = 100) // input validation
    {
      //_upperBound = upperBound;
      Run(upperBound);
    }

    public string Fizz(short number) // input validation
    {
      return Compute(number, 3, "fizz");
    }

    public string Buzz(short number) // input validation
    {
      return Compute(number, 5, "buzz"); // exception handling
    }

    public string FizzBuzzy(short number)
    {
      return Compute(number, 15, "fizzbuzz");
    }

    private void Run(short upperBound)
    {
      for (short i = 0; i <= upperBound; i++)
      {
        Count = i;
        
        if (!string.IsNullOrEmpty(FizzBuzzy(i)))
        {
          Console.WriteLine(FizzBuzzy(i));
          continue;
        }

        if (!string.IsNullOrEmpty(Fizz(i)))
        {
          Console.WriteLine(Fizz(i));
          continue;
        }

        if (!string.IsNullOrEmpty(Buzz(i)))
        {
          Console.WriteLine(Buzz(i));
          continue;
        }
        
        Console.WriteLine(i);
      }
    }

    private string Compute(short number, short compare, string message)
    {
      if (number >= 0)
      {
        return number % compare == 0 ? message : string.Empty;
      }
      
      return string.Empty; // exception handling
    }
  }
}
