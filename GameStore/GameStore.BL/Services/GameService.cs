using GameStore.BL.Interfaces;
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

        public void Remove(int id)
        {
            _gameRepository.Remove(id);
        }

        public List<Game> GetAllGamesByGenreId(int genreId)
        {
            return _gameRepository.GetAllBooksByAuthorId(genreId);
        }

        public int TestCalculation(int number)
        {
            var books = _gameRepository.GetAll();
            return books.Count() + number;

        }
    }
}
