using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPages.Pages;

public class LibroDetalle : PageModel
{
    private readonly ILogger<LibroDetalle> _logger;

    public LibroDetalle(ILogger<LibroDetalle> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
