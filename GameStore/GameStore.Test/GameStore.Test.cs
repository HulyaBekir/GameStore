using GameStore.BL.Services;
using GameStore.DL.Interfaces;
using GameStore.Models.Models.User;
using Moq;

namespace GameStore.Test
{
    public class GameTest
    {
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


        [Fact]
        public void GetAllByGenreId_Count_Check()
        {
            var expectedCount = 2;
            var genreId = 1;

            var mockedGameRepository = new Mock<IGameRepository>();
            mockedGameRepository.Setup(x => x.GetAllGamesByGenreId(genreId))
                .Returns(GameData.Where(b => b.GenreId == genreId).ToList());

            //injects
            var service = new GameService(mockedGameRepository.Object);

            //act
            var result = service.GetAllGamesByGenreId(genreId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void GetAllByGenreId_WrongId()
        {
            var expectedCount = 0;
            var genreId = 11;

            var mockedGameRepository = new Mock<IGameRepository>();
            mockedGameRepository.Setup(x => x.GetAllGamesByGenreId(genreId))
                .Returns(GameData.Where(b => b.GenreId == genreId).ToList());

            //injects
            var service = new GameService(mockedGameRepository.Object);

            //act
            var result = service.GetAllGamesByGenreId(genreId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void TestCalculation_Result_Check()
        {
            var expectedResult = 14;
            var testNumber = 10;

            var mockedGameRepository = new Mock<IGameRepository>();
            mockedGameRepository.Setup(x => x.GetAll())
                .Returns(GameData);

            //injects
            var service = new GameService(mockedGameRepository.Object);

            //act
            var result = service.TestCalculation(testNumber);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Remove_Count_Check()
        {
            var expectedResult = 3;
            var gameId = 1;
            var gameToRemove = GameData.FirstOrDefault(x => x.Id == gameId);

            var mockedGameRepository = new Mock<IGameRepository>();
            mockedGameRepository.Setup(x => x.Remove(gameId)).Callback(() =>
            {
                GameData.Remove(gameToRemove);
            });

            //injects
            var service = new GameService(mockedGameRepository.Object);

            //act
            service.Remove(gameId);

            //assert
            Assert.Equal(expectedResult, GameData.Count);
        }
    }
}