using GameStore.DL.Interfaces;
using GameStore.DL.MemoryDb;
using GameStore.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DL.Repositories
{
    public class GameRepository : IGameRepository
    {
        public List<Game> GetAll()
        {
            return InMemoryDb.GameData;
        }
        public Game GetById(int id)
        {
            return InMemoryDb.GameData.First(a => a.Id == id);
        }
        public void Add(Game game)
        {
            InMemoryDb.GameData.Add(game);
        }
        public void Update(Game game)
        {
            InMemoryDb.GameData.Sort((IComparer<Game>?)game);
        }
        public void Remove(int id)
        {
            var game = GetById(id);
            InMemoryDb.GameData.Remove(game);
        }

        public List<Game> GetAllGamesByGenresId(int id)
        {
            var result = InMemoryDb.GameData.Where(b => b.GenreId == id).ToList();
            return result;
        }

        
    }
}
