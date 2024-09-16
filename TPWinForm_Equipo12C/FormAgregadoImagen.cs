using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo12C
{
    public partial class FormAgregadoImagen : Form
    {
        private Articulo articulo = null;
        public FormAgregadoImagen(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Agregar Imagen";
        }

        private void FormAgregadoImagen_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxCodArticulo2.Text = articulo.CodArticulo;
                textBoxNombre2.Text = articulo.Nombre;
                pictureBoxArticulo2.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

       

        private void cargarImagen(string imagenUrl)
        {
            try
            {
                pictureBoxArticulo2.Load(imagenUrl);
            }
            catch (Exception)
            {
                pictureBoxArticulo2.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUrlImagen2_Leave(object sender, EventArgs e)
        {
            try
            {

                cargarImagen(textBoxUrlImagen2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {

                if (articulo == null)
                {
                    articulo = new Articulo();
                }


                articulo.CodArticulo = textBoxCodArticulo2.Text;
                articulo.Nombre = textBoxNombre2.Text;
                articulo.ImagenUrl = textBoxUrlImagen2.Text;

                if (articulo.Id != 0)
                {
                    negocio.agregarImagen(articulo);
                    MessageBox.Show("Imagen del Articulo agregado en el inventario");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
