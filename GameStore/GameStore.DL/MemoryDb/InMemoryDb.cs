using GameStore.Models.Models.User;
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
            Name = "Name 1",
            
        },
        new Genre()
        {
            Id= 2,
            Name = "Name 2",
            
        },
        new Genre()
        {
            Id = 3,
            Name = "Name 3",
           
        }
        };

        public static List<Game> GameData = new List<Game>()
        {
        new Game()
        {
            Id = 1,
            Title = "Name 1",
            GenreId = 1,
            RelaseDate = new DateTime(2011, 11, 10)
        },
        new Game()
        {
            Id= 2,
            Title = "Name 2",
            GenreId = 2,
            RelaseDate = new DateTime(2012, 06, 11)
        },
        new Game()
        {
            Id = 3,
            Title = "Name 3",
            GenreId = 3,
            RelaseDate = new DateTime(2014, 25, 10)
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
