using Friday.ConsoleClient;
using Xunit;

namespace Friday.Testing.Tests
{
  public class FizzBuzzTest
  {
    [Fact]
    public void Test_Count()
    {
      var sut = new FizzBuzz();
      var expected = 100;
      var actual = sut.Count;
      
      Assert.IsType<short>(sut.Count);
      Assert.True(expected >= actual);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    public void Test_Fizz_Positive(short number)
    {
      var sut = new FizzBuzz();
      var expected = "fizz";
      var actual = sut.Fizz(number);
      
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-3)]
    [InlineData(-6)]
    public void Test_Fizz_Negative(short number)
    {
      var sut = new FizzBuzz();
      var expected = "";
      var actual = sut.Fizz(number);
      
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void Test_Buzz_Positive(short number)
    {
      var sut = new FizzBuzz();
      var expected = "buzz";
      var actual = sut.Buzz(number);
      
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-5)]
    [InlineData(-10)]
    public void Test_Buzz_Negative(short number)
    {
      var sut = new FizzBuzz();
      var expected = "";
      var actual = sut.Buzz(number);
      
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(30)]
    [InlineData(60)]
    public void Test_FizzBuzz(short number)
    {
      var sut = new FizzBuzz();
      var expected = "fizzbuzz";
      var actual = sut.FizzBuzzy(number);
      
      Assert.Equal(expected, actual);
    }
  }
}
