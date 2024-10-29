using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio2;
using dominio2;

namespace tp_winform_equipo_12C_2._0_
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        private PromocionNegocio _promocionNegocio = new PromocionNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(TextBoxDocumento.Text) ||
                string.IsNullOrEmpty(TextBoxNombre.Text) ||
                string.IsNullOrEmpty(TextBoxApellido.Text) ||
                string.IsNullOrEmpty(TextBoxEmail.Text) ||
                string.IsNullOrEmpty(TextBoxDireccion.Text) ||
                string.IsNullOrEmpty(TextBoxCiudad.Text) ||
                string.IsNullOrEmpty(TextBoxCP.Text))
            {
                LabelMensaje.Text = "Por favor, complete todos los campos.";
                return;
            }

            var cliente = new Cliente
            {
                Documento = TextBoxDocumento.Text.Trim(),
                Nombre = TextBoxNombre.Text.Trim(),
                Apellido = TextBoxApellido.Text.Trim(),
                Email = TextBoxEmail.Text.Trim(),
                Direccion = TextBoxDireccion.Text.Trim(),
                Ciudad = TextBoxCiudad.Text.Trim(),
                CP = int.Parse(TextBoxCP.Text.Trim())
            };

            // Registrar el cliente
            bool registroExitoso = _promocionNegocio.RegistrarCliente(cliente);


            if (registroExitoso)
            {
                LabelMensaje.Text = "Registro exitoso. ¡Gracias por participar!";
            }
            else
            {
                LabelMensaje.Text = "Error al registrar el cliente. Por favor, intente nuevamente.";
            }
        }
    }
}