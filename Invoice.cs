using System;
using System.Windows.Forms;
using Npgsql;

namespace courseWork
{
    public partial class Invoice : Form
    {
        string documentN = ""; // Переменная для обновления ключевого поля
        public Invoice()
        {
            InitializeComponent();
            data.DataSource = Warehouse.InvoiceTable; // Обновление данных в грид вью
            if (Warehouse.currentUser.AccessInvoice == "0") // Установка в соответствии с правами пользователя
            {
                add.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessInvoice == "1")
            {
                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessInvoice == "2")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessInvoice == "3")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = true;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE invoice SET \"DocumentN\" = @p1, \"Seller\" = @p2, \"INNClient\" = @p3 WHERE \"DocumentN\" = @p4", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToInt32(first.Text));
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", third.Text);
                npgsqlC.Parameters.AddWithValue("p4", Convert.ToInt32(documentN));
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} изменил запись в таблице Invoice в {DateTime.Now}: \"DocumentN\", \"Seller\", \"INNClient\" - '{first.Text}', '{second.Text}', '{third.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from invoice"); // Обновление данных в грид вью
        }

        private void add_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO invoice (\"DocumentN\", \"Seller\", \"INNClient\") VALUES (@p1, @p2, @p3)", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToInt32(first.Text));
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", third.Text);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} добавил запись в таблицу Invoice в {DateTime.Now}: \"DocumentN\", \"Seller\", \"INNClient\" - '{first.Text}', '{second.Text}', '{third.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from invoice"); // Обновление данных в грид вью
        }

        private void delete_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM invoice WHERE \"DocumentN\" = @p1", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", Convert.ToInt32(first.Text));
            npgsqlC.ExecuteNonQuery(); // Удаление записи
            Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} удалил запись в таблице Invoice в {DateTime.Now}: \"DocumentN\", \"Seller\", \"INNClient\" - '{first.Text}', '{second.Text}', '{third.Text}'"); // Логирование
            data.DataSource = Warehouse.GetData("SELECT * from invoice"); // Обновление данных в грид вью
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            Warehouse.ClearF(this); // Очистка текстбоксов 
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                first.Text = row.Cells["DocumentN"].Value.ToString();
                second.Text = row.Cells["Seller"].Value.ToString();
                third.Text = row.Cells["INNClient"].Value.ToString();
                documentN = first.Text; // Получение данных в текст боксы
            }
            catch (Exception)
            {

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            data.DataSource = Warehouse.InvoiceTable; // Обновление данных в грид вью
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.DataSource = Warehouse.GetData($"select * from invoice WHERE \"INNClient\" = @p1", new NpgsqlParameter("p1", search.Text)); // Поиск записей по ИНН клиента
            }
            catch (Exception)
            {

            }
        }
    }
}
