namespace courseWork
{
    partial class Goods
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
            this.label1 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.helper = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGoodsID = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.goodsID = new System.Windows.Forms.TextBox();
            this.begin = new System.Windows.Forms.TextBox();
            this.labelBegin = new System.Windows.Forms.Label();
            this.labelBatch = new System.Windows.Forms.Label();
            this.batch = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelDateYes = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.TextBox();
            this.dateYes = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.labelGoodsInvoiceN = new System.Windows.Forms.Label();
            this.labelClientID = new System.Windows.Forms.Label();
            this.labelINN = new System.Windows.Forms.Label();
            this.goodsInvoiceN = new System.Windows.Forms.TextBox();
            this.clientID = new System.Windows.Forms.TextBox();
            this.INN = new System.Windows.Forms.TextBox();
            this.numberYes = new System.Windows.Forms.CheckBox();
            this.labelNumberYes = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.producer = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.PictureBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(984, 229);
            this.data.TabIndex = 2;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 129;
            this.label1.Text = "Действие с товаром";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(532, 232);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(341, 25);
            this.warning.TabIndex = 128;
            this.warning.Text = "Некорректно введены данные";
            this.warning.Visible = false;
            // 
            // helper
            // 
            this.helper.AutoSize = true;
            this.helper.Location = new System.Drawing.Point(255, 533);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(356, 13);
            this.helper.TabIndex = 127;
            this.helper.Text = "Для удаления и изменения записи достаточно ввести номер товара";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(17, 504);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 42);
            this.delete.TabIndex = 126;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(136, 504);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(113, 42);
            this.edit.TabIndex = 125;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(17, 461);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 42);
            this.Clear.TabIndex = 124;
            this.Clear.Text = "Очистить данные ввода";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(136, 461);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 42);
            this.add.TabIndex = 123;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(15, 360);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(99, 13);
            this.labelPath.TabIndex = 122;
            this.labelPath.Text = "Путь к штрих-коду";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 318);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 13);
            this.labelName.TabIndex = 121;
            this.labelName.Text = "Название товара";
            // 
            // labelGoodsID
            // 
            this.labelGoodsID.AutoSize = true;
            this.labelGoodsID.Location = new System.Drawing.Point(34, 281);
            this.labelGoodsID.Name = "labelGoodsID";
            this.labelGoodsID.Size = new System.Drawing.Size(79, 13);
            this.labelGoodsID.TabIndex = 120;
            this.labelGoodsID.Text = "Номер товара";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(130, 357);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(162, 20);
            this.path.TabIndex = 119;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(130, 315);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(162, 20);
            this.name.TabIndex = 118;
            // 
            // goodsID
            // 
            this.goodsID.Location = new System.Drawing.Point(130, 278);
            this.goodsID.Name = "goodsID";
            this.goodsID.Size = new System.Drawing.Size(162, 20);
            this.goodsID.TabIndex = 117;
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(130, 399);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(162, 20);
            this.begin.TabIndex = 130;
            // 
            // labelBegin
            // 
            this.labelBegin.AutoSize = true;
            this.labelBegin.Location = new System.Drawing.Point(14, 402);
            this.labelBegin.Name = "labelBegin";
            this.labelBegin.Size = new System.Drawing.Size(107, 13);
            this.labelBegin.TabIndex = 131;
            this.labelBegin.Text = "Дата производства";
            // 
            // labelBatch
            // 
            this.labelBatch.AutoSize = true;
            this.labelBatch.Location = new System.Drawing.Point(327, 401);
            this.labelBatch.Name = "labelBatch";
            this.labelBatch.Size = new System.Drawing.Size(76, 13);
            this.labelBatch.TabIndex = 139;
            this.labelBatch.Text = "Вид упаковки";
            // 
            // batch
            // 
            this.batch.Location = new System.Drawing.Point(420, 398);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(162, 20);
            this.batch.TabIndex = 138;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(645, 401);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(70, 13);
            this.labelInstructions.TabIndex = 137;
            this.labelInstructions.Text = "Примечания";
            // 
            // labelDateYes
            // 
            this.labelDateYes.AutoSize = true;
            this.labelDateYes.Location = new System.Drawing.Point(304, 359);
            this.labelDateYes.Name = "labelDateYes";
            this.labelDateYes.Size = new System.Drawing.Size(111, 13);
            this.labelDateYes.TabIndex = 136;
            this.labelDateYes.Text = "Дата сертиф. соотв.";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(351, 280);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(52, 13);
            this.labelEnd.TabIndex = 135;
            this.labelEnd.Text = "Годен до";
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(732, 401);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(162, 20);
            this.instructions.TabIndex = 134;
            // 
            // dateYes
            // 
            this.dateYes.Location = new System.Drawing.Point(420, 356);
            this.dateYes.Name = "dateYes";
            this.dateYes.Size = new System.Drawing.Size(162, 20);
            this.dateYes.TabIndex = 133;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(420, 277);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(162, 20);
            this.end.TabIndex = 132;
            // 
            // labelGoodsInvoiceN
            // 
            this.labelGoodsInvoiceN.AutoSize = true;
            this.labelGoodsInvoiceN.Location = new System.Drawing.Point(588, 359);
            this.labelGoodsInvoiceN.Name = "labelGoodsInvoiceN";
            this.labelGoodsInvoiceN.Size = new System.Drawing.Size(138, 13);
            this.labelGoodsInvoiceN.TabIndex = 145;
            this.labelGoodsInvoiceN.Text = "Номер прих. накл. ведом.";
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(588, 317);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(131, 13);
            this.labelClientID.TabIndex = 144;
            this.labelClientID.Text = "Идентификатор клиента";
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.Location = new System.Drawing.Point(612, 280);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(96, 13);
            this.labelINN.TabIndex = 143;
            this.labelINN.Text = "ИНН поставщика";
            // 
            // goodsInvoiceN
            // 
            this.goodsInvoiceN.Location = new System.Drawing.Point(732, 356);
            this.goodsInvoiceN.Name = "goodsInvoiceN";
            this.goodsInvoiceN.Size = new System.Drawing.Size(162, 20);
            this.goodsInvoiceN.TabIndex = 142;
            // 
            // clientID
            // 
            this.clientID.Location = new System.Drawing.Point(732, 314);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(162, 20);
            this.clientID.TabIndex = 141;
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(732, 277);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(162, 20);
            this.INN.TabIndex = 140;
            // 
            // numberYes
            // 
            this.numberYes.AutoSize = true;
            this.numberYes.Location = new System.Drawing.Point(441, 321);
            this.numberYes.Name = "numberYes";
            this.numberYes.Size = new System.Drawing.Size(15, 14);
            this.numberYes.TabIndex = 146;
            this.numberYes.UseVisualStyleBackColor = true;
            // 
            // labelNumberYes
            // 
            this.labelNumberYes.AutoSize = true;
            this.labelNumberYes.Location = new System.Drawing.Point(311, 321);
            this.labelNumberYes.Name = "labelNumberYes";
            this.labelNumberYes.Size = new System.Drawing.Size(103, 13);
            this.labelNumberYes.TabIndex = 147;
            this.labelNumberYes.Text = "Сертификат соотв.";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(34, 437);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(86, 13);
            this.labelProducer.TabIndex = 149;
            this.labelProducer.Text = "Производитель";
            // 
            // producer
            // 
            this.producer.Location = new System.Drawing.Point(130, 437);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(162, 20);
            this.producer.TabIndex = 148;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(676, 437);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(254, 94);
            this.code.TabIndex = 150;
            this.code.TabStop = false;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(601, 476);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(59, 13);
            this.labelCode.TabIndex = 151;
            this.labelCode.Text = "Штрих-код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Отображать только продукты, имеющие сертификат соотв.";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(572, 503);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(15, 14);
            this.search.TabIndex = 153;
            this.search.UseVisualStyleBackColor = true;
            this.search.CheckedChanged += new System.EventHandler(this.search_CheckedChanged);
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.code);
            this.Controls.Add(this.labelProducer);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.labelNumberYes);
            this.Controls.Add(this.numberYes);
            this.Controls.Add(this.labelGoodsInvoiceN);
            this.Controls.Add(this.labelClientID);
            this.Controls.Add(this.labelINN);
            this.Controls.Add(this.goodsInvoiceN);
            this.Controls.Add(this.clientID);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.labelBatch);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelDateYes);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.dateYes);
            this.Controls.Add(this.end);
            this.Controls.Add(this.labelBegin);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.helper);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelGoodsID);
            this.Controls.Add(this.path);
            this.Controls.Add(this.name);
            this.Controls.Add(this.goodsID);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Goods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label helper;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGoodsID;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox goodsID;
        private System.Windows.Forms.TextBox begin;
        private System.Windows.Forms.Label labelBegin;
        private System.Windows.Forms.Label labelBatch;
        private System.Windows.Forms.TextBox batch;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelDateYes;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox instructions;
        private System.Windows.Forms.TextBox dateYes;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label labelGoodsInvoiceN;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label labelINN;
        private System.Windows.Forms.TextBox goodsInvoiceN;
        private System.Windows.Forms.TextBox clientID;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.CheckBox numberYes;
        private System.Windows.Forms.Label labelNumberYes;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.TextBox producer;
        private System.Windows.Forms.PictureBox code;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox search;
    }
}