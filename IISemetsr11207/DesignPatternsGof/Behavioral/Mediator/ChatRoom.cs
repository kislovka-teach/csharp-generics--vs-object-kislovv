namespace DesignPatternsGof.Behavioral.Mediator;

public class ChatRoom : IMediator<string>
{
    public List<Collegue<string>> CollegueList { get; set; }= new();
    public void Send(string message, Collegue<string> from)
    {
        if (!CollegueList.Contains(from) || from is not User us)
        {
            return;
        }

        foreach (var collegue in CollegueList
                     .Where(collegue => collegue != from))
        {
            collegue.Notify($"Сообщение от {us.Name}: {message}");
        }
    }
}