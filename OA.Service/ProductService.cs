using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    public class ProductService : IProductService
    {
        private IProductRepo<Product> productRepository;

        public ProductService(IProductRepo<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }

        public void InsertProduct(Product product)
        {
            productRepository.Insert(product);
        }
        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
           
            Product product = GetProduct(id);
            productRepository.Remove(product);
            productRepository.SaveChanges();
        }
    }
}
