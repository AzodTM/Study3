using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Presenter
    {
        static Int32[] data = new int[10];
        

        static void Main(string[] args)
        {
            RadomForData();
            bool MainCikl = true;
            int choose;
            int num;

            while (MainCikl)                               
            {
                View.StartMenu();
                choose = View.UserChoose();
                


                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Выберете ячейку в которой нужно изменить данные. Величина массива = {0}\n", data.Length-1);
                        num = View.ChooseYacheyka(data);
                        data[num] = View.AddData(num, data.Length);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Выберете ячейку в которой нужно уждалить данные. Величина массива = {0}\n", data.Length-1);
                        num = View.ChooseYacheyka(data);
                        data[num] = 0;                        
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Выведете ячейку для отображения данных. Величина массива = {0}\n",data.Length-1);
                        num = View.ChooseYacheyka(data);
                        try
                        {
                            Console.WriteLine(data[num]);
                        }
                        catch
                        {
                            Console.WriteLine("Ячейки {0} не существует",num);
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Вы пересортировали не четные элементы массива по убыванию\n");
                        SortNotChet();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Вы пересортировали четные элементы массива по убыванию\n");
                        SortChet();
                        break;

                    case 6:
                        Console.Clear();
                        for (int i = 0; i < data.Length; i++)
                        {
                            Console.WriteLine(data[i]);
                        }
                        break;

                    case 7:
                       
                        MainCikl = false;
                        break;


                }

            
            }
            
             
        }


       

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
                
                Console.WriteLine("Не верный формат данных\n");

            }
            Console.Clear();
            return 0;
        }



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




        public static void RadomForData()
        {
            var rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(10);
            }
        }

        
    }
}
