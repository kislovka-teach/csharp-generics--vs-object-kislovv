using System.ComponentModel;
using System.Runtime.Serialization;

namespace Action.Function.Predicate.List.Dict.Example;

public enum TypeOfScore
{
    [DescriptionAttribute("История")]
    Story,
    [DescriptionAttribute("Графика")]
    Graphics,
    [DescriptionAttribute("Персонажи")]
    Characters,
    [DescriptionAttribute("Музыка")]
    Music,
    [DescriptionAttribute("Открытый мир")]
    OpenWorld,
    [DescriptionAttribute("Оптимизация")]
    Optimization
}