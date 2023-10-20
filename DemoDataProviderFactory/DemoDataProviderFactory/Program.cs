using Microsoft.Extensions.Configuration;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Reflection;

class Program
{
    static string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        var strConnection = config["ConnectionStrings:MyStoreDB"];
        return strConnection;
    }

    static void ViewProduct()
    {
        DbProviderFactory factory = SqlClientFactory.Instance;
        using DbConnection connection = factory.CreateConnection();
        
        if(connection == null ) { Console.WriteLine("bug"); return; };

        connection.ConnectionString = GetConnectionString();

        connection.Open();

        DbCommand dbCommand = connection.CreateCommand();

        if (dbCommand == null)
        {
            Console.WriteLine("bug"); return;
        }

        // Perform database operations using 'connection'
        dbCommand.Connection = connection;
        dbCommand.CommandText = "Select productID, productName from products";

        using DbDataReader dataReader = dbCommand.ExecuteReader();
        Console.WriteLine("List");
        while (dataReader.Read())
        {
            Console.WriteLine("Product id" + dataReader["ProductId"] + " Product name" + dataReader["ProductName"]);
        }

    }

    static void Main(string[] args)
    {
        ViewProduct();
    }
}
