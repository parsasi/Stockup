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
            CloseForm(FormNavigator.currentForm);
            var formToShow = FormNavigator.OpenForm(formName);
            FormNavigator.currentForm = formToShow;
        }

        public static StockUpForm OpenForm(string formName)
        {
            var formToShow = FormNavigator.FindForm(formName);
            formToShow.Show();
            return formToShow;
        }

        public static void CloseForm(string formName)
        {
            var formToHide = FormNavigator.FindForm(formName);
            formToHide.Hide();
        }
        public static void CloseForm(StockUpForm form)
        {
            form.Hide();
        }

        public static StockUpForm FindForm(string formName)
        {
            return FormNavigator.forms.Find(item => item.Name == formName);
        }
    }
}
