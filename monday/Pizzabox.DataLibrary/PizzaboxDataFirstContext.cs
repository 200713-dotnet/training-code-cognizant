using Microsoft.EntityFrameworkCore;
using Pizzabox.DataLibrary.Entities;

namespace Pizzabox.DataLibrary
{
  public class PizzaboxDataFirstContext : DbContext
  {
    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Crusts { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Customers { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Employees { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Orders { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Pizzas { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Sizes { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Stores { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public DbSet<ABaseEntity> Toppings { get; set; }

    public PizzaboxDataFirstContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {

    }
  }
}
