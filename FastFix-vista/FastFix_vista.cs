using FastFix_Database;
using FastFix_Negocio_logica;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FastFix_vista
{
    public partial class FastFix_vista : MaterialForm
    {
        public FastFix_vista()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue700, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gmail_Click(object sender, EventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //string texto = textBox.Text;
            //if (texto == textBox.Text)
            //{
            //    textBox.Text = "";
            //    return;
            //}else
            //{
            //    textBox.Text = texto;
            //    return;
           // }
            
        }

        private void Gmail_Leave(object sender, EventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (Gmail.Text == string.Empty && Pass.Text == string.Empty || Gmail.Text.Equals("Gmail") || Pass.Text.Equals("Pass"))
            {
                MessageBox.Show("La casilla Gmail y Contraseña estab basios...");
                return;
            }
            else if (Gmail.Text == string.Empty || Gmail.Text.Equals("Gmail"))
            {
                MessageBox.Show("La casilla gmail esta basia...");
                return;
            }
            else if (Pass.Text == string.Empty || Pass.Text.Equals("Pass"))
            {
                MessageBox.Show("La Casilla pass Esta basia...");
                return;
            }
            else
            {
                MessageBox.Show("Todo en orden");
                Usuarios_Metodos usuarios = new Usuarios_Metodos();
                usuarios.comprovarExistencia(Gmail.Text, Pass.Text);
                return;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Usuarios_Metodos usuarios_Metodos = new Usuarios_Metodos();
            if (Pass2_Crear.Text != Pass_Crear.Text)
            {
                MessageBox.Show("Las Dos contraseñas no son iguales...");
                return;
            }

            
            usuarios_Metodos.CrearUsuarioNormal(Nombre_Crear.Text, Apellido_Crear.Text, Apellido2_Crear.Text, Gmail_Crear.Text, sexo.Text, Pass2_Crear.Text);
            MessageBox.Show("Usuario Creado!!!");
            return;
        }
    }
}
