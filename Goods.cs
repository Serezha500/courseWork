using System;
using System.Windows.Forms;
using Npgsql;

namespace courseWork
{
    public partial class Goods : Form
    {
        public Goods()
        {
            InitializeComponent();
            data.DataSource = Warehouse.GoodsTable; // Обновление данных в грид вью
            if (Warehouse.currentUser.AccessGoods == "0") // Установка в соответствии с правами пользователя
            {
                add.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessGoods == "1")
            {
                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessGoods == "2")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessGoods == "3")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = true;
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                goodsID.Text = row.Cells["GoodsID"].Value.ToString();
                name.Text = row.Cells["Name"].Value.ToString();
                begin.Text = row.Cells["Begin"].Value.ToString();
                end.Text = row.Cells["End"].Value.ToString();
                numberYes.Checked = (bool)row.Cells["NumberYes"].Value;
                dateYes.Text = row.Cells["DateYes"].Value.ToString();
                producer.Text = row.Cells["Producer"].Value.ToString();
                instructions.Text = row.Cells["Instructions"].Value.ToString();
                batch.Text = row.Cells["Batch"].Value.ToString();
                INN.Text = row.Cells["INN"].Value.ToString();
                clientID.Text = row.Cells["ClientID"].Value.ToString();
                goodsInvoiceN.Text = row.Cells["GoodsInvoiceN"].Value.ToString();
                code.Image = (System.Drawing.Bitmap)((new System.Drawing.ImageConverter()).ConvertFrom(row.Cells["International"].Value)); // Получение данных в текст боксы
            }
            catch (Exception)
            {

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM goods WHERE \"GoodsID\" = @p1", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToInt32(goodsID.Text));
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} удалил запись в таблице Goods в {DateTime.Now}: \"GoodsID\", \"Name\", \"Begin\", \"End\", \"NumberYes\", \"DateYes\", \"Producer\", \"Instructions\", \"Batch\", \"INN\", \"ClientID\" - '{goodsID.Text}', '{name.Text}', '{begin.Text}', '{end.Text}', '{numberYes.Checked}', '{dateYes.Text}', '{producer.Text}', '{instructions.Text}', '{batch.Text}', '{INN.Text}', '{clientID.Text}', '{goodsInvoiceN.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from goods"); // Обновление данных в грид вью
        }

        private void edit_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand();
                npgsqlC.Connection = Warehouse.npgsql;
                string com1 = $"UPDATE goods SET \"Name\" = @p1, \"International\" = pg_read_binary_file(@p12), \"Begin\" = @p2, \"End\" = @p3, \"NumberYes\" = '{numberYes.Checked}', " +
                    $"\"DateYes\" = @p4, \"Producer\" = @p5, \"Instructions\" = @p6, \"Batch\" = @p7, \"INN\" = @p8, \"ClientID\" = @p9, \"GoodsInvoiceN\" = @p10 WHERE \"GoodsID\" = @p11";
                string com2 = $"UPDATE goods SET \"Name\" = @p1, \"Begin\" = @p2, \"End\" = @p3, \"NumberYes\" = '{numberYes.Checked}', " +
                    $"\"DateYes\" = @p4, \"Producer\" = @p5, \"Instructions\" = @p6, \"Batch\" = @p7, \"INN\" = @p8, \"ClientID\" = @p9, \"GoodsInvoiceN\" = @p10 WHERE \"GoodsID\" = @p11";
                if (path.Text != "")
                {
                    npgsqlC.CommandText = com1;
                    npgsqlC.Parameters.AddWithValue("p12", path.Text);
                }
                if (path.Text == "")
                {
                    npgsqlC.CommandText = com2;
                }
                npgsqlC.Parameters.AddWithValue("p1", name.Text);
                npgsqlC.Parameters.AddWithValue("p2", Convert.ToDateTime(begin.Text));
                npgsqlC.Parameters.AddWithValue("p3", Convert.ToDateTime(end.Text));
                npgsqlC.Parameters.AddWithValue("p4", Convert.ToDateTime(dateYes.Text));
                npgsqlC.Parameters.AddWithValue("p5", producer.Text);
                npgsqlC.Parameters.AddWithValue("p6", instructions.Text);
                npgsqlC.Parameters.AddWithValue("p7", batch.Text);
                npgsqlC.Parameters.AddWithValue("p8", INN.Text);
                npgsqlC.Parameters.AddWithValue("p9", Convert.ToInt32(clientID.Text));
                npgsqlC.Parameters.AddWithValue("p10", Convert.ToInt32(goodsInvoiceN.Text));
                npgsqlC.Parameters.AddWithValue("p11", Convert.ToInt32(goodsID.Text));
                npgsqlC.ExecuteNonQuery(); // Изменение записи (если текстбокс с ссылкой на картинку заполнен или нет)
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} изменил запись в таблице Goods в {DateTime.Now}: \"GoodsID\", \"Name\", \"Begin\", \"End\", \"NumberYes\", \"DateYes\", \"Producer\", \"Instructions\", \"Batch\", \"INN\", \"ClientID\" - '{goodsID.Text}', '{name.Text}', '{begin.Text}', '{end.Text}', '{numberYes.Checked}', '{dateYes.Text}', '{producer.Text}', '{instructions.Text}', '{batch.Text}', '{INN.Text}', '{clientID.Text}', '{goodsInvoiceN.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from goods"); // Обновление данных в грид вью
        }

        private void add_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO goods (\"Name\", \"International\", \"Begin\", \"End\", \"NumberYes\", \"DateYes\", \"Producer\", \"Instructions\", \"Batch\", \"INN\", \"ClientID\", \"GoodsInvoiceN\") VALUES (@p1, pg_read_binary_file(@p11), @p2, @p3, '{numberYes.Checked}', @p4, @p5, @p6, @p7, @p8, @p9, @p10)", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", name.Text);
                npgsqlC.Parameters.AddWithValue("p2", Convert.ToDateTime(begin.Text));
                npgsqlC.Parameters.AddWithValue("p3", Convert.ToDateTime(end.Text));
                npgsqlC.Parameters.AddWithValue("p4", Convert.ToDateTime(dateYes.Text));
                npgsqlC.Parameters.AddWithValue("p5", producer.Text);
                npgsqlC.Parameters.AddWithValue("p6", instructions.Text);
                npgsqlC.Parameters.AddWithValue("p7", batch.Text);
                npgsqlC.Parameters.AddWithValue("p8", INN.Text);
                npgsqlC.Parameters.AddWithValue("p9", Convert.ToInt32(clientID.Text));
                npgsqlC.Parameters.AddWithValue("p10", Convert.ToInt32(goodsInvoiceN.Text));
                npgsqlC.Parameters.AddWithValue("p11", path.Text);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} добавил запись в таблицу Goods в {DateTime.Now}: \"GoodsID\", \"Name\", \"Begin\", \"End\", \"NumberYes\", \"DateYes\", \"Producer\", \"Instructions\", \"Batch\", \"INN\", \"ClientID\" - '{goodsID.Text}', '{name.Text}', '{begin.Text}', '{end.Text}', '{numberYes.Checked}', '{dateYes.Text}', '{producer.Text}', '{instructions.Text}', '{batch.Text}', '{INN.Text}', '{clientID.Text}', '{goodsInvoiceN.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from goods"); // Обновление данных в грид вью
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            Warehouse.ClearF(this); // Очистка текстбоксов
        }

        private void search_CheckedChanged(object sender, EventArgs e)
        {
            if(search.Checked == true)
                data.DataSource = Warehouse.GetData($"select * from goods WHERE \"NumberYes\" = true"); // Отображать только записи с сертификатом соответствия
            else
                data.DataSource = Warehouse.GetData($"select * from goods");
        }
    }
}
