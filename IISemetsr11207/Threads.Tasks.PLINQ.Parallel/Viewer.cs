using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads.Tasks.PLINQ.Parallel;

public class Viewer
{
    /// <summary>
    /// Номер зрителя.
    /// </summary>
    public int id { get; set; }

    public Viewer(int id) => this.id = id;

    /// <summary>
    /// Ой-ой-ой хочу в туалет.
    /// </summary>
    public void WantToilet()
    {
        Console.WriteLine($"Зритель {id} хочет в туалет");
    }

    /// <summary>
    /// Да ё-моё... очередь как в поликлинику.
    /// </summary>
    public void WaitToilet()
    {
        Console.WriteLine($"Зритель {id} ожидает в очереди к туалету");
    }

    /// <summary>
    /// Оооо... даааа...
    /// </summary>
    public void ComeToilet()
    {
        Console.WriteLine($"Зритель {id} заходит в туалет");
    }

    /// <summary>
    /// Пойду дальше смотреть представление.
    /// </summary>
    public void ExitToilet()
    {
        Console.WriteLine($"Зритель {id} выходит из туалета");
    }
}
