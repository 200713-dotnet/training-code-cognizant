using System.Collections;
using System.Collections.Generic;
using Pizzabox.AppLibrary.Abstracts;
using Pizzabox.AppLibrary.Models;
using Pizzabox.AppLibrary.Singletons;
using Pizzabox.ClientConsole;
using Xunit;

namespace Pizzabox.TestRunner.ClientConsole.Tests
{
  public class ClientTesting
  {
    public static IEnumerable<object[]> _stores = new List<object[]>()
    {
      new object[] { ClientSingleton.Instance.ChicagoStyle },
      new object[] { ClientSingleton.Instance.NewYorkStyle }
    };

    [Fact]
    public void Test_ChicagoStore()
    {
      var client = ClientSingleton.Instance;
      var sut = client.ChicagoStyle;

      Assert.IsType<MeatPizzaModel>(sut.MakeMeatPizza());
      Assert.IsType<VeganPizzaModel>(sut.MakeVeganPizza());
      Assert.IsType<VeggiePizzaModel>(sut.MakeVeggiePizza());
    }

    [Theory]
    // [InlineData()] // primitives, value types
    // [ClassData(typeof(StoreData))] // think about (params object[] values)
    [MemberData(nameof(_stores))] // think about (params object[] values)
    public void Test_Store_PrintMenu(AStoreModel store, int TryMany = 0) // think about (values[0], values[1])
    {
      var expected = "Pizzabox.AppLibrary.Models.MeatPizzaModel";

      for(int i = 0; i < TryMany; i +=1 )
      {
        var actual = Program.PrintMenu(store);

        Assert.Contains(expected, actual);
      }
    }
  }

  public class StoreData : IEnumerable<object[]>
  {
    public IEnumerator<object[]> GetEnumerator()
    {
      yield return new object[] { ClientSingleton.Instance.ChicagoStyle, 1 };
      yield return new object[] { ClientSingleton.Instance.NewYorkStyle, 1 };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new System.NotImplementedException();
    }
  }
}
