using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ORM_Dapper1
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepartmentRepository(conn);
            //var repo = new DapperProductRepository(conn);

            var departments = repo.GetAllDepartments();
            //var products = repo.GetAllProducts();

            foreach (var dept in departments)
            //foreach (var prod in products)
            {
                Console.WriteLine($"{dept.DepartmentID} {dept.Name}");
                //Console.WriteLine($"{prod.ProductID} {prod.Name}");
            }
        }
    }
}

