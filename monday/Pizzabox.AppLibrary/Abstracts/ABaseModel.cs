using System;

namespace Pizzabox.AppLibrary.Abstracts
{
  /// <summary>
  ///
  /// </summary>
  public abstract class ABaseModel
  {
    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public int Id { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public bool Active { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Guid ModelId { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DateTime DateCreated { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DateTime DateModified { get; set; }
  }
}
