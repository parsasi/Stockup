using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockUp.Forms
{
    public static class FormNavigator
    {
        public static List<StockUpForm> forms { get; set; }

        public static StockUpForm currentForm { get; set; }

        public static void SwitchForm(string formName)
        {
            FormNavigator.currentForm.Hide();
            var formToShow = FormNavigator.forms.Find(item => item.Name == formName);
            formToShow.Show();
            FormNavigator.currentForm = formToShow;
        }

    }
}
