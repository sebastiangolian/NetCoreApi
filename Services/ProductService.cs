using System.Collections.Generic;
using NetCoreApi.Models;

namespace NetCoreApi.Services
{
    public class ProductService
    {
        List<Product> productList = null;
        public ProductService() {
            productList = new List<Product>();
        }

        public Product GetProduct(string idProduct) {
            return productList.Find(pro => pro.IdProduct == idProduct);
        }

        public List<Product> GetProducts() {
            return productList;
        }

        public void AddProduct(Product product) {
            productList.Add(product);
        }

        public void UpdateProduct(string idProduct, Product product) {
            int index = productList.FindIndex(pro => pro.IdProduct == idProduct);
            if(index != -1) {
                productList[index] = product;
            }
        }

        public void DeleteProduct(string idProduct) {
            Product productFind = productList.Find(product => product.IdProduct == idProduct);
            productList.Remove(productFind);
        }
    }
}