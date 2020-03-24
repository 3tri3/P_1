using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Program
    {
        static monitor ii = new monitor();

        static void Main(string[] args)
        {
            for (int z = 0; z < 99999; z++)
            {
                Console.WriteLine();
                Console.WriteLine($" ┌─────────────────────МЕНЮ─────────────────────┐");
                Console.WriteLine($" │ 1. Заполнить.                                │");
                Console.WriteLine($" │ 2. Вывести.                                  │");
                Console.WriteLine($" │ 3. Очистить консоль.                         │");
                Console.WriteLine($" │ 4. Выйти из программы.                       │");
                Console.WriteLine($" └──────────────────────────────────────────────┘");
                Console.Write(" Выберите команду: ");
                int x1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                switch (x1)
                {
                    case 1: ii.add(); break;
                    case 2: ii.print(); break;
                    case 3: Console.Clear(); break;
                    case 4: Environment.Exit(0); break;
                }
            }
        }
    }
}
