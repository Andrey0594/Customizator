using Customizator.Classes;
using Customizator.Classes.DbClasses;
using Customizator.Classes.Model;
using Customizator.Classes.Settings;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Telerik.WinControls.Data;

namespace Customizator.Forms
{
    /// <summary>
    /// Форма настроек подключения к БД
    /// </summary>
    public partial class ConnectionSettingsForm : Form
    {
        NLog.ILogger _logger;
        MainSettings _mainSettings;
        




        /// <summary>
        /// Конструктор для формы настроек подключения к БД
        /// </summary>
        /// <param name="appContext">Модель БД</param>
        /// <param name="logger">Logger</param>
        public ConnectionSettingsForm(MainSettings mainSettings, NLog.ILogger logger=null)
        {         
            _logger = logger;
            _mainSettings = mainSettings;
            InitializeComponent();
        }

        private void ConnectionSettingsForm_Load(object sender, System.EventArgs e)
        {
            BindDataWithControl(DbTypeCBox, _mainSettings.Context.DbTypes.ToList(), "ID", "Name");
            BindDataWithControl(ServerCBox, _mainSettings.Context.Servers.ToList(), "ID", "ServerName");
        }



        private void UpdateControls(Servers server)
        {
            DbTypeCBox.SelectedItem = server.DbType;
            PortTBox.Text = string.IsNullOrEmpty(server.Port) || server.Port=="null"?"": server.Port;
            UserTBox.Text = server.User;
            PasswordTBox.Text = server.Password;
            DbNameTBox.Text = server.DbName;
            

        }
        private void BindDataWithControl<T>(ListControl control, List<T> values, string valueMember, string displayMember )
        {
            
            control.DataSource = values;
            control.ValueMember = valueMember;
            control.DisplayMember = displayMember;
        }

        private void ServerCBox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            _mainSettings.CurrentServer = ServerCBox.SelectedItem as Servers;
            UpdateControls(_mainSettings.CurrentServer);
        }

        private void ServerCBox_TextChanged(object sender, System.EventArgs e)
        {
            Servers tmpServer = ServerCBox.Items.Cast<Servers>().FirstOrDefault(t => t.ServerName == ServerCBox.Text);
            if (tmpServer != null)
                ServerCBox.SelectedItem = tmpServer;
        }

        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            if(ServerCBox.Text.Length*DbTypeCBox.Text.Length*UserTBox.TextLength*DbNameTBox.TextLength<=0)
            { return; }

            Servers server;

            if (ServerCBox.SelectedItem == null)
            {
                server = new Servers()
                {
                    ServerName = ServerCBox.Text,
                    DbType = DbTypeCBox.SelectedItem as DbTypes,
                    Port = PortTBox.Text,
                    User = UserTBox.Text,
                    Password = PasswordTBox.Text,
                    DbName = DbNameTBox.Text,
                    IsCurrent = "+"
                };
                _mainSettings.Context.Servers.Add(server);
                _mainSettings.Context.SaveChanges();
            }
            else
            {
                
                server = _mainSettings.Context.Servers.FirstOrDefault(t => t.ID == ((Servers)ServerCBox.SelectedItem).ID);
                server.ServerName = ServerCBox.Text;
                server.DbType = DbTypeCBox.SelectedItem as DbTypes;
                server.Port = PortTBox.Text;
                server.User = UserTBox.Text;
                server.Password = PasswordTBox.Text;
                server.DbName = DbNameTBox.Text;
                server.IsCurrent = "+";
                _mainSettings.Context.Servers.AddOrUpdate(server);
                _mainSettings.Context.SaveChanges();
            }
            _mainSettings.CurrentServer = server;


        }

        private void CheckConnectionSettingsBtn_Click(object sender, System.EventArgs e)
        {
            if(_mainSettings.CurrentServer != null)
            {
                _mainSettings.Connection=DataBaseProviderFactory.CreateLanDocsProvider(_mainSettings.CurrentServer);
                if(_mainSettings.Connection!=null)
                {
                    if(_mainSettings.Connection.Connect())
                        MessageBox.Show("Соединение установлено");
                    else
                        MessageBox.Show("Ошибка соединения. Проверьте настройки соединения");
                }
            }
        }
    }
}
