using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseWork;
using System.Data;
using Npgsql;

namespace Tests
{
    [TestClass]
    public class UnitTest4
    {
        static int INN;
        static Random rnd = new Random();
        [ClassInitialize]
        public static void SetPrimary(TestContext context)
        {
            rnd = new Random();
            Warehouse.npgsql.Close();
            Warehouse.npgsql.Open();
            INN = rnd.Next(100, 100000);
        }
        [TestMethod]
        public void TestMethodValid1Add()
        {
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO seller (\"SellerN\", \"INN\") VALUES (@p1, @p2)", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", "test");
            npgsqlC.Parameters.AddWithValue("p2", INN);
            npgsqlC.ExecuteNonQuery();
            DataTable dataTable = Warehouse.GetData($"SELECT (\"SellerN\") from seller WHERE \"INN\" = '{INN}'");
            Assert.AreEqual("test", dataTable.Rows[0]["SellerN"].ToString());
        }
        [TestMethod]
        [ExpectedException((typeof(PostgresException)))]
        public void TestMethodNotValidAdd()
        {
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO sellerqq (\"SellerN\", \"INN\") VALUES (@p1, @p2)", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", "test");
            npgsqlC.Parameters.AddWithValue("p2", INN);
            npgsqlC.ExecuteNonQuery();
        }
        [TestMethod]
        public void TestMethodValid2Edit()
        {
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE seller SET \"SellerN\" = @p1 WHERE \"INN\" = @p2", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", "test2");
            npgsqlC.Parameters.AddWithValue("p2", INN.ToString());
            npgsqlC.ExecuteNonQuery();
            DataTable dataTable = Warehouse.GetData($"SELECT (\"SellerN\") from seller WHERE \"INN\" = '{INN}'");
            Assert.AreEqual("test2", dataTable.Rows[0]["SellerN"].ToString());
        }
        [TestMethod]
        [ExpectedException((typeof(PostgresException)))]
        public void TestMethodNotValidEdit()
        {
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE seller SET \"SellerN\" = @p1qq WHERE \"INN\" = @p2", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", "test2");
            npgsqlC.Parameters.AddWithValue("p2", INN.ToString());
            npgsqlC.ExecuteNonQuery();
        }
        [TestMethod]
        public void TestMethodValid3Delete()
        {
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM seller WHERE \"INN\" = @p1", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", INN.ToString());
            npgsqlC.ExecuteNonQuery();
            DataTable dataTable = Warehouse.GetData($"SELECT (\"SellerN\") from seller WHERE \"INN\" = '{INN}'");
            Assert.AreEqual(0, dataTable.Rows.Count);
        }
        [TestMethod]
        [ExpectedException((typeof(PostgresException)))]
        public void TestMethodNotValidDelete()
        {
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROMq seller WHERE \"INN\" = @p1", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", INN.ToString());
            npgsqlC.ExecuteNonQuery();
        }
    }
}
