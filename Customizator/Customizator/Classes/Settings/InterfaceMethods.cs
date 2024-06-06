using Customizator.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Customizator.Classes.Settings
{
    public class InterfaceMethods
    {

        /// <summary>
        ////Добавление формы в виде контрола на вкладку
        /// </summary>
        /// <param name="frm">Добавляемая форма</param>
        /// <param name="page">Вкладка на которую добавляется форма</param>
        public static void AddFormOnPanel(Form frm, RadPageViewPage page)
        {
            frm.TopLevel = false;
            page.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Parent = page;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        /// <summary>
        /// Создание связи между контролом и набором данных
        /// </summary>
        /// <typeparam name="ControlType">Тип контрола</typeparam>
        /// <typeparam name="ValuesType">Тип набора данных</typeparam>
        /// <param name="control">Контрол в котором создается связь с данными</param>
        /// <param name="values">Набор значений</param>
        /// <param name="valueMember">Ключевая колонка набора данных</param>
        /// <param name="displayMember">Отображаемая колонка набора данных</param>
        public static void BindDataWithControl<ControlType, ValuesType>(ControlType control, List<ValuesType> values, string valueMember, string displayMember)
        {
            if(control is RadListView)
            {
                (control as RadListView).DataSource = null;
                (control as RadListView).DataSource = values;
                (control as RadListView).ValueMember = valueMember;
                (control as RadListView).DisplayMember = displayMember;
            }
            else if(control is ListControl)
            {
                (control as ListControl).DataSource = null;
                (control as ListControl).DataSource = values;
                (control as ListControl).ValueMember = valueMember;
                (control as ListControl).DisplayMember = displayMember;
            }
            
            
        }

        /// <summary>
        /// Добавляет картинку ко всем элементам ListView
        /// </summary>
        /// <param name="lView">Контрол RadListView</param>
        /// <param name="img">Изображение</param>
        public static void AddImageToListView(RadListView lView, Bitmap img)
        {
            foreach (ListViewDataItem item in lView.Items)
            {
                item.Image = img;
            }
        }
    }
}
