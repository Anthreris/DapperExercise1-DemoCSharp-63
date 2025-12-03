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

var productRepository = new ProductRepository(conn);

var products = productRepository.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine();
    Console.WriteLine($"Product ID: {product.Name} | Product ID: {product.ProductID} | Price: {product.Price} |" +
    $" Category ID: {product.CategoryID} | OnSale: {product.OnSale} | Amount of Product: {product.StockLevel}");
    Console.WriteLine();
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------");
    
}
