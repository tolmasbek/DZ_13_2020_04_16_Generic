using System;
using DZ16042020Space;
namespace DZ_16_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] user_array = {"a", "r", "r", "a", "y"};
            
            int choise = int.Parse(Console.ReadLine());
            System.Console.Write($"Выберите один из действий для данного массива: ");
            System.Console.WriteLine("1. Pop – Удаляет последний элемент массива");
            System.Console.WriteLine("2. Push – Добавляет элемент с конца массива");
            System.Console.WriteLine("3. Shift – Удаляет первый элемент"); 
            System.Console.WriteLine("4. UnShift – Добавляет элемент в начало массива");
            System.Console.WriteLine("5. Slice – возвращает новый массив, содержащий копию части исходного массива");
            System.Console.Write("Ваш выбор: ");    
            switch(choise)
            {
                case 1:
                {
                    var element_del = ArrayHelper<string>.Pop(ref user_array);
                    System.Console.WriteLine(element_del);
                    break;
                }
                
                case 2:
                {
                    System.Console.Write("Введите новый элемент для добавления: ");
                    string new_elem = Console.ReadLine();
                    int newarr = ArrayHelper<string>.Push(ref user_array, new_elem);
                    System.Console.WriteLine(newarr);
                    break;
                }
                
                case 3:
                {
                    var elem_del = ArrayHelper<string>.Shift(ref user_array);
                    System.Console.WriteLine(elem_del);
                    break;
                }
                
                case 4:
                {
                    Console.Write("Введите элемент для добавления в начало массива: ");
                    string newelem = Console.ReadLine();
                    int newSize = ArrayHelper<string>.UnShift(ref user_array, newelem);
                    break;
                }
                case 5:
                {
                    Console.Write("Введите начальный индекс: ");
                    int begin_index = int.Parse(Console.ReadLine());
                    Console.Write("Введите конечный индекс: ");
                    int end_index = int.Parse(Console.ReadLine());
                    string[] new_arr = ArrayHelper<string>.Slice(user_array, begin_index, end_index);
                    break;
                }
            }            
            Console.ReadKey();
        }
    }
}
