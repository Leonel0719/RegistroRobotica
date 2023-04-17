using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Robotica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            if(Usuario == "Admin Robotica" && Contraseña == "Robotica2023")
            {
                this.DialogResult= DialogResult.OK;

                MessageBox.Show("Acceso concedido, Bienvenido/a");

                Form2 ir = new Form2();
                ir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado, Usuario o contraseña incorrecta,Intente nuevamente");

                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}
