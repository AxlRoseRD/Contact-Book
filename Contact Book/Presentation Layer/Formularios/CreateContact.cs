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

namespace Presentation_Layer.Formularios
{    
    public partial class CreateContact : Form
    {
        //atributos
        List<String> placeHolders = new List<string>()
        {
         "Nombre","Apellido","Fecha de nacimiento","Direccion","Genero","Estado Civil","Movil","Telefono","Correo electrionico"
        };
        SqlConnection conexion = new SqlConnection("server = DESKTOP-G1UOUIO ; database = Contact_Book ; integrated security = true");
        private string[] combo = new string[]{"Casado","Divorciado","Soltero","Viudo"};

        public CreateContact()
        {
            InitializeComponent();
        }

        private void CreateContact_Load(object sender, EventArgs e)
        {
            txtbNombre.Text = placeHolders[0];
            txtbNombre.ForeColor = Color.Gray;

            txtbApellido.Text = placeHolders[1];
            txtbApellido.ForeColor = Color.Gray;

            txtbBirthDate.Text = placeHolders[2];
            txtbBirthDate.ForeColor = Color.Gray;

            txtbDireccion.Text = placeHolders[3];
            txtbDireccion.ForeColor = Color.Gray;

            txtbGenero.Text = placeHolders[4];
            txtbGenero.ForeColor = Color.Gray;

            txtbMovil.Text = placeHolders[6];
            txtbMovil.ForeColor = Color.Gray;

            txtbTelefono.Text = placeHolders[7];
            txtbTelefono.ForeColor = Color.Gray;

            txtbEmail.Text = placeHolders[8];
            txtbEmail.ForeColor = Color.Gray;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtbNombre.Text = "";
            txtbNombre.ForeColor = Color.Black;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            string sentence = "INSERT INTO Contact (nombre,apellido,fecha_de_nacimiento,direccion,genero,estado_civil,movil,telefono,correo_electronico)"
                + " VALUES (@nombre,@apellido,@fecha_de_nacimiento,@direccion,@genero,@estado_civil,@movil,@telefono,@correo_electronico)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentence, conexion);
            comando.Parameters.AddWithValue("@nombre",txtbNombre.Text);
            comando.Parameters.AddWithValue("@apellido",txtbApellido.Text);
            comando.Parameters.AddWithValue("@fecha_de_nacimiento",txtbBirthDate.Text);
            comando.Parameters.AddWithValue("@direccion",txtbDireccion.Text);
            comando.Parameters.AddWithValue("@genero",txtbGenero.Text);
            if(comboBoxEstadoCiivl.SelectedIndex >= 0)
            comando.Parameters.AddWithValue("@estado_civil",combo[comboBoxEstadoCiivl.SelectedIndex]);
            else
            comando.Parameters.AddWithValue("@estado_civil","");
            comando.Parameters.AddWithValue("@movil",txtbMovil.Text);
            comando.Parameters.AddWithValue("@telefono",txtbTelefono.Text);
            comando.Parameters.AddWithValue("@correo_electronico",txtbEmail.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Insertado!!");
        }

        private void txtbApellido_Enter(object sender, EventArgs e)
        {
            txtbApellido.Text = "";
            txtbApellido.ForeColor = Color.Black;
        }

        private void txtbMovil_Enter(object sender, EventArgs e)
        {
            txtbMovil.Text = "";
            txtbMovil.ForeColor = Color.Black;
        }

        private void txtbTelefono_Enter(object sender, EventArgs e)
        {
            txtbTelefono.Text = "";
            txtbTelefono.ForeColor = Color.Black;
        }

        private void txtbEmail_Enter(object sender, EventArgs e)
        {
            txtbEmail.Text = "";
            txtbEmail.ForeColor = Color.Black;
        }

        private void txtbDireccion_Enter(object sender, EventArgs e)
        {
            txtbDireccion.Text = "";
            txtbDireccion.ForeColor = Color.Black;
        }

        private void txtbBirthDate_Enter(object sender, EventArgs e)
        {
            txtbBirthDate.Text = "";
            txtbBirthDate.ForeColor = Color.Black;
        }

        private void txtbGenero_Enter(object sender, EventArgs e)
        {
            txtbGenero.Text = "";
            txtbGenero.ForeColor = Color.Black;
        }
    }
}
