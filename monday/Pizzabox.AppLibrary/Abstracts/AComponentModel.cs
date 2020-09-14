namespace Pizzabox.AppLibrary.Abstracts
{
  /// <summary>
  ///
  /// </summary>
  public abstract class AComponentModel : ABaseModel
  {
    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public decimal Price { get; set; }
  }
}
