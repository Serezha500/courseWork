using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ClosedXML.Excel;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace courseWork
{
    public partial class Count : Form
    {
        string documentN = ""; // Переменная для обновления ключевого поля
        public Count()
        {
            InitializeComponent();
            data.DataSource = Warehouse.CountTable; // Обновление данных в грид вью
            if (Warehouse.currentUser.AccessCount == "0") // Установка в соответствии с правами пользователя
            {
                add.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessCount == "1")
            {
                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessCount == "2")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessCount == "3")
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
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE count SET \"DateStart\" = @p1, \"Cash\" = '{chCash.Checked}', \"Worker\" = @p2, \"DocumentN\" = @p3, \"Sum\" = @p4, \"ClientID\" = @p5 WHERE \"DocumentN\" = @p6", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToDateTime(first.Text));
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", Convert.ToInt32(third.Text));
                npgsqlC.Parameters.AddWithValue("p4", Convert.ToDouble(fourth.Text));
                npgsqlC.Parameters.AddWithValue("p5", Convert.ToInt32(fifth.Text));
                npgsqlC.Parameters.AddWithValue("p6", Convert.ToInt32(documentN));
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} изменил запись в таблице Count в {DateTime.Now}: \"DateStart\", \"Cash\", \"DocumentN\",\"Worker\", \"Sum\", \"ClientID\" - '{first.Text}', '{chCash.Checked}', '{third.Text}', '{second.Text}', '{fourth.Text}', '{fifth.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from count"); // Обновление данных в грид вью
        }

        private void add_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO count (\"DateStart\", \"Cash\", \"DocumentN\",\"Worker\", \"Sum\", \"ClientID\") VALUES (@p1, '{chCash.Checked}', @p3, @p2, @p4, @p5)", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", Convert.ToDateTime(first.Text));
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", Convert.ToInt32(third.Text));
                npgsqlC.Parameters.AddWithValue("p4", Convert.ToDouble(fourth.Text));
                npgsqlC.Parameters.AddWithValue("p5", Convert.ToInt32(fifth.Text));
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} добавил запись в таблицу Count в {DateTime.Now}: \"DateStart\", \"Cash\", \"DocumentN\",\"Worker\", \"Sum\", \"ClientID\" - '{first.Text}', '{chCash.Checked}', '{third.Text}', '{second.Text}', '{fourth.Text}', '{fifth.Text}'"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from count"); // Обновление данных в грид вью
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            Warehouse.ClearF(this); // Очистка текстбоксов
        }

        private void delete_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM count WHERE \"DocumentN\" = @p1", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", Convert.ToInt32(third.Text));
            npgsqlC.ExecuteNonQuery(); // Удаление записи
            Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} удалил запись в таблице Count в {DateTime.Now}: \"DateStart\", \"Cash\", \"DocumentN\",\"Worker\", \"Sum\", \"ClientID\" - '{first.Text}', '{chCash.Checked}', '{third.Text}', '{second.Text}', '{fourth.Text}', '{fifth.Text}'"); // Логирование
            data.DataSource = Warehouse.GetData("SELECT * from count"); // Обновление данных в грид вью
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                first.Text = row.Cells["DateStart"].Value.ToString();
                second.Text = row.Cells["Worker"].Value.ToString();
                third.Text = row.Cells["DocumentN"].Value.ToString();
                fourth.Text = row.Cells["Sum"].Value.ToString();
                fifth.Text = row.Cells["ClientID"].Value.ToString();
                chCash.Checked = (bool)row.Cells["Cash"].Value;  // Получение данных в текст боксы
                documentN = third.Text;
            }
            catch(Exception)
            {

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.DataSource = Warehouse.GetData($"select * from count WHERE \"Sum\" > @p1", new NpgsqlParameter("p1", Convert.ToDouble(search.Text))); // Поиск записи по сумме больше указанной
            }
            catch (Exception)
            {

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            data.DataSource = Warehouse.CountTable; // Обновление данных в грид вью
        }

        private void reportExcel_Click(object sender, EventArgs e)
        {
            XLWorkbook wb = new XLWorkbook();
            var ws = wb.Worksheets.Add((DataTable)data.DataSource, "Counts");
            ws.Cell("G" + 1).Value = "Всего счёт-фактур:";
            ws.Cell("H" + 1).Value = data.Rows.Count;
            ws.Columns().AdjustToContents();
            wb.SaveAs("reportCounts.xlsx"); // Отчёт в формате xlsx
        }

        private void reportWord_Click(object sender, EventArgs e)
        {
            DocX doc = DocX.Create("reportCounts.docx");
            Paragraph head = doc.InsertParagraph("Информация о счёт-фактурах\r\r\r\r");
            Formatting form = new Formatting();
            form.Size = 14;
            form.FontFamily = new Font("Times New Roman");
            head.Alignment = Alignment.center;
            head.FontSize(20);
            head.Font("Times New Roman");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Paragraph par = doc.InsertParagraph($"Документ № {data.Rows[i].Cells["DocumentN"].Value}", false, form);
                par.Alignment = Alignment.center;
                par.Bold(true);
                doc.InsertParagraph($"Дата выписки: {data.Rows[i].Cells["DateStart"].Value}", false, form);
                doc.InsertParagraph($"Фамилия работника: {data.Rows[i].Cells["Worker"].Value}", false, form);
                doc.InsertParagraph($"Сумма: {data.Rows[i].Cells["Sum"].Value}", false, form);
                if((bool)data.Rows[i].Cells["Cash"].Value)
                    doc.InsertParagraph($"Оплата наличным расчётом\r\r", false, form);
                else
                    doc.InsertParagraph($"Оплата безналичным расчётом\r\r", false, form);
            }
            doc.InsertParagraph($"Всего счёт-фактур: {data.Rows.Count}", false, form);
            doc.Save(); // Отчёт в формате docx
        }
    }
}
