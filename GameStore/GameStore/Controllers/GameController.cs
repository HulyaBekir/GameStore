using GameStore.BL.Interfaces;
using GameStore.Models.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("GetGameById")]

        public Game GetGameById(int id) 
        {
            return _gameService.GetById(id);
        }

        [HttpGet("GetAll")]

        public List<Game> GetAllGames() 
        {
            return _gameService.GetAll();
        }

        [HttpPost("Add")]

        public void Add([FromBody] Game game) 
        {
            if (game == null) return;
            _gameService.Add(game);
        }

        [HttpPut("Update")]

        public void Update([FromBody] Game game) 
        {
            if (game == null) return;

            _gameService.Update(game);
        }

        [HttpDelete]

        public void Delete(int id)
        {
            _gameService.Remove(id);
        }
    }
}
