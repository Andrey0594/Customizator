namespace Customizator.Forms
{
    partial class FunctionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionsForm));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FunctionsLView = new Telerik.WinControls.UI.RadListView();
            this.CreateSqlTextPanel = new System.Windows.Forms.Panel();
            this.CreateSqlTextTBox = new Telerik.WinControls.UI.RadSyntaxEditor();
            this.CreateSqlTextLbl = new System.Windows.Forms.Label();
            this.DropSqlTextPanel = new System.Windows.Forms.Panel();
            this.DropSqlTextTBox = new Telerik.WinControls.UI.RadSyntaxEditor();
            this.DropSlqTextLbl = new System.Windows.Forms.Label();
            this.FunctionNamePanel = new System.Windows.Forms.Panel();
            this.FunctionNameTBox = new System.Windows.Forms.TextBox();
            this.FunctionNameLbl = new System.Windows.Forms.Label();
            this.FunctionsBtnPanel = new System.Windows.Forms.Panel();
            this.CreateNewFunctionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsLView)).BeginInit();
            this.CreateSqlTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateSqlTextTBox)).BeginInit();
            this.DropSqlTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropSqlTextTBox)).BeginInit();
            this.FunctionNamePanel.SuspendLayout();
            this.FunctionsBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(5);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.FunctionsBtnPanel);
            this.MainSplitContainer.Panel1.Controls.Add(this.FunctionsLView);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.CreateSqlTextPanel);
            this.MainSplitContainer.Panel2.Controls.Add(this.DropSqlTextPanel);
            this.MainSplitContainer.Panel2.Controls.Add(this.FunctionNamePanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(1924, 1061);
            this.MainSplitContainer.SplitterDistance = 341;
            this.MainSplitContainer.SplitterWidth = 7;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // FunctionsLView
            // 
            this.FunctionsLView.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionsLView.GroupItemSize = new System.Drawing.Size(200, 28);
            this.FunctionsLView.ItemSize = new System.Drawing.Size(200, 28);
            this.FunctionsLView.Location = new System.Drawing.Point(0, 0);
            this.FunctionsLView.Name = "FunctionsLView";
            this.FunctionsLView.Size = new System.Drawing.Size(341, 938);
            this.FunctionsLView.TabIndex = 0;
            // 
            // CreateSqlTextPanel
            // 
            this.CreateSqlTextPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateSqlTextPanel.Controls.Add(this.CreateSqlTextTBox);
            this.CreateSqlTextPanel.Controls.Add(this.CreateSqlTextLbl);
            this.CreateSqlTextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateSqlTextPanel.Location = new System.Drawing.Point(0, 54);
            this.CreateSqlTextPanel.Margin = new System.Windows.Forms.Padding(5);
            this.CreateSqlTextPanel.Name = "CreateSqlTextPanel";
            this.CreateSqlTextPanel.Size = new System.Drawing.Size(1576, 858);
            this.CreateSqlTextPanel.TabIndex = 2;
            // 
            // CreateSqlTextTBox
            // 
            this.CreateSqlTextTBox.AllowScaling = false;
            this.CreateSqlTextTBox.AutoScroll = true;
            this.CreateSqlTextTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateSqlTextTBox.Location = new System.Drawing.Point(0, 24);
            this.CreateSqlTextTBox.Name = "CreateSqlTextTBox";
            this.CreateSqlTextTBox.ShowLineNumbers = false;
            this.CreateSqlTextTBox.Size = new System.Drawing.Size(1572, 830);
            this.CreateSqlTextTBox.TabIndex = 1;
            this.CreateSqlTextTBox.Text = "radSyntaxEditor1";
            // 
            // CreateSqlTextLbl
            // 
            this.CreateSqlTextLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateSqlTextLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateSqlTextLbl.Location = new System.Drawing.Point(0, 0);
            this.CreateSqlTextLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CreateSqlTextLbl.Name = "CreateSqlTextLbl";
            this.CreateSqlTextLbl.Size = new System.Drawing.Size(1572, 24);
            this.CreateSqlTextLbl.TabIndex = 0;
            this.CreateSqlTextLbl.Text = "Текст функции";
            // 
            // DropSqlTextPanel
            // 
            this.DropSqlTextPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DropSqlTextPanel.Controls.Add(this.DropSqlTextTBox);
            this.DropSqlTextPanel.Controls.Add(this.DropSlqTextLbl);
            this.DropSqlTextPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DropSqlTextPanel.Location = new System.Drawing.Point(0, 912);
            this.DropSqlTextPanel.Margin = new System.Windows.Forms.Padding(5);
            this.DropSqlTextPanel.Name = "DropSqlTextPanel";
            this.DropSqlTextPanel.Size = new System.Drawing.Size(1576, 149);
            this.DropSqlTextPanel.TabIndex = 1;
            // 
            // DropSqlTextTBox
            // 
            this.DropSqlTextTBox.AllowScaling = false;
            this.DropSqlTextTBox.AutoScroll = true;
            this.DropSqlTextTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropSqlTextTBox.Location = new System.Drawing.Point(0, 24);
            this.DropSqlTextTBox.Name = "DropSqlTextTBox";
            this.DropSqlTextTBox.ShowLineNumbers = false;
            this.DropSqlTextTBox.Size = new System.Drawing.Size(1572, 121);
            this.DropSqlTextTBox.TabIndex = 1;
            this.DropSqlTextTBox.Text = "radSyntaxEditor1";
            // 
            // DropSlqTextLbl
            // 
            this.DropSlqTextLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DropSlqTextLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DropSlqTextLbl.Location = new System.Drawing.Point(0, 0);
            this.DropSlqTextLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DropSlqTextLbl.Name = "DropSlqTextLbl";
            this.DropSlqTextLbl.Size = new System.Drawing.Size(1572, 24);
            this.DropSlqTextLbl.TabIndex = 0;
            this.DropSlqTextLbl.Text = "Скрипт удаления функции";
            // 
            // FunctionNamePanel
            // 
            this.FunctionNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FunctionNamePanel.Controls.Add(this.FunctionNameTBox);
            this.FunctionNamePanel.Controls.Add(this.FunctionNameLbl);
            this.FunctionNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionNamePanel.Location = new System.Drawing.Point(0, 0);
            this.FunctionNamePanel.Margin = new System.Windows.Forms.Padding(5);
            this.FunctionNamePanel.Name = "FunctionNamePanel";
            this.FunctionNamePanel.Size = new System.Drawing.Size(1576, 54);
            this.FunctionNamePanel.TabIndex = 0;
            // 
            // FunctionNameTBox
            // 
            this.FunctionNameTBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionNameTBox.Location = new System.Drawing.Point(0, 24);
            this.FunctionNameTBox.Name = "FunctionNameTBox";
            this.FunctionNameTBox.Size = new System.Drawing.Size(1572, 29);
            this.FunctionNameTBox.TabIndex = 1;
            // 
            // FunctionNameLbl
            // 
            this.FunctionNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FunctionNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionNameLbl.Location = new System.Drawing.Point(0, 0);
            this.FunctionNameLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FunctionNameLbl.Name = "FunctionNameLbl";
            this.FunctionNameLbl.Size = new System.Drawing.Size(1572, 24);
            this.FunctionNameLbl.TabIndex = 0;
            this.FunctionNameLbl.Text = "Название функции";
            // 
            // FunctionsBtnPanel
            // 
            this.FunctionsBtnPanel.Controls.Add(this.CreateNewFunctionBtn);
            this.FunctionsBtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionsBtnPanel.Location = new System.Drawing.Point(0, 938);
            this.FunctionsBtnPanel.Name = "FunctionsBtnPanel";
            this.FunctionsBtnPanel.Size = new System.Drawing.Size(341, 123);
            this.FunctionsBtnPanel.TabIndex = 1;
            // 
            // CreateNewFunctionBtn
            // 
            this.CreateNewFunctionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateNewFunctionBtn.Location = new System.Drawing.Point(0, 0);
            this.CreateNewFunctionBtn.Name = "CreateNewFunctionBtn";
            this.CreateNewFunctionBtn.Size = new System.Drawing.Size(341, 32);
            this.CreateNewFunctionBtn.TabIndex = 0;
            this.CreateNewFunctionBtn.Text = "button1";
            this.CreateNewFunctionBtn.UseVisualStyleBackColor = true;
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.MainSplitContainer);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FunctionsForm";
            this.Text = "Функции";
            this.Load += new System.EventHandler(this.FunctionsForm_Load);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsLView)).EndInit();
            this.CreateSqlTextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreateSqlTextTBox)).EndInit();
            this.DropSqlTextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DropSqlTextTBox)).EndInit();
            this.FunctionNamePanel.ResumeLayout(false);
            this.FunctionNamePanel.PerformLayout();
            this.FunctionsBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Panel FunctionNamePanel;
        private System.Windows.Forms.TextBox FunctionNameTBox;
        private System.Windows.Forms.Label FunctionNameLbl;
        private System.Windows.Forms.Panel DropSqlTextPanel;
        private Telerik.WinControls.UI.RadSyntaxEditor DropSqlTextTBox;
        private System.Windows.Forms.Label DropSlqTextLbl;
        private System.Windows.Forms.Panel CreateSqlTextPanel;
        private Telerik.WinControls.UI.RadSyntaxEditor CreateSqlTextTBox;
        private System.Windows.Forms.Label CreateSqlTextLbl;
        private Telerik.WinControls.UI.RadListView FunctionsLView;
        private System.Windows.Forms.Panel FunctionsBtnPanel;
        private System.Windows.Forms.Button CreateNewFunctionBtn;
    }
}