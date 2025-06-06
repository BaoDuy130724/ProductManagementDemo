using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductRepository _repository;
        public ProductRepository(IProductRepository repository)
        {
            _repository = repository;
        }
        public void DeleteProduct(Product product) => _repository.DeleteProduct(product);


        public Product GetProductById(int id) => _repository.GetProductById(id);


        public List<Product> GetProducts() => _repository.GetProducts();


        public void SaveProduct(Product product) => _repository.SaveProduct(product);


        public void UpdateProduct(Product product) => _repository.UpdateProduct(product);

    }
}
