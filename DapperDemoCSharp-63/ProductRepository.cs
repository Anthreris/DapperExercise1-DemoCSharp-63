using System.Data;
using Dapper;

namespace DapperDemoCSharp_63;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _connection;

    public ProductRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _connection.Query<Product>("SELECT * FROM products;");
    }

    public void CreateProduct(string name, double price, int categoryId, bool OnSale, int stockLevel)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(string name, double price, int categoryId, bool OnSale, int stockLevel)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }
}