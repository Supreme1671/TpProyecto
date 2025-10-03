namespace RazorPages.Controller;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LibrosController : ControllerBase
{
    private readonly ILibroRepository _repo;
    public LibrosController(ILibroRepository repo) { _repo = repo; }

    [HttpGet]
    public IActionResult Get() => Ok(_repo.GetAll());

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var libro = _repo.GetById(id);
        if (libro == null) return NotFound();
        return Ok(libro);
    }
}
