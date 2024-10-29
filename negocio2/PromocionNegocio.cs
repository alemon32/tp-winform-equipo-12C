using dominio2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio2
{
    public class PromocionNegocio
    {
        private AccesoDatos _accesoDatos;

        public PromocionNegocio()
        {
            _accesoDatos = new AccesoDatos();
        }

        // Validar voucher
        public bool ValidarCodigoVoucher(string codigo)
        {
            return _accesoDatos.ExisteCodigoVoucher(codigo);
        }

        // Obtener premios disponibles
        public List<Articulo> ObtenerPremiosDisponibles()
        {
            List<Articulo> articulos = _accesoDatos.ListarArticulos();

            // Por cada artículo, cargar las imágenes asociadas
            foreach (var articulo in articulos)
            {
                articulo.Imagenes = _accesoDatos.ObtenerImagenesArticulo(articulo.Id);
            }

            return articulos;
        }

        // Registrar un cliente y asignarle el voucher
        public void ParticiparEnPromocion(Cliente cliente, string codigoVoucher, int idArticulo)
        {
            int idCliente = _accesoDatos.AltaCliente(cliente);
            _accesoDatos.ActualizarVoucher(codigoVoucher, idCliente, idArticulo);
        }

        public List<string> ObtenerImagenesPorArticulo(int idArticulo)
        {
            return _accesoDatos.ObtenerImagenesArticulo(idArticulo);
        }

        public bool RegistrarCliente(Cliente cliente)
        {
            string consultaSQL = "INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " + "VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)";

            // Usar el acceso a datos para ejecutar la consulta
            SqlCommand comando = new SqlCommand(consultaSQL);
            comando.Parameters.AddWithValue("@Documento", cliente.Documento);
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
            comando.Parameters.AddWithValue("@CP", cliente.CP);

            // Ejecutar el comando y verificar si se registró con éxito
            return _accesoDatos.EjecutarComando(comando) > 0;
        }
    }
}
