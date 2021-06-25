using DataTableSample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample2.IService
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetById(int productId);
        void Save(Product oProduct);
        void Update(Product oProduct);
        string Delete(int productId);
    }
}
