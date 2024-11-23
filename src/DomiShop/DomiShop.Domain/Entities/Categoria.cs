using DomiShop.Domain.Core;

namespace DomiShop.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
