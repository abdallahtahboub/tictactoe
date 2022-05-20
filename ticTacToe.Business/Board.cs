namespace ticTacToe;
public class Board
{
    public Options[,] _Options = new Options[3, 3];
    public Board()
    {
        _Options[0, 0] = Options.Empty;
        _Options[0, 1] = Options.Empty;
        _Options[0, 2] = Options.Empty;
        _Options[1, 0] = Options.Empty;
        _Options[1, 1] = Options.Empty;
        _Options[1, 2] = Options.Empty;
        _Options[2, 0] = Options.Empty;
        _Options[2, 1] = Options.Empty;
        _Options[2, 2] = Options.Empty;

    }


}
