using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pizzabox.AppLibrary.Abstracts;
using Pizzabox.AppLibrary.Models;

namespace Pizzabox.AppLibrary.Factories
{
  /// <summary>
  ///
  /// </summary>
  public class NewYorkStoreFactory : AStoreModel, IValidatableObject
  {
    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override APizzaModel MakeMeatPizza()
    {
      return _pizzaFactory.Make<MeatPizzaModel>();
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override APizzaModel MakeVeganPizza()
    {
      return _pizzaFactory.Make<VeganPizzaModel>();
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override APizzaModel MakeVeggiePizza()
    {
      return _pizzaFactory.Make<VeggiePizzaModel>();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="validationContext"></param>
    /// <returns></returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => new List<ValidationResult>();
  }
}
