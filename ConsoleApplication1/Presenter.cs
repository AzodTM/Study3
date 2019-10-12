﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Presenter
    {
        //основной массив данных
        static Int32[] data = new int[10];
        
        //Точка запуска программы
        static void Main(string[] args)
        {
            MainMenu();
        }

        //Главное меню
        static void MainMenu()
        {
            RadomForData();
            bool MainCikle = true;
            int choose;
            int num;

            while (MainCikle)
            {
                View.StartMenu();
                choose = View.UserChoose();



                switch (choose)
                {
                    //1 Добавить данные в ячейку массива
                    case 1:                        
                        View.Messege("Выберете ячейку в которой нужно изменить данные. Величина массива = {0}\n", data.Length - 1);
                        num = View.ChooseYacheyka(data);
                        data[num] = View.AddData(num, data.Length);
                        break;

                    //2 Удалить данные из ячейки массива
                    case 2:                        
                        View.Messege("Выберете ячейку в которой нужно уждалить данные. Величина массива = {0}\n", data.Length - 1);
                        num = View.ChooseYacheyka(data);
                        DeliteData(num);
                        break;

                    //3 вывод информации из ячейки массива
                    case 3:                        
                        View.Messege("Выведете ячейку для отображения данных. Величина массива = {0}\n", data.Length - 1);
                        num = View.ChooseYacheyka(data);
                        try
                        {
                            Console.WriteLine(data[num]);
                        }
                        catch
                        {
                            View.Messege("Ячейки {0} не существует", num);
                        }
                        Console.WriteLine();
                        break;

                    //4 Сортировка не четных элементов массива
                    case 4:                        
                        View.Messege("Вы пересортировали не четные элементы массива по убыванию\n");
                        SortNotChet();
                        break;

                    //5 Сортировка четных элементов массива
                    case 5:                        
                        View.Messege("Вы пересортировали четные элементы массива по убыванию\n");
                        SortChet();
                        break;

                    //6 Показать все значения в массиве
                    case 6:                       
                        for (int i = 0; i < data.Length; i++)
                        {
                            Console.WriteLine(data[i]);
                        }
                        break;

                    //7 Удалить первый четный элемент
                    case 7:                                                               
                        DelFirstNeChet();
                        break;

                    //8 Удалить элемент с заданым значением
                    case 8:
                        num = View.ChooseYacheyka(data);
                        DeliteData(num, 0);
                        break;

                    //9 Удалить элемент равный среднему арифметическому масива
                    case 9:
                        DeliteData(Average());
                        View.Messege("Удалены элементы со значением {0}", Average());
                        break;

                    //Выход
                    case 15:
                        MainCikle = false;
                        break;


                }


            }
        }

        //Обработка изключений на команды пользователя
        public static int TryRead(string txt)
        {
            int data;
            try
            {
                data = Convert.ToInt32(txt);
                return data;
            }
            catch
            {

                View.Messege("Не верный формат данных\n");

            }
            Console.Clear();
            return 0;
        }

        //Сортировка не четных чисел
        public static void SortNotChet()
        {
            bool sortOk = false;
            bool change;
            int tempdata;

            while (!sortOk)

            {
                change = false;
                for (int i = 0; i < data.Length; i++)
                {

                    if (i+2 <= data.Length-1)
                    {
                        if ((data[i] < data[i + 2])&& ((i+1) % 2 > 0))
                        {
                            tempdata = data[i];
                            data[i] = data[i + 2];
                            data[i + 2] = tempdata;
                            change = true;

                        }
                    }

                

                }
                if(!change)
                {
                    sortOk = true;
                }
            }
        }

        //Сортировка четных чисел
        public static void SortChet()
        {
            bool sortOk = false;
            bool change;
            int tempdata;

            while (!sortOk)

            {
                change = false;
                for (int i = 0; i < data.Length; i++)
                {

                    if (i + 2 <= data.Length - 1)
                    {
                        if ((data[i] < data[i + 2]) && ((i + 1) % 2 == 0))
                        {
                            tempdata = data[i];
                            data[i] = data[i + 2];
                            data[i + 2] = tempdata;
                            change = true;

                        }
                    }



                }
                if (!change)
                {
                    sortOk = true;
                }
            }
        }

        //Заполнение массива случайными числами
        public static void RadomForData()
        {
            var rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(10);
            }
        }
        
        //удалить данные из ячейки (прировнять к нулю)
        public static void DeliteData(int num)
        {
            data[num] = 0;
        }

        //Удалить данные равные ...
        public static void DeliteData(int num,int luboeChislo)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if(data[i]==num)
                {
                    data[i] = 0;
                }
            }
        }

        //удалить первое не четное число
        public static void DelFirstNeChet()
        {            
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 > 0)
                {
                    data[i] = 0;
                    break;
                }
            }
           
        }

        //Вчислить среднее арифметическое значине, значиний всего массива
        public static int Average()
        {
            int avg;
            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            avg = sum / data.Length;
            return avg;
        }
    }
}
