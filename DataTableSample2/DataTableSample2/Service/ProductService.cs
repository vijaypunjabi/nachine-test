using DataTableSample2.Context;
using DataTableSample2.IService;
using DataTableSample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample2.Service
{
    public class ProductService : IProductService
    {
        private readonly DatabaseContext _context;
        public ProductService(DatabaseContext context)
        {
            _context = context;
        }
        public string Delete(int productId)
        {
            var product = _context.Products.FirstOrDefault(x=>x.ProductId == productId);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public Product GetById(int productId)
        {
            return _context.Products.SingleOrDefault(x => x.ProductId == productId);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void Save(Product oProduct)
        {
            _context.Products.Add(oProduct);
            _context.SaveChanges();
        }

        public void Update(Product oProduct)
        {
            _context.Products.Update(oProduct);
            _context.SaveChanges();
        }
    }
}
