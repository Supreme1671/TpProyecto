using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPages.Pages;

public class Libros : PageModel
{
    private readonly ILogger<Libros> _logger;

    public Libros(ILogger<Libros> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
