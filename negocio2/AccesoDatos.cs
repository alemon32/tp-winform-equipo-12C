using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using dominio2;

namespace negocio2
{
    public class AccesoDatos
    {
        private string _conexionString;

        public AccesoDatos()
        {
            _conexionString = "Server=.\\SQLEXPRESS; Database=PROMOS_DB; Integrated Security=True;";
        }

        // verificar si un codigo de voucher existe y no se uso
        public bool ExisteCodigoVoucher(string codigo)
        {
            SqlConnection conexion = new SqlConnection(_conexionString);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM Vouchers WHERE CodigoVoucher = @Codigo AND IdCliente IS NULL", conexion);
            comando.Parameters.AddWithValue("@Codigo", codigo);
            int cantidad = (int)comando.ExecuteScalar();
            return cantidad > 0;
        }

        // Lista de articulos disponibles para los premios
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            SqlConnection conexion = new SqlConnection(_conexionString);

            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT Id, Nombre, Descripcion, Precio FROM ARTICULOS", conexion);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                articulos.Add(new Articulo
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Descripcion = lector.GetString(2),
                    Precio = lector.GetDecimal(3)
                });
            }

            return articulos;
        }

        // Dar de alta a un cliente en la DB
        public int AltaCliente(Cliente cliente)
        {
            SqlConnection conexion = new SqlConnection(_conexionString);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO Clientes(Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " + "OUTPUT INSERTED.Id VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)", conexion);

            comando.Parameters.AddWithValue("@Documento", cliente.Documento);
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
            comando.Parameters.AddWithValue("@CP", cliente.CP);

            return (int)comando.ExecuteScalar(); // Id generado
        }

        internal int EjecutarComando(SqlCommand comando)
        {
            SqlConnection conexion = new SqlConnection(_conexionString);

            comando.Connection = conexion;
            conexion.Open();
            return comando.ExecuteNonQuery(); // Devuelve el número de filas afectadas
        }

        // Actualizar voucher para el cliente
        public void ActualizarVoucher(string cod, int idCliente, int idArticulo)
        {
            SqlConnection conexion = new SqlConnection(_conexionString);
            conexion.Open();

            SqlCommand comando = new SqlCommand("UPDATE Vouchers SET IdCliente = @IdCliente, FechaCanje = GETDATE(), IdArticulo = @IdArticulo WHERE CodigoVoucher = @Codigo", conexion);

            comando.Parameters.AddWithValue("@Codigo", cod);
            comando.Parameters.AddWithValue("@IdCliente", idCliente);
            comando.Parameters.AddWithValue("@IdArticulo", idArticulo);
        }

        // Obtener imagenes del articulo
        public List<string> ObtenerImagenesArticulo(int idArticulo)
        {
            List<string> imagenes = new List<string>();

            SqlConnection conexion = new SqlConnection(_conexionString);
            conexion.Open();

            SqlCommand comando = new SqlCommand("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo", conexion);
            comando.Parameters.AddWithValue("@IdArticulo", idArticulo);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                imagenes.Add(lector["ImagenUrl"].ToString());
            }

            return imagenes;
        }
    }
}
