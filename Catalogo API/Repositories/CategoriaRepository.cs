using Catalogo_API.Context;
using Catalogo_API.Models;

namespace Catalogo_API.Repositories;

public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(CatalogoDbContext context) : base(context)
    {
    }
}
