using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {

        public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);

        public Product GetProductById(int id) => _productDAO.GetProductById(id);

        public List<Product> GetProducts()
        {
            
        }

        public void SaveProduct(Product p) => _productDAO.SaveProduct(p);

        public void UpdateProduct(Product product) => _productDAO.UpdateProduct(product);
    }
}
