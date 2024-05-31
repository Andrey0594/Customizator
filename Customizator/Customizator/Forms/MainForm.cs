﻿
using Customizator.Classes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
      


        
        private ConnectionSettingsForm connectionSettingsForm= new ConnectionSettingsForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddFormOnPanel(connectionSettingsForm, ConnectionSettingsPage);
            connectionSettingsForm.SaveBtn.Click+= SaveBtn_Click;
            



        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            

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
