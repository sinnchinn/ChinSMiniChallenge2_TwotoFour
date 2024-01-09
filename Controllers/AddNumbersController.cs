using ChinSMiniChallenge2_TwotoFour.services.questions;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge2_TwotoFour.Controllers;

[ApiController]
[Route("controller")]
public class AddNumbersController : ControllerBase
{
    private readonly IAddNumbersService _addNumbersService;

    public AddNumbersController(IAddNumbersService addNumbersService)
    {
        _addNumbersService = addNumbersService;
    }

    [HttpPost]
    [Route("AddNumber/{firstNumber}, {secondNumber}")]
    public int AddNumber(int firstNumber, int secondNumber)
    {
        return _addNumbersService.AddNumber(firstNumber, secondNumber);
    }
}
