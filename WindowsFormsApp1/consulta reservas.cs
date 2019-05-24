using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class consulta_reservas : Form
    {
        private DataTable datos = new DataTable();
        public consulta_reservas()
        {
            InitializeComponent();
            rellenatabla();
        }

        private void rellenatabla()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("select * from prestamos", conexion);

            MySqlDataReader resultados = comando.ExecuteReader();

           
            datos.Load(resultados);
            dataGridView1.DataSource = datos;
            conexion.Close();
        }

        
    }

}
