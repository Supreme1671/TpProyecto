using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using System.Text.Json;

namespace RazorPages.Pages
{
    public class CarritoModel : PageModel
    {
        public List<CarritoItem> Items { get; set; } = new();
        public decimal Total => Items.Sum(i => i.Precio * i.Cantidad);

        public void OnGet()
        {
            var data = HttpContext.Session.GetString("carrito");
            if (data != null)
                Items = JsonSerializer.Deserialize<List<CarritoItem>>(data) ?? new();
        }
    }
}
