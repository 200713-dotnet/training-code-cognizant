using Pizzabox.AppLibrary.Factories;

namespace Pizzabox.AppLibrary.Abstracts
{
  /// <summary>
  ///
  /// </summary>
  public abstract class AStoreModel : ABaseModel
  {
    protected readonly GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public abstract APizzaModel MakeMeatPizza();

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public abstract APizzaModel MakeVeganPizza();

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public abstract APizzaModel MakeVeggiePizza();
  }
}
