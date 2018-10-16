using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoggenFogger.Data;
using NoggenFogger.Data.Entities;
using NoggenFogger.Models;
using NoggenFogger.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoggenFogger.Services
{
    public class GameManager<T> : IGameManager
        where T : Game
    {
        private readonly NoggenFoggerDbContext _context;
        private ICollection<Game> allGames;
        public GameManager(NoggenFoggerDbContext context)
        {
            _context = context;
            this.allGames = this._context.Games.ToList();
        }

        public Task CreateAsync(Game game)
        {
            var task = _context.Games.AddAsync(game);
            _context.SaveChanges();
            return task;
        }

        public void Delete(Game game)
        {
            _context.Games.Remove(game);
            _context.SaveChanges();
        }

        public Task<Game> GetCurrentGame(string gameTitle)
        {
            var task = _context.Games.FirstOrDefaultAsync(x => x.Title == gameTitle);
            return task;
        }

        public ICollection<Game> GetGames()
        {
            foreach (var game in allGames)
            {
                game.LikesCount = _context.Likes.Where(x => x.Game.Id == game.Id).Count();
            }
            return _context.Games.ToList();
        }


    }
}
