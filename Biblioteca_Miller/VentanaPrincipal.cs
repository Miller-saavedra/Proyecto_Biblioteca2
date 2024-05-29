using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca_Miller
{
    public partial class VentanaPrincipal : Form
    {
        ConexionBibliotecaN conexionBibliotecaN = new ConexionBibliotecaN();

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btn_buscar1_Click(object sender, EventArgs e)
        {
            string autor = txt_autor.Text.Trim();
            string nombreLibro = txt_nombrelibro.Text.Trim();

            DataTable resultados = conexionBibliotecaN.BuscarLibros(autor, nombreLibro);

            if (resultados.Rows.Count > 0)
            {
                txt_resultadonombre.Text = resultados.Rows[0]["n_libro"].ToString();
                txt_resultadoautor.Text = resultados.Rows[0]["n_autor"].ToString();
                txt_resultadoubicacion.Text = resultados.Rows[0]["ubicacion"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron resultados.");
                txt_resultadonombre.Clear();
                txt_resultadoautor.Clear();
                txt_resultadoubicacion.Clear();
            }
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            txt_autor.Clear();
            txt_nombrelibro.Clear();
            txt_resultadonombre.Clear();
            txt_resultadoautor.Clear();
            txt_resultadoubicacion.Clear();
        }
    }    
}

