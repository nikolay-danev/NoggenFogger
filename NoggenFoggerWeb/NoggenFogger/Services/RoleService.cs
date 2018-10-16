using Microsoft.AspNetCore.Identity;
using NoggenFogger.Extensions.GlobalConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NoggenFogger.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleService(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public async Task CheckOrAddRoles()
        {
            var memberRole = await roleManager.RoleExistsAsync(RoleTypes.Member);
            var adminRole = await roleManager.RoleExistsAsync(RoleTypes.Administrator);
            var moderatorRole = await roleManager.RoleExistsAsync(RoleTypes.Moderator);

          

            if (!memberRole)
            {
                await roleManager.CreateAsync(new IdentityRole { Name = RoleTypes.Member });
                var memberRoleName = await roleManager.FindByNameAsync("Member");
                await roleManager.AddClaimAsync(memberRoleName, new Claim(ClaimTypes.Role, "Member"));
            }

            if (!adminRole)
            {
                await roleManager.CreateAsync(new IdentityRole { Name = RoleTypes.Administrator });
                var adminRoleName = await roleManager.FindByNameAsync("Administrator");
                await roleManager.AddClaimAsync(adminRoleName, new Claim(ClaimTypes.Role, "Administrator"));
            }

            if (!moderatorRole)
            {
                await roleManager.CreateAsync(new IdentityRole { Name = RoleTypes.Moderator });
                var moderatorRoleName = await roleManager.FindByNameAsync("Moderator");
                await roleManager.AddClaimAsync(moderatorRoleName, new Claim(ClaimTypes.Role, "Moderator"));
            }
        }
    }
}
