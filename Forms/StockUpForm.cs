using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;

namespace StockUp.Forms
{
    public class StockUpForm : MaterialForm
    {
        public StockUpForm() : base()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey400, Primary.Cyan900, Primary.DeepOrange900, Accent.Amber200, TextShade.WHITE);
        }
    }
}
