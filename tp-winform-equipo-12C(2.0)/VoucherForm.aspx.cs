using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio2;

namespace tp_winform_equipo_12C_2._0_
{
    public partial class VoucherForm : System.Web.UI.Page
    {
        private PromocionNegocio promocionNegocio = new PromocionNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMensaje.Text = ""; // Limpiamos el mensaje al actualizar la pagina

        }

        protected void ButtonValidarCodigo_Click(object sender, EventArgs e)
        {
            // Obtener el codigo ingresado por el cliente
            string codigoVoucher = TextBoxCodigoVoucher.Text.Trim(); // uso .Trim para borrar los espacio ingresados

            // Verificar si el campo esta vacio
            if (string.IsNullOrEmpty(codigoVoucher))
            {
                LabelMensaje.Text = "Por favor, ingrese un codigo de voucher";
                return;
            }

            try
            {
                // Calidar el código
                bool esValido = promocionNegocio.ValidarCodigoVoucher(codigoVoucher);

                if (esValido)
                {
                    // Si el voucher es valido vamos a la pagina para seleccionar de premios
                    Response.Redirect("SeleccionarPremio.aspx?codigoVoucher=" + codigoVoucher);
                }
                else
                {
                    // Si no es valido, muestra msj de error
                    LabelMensaje.Text = "El codigo es incorrecto o ya ha sido utilizado";
                }
            }
            catch (Exception ex)
            {
                LabelMensaje.Text = "Ocurrió un error al validar el código. Por favor, inténtelo nuevamente.";
                throw ex;
            }
        }
    }
}