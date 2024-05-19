using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseWork;
using System.Data;

namespace Tests
{
    [TestClass]
    public class UnitTest3
    {
        public bool searchUser(string login, string password)
        {
            Warehouse.npgsql.Close();
            Warehouse.npgsql.Open();
            DataTable dataTable = Warehouse.GetData("SELECT *from logins"); // Получение всех записей пользователей
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i]["login"].ToString() == login)
                {
                    if (Autho.Crypt(dataTable.Rows[i]["Password"].ToString(), Autho.secretKey) == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        [TestMethod]
        public void TestMethodValid()
        {
            Assert.AreEqual(true, searchUser("admin", "admin123456"));
            Assert.AreEqual(true, searchUser("admin0", "123"));
        }
        [TestMethod]
        public void TestMethodNotValid()
        {
            Assert.AreEqual(false, searchUser("admin1", "admin123456"));
            Assert.AreEqual(false, searchUser("admin0", "12345"));
            Assert.AreEqual(false, searchUser("adm", "123"));
        }
    }
}
