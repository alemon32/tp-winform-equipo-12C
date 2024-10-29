using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dominio2;
using negocio2;

namespace tp_winform_equipo_12C_2._0_
{
    public partial class SeleccionarPremio : System.Web.UI.Page
    {
        private PromocionNegocio promocionNegocio = new PromocionNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPremios();
            }
        }

        private void CargarPremios()
        {
            try
            {
                // Obtener lista de premios desde la BD
                List<Articulo> premios = promocionNegocio.ObtenerPremiosDisponibles();

                // Limpiar el DropDownList antes de llenarlo
                DropDownListPremios.Items.Clear();

                foreach (var premio in premios)
                {
                    // Agregar un nuevo ListItem por cada premio
                    ListItem item = new ListItem
                    {
                        Text = premio.Nombre, 
                        Value = premio.Id.ToString() 
                    };
                    DropDownListPremios.Items.Add(item);
                }

                // opcion por defecto
                DropDownListPremios.Items.Insert(0, new ListItem("Selecciona una premio", ""));
            }
            catch (Exception ex)
            {
                LabelMensaje.Text = "Error al cargar los premios: " + ex.Message;
            }
        }

        protected void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar que el cliente hata seleccionado un premio
            if (string.IsNullOrEmpty(DropDownListPremios.SelectedValue))
            {
                LabelMensaje.Text = "Por favor, selecciona un premio";
                return;
            }

            // Obtener el ID del premio seleccionado
            int premioId = int.Parse(DropDownListPremios.SelectedValue);

            // Guardar la seleccion del cliente en una sesion para usarla luego
            Session["PremioSeleccionado"] = premioId;

            // Ir a la siguiente pagina
            Response.Redirect("RegistroCliente.aspx");
        }

        protected void DropDownListPremios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            int idPremioSeleccionado = int.Parse(DropDownListPremios.SelectedValue);
            var imagenes = promocionNegocio.ObtenerImagenesPorArticulo(idPremioSeleccionado);

            // Limpiar el panel de imágenes
            PanelImagenes.Controls.Clear();

            foreach (var imagenUrl in imagenes)
            {
                Image imagen = new Image
                {
                    ImageUrl = imagenUrl,
                    CssClass = "img-thumbnail col-md-4", 
                    Width = Unit.Pixel(200), 
                    Height = Unit.Pixel(200)
                };
                PanelImagenes.Controls.Add(imagen);
            }
        }
    }
}