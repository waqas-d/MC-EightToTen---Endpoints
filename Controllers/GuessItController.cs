using MC_EightToTen___Endpoints.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace MC_EightToTen___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class GuessItController : ControllerBase
    {
         private readonly IGuessItService _GuessItService;

    public GuessItController(IGuessItService GuessItService){
        _GuessItService = GuessItService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetGuessItEasyResult/{easyMode}")]

    public string GetGuessItEasyResult(string easyMode)
    {
        return _GuessItService.GetGuessItEasyResult(easyMode);
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetGuessItMediumResult/{mediumMode}")]

    public string GetGuessItMediumResult(string mediumMode)
    {
        return _GuessItService.GetGuessItMediumResult(mediumMode);
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetGuessItHardResult/{hardMode}")]

    public string GetGuessItHardResult(string hardMode)
    {
        return _GuessItService.GetGuessItHardResult(hardMode);
    }

        
    }