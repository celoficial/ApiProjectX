using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Infra.Data.Repository
{
    public class AnimeRepository : BaseRepository<AnimeEntity>, IAnimeRepository
    {
        public AnimeRepository(ProjectXContext dbContext) : base(dbContext)
        {
            
        }

        public async Task<List<AnimeEntity>> testAnime()
        {
            return await _dbContext.Anime
                .Include(c => c.AnimeCategory)
                .ThenInclude(c => c.Category)
                .Include(c => c.AnimeAuthor)
                .ThenInclude(c => c.Author)
                .ToListAsync();
        }
    }

}
