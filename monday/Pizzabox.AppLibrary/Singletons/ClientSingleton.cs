using Pizzabox.AppLibrary.Abstracts;
using Pizzabox.AppLibrary.Factories;

/// <summary>
///
/// </summary>
namespace Pizzabox.AppLibrary.Singletons
{
  /// <summary>
  ///
  /// </summary>
  public class ClientSingleton
  {
    private static readonly ClientSingleton _clientSingleton = new ClientSingleton();

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public AStoreModel NewYorkStyle { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public AStoreModel ChicagoStyle { get; }

    /// <summary>
    ///
    /// </summary>
    public static ClientSingleton Instance => _clientSingleton;

    /// <summary>
    ///
    /// </summary>
    private ClientSingleton()
    {
      NewYorkStyle = new NewYorkStoreFactory();
      ChicagoStyle = new ChicagoStoreFactory();
    }
  }
}
