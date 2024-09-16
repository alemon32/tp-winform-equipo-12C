using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TPWinForm_Equipo12C
{
    public partial class FormAgregarMarca : Form
    {
        public FormAgregarMarca()
        {
            InitializeComponent();
        }

        private void buttontAceptar_Click(object sender, EventArgs e)
        {
            Marca nueva = new Marca();
            nueva.Descripcion = textBoxMarca.Text;
            MarcaNegocio negocio = new MarcaNegocio();
            negocio.agregarMarca(nueva);
            MessageBox.Show("Marca agregada correctamente");

            Close();
        }

        private void buttontSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
