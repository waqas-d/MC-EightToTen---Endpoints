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
    [Route("GetMagic8BallResult/{firstUniqueResp}/{secondUniqueResp}/{thirdUniqueResp}/{fourthUniqueResp}/{fifthUniqueResp}/{sixthUniqueResp}/{seventhUniqueResp}/{eighthUniqueResp}/{ninthUniqueResp}/{tenthUniqueResp}")]

    public string GetMagic8BallResult(string firstUniqueResp, string secondUniqueResp, string thirdUniqueResp, string fourthUniqueResp, string fifthUniqueResp, string sixthUniqueResp, string seventhUniqueResp, string eighthUniqueResp, string ninthUniqueResp, string tenthUniqueResp)
    {
        return _Magic8BallService.GetMagic8BallResult(firstUniqueResp, secondUniqueResp, thirdUniqueResp, fourthUniqueResp, fifthUniqueResp, sixthUniqueResp, seventhUniqueResp, eighthUniqueResp, ninthUniqueResp, tenthUniqueResp);
    }

    }