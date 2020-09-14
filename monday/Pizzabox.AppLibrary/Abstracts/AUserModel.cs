namespace Pizzabox.AppLibrary.Abstracts
{
  /// <summary>
  ///
  /// </summary>
  public abstract class AUserModel : ABaseModel
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
    public string Username { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public string Password { get; set; }
  }
}
