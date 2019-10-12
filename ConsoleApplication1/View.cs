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
        public static int UserChoose()
        {
            int userChoose;
            userChoose = Presenter.TryRead(Console.ReadLine());
            return userChoose;
        }

        /// <summary>
        /// ввод пользователем длинны массива
        /// </summary>
        /// <returns></returns>
        public static int arrayLeght()
        {
            int leght;
            Console.WriteLine("введите длинну массива\n");
            leght = Presenter.TryRead(Console.ReadLine());
            return leght;
        }

        /// <summary>
        /// выбор ячейки
        /// </summary>
        /// <param name="myArray">Массив Int.ов</param>
        /// <returns></returns>
        public static int ChooseYacheyka(int[] myArray)
        {
            int num;
                        
            Console.WriteLine("введите номер ячейки максимальная длинна {0}\n", myArray.Length-1);
                       
            
            num = Presenter.TryRead(Console.ReadLine());
            return num;
            
        }

        /// <summary>
        /// Добавление данных в ячейку
        /// </summary>
        /// <param name="yacheyka">номер ячейки массива</param>
        /// <param name="leght">длинна массива</param>
        /// <returns></returns>
        public static int AddData(int yacheyka, int leght)
        {
            int data;
            Console.WriteLine("Введите данные для добавления в ячейку № {0}", yacheyka);
            data = Convert.ToInt32(Console.ReadLine());
            return data;
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
        

    }
}
