namespace ProductCatalogue.Models;

using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Product")]
public class Product
{

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }

    public Product(string name)
    {
	this.Name = name;
    }

}
