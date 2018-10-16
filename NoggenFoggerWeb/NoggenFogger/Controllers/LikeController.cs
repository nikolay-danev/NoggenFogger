using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoggenFogger.Data;
using NoggenFogger.Data.Entities;
using NoggenFogger.Models;

namespace NoggenFogger.Controllers
{
    public class LikeController : Controller
    {
        private readonly NoggenFoggerDbContext context;

        public LikeController(NoggenFoggerDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> LikeGame([FromBody]string gameTitle)
        {
            var game = this.context.Games.First(g => g.Title == gameTitle);
            var user = this.context.Users.First(x => x.UserName == this.User.Identity.Name);

            var currentGameLikes = this.context.Likes.Where(x => x.Game.Id == game.Id);

            if (!currentGameLikes.Any(x => x.User.Id == user.Id))
            {
                var like = new Like
                {
                    Game = game,
                    User = user
                };

                await this.context.Likes.AddAsync(like);
                this.context.SaveChanges();
            }
            else
            {
                var currentLike = this.context.Likes.First(x => x.User.Id == user.Id && x.Game.Id == game.Id);
                this.context.Likes.Remove(currentLike);
                this.context.SaveChanges();
            }
            
            return RedirectToAction("/games");
        }
    }
}