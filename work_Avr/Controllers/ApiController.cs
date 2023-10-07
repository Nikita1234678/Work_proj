using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using work_Avr.game;
using work_Avr.Models.Api;

namespace work_Avr.Controllers
{
   // [Route("api/[controller]")]
  //  [ApiController]
    public class ApiController : Controller
    {
        private Game _game;
        private object _getFieldLockObject = new();
        public ApiController(Game game)
        {
            _game = game;
        }

        public IActionResult GetFiend()
        {
            lock (_getFieldLockObject)
            {
                _game.field.ChangeField();
                var dataModel = new GetFieldDataModel(_game);

                return PartialView("/Views/PageParts/SnakeTable.cshtml", dataModel);
            }
        }

    }
}
