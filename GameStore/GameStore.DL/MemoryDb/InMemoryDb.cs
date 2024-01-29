using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Genre> GenreData = new List<Genre>()
        {
        new Genre()
        {
            Id = 1,
            Type = "Name 1",
            StartDate = DateTime.Now,
        },
        new Genre()
        {
            Id= 2,
            Type = "Name 2",
            StartDate = DateTime.Now,
        },
        new Genre()
        {
            Id = 3,
            Type = "Name 3",
            StartDate = DateTime.Now,
        }
        };

        public static List<Game> GameData = new List<Game>()
        {
        new Game()
        {
            Id = 1,
            Title = "Name 1",
            GenreId = 1,
            RelaseDate = new DateTime(2012, 03, 13)
        },
        new Game()
        {
            Id= 2,
            Title = "Name 2",
            GenreId = 2,
            RelaseDate = new DateTime(2019, 04, 18)
        },
        new Game()
        {
            Id = 3,
            Title = "Name 3",
            GenreId = 3,
            RelaseDate = new DateTime(2014, 05, 14)
        },
        new Game()
        {
            Id = 4,
            Title = "Name 4",
            GenreId = 1,
            RelaseDate = new DateTime(2021, 03, 13)
        },
        };
    }
}
