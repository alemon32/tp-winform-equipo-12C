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
    public partial class FormInicio : Form
    {
        private List<Articulo> listaArticulo;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            comboBoxCampo.Items.Add("Codigo Articulo");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Categoria");
            comboBoxCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dataGridViewArticuloBD.DataSource = listaArticulo;
                ocultarColumnas();
                //cargarImagen(listaArticulo[0].ImagenUrl);
                List<string> imagenes = new List<string>();
                imagenes = negocio.vectorImagenes(listaArticulo[0].Id);
                cargarImagen(imagenes[listaArticulo[0].indiceImg]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dataGridViewArticuloBD.Columns["ImagenUrl"].Visible = false;
            dataGridViewArticuloBD.Columns["Id"].Visible = false;
            dataGridViewArticuloBD.Columns["idArticulo"].Visible = false;
            dataGridViewArticuloBD.Columns["indiceImg"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArticulo.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
        }

        private void dataGridViewArticuloBD_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewArticuloBD.CurrentRow != null)
            {
                Articulo selecionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                List<string> lista = new List<string>();
                lista = negocio.vectorImagenes(selecionado.Id);
                try
                {
                    cargarImagen(lista[selecionado.indiceImg]);
                }
                catch (Exception ex)
                {
                    cargarImagen("https://www.google.com/url?sa=i&url=https%3A%2F%2Fes.vecteezy.com%2Farte-vectorial%2F4141669-sin-foto-o-imagen-en-blanco-icono-cargando-imagenes-o-imagen-faltante-marca-imagen-no-disponible-o-imagen-proxima-firmar-simple-naturaleza-silueta-en-marco-ilustracion-vectorial-aislada&psig=AOvVaw1ZXUe6w0_LG2hEINy0rxN0&ust=1714442133108000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCJiq3eeo5oUDFQAAAAAdAAAAABAE");
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAltaBajaModificacion form2 = new FormAltaBajaModificacion();
            form2.ShowDialog();
            cargar();
        }

        private void buttonModificiar_Click(object sender, EventArgs e)
        {
            Articulo selecionado;
            selecionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;

            FormAltaBajaModificacion modificar = new FormAltaBajaModificacion(selecionado);
            modificar.ShowDialog();
            cargar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro de elimnar el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Articulo eliminado del inventario");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione los campos para filtrar");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione los campos para filtrar");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxFiltro.Text))
                {
                    MessageBox.Show("Indicar el numero en el campo filtro");
                    return true;
                }
                if (!(soloNumeros(textBoxFiltro.Text)))
                {
                    MessageBox.Show("Por favor ingresar solo numeros al filtrar por un campo numerico");
                    return true;
                }
            }

            return false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;
                dataGridViewArticuloBD.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxCampo.Items.Clear();
            comboBoxCriterio.Items.Clear();
            textBoxFiltro.Clear();

            cargar();
            comboBoxCampo.Items.Add("Codigo Articulo");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Categoria");
            comboBoxCampo.Items.Add("Precio");

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            Articulo selecionado;
            selecionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;

            FormAgregadoImagen form2 = new FormAgregadoImagen(selecionado);
            form2.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            seleccionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;
            List<string> lista = new List<string>();
            lista = negocio.vectorImagenes(seleccionado.Id);
            int maximo = lista.Count;

            if (seleccionado.indiceImg < maximo - 1)
            { 
                seleccionado.indiceImg++;
                cargarImagen(lista[seleccionado.indiceImg]); 
            }
            else if (seleccionado.indiceImg == maximo - 1)
            {
                seleccionado.indiceImg = maximo - 1;
                cargarImagen(lista[seleccionado.indiceImg]);
            }

            // Al principio este evento si "segui" haciendo clic volvia a la primera imagen (como que daba una "vuelta) - SOLUCINADO
            // Pero no logro comprender o ver porque motivo tengo que hacer 2 clic para avanzar por primera vez

        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            seleccionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;
            List<string> lista = new List<string>();
            lista = negocio.vectorImagenes(seleccionado.Id);
            int maximo = lista.Count;

            if (seleccionado.indiceImg == 0)
                seleccionado.indiceImg = 0;
            else
                seleccionado.indiceImg--;

            cargarImagen(lista[seleccionado.indiceImg]);
        }
    }
}
