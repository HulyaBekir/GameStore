using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Models.Models.User
{
    public class Genre
    {
        public int Id { get; set; }

        public string Type { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }
    }
}
