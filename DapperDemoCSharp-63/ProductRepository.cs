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
        _connection.Execute("INSERT INTO products (Name, Price, CategoryID, OnSale, StockLevel) Values (@name, @price, @categoryId, @onSale, @stockLevel)",
            new {name, price, categoryId, OnSale, stockLevel});
    }

    public void UpdateProduct(string name, double price, int categoryId, bool OnSale, int stockLevel)
    {
        _connection.Execute("UPDATE products SET Name = @name, Price = @price, CategoryID = @categoryId, OnSale = @onSale, StockLevel = @stockLevel", new {});
    }

    public void DeleteProduct(int productId)
    {
        _connection.Execute("", new {});
    }
}