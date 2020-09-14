using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pizzabox.AppLibrary.Abstracts;

namespace Pizzabox.AppLibrary.Models
{
  /// <summary>
  ///
  /// </summary>
  public class VeggiePizzaModel : APizzaModel, IValidatableObject
  {
    /// <summary>
    ///
    /// </summary>
    protected override void AddCrust()
    {
      Crust = new CrustModel();
    }

    /// <summary>
    ///
    /// </summary>
    protected override void AddSize()
    {
      Size = new SizeModel();
    }

    /// <summary>
    ///
    /// </summary>
    protected override void AddToppings()
    {
      Toppings.Add(new VeggieToppingModel());
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="validationContext"></param>
    /// <returns></returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      throw new System.NotImplementedException();
    }
  }
}
