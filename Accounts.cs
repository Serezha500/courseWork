using System;
using System.Windows.Forms;
using Npgsql;

namespace courseWork
{
    public partial class Accounts : Form
    {
        string login = ""; // Переменная для обновления ключевого поля
        public Accounts()
        {
            InitializeComponent();
            data.DataSource = Warehouse.AccountsTable; // Данные в грид вью при заходе
            if (Warehouse.currentUser.AccessAccounts == "0") // Установка в соответствии с правами пользователя
            {
                add.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessAccounts == "1")
            {
                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessAccounts == "2")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessAccounts == "3")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO logins (\"Name\", \"Surname\", \"Patronymic\", login, password, \"chClient\", \"chCount\", \"chSeller\", \"chGoods\", \"chGoodsInvoice\", \"chAccounts\", \"chInvoice\", \"accessClient\", \"accessCount\", \"accessSeller\", \"accessGoods\", \"accessGoodsInvoice\", \"accessAccounts\", \"accessInvoice\") VALUES " +
                    $"(@p1, @p2, @p3, @p4, '{Autho.Crypt(fifth.Text,Autho.secretKey)}', {chClient.Checked}, {chCount.Checked}," +
                $"{chSeller.Checked}, {chGoods.Checked}, {chGoodsInvoice.Checked}, {chAccounts.Checked}, {chInvoice.Checked}, '{accessClient.SelectedItem}', '{accessCount.SelectedItem}', '{accessSeller.SelectedItem}', '{accessGoods.SelectedItem}', '{accessGoodsInvoice.SelectedItem}', '{accessAccounts.SelectedItem}', '{accessInvoice.SelectedItem}')", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", first.Text);
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", third.Text);
                npgsqlC.Parameters.AddWithValue("p4", fourth.Text);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} добавил запись в таблицу Logins в {DateTime.Now}: \"Name\", \"Surname\", \"Patronymic\", login, password, \"chClient\", \"chCount\", \"chSeller\", \"chGoods\", \"chGoodsInvoice\", \"chAccounts\", \"chInvoice\", \"accessClient\", \"accessCount\", \"accessSeller\", \"accessGoods\", \"accessGoodsInvoice\", \"accessAccounts\", \"accessInvoice\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{Autho.Crypt(fifth.Text, Autho.secretKey)}', {chClient.Checked}, {chCount.Checked}," +
                $"{chSeller.Checked}, {chGoods.Checked}, {chGoodsInvoice.Checked}, {chAccounts.Checked}, {chInvoice.Checked}, '{accessClient.SelectedItem}', '{accessCount.SelectedItem}', '{accessSeller.SelectedItem}', '{accessGoods.SelectedItem}', '{accessGoodsInvoice.SelectedItem}', '{accessAccounts.SelectedItem}', '{accessInvoice.SelectedItem}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from logins"); // Обновление данных в грид вью
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                first.Text = row.Cells["Name"].Value.ToString();
                second.Text = row.Cells["Surname"].Value.ToString();
                third.Text = row.Cells["Patronymic"].Value.ToString();
                fourth.Text = row.Cells["login"].Value.ToString();
                fifth.Text = row.Cells["password"].Value.ToString();
                chClient.Checked = (bool)row.Cells["chClient"].Value;
                chCount.Checked = (bool)row.Cells["chCount"].Value;
                chSeller.Checked = (bool)row.Cells["chSeller"].Value;
                chGoods.Checked = (bool)row.Cells["chGoods"].Value;
                chGoodsInvoice.Checked = (bool)row.Cells["chGoodsInvoice"].Value;
                chAccounts.Checked = (bool)row.Cells["chAccounts"].Value;
                chInvoice.Checked = (bool)row.Cells["chInvoice"].Value;
                accessClient.SelectedItem = row.Cells["accessClient"].Value;
                accessAccounts.SelectedItem = row.Cells["accessAccounts"].Value;
                accessCount.SelectedItem = row.Cells["accessCount"].Value;
                accessGoods.SelectedItem = row.Cells["accessGoods"].Value;
                accessGoodsInvoice.SelectedItem = row.Cells["accessGoodsInvoice"].Value;
                accessInvoice.SelectedItem = row.Cells["accessInvoice"].Value;
                accessSeller.SelectedItem = row.Cells["accessSeller"].Value; // Получение данных в текст боксы
                login = fourth.Text;
            }
            catch (Exception)
            {

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            Warehouse.ClearF(this); // Очистка текстбоксов 
        }
        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                warning.Visible = false;
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE logins SET \"Name\" = @p1, \"Surname\" = @p2, \"Patronymic\" = @p3, \"login\" = @p4, password = '{Autho.Crypt(fifth.Text, Autho.secretKey)}', \"chClient\" = {chClient.Checked}, \"chCount\" = {chCount.Checked}, \"chSeller\" = {chSeller.Checked}, \"chGoods\" = {chGoods.Checked}, \"chGoodsInvoice\" = {chGoodsInvoice.Checked}, \"chAccounts\" = {chAccounts.Checked}, \"chInvoice\" = {chInvoice.Checked}," +
                    $"\"accessClient\" = '{accessClient.SelectedItem}', \"accessCount\" = '{accessCount.SelectedItem}', \"accessSeller\" = '{accessSeller.SelectedItem}', \"accessGoods\" = '{accessGoods.SelectedItem}', \"accessGoodsInvoice\" = '{accessGoodsInvoice.SelectedItem}', \"accessAccounts\" = '{accessAccounts.SelectedItem}', \"accessInvoice\" = '{accessInvoice.SelectedItem}' WHERE login = @p5", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", first.Text);
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", third.Text);
                npgsqlC.Parameters.AddWithValue("p4", fourth.Text);
                npgsqlC.Parameters.AddWithValue("p5", login);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} изменил запись в таблице Logins в {DateTime.Now}: \"Name\", \"Surname\", \"Patronymic\", login, password, \"chClient\", \"chCount\", \"chSeller\", \"chGoods\", \"chGoodsInvoice\", \"chAccounts\", \"chInvoice\", \"accessClient\", \"accessCount\", \"accessSeller\", \"accessGoods\", \"accessGoodsInvoice\", \"accessAccounts\", \"accessInvoice\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{Autho.Crypt(fifth.Text, Autho.secretKey)}', {chClient.Checked}, {chCount.Checked}," +
                    $"{chSeller.Checked}, {chGoods.Checked}, {chGoodsInvoice.Checked}, {chAccounts.Checked}, {chInvoice.Checked}, '{accessClient.SelectedItem}', '{accessCount.SelectedItem}', '{accessSeller.SelectedItem}', '{accessGoods.SelectedItem}', '{accessGoodsInvoice.SelectedItem}', '{accessAccounts.SelectedItem}', '{accessInvoice.SelectedItem}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from logins"); // Обновление данных в грид вью 
        }

        private void delete_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM logins WHERE login = @p1", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", fourth.Text);
            npgsqlC.ExecuteNonQuery(); // Удаление записи
            Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} удалил запись в таблице Logins в {DateTime.Now}: \"Name\", \"Surname\", \"Patronymic\", login, password, \"chClient\", \"chCount\", \"chSeller\", \"chGoods\", \"chGoodsInvoice\", \"chAccounts\", \"chInvoice\", \"accessClient\", \"accessCount\", \"accessSeller\", \"accessGoods\", \"accessGoodsInvoice\", \"accessAccounts\", \"accessInvoice\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{Autho.Crypt(fifth.Text, Autho.secretKey)}', {chClient.Checked}, {chCount.Checked}," +
                $"{chSeller.Checked}, {chGoods.Checked}, {chGoodsInvoice.Checked}, {chAccounts.Checked}, {chInvoice.Checked}, '{accessClient.SelectedItem}', '{accessCount.SelectedItem}', '{accessSeller.SelectedItem}', '{accessGoods.SelectedItem}', '{accessGoodsInvoice.SelectedItem}', '{accessAccounts.SelectedItem}', '{accessInvoice.SelectedItem}'"); // Логирование
            data.DataSource = Warehouse.GetData("SELECT * from logins"); // Обновление данных в грид вью 
        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = role.SelectedItem.ToString();
            if(selected == "Администратор") // Автоматические заполнений текстбоксов и чекбоксов при выборе роли
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is CheckBox)
                       (Controls[i] as CheckBox).Checked = true;
                }
                accessClient.SelectedItem = "3";
                accessCount.SelectedItem = "3";
                accessSeller.SelectedItem = "3";
                accessGoods.SelectedItem = "3";
                accessGoodsInvoice.SelectedItem = "3";
                accessAccounts.SelectedItem = "3";
                accessInvoice.SelectedItem = "3";
            }
            if(selected == "Менеджер")
            {
                chClient.Checked = true;
                chCount.Checked = true;
                chSeller.Checked = true;
                chGoods.Checked = true;
                chGoodsInvoice.Checked = true;
                chAccounts.Checked = false;
                chInvoice.Checked = true;
                accessClient.SelectedItem = "3";
                accessCount.SelectedItem = "2";
                accessSeller.SelectedItem = "3";
                accessGoods.SelectedItem = "3";
                accessGoodsInvoice.SelectedItem = "2";
                accessAccounts.SelectedItem = "0";
                accessInvoice.SelectedItem = "2";
            }
            if(selected == "Бухгалтер")
            {
                chClient.Checked = false;
                chCount.Checked = true;
                chSeller.Checked = false;
                chGoods.Checked = false;
                chGoodsInvoice.Checked = true;
                chAccounts.Checked = false;
                chInvoice.Checked = true;
                accessClient.SelectedItem = "0";
                accessCount.SelectedItem = "3";
                accessSeller.SelectedItem = "0";
                accessGoods.SelectedItem = "0";
                accessGoodsInvoice.SelectedItem = "3";
                accessAccounts.SelectedItem = "0";
                accessInvoice.SelectedItem = "3";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.DataSource = Warehouse.GetData($"select * from logins WHERE \"Surname\" = @p1", new NpgsqlParameter("p1", search.Text)); // Поиск записи по фамилии
            }
            catch (Exception)
            {

            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            data.DataSource = Warehouse.AccountsTable; // Обновление данных в грид вью 
        }
    }
}