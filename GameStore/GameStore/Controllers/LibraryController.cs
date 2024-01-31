using GameStore.BL.Interfaces;
using GameStore.Models.Models.Request;
using GameStore.Models.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }

        [HttpGet]

        public GetGamesByGenreResponse? GetGamesByGenre(GetGamesByGenreRequest request)
        {
            if (request == null) return null;

            return _libraryService.GetGamesByGenre(request);
        }

        [HttpGet]

        
    }
}
