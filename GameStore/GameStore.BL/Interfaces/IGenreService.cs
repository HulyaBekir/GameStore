using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL.Interfaces
{
    public interface IGenreService
    {
        List<Genre> GetAll();

        Genre GetById(int id);

        void Add(Genre author);

        void Remove(int id);
    }
}
