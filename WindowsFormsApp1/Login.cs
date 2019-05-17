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
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM usuarios WHERE " +
                "  usuario = '" + textBox1.Text +
                "' AND pass = '" + textBox2.Text +
                "' ;", conexion
                );

            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.Read())
            {
                MessageBox.Show("Acceso Correcto", "USUARIO OK");
                this.Visible = false;
                PaginaPrincipal ventana = new PaginaPrincipal();
                ventana.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto(s)", "ERROR");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }   
}
