
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

    public static Result Evaluate(Options[] options)
    {
        Result result = new Result();

        if (options[1] == Options.O && options[2] == Options.O && options[3] == Options.O)
        {
            result.Player = Options.O;
            result.Status = statuses.Won;
            return result;
        }
        if (options[4] == Options.O && options[5] == Options.O && options[6] == Options.O)
        {
            result.Player = Options.O;
            result.Status = statuses.Won;
            return result;
        }
        if (options[7] == Options.O && options[8] == Options.O && options[9] == Options.O)
        {
            result.Player = Options.O;
            result.Status = statuses.Won;
            return result;
        }
        if (options[1] == Options.O && options[4] == Options.O && options[7] == Options.O)
        {
            result.Player = Options.O;
            result.Status = statuses.Won;
            return result;
        } 
        if (options[2] == Options.O && options[5] == Options.O && options[8] == Options.O)
        {
            result.Player = Options.O;
            result.Status = statuses.Won;
            return result;
        }
        if (options[3] == Options.O && options[6] == Options.O && options[9] == Options.O)
        {
            result.Player = Options.O;
            result.Status = statuses.Won;
            return result;
        }     
        if (options[1] == Options.X && options[2] == Options.X && options[3] == Options.X)
        {
            result.Player = Options.O;
            result.Status = statuses.Won;
            return result;
        }
        if (options[4] == Options.X && options[5] == Options.X && options[6] == Options.X)
        {
            result.Player = Options.X;
            result.Status = statuses.Won;
            return result;
        }
        if (options[7] == Options.X && options[8] == Options.X && options[9] == Options.X)
        {
            result.Player = Options.X;
            result.Status = statuses.Won;
            return result;
        }
        if (options[1] == Options.X && options[4] == Options.X && options[7] == Options.X)
        {
            result.Player = Options.X;
            result.Status = statuses.Won;
            return result;
        }
        
        if (options[2] == Options.X && options[5] == Options.X && options[8] == Options.X)
        {
            result.Player = Options.X;
            result.Status = statuses.Won;
            return result;
        }
        
        if (options[3] == Options.X && options[6] == Options.X && options[9] == Options.X)
        {
            result.Player = Options.X;
            result.Status = statuses.Won;
            return result;
        }
       
        if (options[3] == Options.X && options[5] == Options.X && options[7] == Options.X)
        {
            result.Player = Options.X;
            result.Status = statuses.Won;
            return result;
        }
    
        if (options[1] == Options.O && options[5] == Options.O && options[9] == Options.O)
        {
            result.Player = Options.X;
            result.Status = statuses.Won;
            return result;
        }

        else
        {
            result.Status = statuses.Tied;
            return result;
        }
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
