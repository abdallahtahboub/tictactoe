using Microsoft.AspNetCore.Mvc;
using ticTacToe.Data;
using ticTacToe.Bussiness;

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
    [HttpPost("~/PutGrid")]
    public ActionResult<Result> EvaluateGrid(Options[] options)
    {
        
             _Board._Options = options;
             var result = Movement.Evaluate(options);
             return result;
               
       


    }

}
