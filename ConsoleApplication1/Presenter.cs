using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Presenter
    {
        /// <summary>
        /// основной массив данных
        /// </summary>
        static Int32[] data = new int[10];

        /// <summary>
        /// Точка запуска программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MainMenu();
        }

        /// <summary>
        /// Главное меню
        /// </summary>
        static void MainMenu()
        {
            RadomForData();
            bool MainCikle = true;
            bool UserDataInput;
            string chooseTxt;
            int chooseInt;
            int num;

            while (MainCikle)
            {
                View.Clean();
                View.StartMenu();
                chooseTxt = View.UserChoose();
                UserDataInput = CheckUserData(chooseTxt);        
                if(UserDataInput)
                {
                    chooseInt = Convert.ToInt32(chooseTxt);

                    switch (chooseInt)
                    {
                        //1 Изменить данные в ячейке массива
                        case 1:
                            ChangeData();
                            break;

                        //2 Удалить данные из ячейки массива
                        case 2:
                            DeliteDataFromCell();
                            break;

                        //3 вывод информации из ячейки массива
                        case 3:
                            View.Clean();
                            View.Messege("Выведете ячейку для отображения данных. Величина массива = {0}\n", data.Length - 1);
                            chooseTxt = InputData();
                            if (CheckIntIsArrayLength(chooseTxt))
                            {
                                View.Messege(chooseTxt);
                                View.PauseAndClean();
                            }
                            break;

                        //4 Сортировка не четных элементов массива
                        case 4:
                            View.Clean();
                            View.Messege("Вы пересортировали не четные элементы массива по убыванию\n");
                            SortNotChet();
                            View.PauseAndClean();
                            break;

                        //5 Сортировка четных элементов массива
                        case 5:
                            View.Clean();
                            View.Messege("Вы пересортировали четные элементы массива по убыванию\n");
                            SortChet();
                            View.PauseAndClean();
                            break;

                        //6 Показать все значения в массиве
                        case 6:
                            View.Clean();
                            View.Messege("Все знаяения массива:\n");
                            for (int i = 0; i < data.Length; i++)
                            {
                                View.Messege(data[i]);
                            }
                            View.PauseAndClean();
                            break;

                        //7 Удалить первый четный элемент
                        case 7:                            
                            DelFirstChet();                           
                            break;

                        //8 Удалить элемент с заданым значением
                        case 8:                            
                            DeliteData(InputData());
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
        }       

        /// <summary>
        /// выбор ячейки 
        /// </summary>
        /// <param name="userStringData"></param>
        /// <returns></returns>
        public static void ChangeData()
        {
            string inputCell;            
            inputCell = InputData();
            if(CheckIntIsArrayLength(inputCell))
            {
                string inputData;
                View.Clean();
                View.Messege("Введите данные для добавления в ячейку № {0}", Convert.ToInt32(inputCell));
                inputData = View.InputString();
                if(CheckUserData(inputData))
                {
                    data[Convert.ToInt32(inputCell)] = Convert.ToInt32(inputData);
                }
            } 
            View.PauseAndClean(); 
        }

        /// <summary>
        /// Ввод данных пользователем
        /// </summary>
        /// <returns></returns>
        public static string InputData()
        {
            string inputCell;
            View.Clean();
            View.Messege("Выберете ячейку. Величина массива = {0}\n", data.Length - 1);
            return View.UserChoose();
        }

        /// <summary>
        /// Сортировка не четных чисел
        /// </summary>
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

        /// <summary>
        /// Сортировка четных чисел
        /// </summary>
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

        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>
        public static void RadomForData()
        {
            var rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(30);
            }
        }

        /// <summary>
        /// удалить данные из ячейки номер
        /// </summary>
        /// <param name="num">Номер ячейки который нудно отчистить</param>
        public static void DeliteData(string userStringData)
        {
            if(CheckIntIsArrayLength(userStringData))
            {
                data[Convert.ToInt32(userStringData)] = 0;
            }
            
        }        

        /// <summary>
        /// Удалить данные равные определенному значению
        /// </summary>
        /// <param name="num">Значение раное чему нам надо удалить</param>
        /// <param name="luboeChislo">любое число типа Int, тупо заглушка</param>
        public static void DeliteData(int num)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if(data[i]==num)
                {
                    data[i] = 0;
                }
            }
        }

        /// <summary>
        /// Удалить наддые в выбраной ячейке
        /// </summary>
        /// <param name="userInput"></param>
        public static void DeliteDataFromCell()
        {
            string userInput = InputData();
            if(CheckIntIsArrayLength(userInput))
            {
                DeliteData(userInput);
            }
        }

        /// <summary>
        /// удалить первое не четное число
        /// </summary>
        public static void DelFirstChet()
        {            
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    data[i] = 0;
                    break;
                }
            }           
        }

        /// <summary>
        /// Вчислить среднее арифметическое значине, значиний всего массива
        /// </summary>
        /// <returns>Возвращает среднее арифметическое Int</returns>
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
        
        /// <summary>
        /// Проверка можно ли законвертить строку в число
        /// </summary>
        /// <param name="txt">сюда заходят данные из Console.Write, для проверки на конвертацию в Int</param>
        /// <returns></returns>
        public static bool CheckUserData(string txt)
        {            
            try
            {
                Convert.ToInt32(txt);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        /// <summary>
        /// Совпадает ли данное число(преобразованное из строки) длинне массива
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool CheckIntIsArrayLength(string txt)
        {
            if (CheckUserData(txt))
            {
                if ((Convert.ToInt32(txt) >=0)&&(Convert.ToInt32(txt) < data.Length))
                {                    
                    return true;
                }
                else
                {
                    View.Messege("Значение вне границы диапазона массива");
                    return false;
                }
            }
            else
            {
                return false;
            }

        }


    }

    
}
