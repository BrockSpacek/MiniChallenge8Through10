
using Microsoft.AspNetCore.Mvc;
using MiniChallenge8Through10.Services;

namespace MiniChallenge8Through10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Challenge9Controller : ControllerBase
    {

        private readonly Challenge9Services _challenge9Services;

        public Challenge9Controller(Challenge9Services challenge9Services)
        {
          _challenge9Services = challenge9Services;
        }

    

        [HttpPost]
        [Route("GuessitEasy/{guessNumberEasy}")]
        public string GuessItEasy(string guessNumberEasy){
            return _challenge9Services.GuessItEasy(guessNumberEasy);
        }


        [HttpPost]
        [Route("GuessitMedium/{guessNumberMedium}")]
        public string GuessItMedium(string guessNumberMedium){
            return _challenge9Services.GuessItMedium(guessNumberMedium);
        }


        [HttpPost]
        [Route("GuessitHard/{guessNumberHard}")]
        public string GuessItHard(string guessNumberHard){
            return _challenge9Services.GuessItHard(guessNumberHard);
        }
    }
}