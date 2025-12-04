using System;
using System.Data;
using System.IO;
using DapperDemoCSharp_63;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

#region Department Section
// var departmentRepo = new DepartmentRepository(conn);
//
// //departmentRepo.InsertDepartment("CSharp-63");
//
// var departments = departmentRepo.GetAllDepartments();
//
// foreach (var dep in departments)
// {
//     Console.WriteLine($"Name: {dep.Name} | ID: {dep.DepartmentID}");
// }
#endregion

#region Product Section
var productRepository = new ProductRepository(conn);

//productRepository.CreateProduct("How to Train Your: Basenji",34.99,10,false, 20);
//productRepository.UpdateProduct("How to Train Your: Pharaoh Hound", 34.99, 10, false, 19, 942);

//productRepository.CreateProduct("How to Train Your: Dinosaur", 17.50, 10, true, 0);
//productRepository.DeleteProduct(943);

var products = productRepository.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"Product Name: {product.Name} | Product ID: {product.ProductID} | Price: {product.Price} |" +
    $" Category ID: {product.CategoryID} | OnSale: {product.OnSale} | Amount of Product: {product.StockLevel}");
}
#endregion

