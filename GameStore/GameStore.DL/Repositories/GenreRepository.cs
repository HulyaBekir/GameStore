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
    public class GenreRepository : IGenreRepository
    {
        public List<Genre> GetAll()
        {
            return InMemoryDb.GenreData;
        }
        public Genre GetById(int id)
        {
            return InMemoryDb.GenreData.First(a => a.Id == id);
        }
        public void Add(Genre genre)
        {
            InMemoryDb.GenreData.Add(genre);
        }
        public void Remove(int id)
        {
            var genre = GetById(id);
            InMemoryDb.GenreData.Remove(genre);
        }

      
    }
}
