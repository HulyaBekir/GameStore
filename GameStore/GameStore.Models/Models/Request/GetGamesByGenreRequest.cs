using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Models.Models.Request
{
    public class GetGamesByGenreRequest
    {
        public int GenreId { get; set; }

        public DateTime AfterDate { get; set; }
        public bool IsValid { get; set; }
    }
}
