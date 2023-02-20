namespace Generic.Collection.Seriallization.Linq.Example;

public class Account
{
    public string NickName { get; set; }
    public Guid SessionId { get; set; }


    public Transaction<T> CreateTransaction<T>(T data, Account to)
    {
        return new Transaction<T>()
        {
            Data = data,
            Code = new Random().Next(),
            From = this,
            To = to
        };
    }

    public void SendTransaction<T>(Transaction<T> transaction, Session<T> session) where T : struct
    {
        session.SaveTransaction(transaction);
    }
}