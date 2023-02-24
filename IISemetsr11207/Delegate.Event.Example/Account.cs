
using static Delegate.Event.Example.Account;

namespace Delegate.Event.Example
{
    public class Account
    {
        public delegate void Notify(string message);
        int _sum;
        public event Notify NotifyEvent;
        public Account(int sum)
        {
            _sum = sum;
            Console.WriteLine($"Создан счет с суммой { _sum}");
        }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            NotifyEvent?.Invoke($"Добавлено {sum} к счету, остаток -{_sum}");
            _sum += sum;
            Console.WriteLine($"Добавлено { sum} к счету, остаток -{ _sum}");
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                Console.WriteLine($"Убрано со счета {sum}, остаток -{_sum}");
            }
        }
    }

}
