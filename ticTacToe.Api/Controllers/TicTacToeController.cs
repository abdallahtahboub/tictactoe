using Microsoft.AspNetCore.Mvc;
namespace ticTacToe.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TicTacToeController : ControllerBase
{
    public Board _Board;

    public TicTacToeController()
    {
        _Board = new Board();
        _Board._Options[0]= Options.X;
        _Board._Options[1]= Options.O;
        _Board._Options[2]= Options.O;
        _Board._Options[3]= Options.O;
        _Board._Options[4]= Options.X;
    }
    [HttpGet("~/PutGrid")]
    public ActionResult<Result> EvaluateGrid()
    {   return Movement.Evaluate(_Board._Options);
    }

}
