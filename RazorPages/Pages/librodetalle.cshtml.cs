using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPages.Pages;

public class librodetalle : PageModel
{
    private readonly ILogger<librodetalle> _logger;

    public librodetalle(ILogger<librodetalle> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
