using System.ComponentModel.DataAnnotations;

namespace DomiShop.Domain.Entities
{
    public class Producto
    {
        public Producto()
        {
        }

        [Key]
        public int ID_PRODUCTO { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
