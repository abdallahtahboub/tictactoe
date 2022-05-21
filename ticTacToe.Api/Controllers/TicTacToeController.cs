using Microsoft.AspNetCore.Mvc;
namespace ticTacToe.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TicTacToeController : ControllerBase
{


    [HttpGet]
    public Options[] Get()
    {

        var grid = Startup.InitiateGame();
        return grid;

    }




}
