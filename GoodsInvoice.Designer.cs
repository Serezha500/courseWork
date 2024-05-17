namespace courseWork
{
    partial class Goods_invoice
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
            this.date = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.TextBox();
            this.search2 = new System.Windows.Forms.TextBox();
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
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(95, 380);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(33, 13);
            this.date.TabIndex = 95;
            this.date.Text = "Дата";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(57, 341);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(71, 13);
            this.price.TabIndex = 93;
            this.price.Text = "Цена товара";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(29, 304);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(99, 13);
            this.number.TabIndex = 92;
            this.number.Text = "Номер ведомости";
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(145, 380);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(162, 20);
            this.third.TabIndex = 91;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(145, 338);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(162, 20);
            this.second.TabIndex = 90;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(145, 301);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(162, 20);
            this.first.TabIndex = 89;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(75, 464);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 42);
            this.delete.TabIndex = 99;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(194, 464);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(113, 42);
            this.edit.TabIndex = 98;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(75, 421);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 42);
            this.Clear.TabIndex = 97;
            this.Clear.Text = "Очистить данные ввода";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(194, 421);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 42);
            this.add.TabIndex = 96;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(461, 332);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(341, 25);
            this.warning.TabIndex = 101;
            this.warning.Text = "Некорректно введены данные";
            this.warning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "Действие с приходной накладной ведомостью";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(498, 367);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(463, 16);
            this.labelSearch.TabIndex = 139;
            this.labelSearch.Text = "Поиск приходных накладных ведомостей с ценой товара в диапазоне";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(733, 412);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(69, 42);
            this.reset.TabIndex = 138;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(640, 412);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 42);
            this.searchButton.TabIndex = 137;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(640, 386);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(73, 20);
            this.search1.TabIndex = 136;
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(729, 386);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(73, 20);
            this.search2.TabIndex = 140;
            // 
            // Goods_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.date);
            this.Controls.Add(this.price);
            this.Controls.Add(this.number);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Goods_invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods_invoice";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox search1;
        private System.Windows.Forms.TextBox search2;
    }
}