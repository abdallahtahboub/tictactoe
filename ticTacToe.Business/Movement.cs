
namespace ticTacToe;

public static class Movement
{
    public static int Turn = 0;

    public static TileStatus CheckGridTile(Options[,] options, int x, int y)
    {
        if (options[x, y] == Options.Empty)
        {
            return TileStatus.Opened;
        }
        else
        {
            return TileStatus.Blocked;
        }
    }

    public static void SetOptionX(Options[,] options, TileStatus status, int x, int y)
    {
        if (status == TileStatus.Opened)
        {
            options[x, y] = Options.X;
        }
        else
        {
            throw new NotImplementedException("This part is not implemented");
        }
    }

    public static void SetOptionO(Options[,] options, TileStatus status, int x, int y)
    {
        if (status == TileStatus.Opened)
        {
            options[x, y] = Options.O;
        }
    }

    public static (Options, statuses) Evaluate(Options[,] options)
    {
        // First row cobination.
        if (options[0, 0] == Options.O && options[1, 0] == Options.O && options[2, 0] == Options.O)
            return (Options.O, statuses.Won);
        // Second row cobination.
        if (options[0, 1] == Options.O && options[1, 1] == Options.O && options[2, 1] == Options.O)
            // Third row combination.
            return (Options.O, statuses.Won);
        if (options[0, 2] == Options.O && options[1, 2] == Options.O && options[2, 2] == Options.O)
            return (Options.O, statuses.Won);
        // First column combination.
        if (options[0, 0] == Options.O && options[0, 1] == Options.O && options[0, 2] == Options.O)
            return (Options.O, statuses.Won);
        // Second column combination.    
        if (options[1, 0] == Options.O && options[1, 1] == Options.O && options[1, 2] == Options.O)
            return (Options.O, statuses.Won);
        // Third column combination.
        if (options[2, 0] == Options.O && options[2, 1] == Options.O && options[2, 2] == Options.O)
            return (Options.O, statuses.Won);
        // diagonal win.
        if (options[0, 0] == Options.O && options[1, 1] == Options.O && options[2, 2] == Options.O)
            return (Options.O, statuses.Won);
        // X combination
        // First row cobination.
        if (options[0, 0] == Options.X && options[1, 0] == Options.X && options[2, 0] == Options.X)
            return (Options.O, statuses.Won);
        // Second row cobination.
        if (options[0, 1] == Options.X && options[1, 1] == Options.X && options[2, 1] == Options.X)
            // Third row combination.
            return (Options.X, statuses.Won);
        if (options[0, 2] == Options.X && options[1, 2] == Options.X && options[2, 2] == Options.X)
            return (Options.X, statuses.Won);
        // First column combination.
        if (options[0, 0] == Options.X && options[0, 1] == Options.X && options[0, 2] == Options.X)
            return (Options.X, statuses.Won);
        // Second column combination.    
        if (options[1, 0] == Options.X && options[1, 1] == Options.X && options[1, 2] == Options.X)
            return (Options.X, statuses.Won);
        // Third column combination.
        if (options[2, 0] == Options.X && options[2, 1] == Options.X && options[2, 2] == Options.X)
            return (Options.X, statuses.Won);
        // diagonal win.
        if (options[0, 0] == Options.X && options[1, 1] == Options.X && options[2, 2] == Options.X)
            return (Options.X, statuses.Won);

        else
            return (Options.Empty, statuses.Tied);
    }
    public static Options ChangePLayer(Options player_1, Options player_2)
    {

        Turn++;
        if (Turn % 2 == 0)
            return player_1;
        else
            return player_2;

    }

    public static (Options, Options) DefinePlayers(Options firstPlayer, Options secondPlayer)
    {
        var playser_1 = firstPlayer;
        var playser_2 = secondPlayer;

        return (playser_1, playser_2);
    }

}
