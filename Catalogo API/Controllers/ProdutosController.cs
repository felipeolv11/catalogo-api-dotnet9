using Catalogo_API.Context;
using Catalogo_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo_API.Controllers;

[Route("[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly CatalogoDbContext _context;

    public ProdutosController(CatalogoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get()
    {
        var produtos = _context.Produtos.ToList();

        if (produtos is null)
        {
            return NotFound();
        }

        return produtos;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Produto> Get(int id)
    {
        var produtos = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

        if (produtos is null)
        {
            return NotFound();
        }

        return produtos;
    }
}
