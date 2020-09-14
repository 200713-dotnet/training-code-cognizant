using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pizzabox.AppLibrary.Abstracts;

namespace Pizzabox.DataLibrary.Repositories
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class Repository<T> where T : ABaseModel
  {
    private readonly DbContext _dataContext;
    private readonly IMapper _mapper;
    private readonly DbSet<T> _repoContext;

    /// <summary>
    ///
    /// </summary>
    /// <param name="dbContext"></param>
    public Repository(DbContext dbContext, IMapper mapper = null)
    {
      _dataContext = dbContext;
      _mapper = mapper;
      _repoContext = dbContext.Set<T>();
    }
  }
}
