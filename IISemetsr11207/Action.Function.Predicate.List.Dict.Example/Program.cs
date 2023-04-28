using System.Reflection;
using Action.Function.Predicate.List.Dict.Example;

var games = new List<Game>() 
{ 
    new Game 
    { 
        Genre = Genre.Horror,
        Name  = "Doka2",
        Score = new Dictionary<TypeOfScore, decimal>()
        {
            {
                TypeOfScore.Characters, 10
            }, 
            {
                TypeOfScore.Graphics, 1
            }, 
            {
                TypeOfScore.Music, 3
            }, 
            {
                TypeOfScore.Optimization, 10
            },
            {
                TypeOfScore.Story, 1
            },
            {
                TypeOfScore.OpenWorld, 0
            },
            
        }
    },
    new Game
    {
        Genre = Genre.Adventure,
        Name  = "Hogwarts: Legacy",
        Score = new Dictionary<TypeOfScore, decimal>()
        {
            {
                TypeOfScore.Characters, 5
            }, 
            {
                TypeOfScore.Graphics, 6
            }, 
            {
                TypeOfScore.Music, 10
            }, 
            {
                TypeOfScore.Optimization, 6
            },
            {
                TypeOfScore.Story, 9
            },
            {
                TypeOfScore.OpenWorld, 10
            },
            
        }
        
    },
    new Game
    {
        Genre = Genre.Adventure,
        Name  = "RDR2",
        Score = new Dictionary<TypeOfScore, decimal>()
        {
            {
                TypeOfScore.Characters, 7
            }, 
            {
                TypeOfScore.Graphics, 10
            }, 
            {
                TypeOfScore.Music, 8
            }, 
            {
                TypeOfScore.Optimization, 7
            },
            {
                TypeOfScore.Story, 9
            },
            {
                TypeOfScore.OpenWorld, 10
            },
            
        }
    },
    new Game
    {
        Genre = Genre.Horror,
        Name  = "Geometry Dash",
        Score = new Dictionary<TypeOfScore, decimal>()
        {
            {
                TypeOfScore.Characters, 10
            }, 
            {
                TypeOfScore.Graphics, 4
            }, 
            {
                TypeOfScore.Music, 10
            }, 
            {
                TypeOfScore.Optimization, 10
            },
            {
                TypeOfScore.Story, 1
            },
            {
                TypeOfScore.OpenWorld, 0
            },
            
        }
    }
};


foreach (var game in games)
{
    Console.WriteLine(game.Name);
}



var typeOfMetacritic = typeof(Metacritic);
var metacritic = Activator.CreateInstance(typeOfMetacritic);

var methods = typeOfMetacritic.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
var method = methods.FirstOrDefault(m =>  m.Name == "GetSortedGames");
method.Invoke(metacritic, new object[] { games });
Console.ReadLine();

foreach (var game in games)
{
    Console.WriteLine(
        $@"""{game.Name} Критерии оценок: 
                        {string.Join(" ,", 
                            game.Score.Keys.Select(
                                x => 
                                    x.GetEnumDescription<DescriptionAttribute>().Name))
                        } """);
}