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
    public partial class SearchContact : Form
    {
        SqlConnection conexion = new SqlConnection("server = DESKTOP-G1UOUIO ; database = Contact_Book ; integrated security = true");

        public SearchContact()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //tablaDatos.Refresh();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM Contact WHERE nombre LIKE '%"+txtBuscar.Text+"%'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;            
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            tablaDatos.DataSource = tabla;
            conexion.Close();
        }

        private void SearchContact_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'contact_BookDataSet.Contact' Puede moverla o quitarla según sea necesario.            

        }

        private void tablaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(tablaDatos.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show(tablaDatos.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
