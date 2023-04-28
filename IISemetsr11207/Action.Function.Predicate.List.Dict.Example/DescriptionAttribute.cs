namespace Action.Function.Predicate.List.Dict.Example;

[AttributeUsage(AttributeTargets.Field)]
public class DescriptionAttribute: Attribute
{
    public string Name { get; set; }

    public DescriptionAttribute(string name)
    {
        Name = name;
    }
}