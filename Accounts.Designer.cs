namespace courseWork
{
    partial class Accounts
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
            this.add = new System.Windows.Forms.Button();
            this.text12 = new System.Windows.Forms.Label();
            this.text11 = new System.Windows.Forms.Label();
            this.text10 = new System.Windows.Forms.Label();
            this.text9 = new System.Windows.Forms.Label();
            this.text8 = new System.Windows.Forms.Label();
            this.text7 = new System.Windows.Forms.Label();
            this.text6 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.chInvoice = new System.Windows.Forms.CheckBox();
            this.chAccounts = new System.Windows.Forms.CheckBox();
            this.chGoods = new System.Windows.Forms.CheckBox();
            this.chSeller = new System.Windows.Forms.CheckBox();
            this.chGoodsInvoice = new System.Windows.Forms.CheckBox();
            this.chCount = new System.Windows.Forms.CheckBox();
            this.chClient = new System.Windows.Forms.CheckBox();
            this.fifth = new System.Windows.Forms.TextBox();
            this.fourth = new System.Windows.Forms.TextBox();
            this.third = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.helper = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.roleText = new System.Windows.Forms.Label();
            this.access = new System.Windows.Forms.Label();
            this.accessClient = new System.Windows.Forms.ComboBox();
            this.accessCount = new System.Windows.Forms.ComboBox();
            this.accessSeller = new System.Windows.Forms.ComboBox();
            this.accessGoods = new System.Windows.Forms.ComboBox();
            this.accessGoodsInvoice = new System.Windows.Forms.ComboBox();
            this.accessAccounts = new System.Windows.Forms.ComboBox();
            this.accessInvoice = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
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
            this.data.TabIndex = 1;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(160, 474);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 42);
            this.add.TabIndex = 59;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // text12
            // 
            this.text12.AutoSize = true;
            this.text12.Location = new System.Drawing.Point(307, 503);
            this.text12.Name = "text12";
            this.text12.Size = new System.Drawing.Size(135, 13);
            this.text12.TabIndex = 58;
            this.text12.Text = "Доступ к таблице Invoice";
            // 
            // text11
            // 
            this.text11.AutoSize = true;
            this.text11.Location = new System.Drawing.Point(307, 469);
            this.text11.Name = "text11";
            this.text11.Size = new System.Drawing.Size(145, 13);
            this.text11.TabIndex = 57;
            this.text11.Text = "Доступ к таблице Accounts";
            // 
            // text10
            // 
            this.text10.AutoSize = true;
            this.text10.Location = new System.Drawing.Point(307, 434);
            this.text10.Name = "text10";
            this.text10.Size = new System.Drawing.Size(166, 13);
            this.text10.TabIndex = 56;
            this.text10.Text = "Доступ к таблице GoodsInvoice";
            // 
            // text9
            // 
            this.text9.AutoSize = true;
            this.text9.Location = new System.Drawing.Point(307, 401);
            this.text9.Name = "text9";
            this.text9.Size = new System.Drawing.Size(131, 13);
            this.text9.TabIndex = 55;
            this.text9.Text = "Доступ к таблице Goods";
            // 
            // text8
            // 
            this.text8.AutoSize = true;
            this.text8.Location = new System.Drawing.Point(307, 364);
            this.text8.Name = "text8";
            this.text8.Size = new System.Drawing.Size(126, 13);
            this.text8.TabIndex = 54;
            this.text8.Text = "Доступ к таблице Seller";
            // 
            // text7
            // 
            this.text7.AutoSize = true;
            this.text7.Location = new System.Drawing.Point(307, 328);
            this.text7.Name = "text7";
            this.text7.Size = new System.Drawing.Size(131, 13);
            this.text7.TabIndex = 53;
            this.text7.Text = "Доступ к таблице Count ";
            // 
            // text6
            // 
            this.text6.AutoSize = true;
            this.text6.Location = new System.Drawing.Point(307, 291);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(126, 13);
            this.text6.TabIndex = 52;
            this.text6.Text = "Доступ к таблице Client";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Location = new System.Drawing.Point(39, 414);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(38, 13);
            this.text4.TabIndex = 51;
            this.text4.Text = "Логин";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Location = new System.Drawing.Point(39, 375);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(54, 13);
            this.text3.TabIndex = 50;
            this.text3.Text = "Отчество";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(39, 333);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(56, 13);
            this.text2.TabIndex = 48;
            this.text2.Text = "Фамилия";
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Location = new System.Drawing.Point(39, 455);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(45, 13);
            this.text5.TabIndex = 49;
            this.text5.Text = "Пароль";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(39, 296);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(29, 13);
            this.text1.TabIndex = 47;
            this.text1.Text = "Имя";
            // 
            // chInvoice
            // 
            this.chInvoice.AutoSize = true;
            this.chInvoice.Location = new System.Drawing.Point(473, 502);
            this.chInvoice.Name = "chInvoice";
            this.chInvoice.Size = new System.Drawing.Size(15, 14);
            this.chInvoice.TabIndex = 46;
            this.chInvoice.UseVisualStyleBackColor = true;
            // 
            // chAccounts
            // 
            this.chAccounts.AutoSize = true;
            this.chAccounts.Location = new System.Drawing.Point(473, 469);
            this.chAccounts.Name = "chAccounts";
            this.chAccounts.Size = new System.Drawing.Size(15, 14);
            this.chAccounts.TabIndex = 45;
            this.chAccounts.UseVisualStyleBackColor = true;
            // 
            // chGoods
            // 
            this.chGoods.AutoSize = true;
            this.chGoods.Location = new System.Drawing.Point(473, 401);
            this.chGoods.Name = "chGoods";
            this.chGoods.Size = new System.Drawing.Size(15, 14);
            this.chGoods.TabIndex = 44;
            this.chGoods.UseVisualStyleBackColor = true;
            // 
            // chSeller
            // 
            this.chSeller.AutoSize = true;
            this.chSeller.Location = new System.Drawing.Point(473, 364);
            this.chSeller.Name = "chSeller";
            this.chSeller.Size = new System.Drawing.Size(15, 14);
            this.chSeller.TabIndex = 43;
            this.chSeller.UseVisualStyleBackColor = true;
            // 
            // chGoodsInvoice
            // 
            this.chGoodsInvoice.AutoSize = true;
            this.chGoodsInvoice.Location = new System.Drawing.Point(473, 434);
            this.chGoodsInvoice.Name = "chGoodsInvoice";
            this.chGoodsInvoice.Size = new System.Drawing.Size(15, 14);
            this.chGoodsInvoice.TabIndex = 42;
            this.chGoodsInvoice.UseVisualStyleBackColor = true;
            // 
            // chCount
            // 
            this.chCount.AutoSize = true;
            this.chCount.Location = new System.Drawing.Point(473, 327);
            this.chCount.Name = "chCount";
            this.chCount.Size = new System.Drawing.Size(15, 14);
            this.chCount.TabIndex = 41;
            this.chCount.UseVisualStyleBackColor = true;
            // 
            // chClient
            // 
            this.chClient.AutoSize = true;
            this.chClient.Location = new System.Drawing.Point(473, 291);
            this.chClient.Name = "chClient";
            this.chClient.Size = new System.Drawing.Size(15, 14);
            this.chClient.TabIndex = 40;
            this.chClient.UseVisualStyleBackColor = true;
            // 
            // fifth
            // 
            this.fifth.Location = new System.Drawing.Point(111, 448);
            this.fifth.Name = "fifth";
            this.fifth.Size = new System.Drawing.Size(162, 20);
            this.fifth.TabIndex = 39;
            // 
            // fourth
            // 
            this.fourth.Location = new System.Drawing.Point(111, 407);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(162, 20);
            this.fourth.TabIndex = 38;
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(111, 368);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(162, 20);
            this.third.TabIndex = 37;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(111, 326);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(162, 20);
            this.second.TabIndex = 36;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(111, 289);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(162, 20);
            this.first.TabIndex = 35;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(609, 517);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(341, 25);
            this.warning.TabIndex = 60;
            this.warning.Text = "Некорректно введены данные";
            this.warning.Visible = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(41, 474);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 42);
            this.Clear.TabIndex = 61;
            this.Clear.Text = "Очистить данные ввода";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(160, 517);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(113, 42);
            this.edit.TabIndex = 62;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(41, 517);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 42);
            this.delete.TabIndex = 63;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // helper
            // 
            this.helper.AutoSize = true;
            this.helper.Location = new System.Drawing.Point(279, 532);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(318, 13);
            this.helper.TabIndex = 64;
            this.helper.Text = "Для удаления и изменения записи достаточно ввести логин ";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(8, 246);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(309, 25);
            this.info.TabIndex = 116;
            this.info.Text = "Действие с пользователем";
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Бухгалтер"});
            this.role.Location = new System.Drawing.Point(325, 262);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(125, 21);
            this.role.TabIndex = 118;
            this.role.SelectedIndexChanged += new System.EventHandler(this.role_SelectedIndexChanged);
            // 
            // roleText
            // 
            this.roleText.AutoSize = true;
            this.roleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleText.Location = new System.Drawing.Point(322, 246);
            this.roleText.Name = "roleText";
            this.roleText.Size = new System.Drawing.Size(82, 13);
            this.roleText.TabIndex = 119;
            this.roleText.Text = "Должность: ";
            this.roleText.Visible = false;
            // 
            // access
            // 
            this.access.AutoSize = true;
            this.access.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.access.Location = new System.Drawing.Point(620, 238);
            this.access.Name = "access";
            this.access.Size = new System.Drawing.Size(365, 65);
            this.access.TabIndex = 120;
            this.access.Text = "Доступ: \r\n0 - только чтение записей\r\n1 - редактирование и чтение записей\r\n2 - ред" +
    "актирование, чтение и добавление записей\r\n3 - редактирование, чтение, добавление" +
    ", удаление записей";
            // 
            // accessClient
            // 
            this.accessClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessClient.FormattingEnabled = true;
            this.accessClient.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.accessClient.Location = new System.Drawing.Point(491, 283);
            this.accessClient.Name = "accessClient";
            this.accessClient.Size = new System.Drawing.Size(125, 21);
            this.accessClient.TabIndex = 121;
            // 
            // accessCount
            // 
            this.accessCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessCount.FormattingEnabled = true;
            this.accessCount.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.accessCount.Location = new System.Drawing.Point(491, 320);
            this.accessCount.Name = "accessCount";
            this.accessCount.Size = new System.Drawing.Size(125, 21);
            this.accessCount.TabIndex = 122;
            // 
            // accessSeller
            // 
            this.accessSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessSeller.FormattingEnabled = true;
            this.accessSeller.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.accessSeller.Location = new System.Drawing.Point(491, 356);
            this.accessSeller.Name = "accessSeller";
            this.accessSeller.Size = new System.Drawing.Size(125, 21);
            this.accessSeller.TabIndex = 123;
            // 
            // accessGoods
            // 
            this.accessGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessGoods.FormattingEnabled = true;
            this.accessGoods.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.accessGoods.Location = new System.Drawing.Point(491, 394);
            this.accessGoods.Name = "accessGoods";
            this.accessGoods.Size = new System.Drawing.Size(125, 21);
            this.accessGoods.TabIndex = 124;
            // 
            // accessGoodsInvoice
            // 
            this.accessGoodsInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessGoodsInvoice.FormattingEnabled = true;
            this.accessGoodsInvoice.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.accessGoodsInvoice.Location = new System.Drawing.Point(491, 427);
            this.accessGoodsInvoice.Name = "accessGoodsInvoice";
            this.accessGoodsInvoice.Size = new System.Drawing.Size(125, 21);
            this.accessGoodsInvoice.TabIndex = 125;
            // 
            // accessAccounts
            // 
            this.accessAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessAccounts.FormattingEnabled = true;
            this.accessAccounts.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.accessAccounts.Location = new System.Drawing.Point(491, 461);
            this.accessAccounts.Name = "accessAccounts";
            this.accessAccounts.Size = new System.Drawing.Size(125, 21);
            this.accessAccounts.TabIndex = 126;
            // 
            // accessInvoice
            // 
            this.accessInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessInvoice.FormattingEnabled = true;
            this.accessInvoice.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.accessInvoice.Location = new System.Drawing.Point(491, 495);
            this.accessInvoice.Name = "accessInvoice";
            this.accessInvoice.Size = new System.Drawing.Size(125, 21);
            this.accessInvoice.TabIndex = 127;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(729, 356);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 20);
            this.search.TabIndex = 128;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(729, 382);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 42);
            this.searchButton.TabIndex = 129;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(822, 382);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(69, 42);
            this.reset.TabIndex = 130;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(696, 337);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(231, 16);
            this.labelSearch.TabIndex = 131;
            this.labelSearch.Text = "Поиск пользователя по фамилии: ";
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.accessInvoice);
            this.Controls.Add(this.accessAccounts);
            this.Controls.Add(this.accessGoodsInvoice);
            this.Controls.Add(this.accessGoods);
            this.Controls.Add(this.accessSeller);
            this.Controls.Add(this.accessCount);
            this.Controls.Add(this.accessClient);
            this.Controls.Add(this.access);
            this.Controls.Add(this.roleText);
            this.Controls.Add(this.role);
            this.Controls.Add(this.info);
            this.Controls.Add(this.helper);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.add);
            this.Controls.Add(this.text12);
            this.Controls.Add(this.text11);
            this.Controls.Add(this.text10);
            this.Controls.Add(this.text9);
            this.Controls.Add(this.text8);
            this.Controls.Add(this.text7);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.chInvoice);
            this.Controls.Add(this.chAccounts);
            this.Controls.Add(this.chGoods);
            this.Controls.Add(this.chSeller);
            this.Controls.Add(this.chGoodsInvoice);
            this.Controls.Add(this.chCount);
            this.Controls.Add(this.chClient);
            this.Controls.Add(this.fifth);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label text12;
        private System.Windows.Forms.Label text11;
        private System.Windows.Forms.Label text10;
        private System.Windows.Forms.Label text9;
        private System.Windows.Forms.Label text8;
        private System.Windows.Forms.Label text7;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.CheckBox chInvoice;
        private System.Windows.Forms.CheckBox chAccounts;
        private System.Windows.Forms.CheckBox chGoods;
        private System.Windows.Forms.CheckBox chSeller;
        private System.Windows.Forms.CheckBox chGoodsInvoice;
        private System.Windows.Forms.CheckBox chCount;
        private System.Windows.Forms.CheckBox chClient;
        private System.Windows.Forms.TextBox fifth;
        private System.Windows.Forms.TextBox fourth;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label helper;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label roleText;
        private System.Windows.Forms.Label access;
        private System.Windows.Forms.ComboBox accessClient;
        private System.Windows.Forms.ComboBox accessCount;
        private System.Windows.Forms.ComboBox accessSeller;
        private System.Windows.Forms.ComboBox accessGoods;
        private System.Windows.Forms.ComboBox accessGoodsInvoice;
        private System.Windows.Forms.ComboBox accessAccounts;
        private System.Windows.Forms.ComboBox accessInvoice;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label labelSearch;
    }
}