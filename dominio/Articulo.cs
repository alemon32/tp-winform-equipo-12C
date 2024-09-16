using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo : Imagen
    {
        public int Id { get; set; }
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public int indiceImg { get; set; } // Atributo que utilizare para poder moverme entre las imagenes segun el indice/posicion
        public string ImgAux { get; set; }

        public Articulo() // Constructir para "obligar" a q cada Articulo al ser instanciado tenga por defecto el indice de Imagen en la primera posicion
        {
            indiceImg = 0;
        }
    }
}
