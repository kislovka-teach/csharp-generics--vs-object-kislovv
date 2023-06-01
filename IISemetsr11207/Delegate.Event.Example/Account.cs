namespace Delegate.Event.Example
{
    public class Account
    {
        public delegate void Notify(Account sender, AccountEventArgs args);
        //Используем event т.к. иначе можно было бы управлять Notifier снаружи
        public event Notify Notifier;
        public Account(int sum, Notify notifier)
        {
            CurrentSum = sum;
            Notifier = notifier;
            Notifier?.Invoke(this, new AccountEventArgs($"Создан счет с суммой {CurrentSum}"));
        }

        public int CurrentSum { get; private set; }

        public void Put(int sum)
        {
            CurrentSum += sum;
            Notifier?.Invoke(this, new AccountEventArgs($"Добавлено {sum} к счету, остаток - {CurrentSum}"));
        }

        public void Withdraw(int sum)
        {
            if (sum <= CurrentSum)
            {
                CurrentSum -= sum;
                Notifier?.Invoke(this, new AccountEventArgs($"Убрано со счета {sum}, остаток - {CurrentSum}"));
            }
        }
    }

}
