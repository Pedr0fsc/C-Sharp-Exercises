using System;

namespace Bookstore
{
    public class Cart
    {
        public Client User;
        public List<Product> Products;
        
        public Cart(Client user)
        {
            User = user;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
    }
}