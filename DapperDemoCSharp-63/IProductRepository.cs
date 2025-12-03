namespace DapperDemoCSharp_63;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
    public void CreateProduct(string name, double price, int categoryId, bool OnSale, int stockLevel);
    public void UpdateProduct(string name, double price, int categoryId, bool OnSale, int stockLevel);
    public void DeleteProduct(int productId);
    
}