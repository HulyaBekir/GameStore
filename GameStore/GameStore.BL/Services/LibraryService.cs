using GameStore.BL.Interfaces;
using GameStore.Models.Models.Request;
using GameStore.Models.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IGenreService _genreService;
        private readonly IGameService _gameService;

        public LibraryService(IGenreService genreService, IGameService gameService)
        {
            _genreService = genreService;
            _gameService = gameService;
        }

        public GetGamesByGenreResponse? GetGamesByGenre(GetGamesByGenreRequest request)
        {
            var games = _gameService.GetAllGamesByGenreId(request.GenreId);

            if (games != null && games.Count > 0)
            {
                var response = new GetGamesByGenreResponse
                {
                    Genre = _genreService.GetById(request.GenreId),
                    Games = games.Where(b => b.RelaseDate >= request.AfterDate).ToList()
                };
                return response;
            }

            return null;
        }

        

        
    };
}

