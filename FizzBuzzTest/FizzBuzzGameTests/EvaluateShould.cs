using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTest.FizzBuzzGameTests
{
  [TestClass]
  public class EvaluateShould
  {
    [TestMethod]
    public void Return1_WhenInput_1()
    {
      var result = FizzBuzzGame.Evaluate(1);
      Assert.AreEqual("1", result);
    }

  }
}
