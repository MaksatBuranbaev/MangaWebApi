using MangaWebApi.Models.Enteties;
using Microsoft.EntityFrameworkCore;

namespace MangaWebApi.Data
{
    public class MangaDbContext: DbContext
    {
        public MangaDbContext(DbContextOptions<MangaDbContext> options): base(options) {}

        public DbSet<Manga> Mangas { get; set; }
    }
}
