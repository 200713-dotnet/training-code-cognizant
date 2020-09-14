using Microsoft.EntityFrameworkCore;
using Pizzabox.AppLibrary.Abstracts;
using Pizzabox.AppLibrary.Models;
using Pizzabox.DataLibrary.Entities;

namespace Pizzabox.DataLibrary
{
  public class PizzaboxCodeFirstContext : DbContext
  {
    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<CrustModel> Crusts { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<AUserModel> Customers { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<AUserModel> Employees { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<OrderModel> Orders { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<APizzaModel> Pizzas { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<SizeModel> Sizes { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<AStoreModel> Stores { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<AToppingModel> Toppings { get; set; }

    public PizzaboxCodeFirstContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {

    }
  }
}
