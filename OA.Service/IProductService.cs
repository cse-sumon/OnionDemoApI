using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
   public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
