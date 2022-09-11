﻿namespace Product_API
{
    public class ProductRepository
    {
        private readonly List<ProductType> _product;

        public ProductRepository()
        {
            _product = new ProductType[]
            {
                new ProductType(001,"Jean",Category.FASHION),
                new ProductType(002,"Mobile",Category.TECH),
                new ProductType(003,"Watch",Category.FASHION),
                new ProductType(004,"Sheo",Category.FASHION),
                new ProductType(005,"Shirt",Category.FASHION),
                new ProductType(006,"Laptop",Category.TECH),
                new ProductType(007,"Perfume",Category.FASHION)
            }.ToList();
        }

        public List<ProductType> GetProduct() => _product;
        public List<ProductType> GetProductBy(string name) => _product.Where(x => x.Name == name).ToList();
    }
}
