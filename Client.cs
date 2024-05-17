using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ClosedXML.Excel;
using Xceed.Words.NET;
using Xceed.Document.NET;
namespace courseWork
{
    public partial class Client : Form
    {
        DataTable dataForReport; // Объект с данными для отчёта
        public Client()
        {
            InitializeComponent();
            data.DataSource = Warehouse.ClientTable; // Обновление данных в грид вью 
            dataForReport = Warehouse.GetData("SELECT invoice.*, client.\"Company\" FROM client, invoice WHERE client.\"INNClient\" = invoice.\"INNClient\""); // Обновление данных
            if (Warehouse.currentUser.AccessClient == "0") // Установка в соответствии с правами пользователя
            {
                add.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessClient == "1")
            {
                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessClient == "2")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessClient == "3")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            warning.Visible = false; // Очистка текстбоксов
            Warehouse.ClearF(this);
        }

        private void add_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {

                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO client (\"Company\", \"Street\", \"Building\",\"Phone\", \"INNClient\") VALUES (@p1, @p2, @p3, @p4, @p5)", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", second.Text);
                npgsqlC.Parameters.AddWithValue("p2", third.Text);
                npgsqlC.Parameters.AddWithValue("p3", fourth.Text);
                npgsqlC.Parameters.AddWithValue("p4", fifth.Text);
                npgsqlC.Parameters.AddWithValue("p5", six.Text);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} добавил запись в таблицу Client в {DateTime.Now}: \"ClientID\", \"Company\", \"Street\", \"Building\",\"Phone\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{fifth.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from client"); // Обновление данных в грид вью 
        }

        private void delete_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM client WHERE \"ClientID\" = @p1", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToInt32(first.Text));
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} удалил запись в таблице Client в {DateTime.Now}: \"ClientID\", \"Company\", \"Street\", \"Building\",\"Phone\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{fifth.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from client"); // Обновление данных в грид вью 
        }

        private void edit_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE client SET \"Company\" = @p1, \"Street\" = @p2, \"Building\" = @p3, \"Phone\" = @p4, \"INNClient\" = @p5 WHERE \"ClientID\" = @p6", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", second.Text);
                npgsqlC.Parameters.AddWithValue("p2", third.Text);
                npgsqlC.Parameters.AddWithValue("p3", fourth.Text);
                npgsqlC.Parameters.AddWithValue("p4", fifth.Text);
                npgsqlC.Parameters.AddWithValue("p5", six.Text);
                npgsqlC.Parameters.AddWithValue("p6", Convert.ToInt32(first.Text));
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} изменил запись в таблице Client в {DateTime.Now}: \"ClientID\", \"Company\", \"Street\", \"Building\",\"Phone\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{fifth.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from client"); // Обновление данных в грид вью 
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                first.Text = row.Cells["ClientID"].Value.ToString();
                second.Text = row.Cells["Company"].Value.ToString();
                third.Text = row.Cells["Street"].Value.ToString();
                fourth.Text = row.Cells["Building"].Value.ToString();
                fifth.Text = row.Cells["Phone"].Value.ToString();
                six.Text = row.Cells["INNClient"].Value.ToString(); // Получение данных в текст боксы
            }
            catch (Exception)
            {

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            data.DataSource = Warehouse.ClientTable; // Обновление данных в грид вью 
            dataForReport = Warehouse.GetData("SELECT invoice.*, client.\"Company\" FROM client, invoice WHERE client.\"INNClient\" = invoice.\"INNClient\""); // Обновление данных
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.DataSource = Warehouse.GetData($"select * from client WHERE \"INNClient\" = @p1", new NpgsqlParameter("p1",search.Text)); // Поиск записи по ИНН
                dataForReport = Warehouse.GetData($"SELECT invoice.*, client.\"Company\" FROM client, invoice WHERE client.\"INNClient\" = @p1 and client.\"INNClient\" = invoice.\"INNClient\"", new NpgsqlParameter("p1", search.Text));
            }
            catch (Exception)
            {

            }
        }

        private void reportExcel_Click(object sender, EventArgs e)
        {
            XLWorkbook wb = new XLWorkbook();
            var ws = wb.Worksheets.Add(dataForReport,"Clients");
            ws.Columns().AdjustToContents();
            wb.SaveAs("reportClients.xlsx"); // Отчёт в формате xlsx
        }
        private void reportWord_Click(object sender, EventArgs e)
        {
            DocX doc = DocX.Create("reportClients.docx");
            Paragraph head = doc.InsertParagraph("Информация о клиентах и их выходных накладных ведомостях\r\r\r\r");
            Formatting form = new Formatting();
            form.Size = 14;
            form.FontFamily = new Font("Times New Roman");
            head.Alignment = Alignment.center;
            head.FontSize(20);
            head.Font("Times New Roman");
            for (int i = 0; i < dataForReport.Rows.Count; i++)
            {
                doc.InsertParagraph($"Номер выходной накладной ведомости: {dataForReport.Rows[i]["DocumentN"]}", false, form);
                doc.InsertParagraph($"Наименование клиента: {dataForReport.Rows[i]["Company"]}", false, form);
                doc.InsertParagraph($"ИНН клиента: {dataForReport.Rows[i]["INNClient"]}", false, form);
                doc.InsertParagraph($"Фамилия работника, который выписал ведомость: {dataForReport.Rows[i]["Seller"]}\r\r", false, form);
            }
            doc.Save(); // Отчёт в формате docx
        }
    }
}
