using Microsoft.AspNetCore.Mvc;
using work_Avr.game;
using work_Avr.Models.Api;

namespace work_Avr.Controllers
{
    public class GAMEcontroller : Controller
    {
        private readonly Game _game;
        public GAMEcontroller(Game game)
        {
            _game = game;
        }


        public IActionResult Index()
        {
            //var dataModel = new GetFieldDataModel(_game);
            return View(_game);
        }

    }
}
