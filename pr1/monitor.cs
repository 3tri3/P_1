using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class monitor
    {
        static monitor[] a = new monitor[500];
        static int n;

        private string firm { get; set; }
        private string type { get; set; }
        private float diagonal { get; set; }

        internal void add()
        {
            Console.WriteLine();
            Console.Write("Введите кол-во записей: ");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new monitor();
                Console.Write("Фирма : ");
                a[i].firm = Console.ReadLine();
                Console.Write("Тип: ");
                a[i].type = Console.ReadLine();
                Console.Write("Диагональ: ");
                a[i].diagonal = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine();
            }
        }
        internal void print()
        {
            Console.WriteLine();
            Console.WriteLine("Список Мониторов:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i}. Фирма: {a[i].firm}, Тип: {a[i].type}, Диагональ: {a[i].diagonal}.");
            }
            Console.WriteLine();
        }
    }
}
