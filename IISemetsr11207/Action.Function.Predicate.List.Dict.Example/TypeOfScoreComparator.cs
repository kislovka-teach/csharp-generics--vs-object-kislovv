namespace Action.Function.Predicate.List.Dict.Example;

public class TypeOfScoreComparator : IComparer<Game>
{
    private readonly TypeOfScore _typeOfScore;

    public TypeOfScoreComparator(TypeOfScore typeOfScore)
    {
        _typeOfScore = typeOfScore;
    }
    
    public int Compare(Game x, Game y)
    {
        return x.Score[_typeOfScore] == y.Score[_typeOfScore]
            ? 0
            : x.Score[_typeOfScore] > y.Score[_typeOfScore]
                ? -1
                : 1;
    }
}