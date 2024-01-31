using GameStore.BL.Interfaces;
using GameStore.DL.Interfaces;
using GameStore.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void Add(Game game)
        {
            _gameRepository.Add(game);
        }

        public List<Game> GetAll()
        {
            return _gameRepository.GetAll();
        }

        public Game GetById(int id)
        {
            return _gameRepository.GetById(id);
        }
        public void Update(Game game)
        {
            _gameRepository.Update(game);
        }
        public void Remove(int id)
        {
            _gameRepository.Remove(id);
        }

        public List<Game> GetAllGamesByGenreId(int genreId)
        {
            return _gameRepository.GetAllGamesByGenreId(genreId);
        }

        public int TestCalculation(int number)
        {
            var games = _gameRepository.GetAll();
            return games.Count() + number;

        }

       
    }
}
