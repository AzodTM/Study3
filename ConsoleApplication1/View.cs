using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //Класс для отоюражения данных пользователю
    public class View
    {
        /// <summary>
        /// отрисовка меню
        /// </summary>
        public static void StartMenu()
        {            
            Console.WriteLine("Выберете действие с массивом\n");
            Console.WriteLine("1 Добавить данные в ячейку массива\n");
            Console.WriteLine("2 Удалить данные из ячейки массива\n");
            Console.WriteLine("3 вывод информации из ячейки массива\n");
            Console.WriteLine("4 Сортировка не четных элементов массива\n");
            Console.WriteLine("5 Сортировка четных элементов массива\n");
            Console.WriteLine("6 Показать все значения в массиве\n");
            Console.WriteLine("7 Удалить первый четный элемент\n");
            Console.WriteLine("8 Удалить элемент с заданым значением\n");
            Console.WriteLine("9 Удалить элемент равный среднему арифметическому масива\n");
            Console.WriteLine("15 Выход\n");    
        }

        /// <summary>
        /// выбор ячейки    
        /// </summary>
        /// <returns></returns>
        public static string UserChoose()
        {              
            return Console.ReadLine();            
        }

        /// <summary>
        /// ввод пользователем длинны массива
        /// </summary>
        /// <returns></returns>
        public static string arrayLeght()
        {            
            Console.WriteLine("введите длинну массива\n");
            return Console.ReadLine();            
        }

        /// <summary>
        /// выбор ячейки
        /// </summary>
        /// <param name="myArray">Массив Int.ов</param>
        /// <returns></returns>
        public static string InputString()
        {             
            return Console.ReadLine();                      
        } 

        /// <summary>
        /// Отображение данных в коносли
        /// </summary>
        /// <param name="msg">Текстовое сообщение для отображения данных в консоли</param>
        public static void Messege(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Отображение данных в консоли
        /// </summary>
        /// <param name="msg">Текстовое сообщение для отображения данных в консоли</param>
        /// <param name="num">Вставить цифру в текст</param>
        public static void Messege(string msg,int num)
        {
            Console.WriteLine(msg,num);
        }

        /// <summary>
        /// Отображение данных в коносли
        /// </summary>
        /// <param name="msg">Показать в консоли цифру</param>
        public static void Messege(int msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Ожидание нажатия клавиши и отчистка консоли
        /// </summary>
        public static void PauseAndClean()
        {
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Отчистка консоли
        /// </summary>
        public static void Clean()
        {            
            Console.Clear();
        }

    }
}
