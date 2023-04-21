using System.Security.Cryptography.X509Certificates;

namespace Action.Function.Predicate.List.Dict.Example;

public class Metacritic
{
    private readonly List<Game> _games = new();

    public List<Game> Games => _games;

    public IEnumerable<Game> GetGameByFilter(Func<Game, bool> filter)
    {
        return _games.Where(filter);
    }

    public Dictionary<Genre, List<Game>> GetTopByGenre()
    {
        var groups = _games.GroupBy(x => x.Genre).ToDictionary(y => y.Key, z => z.ToList());
        // groups.Values.ToList().ForEach(x => x.Sort(new GameComparer()));
        foreach (var gamesByGenre in groups.Values)
        {
            gamesByGenre.Sort(new GameComparer());
        }
        
        return groups;
    }

    public IEnumerable<Game> GetGamesByMoreThanScore(decimal score)
    {
        return _games.Where(game => game.Score.Values.Average() >= score);
    }

    public IEnumerable<Game> GetTopTenGamesByTypeOfScore(TypeOfScore typeOfScore)
    {
        var games = _games.Where(game => game.Score.ContainsKey(typeOfScore))
            .ToList();
        games.Sort((game1, game2) => game2.Score[typeOfScore].CompareTo(game1.Score[typeOfScore]));
        // games.Sort(new TypeOfScoreComparator(typeOfScore));
        return games.Take(10);
    }
    public Dictionary<Genre, decimal> GetSumScoreByGenre()
    {
        return _games
            .GroupBy(x => x.Genre)
            .ToDictionary(x => x.Key, y => y.ToList().Sum(z => z.Score.Values.Sum()));
    }

    public IEnumerable<Game> GetAllGamesWhenFirstAndLastCharEquals()
    {
        return _games.Where(x => x.Name[0] == x.Name[^1]);
    }
}