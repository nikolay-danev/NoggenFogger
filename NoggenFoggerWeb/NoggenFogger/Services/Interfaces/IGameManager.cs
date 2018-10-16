using Microsoft.AspNetCore.Mvc;
using NoggenFogger.Data.Entities;
using NoggenFogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoggenFogger.Services.Interfaces
{
    public interface IGameManager
    {
        Task CreateAsync(Game game);

        void Delete(Game game);

        ICollection<Game> GetGames();

        Task<Game> GetCurrentGame(string gameTitle);
    }
}
