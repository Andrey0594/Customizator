using Customizator.Classes.Model;
using Customizator.Classes.Settings;
using Customizator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinForms.Controls.SyntaxEditor.Taggers;

namespace Customizator.Forms
{
    public partial class FunctionsForm : Form
    {
        NLog.ILogger _logger;
        MainSettings _mainSettings;
        


        public FunctionsForm(MainSettings mainSettings, NLog.ILogger logger = null)
        {
            _logger = logger;
            _mainSettings = mainSettings;
            InitializeComponent();
        }

        /// <summary>
        ///Обновление элементов управления формы
        /// </summary>
        public void UpdateControls()
        {
            InterfaceMethods.BindDataWithControl(FunctionsLView, _mainSettings?.Context.Functions.Where(t => t.DbTypeID == _mainSettings.CurrentServer.DbTypeID).ToList(), "ID", "Name");
            InterfaceMethods.AddImageToListView(FunctionsLView, Resources.Function);
            if(FunctionsLView.Items.Count>0)
                FunctionsLView.SelectedItem = FunctionsLView.Items[0];
        }


        private void FunctionsForm_Load(object sender, EventArgs e)
        {
            FunctionsLView.SelectedItemChanged += FunctionsLView_SelectedItemChanged;
            UpdateControls();
            


            var dropSqlTextTagger = new SqlTagger(DropSqlTextTBox.SyntaxEditorElement);
            DropSqlTextTBox.TaggersRegistry.RegisterTagger(dropSqlTextTagger);
            var createSqlTextTagger = new SqlTagger(CreateSqlTextTBox.SyntaxEditorElement);
            CreateSqlTextTBox.TaggersRegistry.RegisterTagger(createSqlTextTagger);
           
        }

        private void FunctionsLView_SelectedItemChanged(object sender, EventArgs e)
        {
            var tmp = e as ListViewItemEventArgs;

            if (tmp?.Item?.DataBoundItem!=null)
            {
                Functions currentFunction= tmp.Item.DataBoundItem as Functions;
                FunctionNameTBox.Text = currentFunction.Name;
                CreateSqlTextTBox.Document = new Telerik.WinForms.SyntaxEditor.Core.Text.TextDocument(currentFunction.CreateSqlText);
                DropSqlTextTBox.Document = new Telerik.WinForms.SyntaxEditor.Core.Text.TextDocument(currentFunction.DropSqlText);
            }
        }
    }
}
