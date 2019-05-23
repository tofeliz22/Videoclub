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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("INSERT INTO `usuario` (`DNI`, `Nombre`, `Apellido`, `password`, `email`)" +
                " VALUES ('" + textBox3.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '0', '" + textBox4.Text + "' ;", conexion
                );

            MySqlDataReader resultado = comando.ExecuteReader();

            MessageBox.Show("usuario guardado correctamente!");
                this.Visible = false;

           
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
