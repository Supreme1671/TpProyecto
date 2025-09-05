using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPages.Pages;

public class libros : PageModel
{
    private readonly ILogger<libros> _logger;

    public libros(ILogger<libros> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
