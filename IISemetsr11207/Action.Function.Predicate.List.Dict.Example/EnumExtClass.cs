namespace Action.Function.Predicate.List.Dict.Example;

public static class EnumExtClass
{
    public static T GetEnumDescription<T>(this Enum enumData)
    {
        var type = enumData.GetType();
        var memInfo = type.GetMember(enumData.ToString());
        var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
        return attributes.Cast<T>().SingleOrDefault(); 
    }
}