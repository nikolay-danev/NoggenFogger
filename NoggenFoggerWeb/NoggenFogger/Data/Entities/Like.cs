using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoggenFogger.Data.Entities
{
    public class Like
    {
        public int Id { get; set; }

        public Game Game { get; set; }

        public User User { get; set; }
    }
}
