using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Linq.Expressions;

namespace courseWork
{
    public partial class Warehouse : Form
    {
        static internal StreamWriter txt = new StreamWriter("log.txt", true); // Файл для логирования
        static internal User currentUser; // Текущий пользователь
        static internal NpgsqlConnection npgsql = new NpgsqlConnection("Server=localhost;Port=5432;User ID=admin;Password=admin;Database=Warehouse"); // Соединение с БД
        static NpgsqlCommand npgsqlC = new NpgsqlCommand(); // Команда для SQL
        static DataTable sellerTable, clientTable, countTable, goodsTable, goodsInvoiceTable, invoiceTable, accountsTable; // Таблицы БД

        internal User CurrentUser { get => currentUser; set => currentUser = value; }
        static internal DataTable SellerTable { get => sellerTable; set => sellerTable = value; }
        internal static DataTable ClientTable { get => clientTable; set => clientTable = value; }
        internal static DataTable CountTable { get => countTable; set => countTable = value; }
        internal static DataTable GoodsTable { get => goodsTable; set => goodsTable = value; }
        internal static DataTable GoodsInvoiceTable { get => goodsInvoiceTable; set => goodsInvoiceTable = value; }
        internal static DataTable InvoiceTable { get => invoiceTable; set => invoiceTable = value; }
        internal static DataTable AccountsTable { get => accountsTable; set => accountsTable = value; }

        public Warehouse()
        {
            InitializeComponent();
        }
        public static DataTable GetData(string sql)
        {
            npgsqlC.Connection = npgsql; // Подключение команды к БД
            DataTable dataTable = new DataTable(); 
            npgsqlC.CommandText = sql;
            NpgsqlDataReader npgsqlDataReader = npgsqlC.ExecuteReader(); // Выполнение запроса на получение данных
            dataTable.Load(npgsqlDataReader); // Загрузка данных 
            return dataTable;
        }
        public static DataTable GetData(string sql, NpgsqlParameter npgsqlParameter) // Получение данных с одним параметром
        {
            npgsqlC.Connection = npgsql;
            DataTable dataTable = new DataTable();
            npgsqlC.CommandText = sql;
            npgsqlC.Parameters.Add(npgsqlParameter);
            NpgsqlDataReader npgsqlDataReader = npgsqlC.ExecuteReader();
            dataTable.Load(npgsqlDataReader);
            npgsqlC = new NpgsqlCommand();
            return dataTable;
        }
        public static DataTable GetData(string sql, NpgsqlParameter npgsqlParameter, NpgsqlParameter npgsqlParameter2) // Получение данных с двумя параметрами
        {
            npgsqlC.Connection = npgsql;
            DataTable dataTable = new DataTable();
            npgsqlC.CommandText = sql;
            npgsqlC.Parameters.Add(npgsqlParameter);
            npgsqlC.Parameters.Add(npgsqlParameter2);
            NpgsqlDataReader npgsqlDataReader = npgsqlC.ExecuteReader();
            dataTable.Load(npgsqlDataReader);
            npgsqlC = new NpgsqlCommand();
            return dataTable;
        }
        public static void ClearF(Form form) // Очистка текстбоксов и чекбоксов
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls[i] is TextBox)
                    (form.Controls[i] as TextBox).Text = null;
                if (form.Controls[i] is CheckBox)
                {
                    (form.Controls[i] as CheckBox).Checked = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!currentUser.ChAccounts) // Установка доступа к таблицам
                accounts.Enabled = false;
            if (!currentUser.ChClient || currentUser.NeedUpdate)
                client.Enabled = false;
            if (!currentUser.ChCount || currentUser.NeedUpdate)
                count.Enabled = false;
            if (!currentUser.ChGoods || currentUser.NeedUpdate)
                goods.Enabled = false;
            if (!currentUser.ChGoodsInvoice || currentUser.NeedUpdate)
                goodsInvoice.Enabled = false;
            if (!currentUser.ChInvoice || currentUser.NeedUpdate)
                invoice.Enabled = false;
            if (!currentUser.ChSeller || currentUser.NeedUpdate)
                seller.Enabled = false;
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} зашёл в БД в {DateTime.Now}"); // Логирование
        }

        private void client_Click(object sender, EventArgs e) 
        {
            clientTable = GetData("SELECT *from client");
            Client clientF = new Client();
            clientF.Show(); // Открытие формы Client
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} открыл таблицу Client в {DateTime.Now}"); // Логирование
        }

        private void count_Click(object sender, EventArgs e)
        {
            countTable = GetData("SELECT *from count");
            Count countF = new Count();
            countF.Show(); // Открытие формы Count
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} открыл таблицу Count в {DateTime.Now}"); // Логирование
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для работы с БД необходимо зайти в одну из форм для соответствующей таблицы (нажав кнопку в левой части меню), после чего появится возможность выполнять различные операции" +
                " с данными (например, добавление или удаление записи). \n\nДоступность операций определяют права доступа, назначенные на данный аккаунт администратором системы.", "Помощь по работе с программой", MessageBoxButtons.OK, MessageBoxIcon.Question); // Помощь по программе
        }

        private void goods_Click(object sender, EventArgs e)
        {
            goodsTable = GetData("SELECT *from goods");
            Goods goodsF = new Goods();
            goodsF.Show(); // Открытие формы Goods
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} открыл таблицу Goods в {DateTime.Now}"); // Логирование
        }

        private void goodsInvoice_Click(object sender, EventArgs e)
        {
            goodsInvoiceTable = GetData("SELECT *from goodsinvoice");
            Goods_invoice goodsInvoiceF = new Goods_invoice();
            goodsInvoiceF.Show(); // Открытие формы GoodsInvoice
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} открыл таблицу GoodsInvoice в {DateTime.Now}"); // Логирование
        }

        private void invoice_Click(object sender, EventArgs e)
        {
            invoiceTable = GetData("SELECT *from invoice");
            Invoice invoiceF = new Invoice();
            invoiceF.Show(); // Открытие формы Invoice
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} открыл таблицу Invoice в {DateTime.Now}"); // Логирование
        }

        private void seller_Click(object sender, EventArgs e)
        {
            sellerTable = GetData("SELECT *from seller");
            Seller sellerF = new Seller();
            sellerF.Show(); // Открытие формы Seller
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} открыл таблицу Seller в {DateTime.Now}"); // Логирование
        }
        private void accounts_Click(object sender, EventArgs e)
        {
            accountsTable = GetData("SELECT *from logins");
            Accounts accountsF = new Accounts();
            accountsF.Show(); // Открытие формы logins
            txt.WriteLine($"Пользователь {currentUser.Surname} {currentUser.Name} {currentUser.Patronymic} открыл таблицу Accounts в {DateTime.Now}"); // Логирование
        }
    }
}
