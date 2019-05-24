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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
            ConsultasPelis ventana = new ConsultasPelis();
            ventana.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta_reservas ventana = new consulta_reservas();
            ventana.Visible = true;
        }
    }
}
