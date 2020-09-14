using System.ComponentModel.DataAnnotations;
using Pizzabox.AppLibrary.Factories;
using Xunit;

namespace Pizzabox.TestRunner.AppLibrary.Tests
{
  /// <summary>
  ///
  /// </summary>
  public class GenericPizzaFactoryTesting
  {
    /// <summary>
    ///
    /// </summary>
    [Fact]
    public void Test_Validate_Method()
    {
      var sut = new GenericPizzaFactory();
      var ctx = new ValidationContext(sut);
      var actual = sut.Validate(new ValidationContext(sut));

      Assert.Empty(actual);
    }
  }
}
