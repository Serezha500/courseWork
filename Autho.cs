using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace courseWork
{
    public partial class Autho : Form
    {
        Warehouse warehouse = new Warehouse();
        static internal int secretKey = 3; // Ключ для шифрования

        public Autho()
        {
            InitializeComponent();
            Warehouse.npgsql.Open(); // Открытие подключения к БД
        }
        private void checkUser_Click(object sender, EventArgs e)
        {
           DataTable dataTable = Warehouse.GetData("SELECT *from logins"); // Получение всех записей пользователей
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i]["login"].ToString() == log.Text)
                {
                    if (Crypt(dataTable.Rows[i]["Password"].ToString(), secretKey) == pass.Text)
                    {
                        Hide();
                        warehouse.CurrentUser = new User(dataTable.Rows[i]["Name"].ToString(), dataTable.Rows[i]["Surname"].ToString(), dataTable.Rows[i]["Patronymic"].ToString(),
                            dataTable.Rows[i]["login"].ToString(), Convert.ToBoolean(dataTable.Rows[i]["chClient"]), Convert.ToBoolean(dataTable.Rows[i]["chCount"]),
                            Convert.ToBoolean(dataTable.Rows[i]["chSeller"]), Convert.ToBoolean(dataTable.Rows[i]["chGoods"]), Convert.ToBoolean(dataTable.Rows[i]["chGoodsInvoice"]), Convert.ToBoolean(dataTable.Rows[i]["chAccounts"]), Convert.ToBoolean(dataTable.Rows[i]["chInvoice"]), dataTable.Rows[i]["accessClient"].ToString(),
                            dataTable.Rows[i]["accessCount"].ToString(), dataTable.Rows[i]["accessSeller"].ToString(), dataTable.Rows[i]["accessGoods"].ToString(), dataTable.Rows[i]["accessGoodsInvoice"].ToString(), dataTable.Rows[i]["accessAccounts"].ToString(), dataTable.Rows[i]["accessInvoice"].ToString());
                        warehouse.ShowDialog(); // Проверка логина и пароля пользователя, создание объекта User, открытие формы работы с БД
                    }
                    else
                        warning.Visible = true;
                }
                else
                    warning.Visible = true;
            }
        }
        public static string Crypt(string str, int secretKey) // Шифрование пароля
        {
            var ch = str.ToArray(); 
            string newStr = "";      
            foreach (var c in ch)  
                newStr += TopSecret(c, secretKey); 
            return newStr;
        }
        public static char TopSecret(char character, int secretKey) // Шифрование посимвольно
        {
            character = (char)(character ^ secretKey); 
            return character;
        }

        private void log_TextChanged(object sender, EventArgs e)
        {
            warning.Visible = false; 
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            warning.Visible = false;
        }
    }
}
