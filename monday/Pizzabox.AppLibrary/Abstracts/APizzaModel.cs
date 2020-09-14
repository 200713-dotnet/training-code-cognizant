using System.Collections.Generic;

namespace Pizzabox.AppLibrary.Abstracts
{
  /// <summary>
  ///
  /// </summary>
  public abstract class APizzaModel : ABaseModel
  {
    private AComponentModel _crust;
    private AComponentModel _size;
    private readonly List<AToppingModel> _toppings = new List<AToppingModel>();

    /// <summary>
    ///
    /// </summary>
    public AComponentModel Crust
    {
      get => _crust;
      protected set => _crust = value;
    }

    /// <summary>
    ///
    /// </summary>
    public AComponentModel Size
    {
      get => _size;
      protected set => _size = value;
    }

    /// <summary>
    ///
    /// </summary>
    public List<AToppingModel> Toppings => _toppings;

    /// <summary>
    ///
    /// </summary>
    protected APizzaModel()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    /// <summary>
    ///
    /// </summary>
    protected abstract void AddCrust();

    /// <summary>
    ///
    /// </summary>
    protected abstract void AddSize();

    /// <summary>
    ///
    /// </summary>
    protected abstract void AddToppings();

    /// <summary>
    ///
    /// </summary>
    /// <param name="crust"></param>
    public virtual void AddCrust(AComponentModel crust)
    {
      _crust = crust;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="size"></param>
    public virtual void AddSize(AComponentModel size)
    {
      _size = size;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="toppings"></param>
    public virtual void AddToppings(params AToppingModel[] toppings)
    {
      _toppings.AddRange(toppings);
    }
  }
}
