using GameStore.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL.Interfaces
{
    public interface IGameService
    {
        List<Game> GetAll();

        Game GetById(int id);

        void Add(Game book);

        void Remove(int id);
        List<Game> GetAllGamesByGenreId(int genreId);
    }
}
