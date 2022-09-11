namespace Product_API
{
    public class Query
    {
        public List<ProductType> GetProduct([Service] ProductRepository productRepository)
        {
            return productRepository.GetProduct();
        }

        public List<ProductType> GetProductBy([Service] ProductRepository productRepository,string name)
        {
            return productRepository.GetProductBy(name);
        }
    }
}
