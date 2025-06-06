using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProduct;
        public ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 40);
            Product aniseed = new Product(3, "Aniseed Syrup", 2, 23, 10);
            listProduct = new List<Product> { chai, chang, aniseed };
        }
        public List<Product> GetProducts()
        {
            return listProduct;
        }
        //public static List<Product> GetProducts()
        //{
        //    var listProdcts = new List<Product>();
        //    try
        //    {
        //        using var db = new MyStoreContext();
        //    } catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred: {ex.Message}");
        //    }
        //    return listProdcts;
        //}
        public void SaveProduct(Product p)
        {
            listProduct.Add(p);
        }
        public void UpdateProduct(Product product)
        {
            foreach (Product p in listProduct.ToList())
            {
                if(p.ProductId == product.ProductId)
                {
                    p.ProductId = product.ProductId;
                    p.ProductName = product.ProductName;
                    p.CategoryId = product.CategoryId; 
                    p.UnitsInStock = product.UnitsInStock;
                    p.UnitPrice = product.UnitPrice;
                }
            }
        }
        public void DeleteProduct(Product product) 
        {
            foreach (var item in listProduct)
            {
                if(item.ProductId == product.ProductId)
                {
                    listProduct.Remove(item);
                }
            }
        }
        public Product GetProductById(int id) 
        {
            foreach (var item in listProduct.ToList())
            {
                if (item.ProductId == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
