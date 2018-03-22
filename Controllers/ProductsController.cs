using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using devnotCore.Models;
 
namespace devnotCore.Controllers
{
    [Route("urunler/api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly FabrikaContext _context;
         
        public ProductsController(FabrikaContext context)
        {
            _context=context;
             
            if(_context.Products.Count()==0)
            {
                _context.Products.Add(new Product{Id=19201,Name="Lego Nexo Knights King I",UnitPrice=45});
                _context.Products.Add(new Product{Id=23942,Name="Lego Starwars Minifigure Jedi",UnitPrice=55});
                _context.Products.Add(new Product{Id=30021,Name="Star Wars çay takımı ",UnitPrice=35.50});
                _context.Products.Add(new Product{Id=30492,Name="Star Wars kahve takımı",UnitPrice=24.40});
                 
                _context.SaveChanges();
            }
        }
         
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }
 
         
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product=_context.Products.FirstOrDefault(t=>t.Id==id);
            if(product==null)
            {
                return NotFound();
            }
            return new ObjectResult(product);
        }
 
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //TODO:Yazılacak
        }
 
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            //TODO:Yazılacak
        }
 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO:Yazılacak
        }
    }
}