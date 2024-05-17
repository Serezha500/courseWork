namespace courseWork
{
    partial class Autho
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
            this.text = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.checkUser = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(138, 57);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(182, 25);
            this.text.TabIndex = 0;
            this.text.Text = "АВТОРИЗАЦИЯ";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(183, 110);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(100, 20);
            this.log.TabIndex = 1;
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(183, 162);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 2;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // checkUser
            // 
            this.checkUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkUser.Location = new System.Drawing.Point(45, 211);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(325, 58);
            this.checkUser.TabIndex = 3;
            this.checkUser.Text = "Войти";
            this.checkUser.UseVisualStyleBackColor = true;
            this.checkUser.Click += new System.EventHandler(this.checkUser_Click);
            // 
            // textLog
            // 
            this.textLog.AutoSize = true;
            this.textLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLog.Location = new System.Drawing.Point(88, 104);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(76, 25);
            this.textLog.TabIndex = 4;
            this.textLog.Text = "Логин";
            // 
            // textPass
            // 
            this.textPass.AutoSize = true;
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPass.Location = new System.Drawing.Point(85, 156);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(92, 25);
            this.textPass.TabIndex = 5;
            this.textPass.Text = "Пароль";
            // 
            // warning
            // 
            this.warning.BackColor = System.Drawing.SystemColors.Control;
            this.warning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warning.Enabled = false;
            this.warning.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(45, 287);
            this.warning.Multiline = true;
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(379, 47);
            this.warning.TabIndex = 6;
            this.warning.Text = "Неверный логин или пароль";
            this.warning.Visible = false;
            // 
            // Autho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 361);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.checkUser);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.log);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Autho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button checkUser;
        private System.Windows.Forms.Label textLog;
        private System.Windows.Forms.Label textPass;
        private System.Windows.Forms.TextBox warning;
    }
}