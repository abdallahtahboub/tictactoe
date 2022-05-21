
namespace ticTacToe;

public static class Movement
{
    public static int Turn = 0;

    public static TileStatus CheckGridTile(Options[] options, int x)
    {
        if (options[x] == Options.Empty)
        {
            return TileStatus.Opened;
        }
        else
        {
            return TileStatus.Blocked;
        }
    }

    public static void SetOptionX(Options[] options, TileStatus status, int x)
    {
        if (status == TileStatus.Opened)
        {
            options[x] = Options.X;
        }
        else
        {
            throw new NotImplementedException("This part is not implemented");
        }
    }

    public static void SetOptionO(Options[] options, TileStatus status, int x)
    {
        if (status == TileStatus.Opened)
        {
            options[x] = Options.O;
        }
    }

    public static (Options, statuses) Evaluate(Options[] options)
    {
        // First row cobination.
        if (options[1] == Options.O && options[2] == Options.O && options[3] == Options.O)
            return (Options.O, statuses.Won);
        // Second row cobination.
        if (options[4] == Options.O && options[5] == Options.O && options[6] == Options.O)
            // Third row combination.
            return (Options.O, statuses.Won);
        if (options[7] == Options.O && options[8] == Options.O && options[9] == Options.O)
            return (Options.O, statuses.Won);
        // First column combination.
        if (options[1] == Options.O && options[4] == Options.O && options[7] == Options.O)
            return (Options.O, statuses.Won);
        // Second column combination.    
        if (options[2] == Options.O && options[5] == Options.O && options[8] == Options.O)
            return (Options.O, statuses.Won);
        // Third column combination.
        if (options[3] == Options.O && options[6] == Options.O && options[9] == Options.O)
            return (Options.O, statuses.Won);

        // X combination
        // First row cobination.
        if (options[1] == Options.X && options[2] == Options.X && options[3] == Options.X)
            return (Options.O, statuses.Won);
        // Second row cobination.
        if (options[4] == Options.X && options[5] == Options.X && options[6] == Options.X)
            // Third row combination.
            return (Options.X, statuses.Won);
        if (options[7] == Options.X && options[8] == Options.X && options[9] == Options.X)
            return (Options.X, statuses.Won);
        // First column combination.
        if (options[1] == Options.X && options[4] == Options.X && options[7] == Options.X)
            return (Options.X, statuses.Won);
        // Second column combination.    
        if (options[2] == Options.X && options[5] == Options.X && options[8] == Options.X)
            return (Options.X, statuses.Won);
        // Third column combination.
        if (options[3] == Options.X && options[6] == Options.X && options[9] == Options.X)
            return (Options.X, statuses.Won);
        // diagonal win.
        if (options[3] == Options.X && options[5] == Options.X && options[7] == Options.X)
            return (Options.X, statuses.Won);
        // diagonal win.
        if (options[1] == Options.O && options[5] == Options.O && options[9] == Options.O)
            return (Options.O, statuses.Won);

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
