using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoggenFogger.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public User User { get; set; }

        public Game Game { get; set; }
    }
}
