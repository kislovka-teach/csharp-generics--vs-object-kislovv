namespace Generic.Collection.Seriallization.Linq.Example;

public class Session<TSessionData> where TSessionData : struct
{
    public Session(Account first, Account last)
    {
        Id = Guid.NewGuid();
        first.SessionId = Id;
        last.SessionId = Id;
        First = first;
        Last = last;
        Transactions = new();
        SessionCount++;
    }

    public static int SessionCount { get; set; }
    public Account First { get; }
    public Account Last { get; }
    public Guid Id { get; }
    public List<Transaction<TSessionData>> Transactions { get; }
    
    public void SaveTransaction(Transaction<TSessionData> transaction) 
    {
        if (transaction.From.SessionId != Id && transaction.To.SessionId != Id)
        {
            throw new ArgumentException(nameof(transaction.From.SessionId));
        }
        Transactions.Add(transaction);
    }
}