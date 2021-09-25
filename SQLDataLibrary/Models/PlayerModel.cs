using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLDataLibrary.Models
{
    public class PlayerModel
    {
        public string PlayerTag { get; set; }
        public int GamesPlayed { get; set; }
        public int Points { get; set; }
    }
}