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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 ir = new Form1();
            ir.Show();
            this.Hide();
        }

        private void registroDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ir = new Form3();
            ir.Show();
            this.Hide();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ir = new Form4();
            ir.Show();
            this.Hide();
        }
    }
}
