using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pizzabox.AppLibrary.Abstracts;

namespace Pizzabox.AppLibrary.Models
{
  /// <summary>
  ///
  /// </summary>
  public class VeganToppingModel : AToppingModel, IValidatableObject
  {
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
