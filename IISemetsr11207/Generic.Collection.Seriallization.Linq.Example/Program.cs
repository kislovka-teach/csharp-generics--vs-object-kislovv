using Generic.Collection.Seriallization.Linq.Example.Generic;

Console.WriteLine("Hello, World!");

var acc1 = new Account
{
    NickName = "kislov-k"
};

var acc2 = new Account
{
    NickName = "Reydzi"
};

var session = new Session<int>(acc1, acc2);

session.SaveTransaction(new Transaction<int>
{
    Code = 1,
    From = acc1,
    To = acc2,
    Data = 100
});

session.SaveTransaction(new Transaction<int>
{
    Code = 2,
    From = acc2,
    To = acc1,
    Data = 50
});
Console.Write("Транзакция: ");
Console.WriteLine(string.Join("\nТранзакция: ",session.Transactions.Select(x=> $"От: {x.From.NickName} \t Кому: {x.To.NickName} \t Передал: {x.Data}")));

var session2 = new Session<int>(acc1, acc2);

var session3 = new Session<decimal>(acc1, acc2);

Console.WriteLine($"Колличество сессий чисел {Session<int>.SessionCount}");
Console.WriteLine($"Колличество сессий строк {Session<decimal>.SessionCount}");