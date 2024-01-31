using GameStore.Models.Models.Request;
using GameStore.Models.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetGamesByGenreResponse? GetGamesByGenre(GetGamesByGenreRequest request);
        
    }
}
