namespace courseWork
{
    partial class Warehouse
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.client = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.goods = new System.Windows.Forms.Button();
            this.goodsInvoice = new System.Windows.Forms.Button();
            this.invoice = new System.Windows.Forms.Button();
            this.seller = new System.Windows.Forms.Button();
            this.accounts = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.helper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(-1, 80);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(165, 77);
            this.client.TabIndex = 1;
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(-1, 159);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(165, 77);
            this.count.TabIndex = 2;
            this.count.Text = "Count";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // goods
            // 
            this.goods.Location = new System.Drawing.Point(-1, 239);
            this.goods.Name = "goods";
            this.goods.Size = new System.Drawing.Size(165, 77);
            this.goods.TabIndex = 3;
            this.goods.Text = "Goods";
            this.goods.UseVisualStyleBackColor = true;
            this.goods.Click += new System.EventHandler(this.goods_Click);
            // 
            // goodsInvoice
            // 
            this.goodsInvoice.Location = new System.Drawing.Point(-1, 319);
            this.goodsInvoice.Name = "goodsInvoice";
            this.goodsInvoice.Size = new System.Drawing.Size(165, 77);
            this.goodsInvoice.TabIndex = 4;
            this.goodsInvoice.Text = "Goods invoice";
            this.goodsInvoice.UseVisualStyleBackColor = true;
            this.goodsInvoice.Click += new System.EventHandler(this.goodsInvoice_Click);
            // 
            // invoice
            // 
            this.invoice.Location = new System.Drawing.Point(-1, 399);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(165, 77);
            this.invoice.TabIndex = 5;
            this.invoice.Text = "Invoice";
            this.invoice.UseVisualStyleBackColor = true;
            this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // seller
            // 
            this.seller.Location = new System.Drawing.Point(-1, 1);
            this.seller.Name = "seller";
            this.seller.Size = new System.Drawing.Size(165, 77);
            this.seller.TabIndex = 6;
            this.seller.Text = "Seller";
            this.seller.UseVisualStyleBackColor = true;
            this.seller.Click += new System.EventHandler(this.seller_Click);
            // 
            // accounts
            // 
            this.accounts.Location = new System.Drawing.Point(-1, 480);
            this.accounts.Name = "accounts";
            this.accounts.Size = new System.Drawing.Size(165, 77);
            this.accounts.TabIndex = 7;
            this.accounts.Text = "Accounts";
            this.accounts.UseVisualStyleBackColor = true;
            this.accounts.Click += new System.EventHandler(this.accounts_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(424, 466);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(197, 91);
            this.exit.TabIndex = 8;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // helper
            // 
            this.helper.Location = new System.Drawing.Point(424, 1);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(197, 91);
            this.helper.TabIndex = 9;
            this.helper.Text = "Помощь";
            this.helper.UseVisualStyleBackColor = true;
            this.helper.Click += new System.EventHandler(this.helper_Click);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 558);
            this.Controls.Add(this.helper);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.accounts);
            this.Controls.Add(this.seller);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.goodsInvoice);
            this.Controls.Add(this.goods);
            this.Controls.Add(this.count);
            this.Controls.Add(this.client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад товаров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Warehouse_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button goods;
        private System.Windows.Forms.Button goodsInvoice;
        private System.Windows.Forms.Button invoice;
        private System.Windows.Forms.Button seller;
        private System.Windows.Forms.Button accounts;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button helper;
    }
}

