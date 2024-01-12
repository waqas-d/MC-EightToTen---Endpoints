using MC_EightToTen___Endpoints.Services.Magic8Ball;
using Microsoft.AspNetCore.Mvc;

namespace MC_EightToTen___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class Magic8BallController : ControllerBase
    {
         private readonly IMagic8BallService _Magic8BallService;

    public Magic8BallController(IMagic8BallService Magic8BallService){
        _Magic8BallService = Magic8BallService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetMagic8BallResult/{magic8BallInput}")]

    public string GetMagic8BallResult(string magic8BallInput)
    {
        return _Magic8BallService.GetMagic8BallResult(magic8BallInput);
    }

    }