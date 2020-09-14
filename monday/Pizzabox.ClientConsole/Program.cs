using System;
using Pizzabox.AppLibrary.Abstracts;
using Pizzabox.AppLibrary.Singletons;

namespace Pizzabox.ClientConsole
{
  public class Program
  {
    static void Main(string[] args)
    {
      var client = ClientSingleton.Instance;

      PrintMenu(client.ChicagoStyle);
      PrintMenu(client.NewYorkStyle);
    }
    
    public static string PrintMenu(AStoreModel store)
    {
      return store.MakeMeatPizza().ToString();
    }
  }
}
