using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoggenFogger.Data.Entities
{
    public class User : IdentityUser
    {
        public bool IsDeleted { get; set; }

        public string Nickname { get; set; }

        public DateTime? OnCreated { get; set; }
    }
}
