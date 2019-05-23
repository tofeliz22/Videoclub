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
    public partial class ConsultasPelis : Form
    {
        private DataTable datos = new DataTable();
        String lector;



        
        public ConsultasPelis()
        {
            InitializeComponent();
            textoDesplegable();
            rellenaUsuarios();
        }

        private void rellenaUsuarios()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("select usuario.DNI " +
                "from usuario", conexion);

            MySqlDataReader resultados = comando.ExecuteReader();
            while (resultados.Read())
            {
                string DNI = resultados.GetString("DNI");
                comboBox1.Items.Add(DNI);
            }

        }

        private void textoDesplegable()
        {
            desplegable.Items.Add("año");
            desplegable.Items.Add("autor");
            desplegable.Items.Add("genero");
            desplegable.Items.Add("titulo");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            listaDatos.DataSource = null;
            listaDatos.Rows.Clear();



            if (desplegable.Text == "año")
            {
                lector = buscador.Text;

                MySqlConnection conexion = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand("select movies.id, movies.name, movies.year, movies.rank " +
                    "from movies " +
                    "where movies.year = " + lector, conexion);

                MySqlDataReader resultados = comando.ExecuteReader();

                datos.Clear();
                datos.Load(resultados);
                listaDatos.DataSource = datos;

                conexion.Close();
            }
            if (desplegable.Text == "autor")
            {
                lector = buscador.Text;

                MySqlConnection conexion = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand("select movie.id, directors.id, directors.first_name, directors.last_name, movies.name as 'pelicula', movies.year " +
                    "from directors, movies, movies_directors " +
                    "where directors.first_name like  '%" + lector +
                    " %' or directors.last_name like '%" + lector + "%' and directors.id = movies_directors.director_id" +
                    " and movies_directors.movie_id = movies.id"

                    , conexion);

                MySqlDataReader resultados = comando.ExecuteReader();

                datos.Clear();
                datos.Load(resultados);
                listaDatos.DataSource = datos;

                conexion.Close();
            }
            if (desplegable.Text == "genero")
            {
                lector = buscador.Text;

                MySqlConnection conexion = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand("select movie.id, movies.name, movies.year " +
                    "from movies " +
                    "where movies.year =  " + lector, conexion);

                MySqlDataReader resultados = comando.ExecuteReader();

                datos.Clear();
                datos.Load(resultados);
                listaDatos.DataSource = datos;

                conexion.Close();
            }
            if (desplegable.Text == "titulo")
            {
                lector = buscador.Text;

                MySqlConnection conexion = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand("select movie.id, movies.name, " +
                    "from movies " +
                    "where movies.name like '% " + lector + "%' and movies.year != '0' "
                    , conexion);

                MySqlDataReader resultados = comando.ExecuteReader();

                datos.Clear();
                datos.Load(resultados);
                listaDatos.DataSource = datos;

                conexion.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoCliente ventana = new NuevoCliente();
            ventana.Visible = true;
        }

        


        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("INSERT INTO `prestamos` (`usuario`, `id_movie`, `titulo`, `fecha`) " +
                "VALUES ('"+ comboBox1.Text +"', '"+ textBox2.Text +"', 'select movies.name from movies where movies.id = " + textBox2 +")', '2019-05-23');", conexion
                );

            MySqlDataReader resultado = comando.ExecuteReader();

            MessageBox.Show("reserva registrada correctamente!");
            


            
            textBox2.Clear();
        }


    }
}

        

