using Microsoft.AspNetCore.Mvc;
using ticTacToe;

namespace ticTacToe.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TicTacToeController : ControllerBase
{


    [HttpGet]
    public void StartGame()
    {

        var start = Startup.InitiateGame();

    }





}
