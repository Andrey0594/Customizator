
namespace Customizator.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPageView = new Telerik.WinControls.UI.RadPageView();
            this.ConnectionSettingsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.FunctionsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.ExecSctriptsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.PluginsPage = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).BeginInit();
            this.MainPageView.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPageView
            // 
            this.MainPageView.Controls.Add(this.ConnectionSettingsPage);
            this.MainPageView.Controls.Add(this.FunctionsPage);
            this.MainPageView.Controls.Add(this.ExecSctriptsPage);
            this.MainPageView.Controls.Add(this.PluginsPage);
            this.MainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPageView.Location = new System.Drawing.Point(0, 0);
            this.MainPageView.Name = "MainPageView";
            this.MainPageView.SelectedPage = this.ConnectionSettingsPage;
            this.MainPageView.ShowItemToolTips = false;
            this.MainPageView.Size = new System.Drawing.Size(1649, 1061);
            this.MainPageView.TabIndex = 0;
            this.MainPageView.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            // 
            // ConnectionSettingsPage
            // 
            this.ConnectionSettingsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionSettingsPage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ConnectionSettingsPage.Image = global::Customizator.Properties.Resources.DBSettings;
            this.ConnectionSettingsPage.ItemSize = new System.Drawing.SizeF(224F, 36F);
            this.ConnectionSettingsPage.Location = new System.Drawing.Point(281, 37);
            this.ConnectionSettingsPage.Name = "ConnectionSettingsPage";
            this.ConnectionSettingsPage.Size = new System.Drawing.Size(1367, 1023);
            this.ConnectionSettingsPage.Text = "Настройки соединения";
            // 
            // FunctionsPage
            // 
            this.FunctionsPage.Image = ((System.Drawing.Image)(resources.GetObject("FunctionsPage.Image")));
            this.FunctionsPage.ItemSize = new System.Drawing.SizeF(224F, 36F);
            this.FunctionsPage.Location = new System.Drawing.Point(281, 37);
            this.FunctionsPage.Name = "FunctionsPage";
            this.FunctionsPage.Size = new System.Drawing.Size(1367, 1023);
            this.FunctionsPage.Text = "Функции";
            // 
            // ExecSctriptsPage
            // 
            this.ExecSctriptsPage.Image = ((System.Drawing.Image)(resources.GetObject("ExecSctriptsPage.Image")));
            this.ExecSctriptsPage.ItemSize = new System.Drawing.SizeF(224F, 36F);
            this.ExecSctriptsPage.Location = new System.Drawing.Point(281, 32);
            this.ExecSctriptsPage.Name = "ExecSctriptsPage";
            this.ExecSctriptsPage.Size = new System.Drawing.Size(1642, 1109);
            this.ExecSctriptsPage.Text = " Исполняемые скрипты";
            // 
            // PluginsPage
            // 
            this.PluginsPage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PluginsPage.Image = ((System.Drawing.Image)(resources.GetObject("PluginsPage.Image")));
            this.PluginsPage.ItemSize = new System.Drawing.SizeF(224F, 36F);
            this.PluginsPage.Location = new System.Drawing.Point(281, 30);
            this.PluginsPage.Name = "PluginsPage";
            this.PluginsPage.Size = new System.Drawing.Size(1367, 1030);
            this.PluginsPage.Text = "Дополнительные модули";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 1061);
            this.Controls.Add(this.MainPageView);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Кастомизатор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).EndInit();
            this.MainPageView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView MainPageView;
        private Telerik.WinControls.UI.RadPageViewPage ConnectionSettingsPage;
        private Telerik.WinControls.UI.RadPageViewPage FunctionsPage;
        private Telerik.WinControls.UI.RadPageViewPage ExecSctriptsPage;
        private Telerik.WinControls.UI.RadPageViewPage PluginsPage;
    }
}

