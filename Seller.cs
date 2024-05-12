using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ClosedXML.Excel;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace courseWork
{
    public partial class Seller : Form
    {
        string innSeller = ""; // Переменная для обновления ключевого поля
        DataTable dataForReport; // Объект с данными для отчёта
        public Seller()
        {
            InitializeComponent();
            data.DataSource = Warehouse.SellerTable; // Обновление данных в грид вью 
            dataForReport = Warehouse.GetData("SELECT goods.\"Name\", goods.\"Producer\", goodsinvoice.*, seller.\"SellerN\", seller.\"INN\" FROM goods, goodsinvoice, seller WHERE goods.\"GoodsInvoiceN\" = goodsinvoice.\"GoodsInvoiceN\" and goods.\"INN\" = seller.\"INN\""); // Обновление данных
            if (Warehouse.currentUser.AccessSeller == "0") // Установка в соответствии с правами пользователя
            {
                add.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessSeller == "1")
            {
                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessSeller == "2")
            {
                add.Enabled = true;
                edit.Enabled = true;
                delete.Enabled = false;
            }
            if (Warehouse.currentUser.AccessSeller == "3")
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
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO seller (\"SellerN\", \"Street\", \"Building\", \"Phone\",\"INN\", \"Sign\") VALUES (@p1, @p2, @p3, @p4, @p5, {chSign.Checked})", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", first.Text);
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", third.Text);
                npgsqlC.Parameters.AddWithValue("p4", fourth.Text);
                npgsqlC.Parameters.AddWithValue("p5", fifth.Text);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} добавил запись в таблицу Seller в {DateTime.Now}: \"SellerN\", \"Street\", \"Building\", \"Phone\",\"INN\", \"Sign\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{fifth.Text}', {chSign.Checked}"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from seller"); // Обновление данных в грид вью 
        }

        private void edit_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE seller SET \"SellerN\" = @p1, \"Street\" = @p2, \"Building\" = @p3, \"Phone\" = @p4, \"INN\" = @p5, \"Sign\" = {chSign.Checked} WHERE \"INN\" = @p6", Warehouse.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", first.Text);
                npgsqlC.Parameters.AddWithValue("p2", second.Text);
                npgsqlC.Parameters.AddWithValue("p3", third.Text);
                npgsqlC.Parameters.AddWithValue("p4", fourth.Text);
                npgsqlC.Parameters.AddWithValue("p5", fifth.Text);
                npgsqlC.Parameters.AddWithValue("p6", innSeller);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} изменил запись в таблице Seller в {DateTime.Now}: \"SellerN\", \"Street\", \"Building\", \"Phone\",\"INN\", \"Sign\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{fifth.Text}', {chSign.Checked}"); // Логирование
            }
            catch (Exception)
            {
                warning.Visible = true;
            }
            data.DataSource = Warehouse.GetData("SELECT * from seller"); // Обновление данных в грид вью 
        }

        private void delete_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM seller WHERE \"INN\" = @p1", Warehouse.npgsql);
            npgsqlC.Parameters.AddWithValue("p1", fifth.Text);
            npgsqlC.ExecuteNonQuery(); // Удаление записи
            Warehouse.txt.WriteLine($"Пользователь {Warehouse.currentUser.Surname} {Warehouse.currentUser.Name} {Warehouse.currentUser.Patronymic} удалил запись в таблице Seller в {DateTime.Now}: \"SellerN\", \"Street\", \"Building\", \"Phone\",\"INN\", \"Sign\" - '{first.Text}', '{second.Text}', '{third.Text}', '{fourth.Text}', '{fifth.Text}', {chSign.Checked}"); // Логирование
            data.DataSource = Warehouse.GetData("SELECT * from seller"); // Обновление данных в грид вью 
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
                first.Text = row.Cells["SellerN"].Value.ToString();
                second.Text = row.Cells["Street"].Value.ToString();
                third.Text = row.Cells["Building"].Value.ToString();
                fourth.Text = row.Cells["Phone"].Value.ToString();
                fifth.Text = row.Cells["INN"].Value.ToString();
                chSign.Checked = (bool)row.Cells["Sign"].Value;
                innSeller = fifth.Text; // Получение данных в текст боксы
            }
            catch (Exception)
            {

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            data.DataSource = Warehouse.SellerTable; // Обновление данных в грид вью 
            dataForReport = Warehouse.GetData("SELECT goods.\"Name\", goods.\"Producer\", goodsinvoice.*, seller.\"SellerN\", seller.\"INN\" FROM goods, goodsinvoice, seller WHERE goods.\"GoodsInvoiceN\" = goodsinvoice.\"GoodsInvoiceN\" and goods.\"INN\" = seller.\"INN\""); // Обновление данных
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.DataSource = Warehouse.GetData($"select * from seller WHERE \"INN\" = @p1", new NpgsqlParameter("p1", search.Text));
                dataForReport = Warehouse.GetData($"SELECT goods.\"Name\", goods.\"Producer\", goodsinvoice.*, seller.\"SellerN\", seller.\"INN\" FROM goods, goodsinvoice, seller WHERE goods.\"GoodsInvoiceN\" = goodsinvoice.\"GoodsInvoiceN\" and seller.\"INN\" = @p1 and goods.\"INN\" = seller.\"INN\"", new NpgsqlParameter("p1", search.Text)); // Поиск записи по ИНН
            }
            catch (Exception)
            {

            }
        }

        private void reportExcel_Click(object sender, EventArgs e) // Создание отчёта в формате xlsx
        {
            XLWorkbook wb = new XLWorkbook();
            var ws = wb.Worksheets.Add(dataForReport, "Sellers");
            ws.Columns().AdjustToContents();
            wb.SaveAs("reportSellers.xlsx");
        }

        private void reportWord_Click(object sender, EventArgs e) // Создание отчёта в формате docx
        {
            DocX doc = DocX.Create("reportSellers.docx");
            Paragraph head = doc.InsertParagraph("Информация о поставщиках и их продукциях\r\r\r\r");
            Formatting form = new Formatting();
            form.Size = 14;
            form.FontFamily = new Font("Times New Roman");
            head.Alignment = Alignment.center;
            head.FontSize(20);
            head.Font("Times New Roman");
            for (int i = 0; i < dataForReport.Rows.Count; i++)
            {
                doc.InsertParagraph($"Номер приходной накладной ведомости: {dataForReport.Rows[i]["GoodsInvoiceN"]}", false, form);
                doc.InsertParagraph($"ИНН поставщика: {dataForReport.Rows[i]["INN"]}", false, form);
                doc.InsertParagraph($"Наименование поставщика: {dataForReport.Rows[i]["SellerN"]}", false, form);
                doc.InsertParagraph($"Наименование производителя товара: {dataForReport.Rows[i]["Producer"]}", false, form);
                doc.InsertParagraph($"Наименование товара: {dataForReport.Rows[i]["Name"]}", false, form);
                doc.InsertParagraph($"Сумма приходной накладной ведомости: {dataForReport.Rows[i]["Price"]}", false, form);
                doc.InsertParagraph($"Дата приходной накладной ведомости: {dataForReport.Rows[i]["Date"]}\r\r", false, form);
                
            }
            doc.Save();
        }
    }
}
