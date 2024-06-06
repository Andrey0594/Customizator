using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using NLog;
using Customizator.Classes.Settings;
using System.Linq;

namespace Customizator.Forms
{
    /// <summary>
    /// Класс базовой формы приложения
    /// </summary>

    public partial class MainForm : Form
    {
      
        private ILogger _logger= LogManager.GetCurrentClassLogger();
        private MainSettings _settings = new MainSettings($"{Application.StartupPath}//Settings.db");

        
        private ConnectionSettingsForm connectionSettingsForm;
        private FunctionsForm functionsForm;


        /// <summary>
        /// Конструктор базовой формы приложения
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connectionSettingsForm = new ConnectionSettingsForm(_settings, _logger);
            InterfaceMethods.AddFormOnPanel(connectionSettingsForm, ConnectionSettingsPage);
            functionsForm = new FunctionsForm(_settings, _logger);
            InterfaceMethods.AddFormOnPanel(functionsForm, FunctionsPage);

        }




        

       
    }
}
