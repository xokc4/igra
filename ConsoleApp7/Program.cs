using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Здравствуйте, это игра вычитание чисел. \n Вы вводите количество игроков , минимальное и максимальное значение , после которых получается рандомное число. \n Ваша задача состоит в том чтобы дойти до нуля первым , используя только 1, 2, 3, 4");
            Console.WriteLine("введите количество участников");
            var n = int.Parse(Console.ReadLine());// ввод участников
            Console.WriteLine("введите максимальное и минимальное число для игры ");
            Console.WriteLine("введите минимальное число");
            var Min4islo = int.Parse(Console.ReadLine());// ввод минимального значения
            Console.WriteLine("введите максимальное число");
            var Max4islo = int.Parse(Console.ReadLine()) ;// ввод максимального значения
            var gameNumber = new Random().Next(Min4islo, Max4islo);
 
            // сама игра 
            while (gameNumber > 0)
            {
                for (var i = 0; i < n; i++)// цикл игры
                {
                    Console.WriteLine($"ход игрока [{i + 1}]");
                    int userTry;// игрок
                    bool notValid;
                    do
                    {
                        userTry = int.Parse(Console.ReadLine());
                        notValid = userTry < 1 || userTry > 4;
                        if (userTry < 1 || userTry > 4)// условия ввода чисел игры 
                            Console.WriteLine("можно ввести только число от 1 до 4");
                    }
                    while (notValid);

                   gameNumber = gameNumber -= userTry;
                    if (gameNumber < 0)// условие окончания игры
                    {
                        Console.WriteLine($"игрок [{i + 1}] выиграл");
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
