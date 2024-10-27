using DomiShop.Domain.Entities;
using DomiShop.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ProductoController : ControllerBase
{
    private readonly DomiShopContext _context;

    public ProductoController(DomiShopContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
    {
        return await _context.Productos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Producto>> GetProducto(int id)
    {
        var producto = await _context.Productos.FindAsync(id);
        if (producto == null)
            return NotFound();

        return producto;
    }

    [HttpPost]
    public async Task<ActionResult<Producto>> PostProducto(Producto producto)
    {
        _context.Productos.Add(producto);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProducto), new { id = producto.ID_PRODUCTO }, producto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutProducto(int id, Producto producto)
    {
        if (id != producto.ID_PRODUCTO)
            return BadRequest();

        _context.Entry(producto).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProducto(int id)
    {
        var producto = await _context.Productos.FindAsync(id);
        if (producto == null)
            return NotFound();

        _context.Productos.Remove(producto);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
