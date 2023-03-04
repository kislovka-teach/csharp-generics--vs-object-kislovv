namespace Action.Function.Predicate.List.Dict.Example;

public class GameComparer : IComparer<Game>
{
    public int Compare(Game x, Game y)
    {
        decimal avgFirstGame = default;
        decimal avgSecondGame = default;
        foreach (var score in x.Score.Values)
        {
            avgFirstGame += score;
        } 
        foreach (var score in y.Score.Values)
        {
            avgSecondGame+= score;
        }
        return avgFirstGame == avgSecondGame
            ? 0 
            : avgFirstGame > avgSecondGame 
                ? -1 
                : 1;
    }
}