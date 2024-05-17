namespace courseWork
{
    partial class Invoice
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
            this.warning = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.inn = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
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
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(452, 329);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(341, 25);
            this.warning.TabIndex = 114;
            this.warning.Text = "Некорректно введены данные";
            this.warning.Visible = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(66, 461);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 42);
            this.delete.TabIndex = 112;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(185, 461);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(113, 42);
            this.edit.TabIndex = 111;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(66, 418);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 42);
            this.Clear.TabIndex = 110;
            this.Clear.Text = "Очистить данные ввода";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(185, 418);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 42);
            this.add.TabIndex = 109;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // inn
            // 
            this.inn.AutoSize = true;
            this.inn.Location = new System.Drawing.Point(31, 379);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(75, 13);
            this.inn.TabIndex = 108;
            this.inn.Text = "ИНН клиента";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(18, 338);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(107, 13);
            this.surname.TabIndex = 106;
            this.surname.Text = "Фамилия продавца";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(20, 301);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(99, 13);
            this.number.TabIndex = 105;
            this.number.Text = "Номер ведомости";
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(136, 377);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(162, 20);
            this.third.TabIndex = 104;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(136, 335);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(162, 20);
            this.second.TabIndex = 103;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(136, 298);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(162, 20);
            this.first.TabIndex = 102;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(12, 251);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(509, 25);
            this.info.TabIndex = 115;
            this.info.Text = "Действие с выходной накладной ведомостью";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(667, 376);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(238, 16);
            this.labelSearch.TabIndex = 135;
            this.labelSearch.Text = "Поиск ведомостей по ИНН клиента";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(807, 421);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(73, 42);
            this.reset.TabIndex = 134;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(718, 421);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 42);
            this.searchButton.TabIndex = 133;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(718, 395);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 20);
            this.search.TabIndex = 132;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
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
            this.Controls.Add(this.inn);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.number);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label inn;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox search;
    }
}