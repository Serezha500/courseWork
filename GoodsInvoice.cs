using System;
using System.Windows.Forms;
using Npgsql;

namespace courseWork
{
    public partial class Goods_invoice : Form
    {
        public Goods_invoice()
        {
            InitializeComponent();
            data.DataSource = Warehouse.GoodsInvoiceTable; // Обновление данных в грид вью
            if (Warehouse.currentUser.AccessGoodsInvoice == "0") // Установка в соответствии с правами пользователя
            {
                add.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessGoodsInvoice == "1")
            {
                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessGoodsInvoice == "2")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessGoodsInvoice == "3")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            Warehouse.ClearF(this); // Очистка текстбоксов
        }

        private void add_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO goodsinvoice (\"Price\", \"Date\") VALUES (@p1, @p2)", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToDouble(second.Text));
                npgsqlC.Parameters.AddWithValue("p2", Convert.ToDateTime(third.Text));
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} добавил запись в таблицу GoodsInvoice в {DateTime.Now}: \"GoodsInvoiceN\", \"Price\", \"Date\" - '{first.Text}', '{second.Text}', '{third.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from goodsinvoice"); // Обновление данных в грид вью
        }

        private void delete_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM goodsinvoice WHERE \"GoodsInvoiceN\" = @p1", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToInt32(first.Text));
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} удалил запись в таблице GoodsInvoice в {DateTime.Now}: \"GoodsInvoiceN\", \"Price\", \"Date\" - '{first.Text}', '{second.Text}', '{third.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from goodsinvoice"); // Обновление данных в грид вью
        }

        private void edit_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                third.Text = third.Text.Replace(',', '.');
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE goodsinvoice SET \"Price\" = @p1, \"Date\" = @p2 WHERE \"GoodsInvoiceN\" = @p3", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToDouble(second.Text));
                npgsqlC.Parameters.AddWithValue("p2", Convert.ToDateTime(third.Text));
                npgsqlC.Parameters.AddWithValue("p3", Convert.ToInt32(first.Text));
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} изменил запись в таблице GoodsInvoice в {DateTime.Now}: \"GoodsInvoiceN\", \"Price\", \"Date\" - '{first.Text}', '{second.Text}', '{third.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from goodsinvoice"); // Обновление данных в грид вью
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (search1.Text != "" && search2.Text != "")
                    data.DataSource = Warehouse.GetData($"select * from goodsinvoice WHERE \"Price\" BETWEEN @p1 AND @p2", new NpgsqlParameter("p1", Convert.ToDouble(search1.Text)), new NpgsqlParameter("p2", Convert.ToDouble(search2.Text)));
                if (search1.Text != "" && search2.Text == "")
                    data.DataSource = Warehouse.GetData($"select * from goodsinvoice WHERE \"Price\" >= @p1", new NpgsqlParameter("p1", Convert.ToDouble(search1.Text)));
                if (search1.Text == "" && search2.Text != "")
                    data.DataSource = Warehouse.GetData($"select * from goodsinvoice WHERE \"Price\" <= @p1", new NpgsqlParameter("p1", Convert.ToDouble(search2.Text))); // Нахождение записей с ценой в диапазоне
            }
            catch (Exception)
            {

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            data.DataSource = Warehouse.GoodsInvoiceTable; // Обновление данных в грид вью
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                first.Text = row.Cells["GoodsInvoiceN"].Value.ToString();
                second.Text = row.Cells["Price"].Value.ToString();
                third.Text = row.Cells["Date"].Value.ToString(); // Получение данных в текст боксы
            }
            catch (Exception)
            {

            }
        }
    }
}
