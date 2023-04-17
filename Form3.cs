using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Robotica
{
    public partial class Form3 : Form
    {
        private SqlConnection cnn;
        private SqlDataReader Leer;

        public void LeerBD()
        {
            string CadenaConcexion = @"Server=LAPTOP-BAG1AMM3;Database=Registro Club Robotica;Trusted_Connection=True"; ;
            cnn = new SqlConnection(CadenaConcexion);
            cnn.Open();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 ir = new Form2();
            ir.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LeerBD();
            string Agregar = "INSERT INTO Datos De Alumnos VALUES (@Id, @Nombre, @Grado, @Sección)";
            SqlCommand Comando1 = new SqlCommand(Agregar, cnn);
            Comando1.Parameters.AddWithValue("@Id", txtId.Text);
            Comando1.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            Comando1.Parameters.AddWithValue("@Grado", txtGrado.Text);
            Comando1.Parameters.AddWithValue("@Sección", txtSección.Text);
            Comando1.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado...");
            cnn.Close();
            txtId.Text = "";
            txtNombre.Text = "";
            txtGrado.Text = "";
            txtSección.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LeerBD();
            string Buscar = "SELECT Id,Nombre FROM Datos De Alumnos WHERE Id LIKE @xx";
            SqlCommand Comando2 = new SqlCommand(Buscar, cnn);
            Comando2.Parameters.AddWithValue("@xx", txtId.Text);
            Leer = Comando2.ExecuteReader();
            while (Leer.Read())
            {
                txtNombre.Text = Convert.ToString(Leer["Nombre"]);
            }
            Leer.Close();
            cnn.Close ();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LeerBD ();
            string Actualizar;
            Actualizar = "UPDATE Datos De Alumnos SET Nombre= @Nombre WHERE Id LIKE @xx";
            SqlCommand Comando3 = new SqlCommand(Actualizar, cnn);
            Comando3.Parameters.AddWithValue("@xx", txtId.Text);
            Comando3.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            Comando3.ExecuteNonQuery();
            MessageBox.Show("Registro actualizado...");
            cnn.Close ();
            txtId.Text = "";
            txtNombre.Text = "";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LeerBD();
            string Borrar = "DELETE FROM Datos De Alumnos WHERE Id LIKE @xx";
            SqlCommand Comando4 = new SqlCommand(Borrar, cnn);
            Comando4.Parameters.AddWithValue("@xx", txtId.Text);
            Comando4.ExecuteNonQuery();
            cnn.Close();
            txtId.Text = "";
            txtNombre.Text = "";
        }
    }
}
