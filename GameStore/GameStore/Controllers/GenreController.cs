using GameStore.BL.Interfaces;
using GameStore.Models.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet("GetGenreById")]

        public Genre GetGenreById(int id)
        {
            return _genreService.GetById(id);
        }

        [HttpGet("GetAll")]

        public List<Genre> GetAllGenres()
        {
            return _genreService.GetAll();
        }

        [HttpPost]

        public void Add([FromBody] Genre genre)
        {
            _genreService.Add(genre);
        }

        [HttpDelete]

        public void Delete(int id)
        {
            _genreService.Remove(id);
        }

    }
}
