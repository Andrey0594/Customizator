using Customizator.Classes.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace Customizator.Forms
{
    public partial class MainForm : Form
    {
       


        private AppSettings appSettings;
        private ConnectionSettingsForm connectionSettingsForm= new ConnectionSettingsForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            appSettings = OptionsLoader<AppSettings>.LoadOptionsFromXml();
            if (appSettings==null)
                appSettings=AppSettings.LoadDefaultOptions();



            AddFormOnPanel(connectionSettingsForm, ConnectionSettingsPage);
            
            


        }

       

        private void AddFormOnPanel(Form frm, RadPageViewPage page)
        {
            
            frm.TopLevel = false;
            page.Controls.Add(frm);
            frm.Dock= DockStyle.Fill;
            frm.Parent = page;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            
            
        }
    }
}
