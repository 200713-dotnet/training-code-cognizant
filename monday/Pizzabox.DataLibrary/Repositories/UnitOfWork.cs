using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pizzabox.AppLibrary.Abstracts;
using Pizzabox.AppLibrary.Models;
using Pizzabox.DataLibrary.Mappers;

namespace Pizzabox.DataLibrary.Repositories
{
  /// <summary>
  ///
  /// </summary>
  public class UnitOfWork
  {
    private static readonly MapperConfiguration _configuration = new MapperConfiguration(configuration =>
    {
      configuration.AddProfile<EntityProfile>();
    });
    private readonly Mapper _mapper;
    private readonly DbContext _dataContext;

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<CrustModel> Crusts { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<AUserModel> Customers { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<AUserModel> Employees { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<OrderModel> Orders { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<APizzaModel> Pizzas { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<SizeModel> Sizes { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<AStoreModel> Stores { get; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public Repository<AToppingModel> Toppings { get; }

    /// <summary>
    ///
    /// </summary>
    /// <param name="dataContext"></param>
    public UnitOfWork(DbContext dataContext)
    {
      _dataContext = dataContext;
      _mapper = (dataContext is PizzaboxDataFirstContext) ? new Mapper(_configuration) : null;

      Crusts = new Repository<CrustModel>(dataContext, _mapper);
      Customers = new Repository<AUserModel>(dataContext, _mapper);
      Employees = new Repository<AUserModel>(dataContext, _mapper);
      Orders = new Repository<OrderModel>(dataContext, _mapper);
      Pizzas = new Repository<APizzaModel>(dataContext, _mapper);
      Sizes = new Repository<SizeModel>(dataContext, _mapper);
      Stores = new Repository<AStoreModel>(dataContext, _mapper);
      Toppings = new Repository<AToppingModel>(dataContext, _mapper);
    }

    /// <summary>
    ///
    /// </summary>
    public void Commit()
    {
      _dataContext.SaveChanges();
    }
  }
}
