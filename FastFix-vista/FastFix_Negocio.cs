using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFix_vista
{
    public partial class FastFix_Negocio : MaterialForm

    {
        public FastFix_Negocio()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue700, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FastFix_Negocio_Load(object sender, EventArgs e)
        {

        }
    }
}
