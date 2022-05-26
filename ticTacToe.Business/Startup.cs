namespace ticTacToe;
public static class Startup
{
    public static bool isGameInAction = true;
    public static int _x;

    public static int X
    {
        get { return _x; }
        set { _x = value; }
    }
    public static Options[] InitiateGame()
    {
        var game = new Board();
        var grid = game._Options;
        return grid;
    }
    // public static void GameLoop()
    // {
    //     var newgame = Startup.InitiateGame();

    //     while (isGameInAction)
    //     {
    //         var check = Movement.CheckGridTile(newgame, X);
    //         Movement.SetOptionX(newgame, check, X);
    //         while (check == TileStatus.Blocked)
    //         {
    //             Movement.SetOptionX(newgame, check, X);
    //         }
    //         var checkresult = Movement.Evaluate(newgame);
    //         // statuses result = checkresult.Item2;
    //         // Options playerWon = checkresult.Item1;
    //         if (result == statuses.Won)
    //         {
    //             isGameInAction = false;
    //             break;
    //         }
    //         else
    //         {

    //             Movement.SetOptionO(newgame, check, X);

    //             while (check == TileStatus.Blocked)
    //             {
    //                 Movement.SetOptionX(newgame, check, X);
    //             }
    //         }
    //         var checkresult2 = Movement.Evaluate(newgame);
    //         statuses result_1 = checkresult2.Item2;
    //         Options playerWon_1 = checkresult2.Item1;
    //         if (result_1 == statuses.Won)
    //         {
    //             isGameInAction = false;

    //         }


    //     }

    // }
}