namespace ProductCatalogue.Models;

using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CatalogueDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }

    public CatalogueDbContext(DbContextOptions<CatalogueDbContext> options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
	optionsBuilder.UseMySQL("server=localhost;database=product_catalogue;user=root;password=root");
    }


}
