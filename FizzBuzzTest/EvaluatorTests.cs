using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
  [TestClass]
  public class EvaluatorTests
  {
    private const string VAL_BUZZ = "Buzz";
    private const string VAL_FIZZ = "Fizz";

    [TestMethod]
    public void Return1_WhenInput_1()
    {
      var result = FizzBuzzGame.Evaluate(1);
      Assert.AreEqual("1", result);
    }

    [TestMethod]
    public void Return2_WhenInput_2()
    {
      var result = FizzBuzzGame.Evaluate(2);
      Assert.AreEqual("2", result);
    }

    [TestMethod]
    public void Return4_WhenInput_4()
    {
      var result = FizzBuzzGame.Evaluate(4);
      Assert.AreEqual("4", result);
    }

    [TestMethod]
    public void ReturnFizz_WhenInput_3()
    {
      var result = FizzBuzzGame.Evaluate(3);
      Assert.AreEqual(VAL_FIZZ, result);
    }
    
    [TestMethod]
    public void ReturnBuzz_WhenInput_5()
    {
      var result = FizzBuzzGame.Evaluate(5);
      Assert.AreEqual(VAL_BUZZ, result);
    }

    [TestMethod]
    public void ReturnFizz_WhenInput_6()
    {
      var result = FizzBuzzGame.Evaluate(6);
      Assert.AreEqual(VAL_FIZZ, result);
    }

    [TestMethod]
    public void ReturnFizz_WhenInput_9()
    {
      var result = FizzBuzzGame.Evaluate(9);
      Assert.AreEqual(VAL_FIZZ, result);
    }

    [TestMethod]
    public void ReturnBuzz_WhenInput_10()
    {
      var result = FizzBuzzGame.Evaluate(10);
      Assert.AreEqual(VAL_BUZZ, result);
    }

    [TestMethod]
    public void ReturnFizzBuzz_WhenInput_15()
    {
      var result = FizzBuzzGame.Evaluate(15);
      Assert.AreEqual($"{VAL_FIZZ}{VAL_BUZZ}", result);
    }

    [TestMethod]
    public void ReturnFizzBuzz_WhenInput_30()
    {
      var result = FizzBuzzGame.Evaluate(30);
      Assert.AreEqual($"{VAL_FIZZ}{VAL_BUZZ}", result);
    }
  }
}
