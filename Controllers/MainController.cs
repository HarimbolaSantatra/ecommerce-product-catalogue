namespace ProductCatalogue.Controllers;

using Microsoft.AspNetCore.Mvc;
using ProductCatalogue.Models;
using System.Linq;
using System.Text.Json;

[ApiController]
[Route("/")]
public class MainController : ControllerBase 
{

    private string okMsg = "ProductCatalogue service is working!";
    private CatalogueDbContext _context;

    public MainController (CatalogueDbContext context)
    {
	_context = context;
    }

    [Route("/")]
    [HttpGet]
    public ActionResult Index()
    {
	Dictionary<string, string> res = new Dictionary<string, string>();
	res.Add("status", okMsg);
	return new JsonResult(res);
    }

    [Route("/status")]
    [HttpGet]
    public string GetStatus()
    {
	return(okMsg);
    }

    [Route("/{productId}")]
    [HttpGet]
    public string GetProduct(int productId)
    {
	var product = _context.Products.Where(p => p.Id == productId).ToList().SingleOrDefault();
	return( JsonSerializer.Serialize(product) );
    }

    [Route("/add")]
    [HttpPost]
    public IActionResult AddProduct (Product product)
    {
	_context.Products.Add(product);
	_context.SaveChanges();
	return(CreatedAtAction("AddProduct", product));
    }

}
