using GameStore.BL.Interfaces;
using GameStore.Models.Models.Request;
using GameStore.Models.Models.Response;
using GameStore.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            this._libraryService = libraryService;
        }

        [HttpGet("GetGamesByGenreResponse")]

        public GetGamesByGenreResponse? GetGamesByGenre(GetGamesByGenreRequest request)
        {
            if (request == null) return null;

            return _libraryService.GetGamesByGenre(request);
        }

        [HttpGet]

        public string GetTestEndpoint([FromBody] GetGamesByGenreRequest request)
        {
            var validator = new GetGamesByGenreRequestValidator();

            var result = validator.Validate(request);

            if (request.IsValid)
            {
                return "Test Pass";
            }

            return "Test Not Pass";
        }
    }
}
