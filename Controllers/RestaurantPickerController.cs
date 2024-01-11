using MC_EightToTen___Endpoints.Services.RestaurantPicker;
using Microsoft.AspNetCore.Mvc;

namespace MC_EightToTen___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class RestaurantPickerController : ControllerBase
    {
         private readonly IRestaurantPickerService _RestaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService RestaurantPickerService){
        _RestaurantPickerService = RestaurantPickerService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetRestaurantPickerResult/{userInput}")]

    public string GetRestaurantPickerResult(string userInput)
    {
        return _RestaurantPickerService.GetRestaurantPickerResult(userInput);
    }

    }