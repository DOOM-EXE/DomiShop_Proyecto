using DomiShop.Domain.Core;

namespace DomiShop.Domain.Entities
{
    public class Productos : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
