using GameStore.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Models.Models.Response
{
    public class GetGamesByGenreResponse
    {
        public Genre? Genre { get; set; }

        public List<Game>? Games { get; set; }
    }
}
