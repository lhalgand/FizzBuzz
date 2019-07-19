using System;

namespace FizzBuzz
{
  public static class FizzBuzzGame
  {
    private const string VAL_BUZZ = "Buzz";
    private const string VAL_FIZZ = "Fizz";
    
    public static string Evaluate(int input)
    {
      string result = string.Empty;
      var isDividableByThree = (input % 3 == 0);
      var isDividableByFive = (input % 5 == 0);

      if (isDividableByThree)
        result += VAL_FIZZ;

      if (isDividableByFive)
        result += VAL_BUZZ;

      result = string.IsNullOrEmpty(result) ? input.ToString() : result;
      return result;
    }

  }
}
