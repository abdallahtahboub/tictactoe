namespace ticTacToe;
public static class Startup
{
    public static bool isGameInAction = true;
    public static int coord_1;
    public static int coord_2;

    public static Options[,] InitiateGame()
    {
        var game = new Board();
        var grid = game._Options;
        return grid;
    }

    public static void GameLoop()
    {
        var newgame = Startup.InitiateGame();

        while (isGameInAction)
        {
            var check = Movement.CheckGridTile(newgame, coord_1, coord_2);
            Movement.SetOptionX(newgame, check, coord_1, coord_2);
            while (check == TileStatus.Blocked)
            {
                Movement.SetOptionX(newgame, check, coord_1, coord_2);
            }
            var checkresult = Movement.Evaluate(newgame);
            statuses result = checkresult.Item2;
            Options playerWon = checkresult.Item1;
            if (result == statuses.Won)
            {
                isGameInAction = false;
                break;
            }
            else
            {

                Movement.SetOptionO(newgame, check, coord_1, coord_2);

                while (check == TileStatus.Blocked)
                {
                    Movement.SetOptionX(newgame, check, coord_1, coord_2);
                }
            }
            var checkresult2 = Movement.Evaluate(newgame);
            statuses result_1 = checkresult2.Item2;
            Options playerWon_1 = checkresult2.Item1;
            if (result_1 == statuses.Won)
            {
                isGameInAction = false;

            }


        }

    }




    public static void Run(int x, int y)
    {

    }

}