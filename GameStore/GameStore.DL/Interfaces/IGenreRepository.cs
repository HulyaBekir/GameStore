using GameStore.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DL.Interfaces
{
    public interface IGenreRepository
    {
        List<Genre> GetAll();

        Genre GetById(int id);

        void Add(Genre genre);

        void Remove(int id);

        void Update(Genre genre);
    }
}
