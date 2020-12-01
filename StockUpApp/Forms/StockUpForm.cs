using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using StockUpDAL;

namespace StockUp.Forms
{
    public class StockUpForm : MaterialForm
    {
        protected AppDbContext DbContext { get; private set; }
        public StockUpForm() : base()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        protected void InitDB(AppDbContext dbContext = null)
        {
            dbContext = dbContext ?? new AppDbContext();
            this.DbContext = dbContext;
        }
    }
}
