namespace courseWork
{
    partial class Count
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data = new System.Windows.Forms.DataGridView();
            this.sum = new System.Windows.Forms.Label();
            this.idClient = new System.Windows.Forms.Label();
            this.worker = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.fifth = new System.Windows.Forms.TextBox();
            this.fourth = new System.Windows.Forms.TextBox();
            this.third = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.chCash = new System.Windows.Forms.CheckBox();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.reportWord = new System.Windows.Forms.Button();
            this.reportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(984, 229);
            this.data.TabIndex = 2;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(32, 415);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(87, 13);
            this.sum.TabIndex = 87;
            this.sum.Text = "Сумма к уплате";
            // 
            // idClient
            // 
            this.idClient.AutoSize = true;
            this.idClient.Location = new System.Drawing.Point(2, 455);
            this.idClient.Name = "idClient";
            this.idClient.Size = new System.Drawing.Size(131, 13);
            this.idClient.TabIndex = 85;
            this.idClient.Text = "Идентификатор клиента";
            // 
            // worker
            // 
            this.worker.AutoSize = true;
            this.worker.Location = new System.Drawing.Point(12, 337);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(112, 13);
            this.worker.TabIndex = 83;
            this.worker.Text = "Фамилия работника";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(32, 300);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(80, 13);
            this.date.TabIndex = 82;
            this.date.Text = "Дата выписки";
            // 
            // fifth
            // 
            this.fifth.Location = new System.Drawing.Point(136, 453);
            this.fifth.Name = "fifth";
            this.fifth.Size = new System.Drawing.Size(162, 20);
            this.fifth.TabIndex = 81;
            // 
            // fourth
            // 
            this.fourth.Location = new System.Drawing.Point(136, 415);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(162, 20);
            this.fourth.TabIndex = 80;
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(136, 376);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(162, 20);
            this.third.TabIndex = 79;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(136, 334);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(162, 20);
            this.second.TabIndex = 78;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(136, 297);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(162, 20);
            this.first.TabIndex = 77;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(21, 376);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(98, 13);
            this.id.TabIndex = 88;
            this.id.Text = "Номер документа";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(333, 297);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(58, 13);
            this.cash.TabIndex = 90;
            this.cash.Text = "Наличные";
            // 
            // chCash
            // 
            this.chCash.AutoSize = true;
            this.chCash.Location = new System.Drawing.Point(397, 296);
            this.chCash.Name = "chCash";
            this.chCash.Size = new System.Drawing.Size(15, 14);
            this.chCash.TabIndex = 89;
            this.chCash.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(43, 519);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 42);
            this.delete.TabIndex = 94;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(162, 519);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(113, 42);
            this.edit.TabIndex = 93;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(43, 476);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 42);
            this.Clear.TabIndex = 92;
            this.Clear.Text = "Очистить данные ввода";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(162, 476);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 42);
            this.add.TabIndex = 91;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(432, 391);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(341, 25);
            this.warning.TabIndex = 96;
            this.warning.Text = "Некорректно введены данные";
            this.warning.Visible = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(10, 249);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(303, 25);
            this.info.TabIndex = 116;
            this.info.Text = "Действие с счёт-фактурой";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(599, 301);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(373, 16);
            this.labelSearch.TabIndex = 135;
            this.labelSearch.Text = "Поиск счёт-фактур с суммой к оплате больше заданной";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(822, 346);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(73, 42);
            this.reset.TabIndex = 134;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(729, 346);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 42);
            this.searchButton.TabIndex = 133;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(729, 320);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 20);
            this.search.TabIndex = 132;
            // 
            // reportWord
            // 
            this.reportWord.Location = new System.Drawing.Point(864, 476);
            this.reportWord.Name = "reportWord";
            this.reportWord.Size = new System.Drawing.Size(108, 56);
            this.reportWord.TabIndex = 143;
            this.reportWord.Text = "Отчёт по записям в таблице в Word";
            this.reportWord.UseVisualStyleBackColor = true;
            this.reportWord.Click += new System.EventHandler(this.reportWord_Click);
            // 
            // reportExcel
            // 
            this.reportExcel.Location = new System.Drawing.Point(750, 476);
            this.reportExcel.Name = "reportExcel";
            this.reportExcel.Size = new System.Drawing.Size(108, 56);
            this.reportExcel.TabIndex = 142;
            this.reportExcel.Text = "Отчёт по записям в таблице в Excel";
            this.reportExcel.UseVisualStyleBackColor = true;
            this.reportExcel.Click += new System.EventHandler(this.reportExcel_Click);
            // 
            // Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.reportWord);
            this.Controls.Add(this.reportExcel);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.info);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.chCash);
            this.Controls.Add(this.id);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.idClient);
            this.Controls.Add(this.worker);
            this.Controls.Add(this.date);
            this.Controls.Add(this.fifth);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Count";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label idClient;
        private System.Windows.Forms.Label worker;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox fifth;
        private System.Windows.Forms.TextBox fourth;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.CheckBox chCash;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button reportWord;
        private System.Windows.Forms.Button reportExcel;
    }
}