
using Microsoft.AspNetCore.Mvc;
using MiniChallenge8Through10.Services;

namespace MiniChallenge8Through10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Challenge10Controller : ControllerBase
    {
        private readonly Challenge10Services _challenge10Services;

        public Challenge10Controller(Challenge10Services challenge10Services)
        {
          _challenge10Services = challenge10Services;
        }

        [HttpPost]
        [Route("RestarauntPicker/{restarauntCategory}")]

        public string RestarauntPicker(string restarauntCategory){
            return _challenge10Services.RestarauntPicker(restarauntCategory);
        }
    }
}