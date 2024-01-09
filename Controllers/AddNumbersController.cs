using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge2_TwotoFour.Controllers;

[ApiController]
[Route("controller")]
    public class AddNumbersController : ControllerBase
    {
        public int firstNumber = 0;
        public int secondNumber = 0;
        public int total = 0;

        [HttpPost]
        [Route("AddNumber/{firstNumber}, {secondNumber}")]
        public int AddNumber(int firstNumber, int secondNumber)
        {
            total = firstNumber + secondNumber;
            return total;
        }
    }
