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
            this.UserTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CheckConnectionSettingsBtn = new System.Windows.Forms.Button();
            this.DbNameLbl = new System.Windows.Forms.Label();
            this.DbNameTBox = new System.Windows.Forms.TextBox();
            this.PortTBox = new System.Windows.Forms.TextBox();
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
            this.ServerCBox.Size = new System.Drawing.Size(589, 27);
            this.ServerCBox.TabIndex = 1;
            this.ServerCBox.SelectedValueChanged += new System.EventHandler(this.ServerCBox_SelectedValueChanged);
            this.ServerCBox.TextChanged += new System.EventHandler(this.ServerCBox_TextChanged);
            // 
            // DbTypeCBox
            // 
            this.DbTypeCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DbTypeCBox.FormattingEnabled = true;
            this.DbTypeCBox.Location = new System.Drawing.Point(149, 74);
            this.DbTypeCBox.Name = "DbTypeCBox";
            this.DbTypeCBox.Size = new System.Drawing.Size(589, 27);
            this.DbTypeCBox.TabIndex = 2;
            // 
            // UserTBox
            // 
            this.UserTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserTBox.Location = new System.Drawing.Point(149, 140);
            this.UserTBox.Name = "UserTBox";
            this.UserTBox.Size = new System.Drawing.Size(589, 26);
            this.UserTBox.TabIndex = 4;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTBox.Location = new System.Drawing.Point(149, 172);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.PasswordChar = '*';
            this.PasswordTBox.Size = new System.Drawing.Size(589, 26);
            this.PasswordTBox.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(611, 235);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 31);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CheckConnectionSettingsBtn
            // 
            this.CheckConnectionSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckConnectionSettingsBtn.Location = new System.Drawing.Point(340, 235);
            this.CheckConnectionSettingsBtn.Name = "CheckConnectionSettingsBtn";
            this.CheckConnectionSettingsBtn.Size = new System.Drawing.Size(256, 31);
            this.CheckConnectionSettingsBtn.TabIndex = 7;
            this.CheckConnectionSettingsBtn.Text = "Проверить соединение";
            this.CheckConnectionSettingsBtn.UseVisualStyleBackColor = true;
            this.CheckConnectionSettingsBtn.Click += new System.EventHandler(this.CheckConnectionSettingsBtn_Click);
            // 
            // DbNameLbl
            // 
            this.DbNameLbl.Location = new System.Drawing.Point(18, 206);
            this.DbNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DbNameLbl.Name = "DbNameLbl";
            this.DbNameLbl.Size = new System.Drawing.Size(114, 23);
            this.DbNameLbl.TabIndex = 0;
            this.DbNameLbl.Text = "База данных";
            // 
            // DbNameTBox
            // 
            this.DbNameTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbNameTBox.Location = new System.Drawing.Point(149, 203);
            this.DbNameTBox.Name = "DbNameTBox";
            this.DbNameTBox.Size = new System.Drawing.Size(589, 26);
            this.DbNameTBox.TabIndex = 6;
            // 
            // PortTBox
            // 
            this.PortTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTBox.Location = new System.Drawing.Point(149, 107);
            this.PortTBox.Name = "PortTBox";
            this.PortTBox.Size = new System.Drawing.Size(589, 26);
            this.PortTBox.TabIndex = 3;
            // 
            // ConnectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 681);
            this.Controls.Add(this.CheckConnectionSettingsBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DbNameTBox);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.PortTBox);
            this.Controls.Add(this.UserTBox);
            this.Controls.Add(this.DbTypeCBox);
            this.Controls.Add(this.DbNameLbl);
            this.Controls.Add(this.ServerCBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.PortLbl);
            this.Controls.Add(this.DBTypeLbl);
            this.Controls.Add(this.ServerLbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionSettingsForm";
            this.Text = "Настройки соединения";
            this.Load += new System.EventHandler(this.ConnectionSettingsForm_Load);
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
        protected internal System.Windows.Forms.TextBox UserTBox;
        protected internal System.Windows.Forms.TextBox PasswordTBox;
        protected internal System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CheckConnectionSettingsBtn;
        protected internal System.Windows.Forms.Label DbNameLbl;
        protected internal System.Windows.Forms.TextBox DbNameTBox;
        protected internal System.Windows.Forms.TextBox PortTBox;
    }
}