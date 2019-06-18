using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioWiliam
{
    public partial class Form1 : Form
    {
        private string usuario;
        private string contrasena;
        public string msjcorrecto = "La contraseña es correcta", msjincorrecto ="la contraseña es incorrecta";

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            usuario = "Juan";
            contrasena = "1234";

            if(txusuario.Text==usuario && txcontrasena.Text == contrasena)
            {
                c msjcorrecto;
            }
        }
    }
}
