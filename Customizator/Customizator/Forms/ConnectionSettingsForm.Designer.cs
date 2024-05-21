namespace Customizator.Forms
{
    partial class ConnectionSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionSettingsForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.DBTypeLbl = new System.Windows.Forms.Label();
            this.PortLbl = new System.Windows.Forms.Label();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.ServerCBox = new System.Windows.Forms.ComboBox();
            this.DbTypeCBox = new System.Windows.Forms.ComboBox();
            this.PortTBox = new System.Windows.Forms.NumericUpDown();
            this.UserTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CheckConnectionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortTBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerLbl
            // 
            this.ServerLbl.Location = new System.Drawing.Point(18, 45);
            this.ServerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(114, 23);
            this.ServerLbl.TabIndex = 0;
            this.ServerLbl.Text = "Сервер";
            // 
            // DBTypeLbl
            // 
            this.DBTypeLbl.Location = new System.Drawing.Point(18, 78);
            this.DBTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DBTypeLbl.Name = "DBTypeLbl";
            this.DBTypeLbl.Size = new System.Drawing.Size(114, 23);
            this.DBTypeLbl.TabIndex = 0;
            this.DBTypeLbl.Text = "Тип БД";
            // 
            // PortLbl
            // 
            this.PortLbl.Location = new System.Drawing.Point(18, 110);
            this.PortLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(114, 23);
            this.PortLbl.TabIndex = 0;
            this.PortLbl.Text = "Порт";
            // 
            // UserLbl
            // 
            this.UserLbl.Location = new System.Drawing.Point(18, 143);
            this.UserLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(114, 23);
            this.UserLbl.TabIndex = 0;
            this.UserLbl.Text = "Пользователь";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Location = new System.Drawing.Point(18, 175);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(114, 23);
            this.PasswordLbl.TabIndex = 0;
            this.PasswordLbl.Text = "Пароль";
            // 
            // ServerCBox
            // 
            this.ServerCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerCBox.FormattingEnabled = true;
            this.ServerCBox.Location = new System.Drawing.Point(149, 41);
            this.ServerCBox.Name = "ServerCBox";
            this.ServerCBox.Size = new System.Drawing.Size(543, 27);
            this.ServerCBox.TabIndex = 1;
            // 
            // DbTypeCBox
            // 
            this.DbTypeCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DbTypeCBox.FormattingEnabled = true;
            this.DbTypeCBox.Location = new System.Drawing.Point(149, 74);
            this.DbTypeCBox.Name = "DbTypeCBox";
            this.DbTypeCBox.Size = new System.Drawing.Size(543, 27);
            this.DbTypeCBox.TabIndex = 1;
            // 
            // PortTBox
            // 
            this.PortTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTBox.Location = new System.Drawing.Point(149, 107);
            this.PortTBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PortTBox.Name = "PortTBox";
            this.PortTBox.Size = new System.Drawing.Size(543, 26);
            this.PortTBox.TabIndex = 2;
            // 
            // UserTBox
            // 
            this.UserTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserTBox.Location = new System.Drawing.Point(149, 140);
            this.UserTBox.Name = "UserTBox";
            this.UserTBox.Size = new System.Drawing.Size(543, 26);
            this.UserTBox.TabIndex = 3;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTBox.Location = new System.Drawing.Point(149, 172);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.PasswordChar = '*';
            this.PasswordTBox.Size = new System.Drawing.Size(543, 26);
            this.PasswordTBox.TabIndex = 3;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(565, 204);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 31);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // CheckConnectionBtn
            // 
            this.CheckConnectionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckConnectionBtn.Location = new System.Drawing.Point(255, 204);
            this.CheckConnectionBtn.Name = "CheckConnectionBtn";
            this.CheckConnectionBtn.Size = new System.Drawing.Size(304, 31);
            this.CheckConnectionBtn.TabIndex = 4;
            this.CheckConnectionBtn.Text = "Проверить соединение";
            this.CheckConnectionBtn.UseVisualStyleBackColor = true;
            // 
            // ConnectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 681);
            this.Controls.Add(this.CheckConnectionBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.UserTBox);
            this.Controls.Add(this.PortTBox);
            this.Controls.Add(this.DbTypeCBox);
            this.Controls.Add(this.ServerCBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.PortLbl);
            this.Controls.Add(this.DBTypeLbl);
            this.Controls.Add(this.ServerLbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConnectionSettingsForm";
            this.Text = "Настройки соединения";
            ((System.ComponentModel.ISupportInitialize)(this.PortTBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        protected internal System.Windows.Forms.Label ServerLbl;
        protected internal System.Windows.Forms.Label DBTypeLbl;
        protected internal System.Windows.Forms.Label PortLbl;
        protected internal System.Windows.Forms.Label UserLbl;
        protected internal System.Windows.Forms.Label PasswordLbl;
        protected internal System.Windows.Forms.ComboBox ServerCBox;
        protected internal System.Windows.Forms.ComboBox DbTypeCBox;
        protected internal System.Windows.Forms.NumericUpDown PortTBox;
        protected internal System.Windows.Forms.TextBox UserTBox;
        protected internal System.Windows.Forms.TextBox PasswordTBox;
        protected internal System.Windows.Forms.Button SaveBtn;
        protected internal System.Windows.Forms.Button CheckConnectionBtn;
    }
}