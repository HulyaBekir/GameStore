using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DL.Interfaces
{
    public interface IGameRepository
    {
        List<Game> GetAll();

        Game GetById(int id);

        void Add(Game game);

        void Remove(int id);
        List<Game> GetAllGamesByGenreId(int genreId);
    }
}
