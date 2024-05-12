namespace courseWork
{
    partial class Client
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
            this.phone = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.fifth = new System.Windows.Forms.TextBox();
            this.fourth = new System.Windows.Forms.TextBox();
            this.third = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.building = new System.Windows.Forms.Label();
            this.helper = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.Label();
            this.six = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.reportExcel = new System.Windows.Forms.Button();
            this.reportWord = new System.Windows.Forms.Button();
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
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(39, 454);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(52, 13);
            this.phone.TabIndex = 74;
            this.phone.Text = "Телефон";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Location = new System.Drawing.Point(42, 374);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(39, 13);
            this.street.TabIndex = 73;
            this.street.Text = "Улица";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(29, 330);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(58, 13);
            this.company.TabIndex = 71;
            this.company.Text = "Компания";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(4, 291);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(87, 13);
            this.name.TabIndex = 70;
            this.name.Text = "Идентификатор";
            // 
            // fifth
            // 
            this.fifth.Location = new System.Drawing.Point(101, 447);
            this.fifth.Name = "fifth";
            this.fifth.Size = new System.Drawing.Size(162, 20);
            this.fifth.TabIndex = 69;
            // 
            // fourth
            // 
            this.fourth.Location = new System.Drawing.Point(101, 406);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(162, 20);
            this.fourth.TabIndex = 68;
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(101, 367);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(162, 20);
            this.third.TabIndex = 67;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(101, 325);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(162, 20);
            this.second.TabIndex = 66;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(101, 288);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(162, 20);
            this.first.TabIndex = 65;
            // 
            // building
            // 
            this.building.AutoSize = true;
            this.building.Location = new System.Drawing.Point(32, 409);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(55, 13);
            this.building.TabIndex = 76;
            this.building.Text = "Строение";
            // 
            // helper
            // 
            this.helper.AutoSize = true;
            this.helper.Location = new System.Drawing.Point(265, 530);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(364, 13);
            this.helper.TabIndex = 81;
            this.helper.Text = "Для удаления и изменения записи достаточно ввести идентификатор";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(27, 515);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 42);
            this.delete.TabIndex = 80;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(146, 515);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(113, 42);
            this.edit.TabIndex = 79;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(27, 472);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 42);
            this.Clear.TabIndex = 78;
            this.Clear.Text = "Очистить данные ввода";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(146, 472);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 42);
            this.add.TabIndex = 77;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(621, 262);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(341, 25);
            this.warning.TabIndex = 82;
            this.warning.Text = "Некорректно введены данные";
            this.warning.Visible = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(12, 244);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(246, 25);
            this.info.TabIndex = 116;
            this.info.Text = "Действие с клиентом";
            // 
            // INN
            // 
            this.INN.AutoSize = true;
            this.INN.Location = new System.Drawing.Point(346, 291);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(31, 13);
            this.INN.TabIndex = 118;
            this.INN.Text = "ИНН";
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(383, 288);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(162, 20);
            this.six.TabIndex = 117;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(775, 374);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(156, 16);
            this.labelSearch.TabIndex = 139;
            this.labelSearch.Text = "Поиск клиента по ИНН";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(866, 419);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(69, 42);
            this.reset.TabIndex = 138;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(773, 419);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 42);
            this.searchButton.TabIndex = 137;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(773, 393);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 20);
            this.search.TabIndex = 136;
            // 
            // reportExcel
            // 
            this.reportExcel.Location = new System.Drawing.Point(746, 493);
            this.reportExcel.Name = "reportExcel";
            this.reportExcel.Size = new System.Drawing.Size(108, 56);
            this.reportExcel.TabIndex = 140;
            this.reportExcel.Text = "Отчёт по записям в таблице в Excel";
            this.reportExcel.UseVisualStyleBackColor = true;
            this.reportExcel.Click += new System.EventHandler(this.reportExcel_Click);
            // 
            // reportWord
            // 
            this.reportWord.Location = new System.Drawing.Point(860, 493);
            this.reportWord.Name = "reportWord";
            this.reportWord.Size = new System.Drawing.Size(108, 56);
            this.reportWord.TabIndex = 141;
            this.reportWord.Text = "Отчёт по записям в таблице в Word";
            this.reportWord.UseVisualStyleBackColor = true;
            this.reportWord.Click += new System.EventHandler(this.reportWord_Click);
            // 
            // Client
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
            this.Controls.Add(this.INN);
            this.Controls.Add(this.six);
            this.Controls.Add(this.info);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.helper);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.building);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.street);
            this.Controls.Add(this.company);
            this.Controls.Add(this.name);
            this.Controls.Add(this.fifth);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox fifth;
        private System.Windows.Forms.TextBox fourth;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label building;
        private System.Windows.Forms.Label helper;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label INN;
        private System.Windows.Forms.TextBox six;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button reportExcel;
        private System.Windows.Forms.Button reportWord;
    }
}