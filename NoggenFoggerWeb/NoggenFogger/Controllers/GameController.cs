using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NoggenFogger.Data.Entities;
using NoggenFogger.Models;
using NoggenFogger.Services;
using NoggenFogger.Services.Interfaces;

namespace NoggenFogger.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameManager gameManager;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;

        public GameController(IGameManager gameManager,
            IMapper mapper,
            UserManager<User> userManager)
        {
            this.gameManager = gameManager;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/games")]
        public IActionResult Index()
        {
            var games = gameManager.GetGames().OrderByDescending(x => x.LikesCount);
            var gameViewModels = new List<GameViewModel>();

            foreach (var game in games)
            {
                gameViewModels.Add(mapper.Map<GameViewModel>(game));
            }

            return View(gameViewModels);
        }

        [HttpGet]
        [Route("/games/add")]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [Route("/games/add")]
        public async Task<IActionResult> Add(GameViewModel gameViewModel)
        {
            if (ModelState.IsValid)
            {
                var getCurrentUser = this.userManager.Users.First(x => x.UserName == this.User.Identity.Name);
                var newGame = new Game
                {
                    Title = gameViewModel.Title,
                    Author = gameViewModel.Author,
                    ImageUrl = gameViewModel.ImageUrl,
                    VideoTrailer = gameViewModel.VideoTrailer,
                    Description = gameViewModel.Description,
                    DownloadLink = gameViewModel.DownloadLink,
                    Creator = getCurrentUser
                };

                await gameManager.CreateAsync(newGame);
            }

            return Redirect("/games");
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody]string gameTitle)
        {
            var game = await this.gameManager.GetCurrentGame(gameTitle);

            this.gameManager.Delete(game);

            return RedirectToAction("/games");
        }
    }
}