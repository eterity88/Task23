//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int N = int.Parse(Console.ReadLine());
 
            Console.WriteLine("\t" + "Куб");
            for(int i = 1; i <= N; i++)
                Console.WriteLine( "\t" + i*i*i);
 
            Console.ReadLine();
  
        }
    }