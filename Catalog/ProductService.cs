using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class ProductService:IProductService
    {
        List<Product> _products;
        public ProductService() {
            _products = new List<Product>();
            _products.Add(new Product { Id = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, ImageUrl = "/images/gerbera.jpg" });
            _products.Add(new Product { Id = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 23, Quantity = 9000, ImageUrl = "/images/rose.jpg" });
            _products.Add(new Product { Id = 3, Title = "Lily", Description = "Delicate Flower", UnitPrice = 2, Quantity = 2000, ImageUrl = "/images/lily.jpg" });
            _products.Add(new Product { Id = 4, Title = "jasmine", Description = "Fragrance Flower", UnitPrice = 12, Quantity = 55000, ImageUrl = "/images/jasmine.jpg" });
            _products.Add(new Product { Id = 5, Title = "Lotus", Description = "Worship Flower", UnitPrice = 12, Quantity = 15000, ImageUrl = "/images/lotus.jpg" });

        }

        public void Delete(Product product)
        {
            Product theProuduct = GetById(product.Id);
            this._products.Remove(theProuduct);
        }

        public List<Product> GetAll()
        {
            //return _products;
            return  _products;
        }

        public Product GetById(int id)
        {
            foreach (var product in _products)
            {
                if(product.Id==id) return product;
            }
            return null;
        }

        public void Insert(Product product)
        {
            this._products.Add(product);
        }

        public void Update(Product product)
        {
            this.Delete(product);
            this._products.Add(product);

        }
    }
}
