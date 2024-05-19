using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using courseWork;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodConnection()
        {
            NpgsqlConnection npgsql = new NpgsqlConnection("Server=localhost;Port=5432;User ID=admin;Password=admin;Database=Warehouse");
            npgsql.Open();
        }
        [TestMethod]
        [ExpectedException((typeof(PostgresException)))]
        public void TestMethodNotConnection()
        {
            NpgsqlConnection npgsql = new NpgsqlConnection("Server=localhost;Port=5432;User ID=admin;Password=admin123;Database=Warehouse");
            npgsql.Open();
        }
    }
}
