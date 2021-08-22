using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class AnimeService : BaseService<AnimeEntity>, IAnimeService
    {
        private readonly IRepositoryWrapper _repository;
        public AnimeService(IRepositoryWrapper repository, IBaseRepository<AnimeEntity> baseRepository):base(baseRepository)
        {
            _repository = repository;
        }

        public async Task<GenericResult<List<AnimeAllResponse>>> GetAllResponse()
        {
            var retorno = new GenericResult<List<AnimeAllResponse>>();
            try
            {
                var entities = await _repository.Anime.FindAll();

                var data = new List<AnimeAllResponse>();

                foreach (var entity in entities)
                {
                    data.Add(new AnimeAllResponse
                    {
                        Id = entity.Id,
                        ImgUrl = entity.ImgUrl,
                        Rating = entity.Rating,
                        Title = entity.Title
                    });
                }

                retorno.Data = data;
                retorno.Success = true;

                return retorno;
            }
            catch (System.Exception)
            {
                retorno.Success = false;
                retorno.Message = "deu ruim";

                return retorno;
            }

        }
    }
}
