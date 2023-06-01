namespace Action.Function.Predicate.List.Dict.Example;

public class GameComparer : IComparer<Game>
{
    public int Compare(Game x, Game y)
    {
        switch (x)
        {
            case null when y == null:
                return 0;
            case null:
                return -1;
        }

        if (y == null)
            return 1;
       
        var avgFirstGame = x.Score.Values.Sum();
        var avgSecondGame = y.Score.Values.Sum();
        return avgFirstGame == avgSecondGame
            ? 0 
            : avgFirstGame > avgSecondGame 
                ? -1 
                : 1;
    }
}