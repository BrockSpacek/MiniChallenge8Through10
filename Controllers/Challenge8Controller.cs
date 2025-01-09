
using Microsoft.AspNetCore.Mvc;
using MiniChallenge8Through10.Services;

namespace MiniChallenge8Through10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Challenge8Controller : ControllerBase
    {
        private readonly Challenge8Services _challenge8Services;

        public Challenge8Controller(Challenge8Services challenge8Services)
        {
          _challenge8Services = challenge8Services;
        }

         [HttpPost]
        [Route("MagicEightBall/{yesOrNoQuestion}")]

        public string EightBallGame(string yesOrNoQuestion)
        {
            return _challenge8Services.MagicEightBall(yesOrNoQuestion);
        }
    }
}