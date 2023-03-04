namespace Action.Function.Predicate.List.Dict.Example;

public class Game
{
    public string Name { get; init; }
    public Genre Genre { get; init; }
    public Dictionary<TypeOfScore, decimal> Score { get; set; }
}
