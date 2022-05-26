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
    }

    [HttpGet("~/getGrid")]
    public ActionResult<Options[]> GetGrid()
    {
        return Startup.InitiateGame(); ;
    }



    [HttpGet("~/Evaluate")]
    public ActionResult<Result> GetEvalute()
    {
        var op = _Board._Options;
        op[1] = Options.X;
        var x = Movement.Evaluate(op);
        return x;
    }


}
