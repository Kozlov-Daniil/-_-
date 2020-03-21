using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = @$"C:\Temp\eagle.txt";
            Creation(ref f);
            logic(ref f);
            Console.ReadKey(true);
        }
        public static void Creation(ref string f)
        {
            string[] strings =
            {
                "Друзей Оушена","11",
                "Друзей у Орлика?", "0",
                "Какое количество лапок у бабочки?","6",
                "Сколько лапок у паукоа?","8",
            };
            var ultimate = File.Create(f);
            ultimate.Close();
            File.WriteAllLines(f, strings);
        }
        public static void logic(ref string path)
        {
            int polzovatel = 0;
            int otvet = 0;
            int vernie = 0;
            string[] massiv = File.ReadAllLines(path);
            for (int i = 0; i < massiv.Length; i++)

            {
                Console.WriteLine(massiv[i]);
                polzovatel = int.Parse(Console.ReadLine());
                otvet = Convert.ToInt32(massiv[i + 1]);
                if (polzovatel == otvet)
                {
                    Console.WriteLine("Верный ответ");
                    vernie++;
                    Console.WriteLine("Нажмите клавишу для перехода");
                    Console.ReadKey(true);
                    Console.Clear();
                }

                else

                {
                    Console.WriteLine($"Неверный ответ\nВерный ответ: {otvet}\nНажмите клавишу для перехода");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                i++;
            }
            Console.WriteLine($"Число верных ответов:{vernie}");
        }
    }
}
