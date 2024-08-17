using API_CATALOGO_PRODUTOS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CATALOGO_PRODUTOS.Contex
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base( options )
        {
                
        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }

    }
}


