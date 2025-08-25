using EFCoreMainPractice.Data;
using EFCoreMainPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EFCoreMainPractice.Controllers
{
    public class GameController : Controller
    {
        private readonly MyAppContext _db;

        public GameController(MyAppContext db)
        {
            _db = db;
        }

        [HttpGet("AllGames")]
        public IActionResult GetAllGames()
        {
            return Ok(_db.Games);
        }

        [HttpPost("AddGame")]
        public IActionResult AddGame(AddGame addGame)
        {
            Game newGame = new Game();
            newGame.DescriptionOfGame = addGame.Description;
            newGame.Title = addGame.Title;
            newGame.CategoryId = 1;

            _db.Games.Add(newGame);
            _db.SaveChanges();

            return Ok(newGame);
        }

        [HttpDelete("DeleteGame/{id}")]
        public IActionResult DeleteGame(int id)
        {
            var game = _db.Games.FirstOrDefault(g => g.Id == id);
            if (game!=null)
            {
                _db.Remove(game);
                _db.SaveChanges();
                return Ok($"Deleted {game.Title}");

            }
            return BadRequest("Game not found");
        }

        [HttpPut("UpdateGame/{id}")]
        public IActionResult UpdateGame(int id, AddGame updatedGame)
        {
            var game = _db.Games.FirstOrDefault(g => g.Id == id);
            if(game != null)
            {
                game.Title = updatedGame.Title;
                game.DescriptionOfGame = updatedGame.Description;
                _db.SaveChanges();
                return Ok(game);
            }
            return BadRequest("Game not found");
        }

    }

    //DTO to add game (used same for Update)
    public class AddGame
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }


}
