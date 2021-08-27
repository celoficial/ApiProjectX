using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.Anime;
using ApiProjectX.Domain.Responses.Category;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class AnimeService : BaseService<AnimeEntity, AnimeRequest, AnimeResponse>, IAnimeService
    {
        private readonly IRepositoryWrapper _repository;
        public AnimeService(IRepositoryWrapper repository, IBaseRepository<AnimeEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }

        public async Task<GenericResult> GetAllResponse()
        {
            var entities = await _repository.Anime.testAnime();
           // var entities = await _repository.Anime.FindAll(new List<string> {"AnimeCategory" , "Category"});

            var entities2 = _mapper.Map<IEnumerable<AnimeEntity>, IEnumerable<AnimeAllResponse>>(entities);
            #region Fazendo mapper na mão
            //List < CategoryEntity > categoryList = new List<CategoryEntity>();
            //foreach (var item in entities)
            //{
            //    foreach (var item2 in item.AnimeCategory)
            //    {
            //        categoryList.Add(item2.Category);
            //    }
            //}
            //var x = _mapper.Map<IEnumerable<CategoryEntity>, IEnumerable<CategoryResponse>>(categoryList);
            //foreach (var item in entities2)
            //{
            //    item.Categories = x;
            //}
            #endregion
            return new GenericResult("deu certo", true, entities2);

        }
    }
}
