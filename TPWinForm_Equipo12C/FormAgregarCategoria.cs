using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_Equipo12C
{
    public partial class FormAgregarCategoria : Form
    {
        public FormAgregarCategoria()
        {
            InitializeComponent();
        }

        private void buttontAgregar_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria();
            nueva.Descripcion = textBoxCategoria.Text;
            CategoriaNegocio negocio = new CategoriaNegocio();
            negocio.agregarCategoria(nueva);
            MessageBox.Show("Categoria agregada correctamente");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
