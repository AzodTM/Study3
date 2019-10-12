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
        //отрисовка меню
        public static void StartMenu()
        {
            
            Console.WriteLine("Выберете действие с массивом\n");
            Console.WriteLine("1 Добавить данные в ячейку массива\n");
            Console.WriteLine("2 Удалить данные из ячейки массива\n");
            Console.WriteLine("3 вывод информации из ячейки массива\n");
            Console.WriteLine("4 Сортировка не четных элементов массива\n");
            Console.WriteLine("5 Сортировка четных элементов массива\n");
            Console.WriteLine("6 Показать все значения в массиве\n");
            Console.WriteLine("7 Удалить первый четный элемент");
            Console.WriteLine("8 Выход\n");    
        }

        //выбор ячейки    
        public static int UserChoose()
        {
            int userChoose;
            userChoose = Presenter.TryRead(Console.ReadLine());
            return userChoose;
        }
           
        //ввод пользователем длинны массива
        public static int arrayLeght()
        {
            int leght;
            Console.WriteLine("введите длинну массива\n");
            leght = Presenter.TryRead(Console.ReadLine());
            return leght;
        }

        //выбор ячейки
        public static int ChooseYacheyka(int[] myArray)
        {
            int num;
                        
            Console.WriteLine("введите номер ячейки максимальная длинна {0}\n", myArray.Length-1);
                       
            
            num = Presenter.TryRead(Console.ReadLine());
            return num;
            
        }

        //Добавление данных в ячейку
        public static int AddData(int yacheyka, int leght)
        {
            int data;
            Console.WriteLine("Введите данные для добавления в ячейку № {0}", yacheyka);
            data = Convert.ToInt32(Console.ReadLine());
            return data;
        }

        public static void Messege(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Messege(string msg,int num)
        {
            Console.WriteLine(msg,num);
        }
        

    }
}
