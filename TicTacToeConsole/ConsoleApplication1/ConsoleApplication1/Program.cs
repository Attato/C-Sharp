using System;
using System.Threading;


namespace tic_tac_toe
{
    class Program {
        
        //Создание массива 0-9, где 0 не используется

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice; //Позиция выбора

        // Определяет победителя (1 = кто-то выйграл; -1 = ничья; 0 = матч в процессе)
        static int flag = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();// Очистка экрана при каждом запуске массива 
                Console.WriteLine("\n");
                Console.WriteLine("Игрок 1: X \tИгрок 2: O");
                Console.WriteLine("\n");

                if (player % 2 == 0)//Проверка хода игрока 
                {
                    Console.WriteLine("Ход игрока 2");
                }

                else
                {
                    Console.WriteLine("Ход игрока 1");
                }

                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());//Выбор пользователей

                // Проверка того, что позиция, которую хочет выбрать пользователь, отмечена (X или O) или нет

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //Если черёд хода даётся игроку 2, иначе игроку 1
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else //Если есть какая-то возможность, в которой пользователь хочет запустить, и она уже отмечена, то покажите сообщение и снова загрузите доску 
                {
                    Console.WriteLine("\nК сожалению строка {0} уже занята числом {1}", choice, arr[choice]);
                    Console.WriteLine("\nПодождите пару секунд, идёт возвращение к шагу...");
                    Thread.Sleep(10000);
                }
                flag = CheckWin();// Вызов проверки на  выигрыш  
            } while (flag != 1 && flag != -1);// Игра продолжается до тех пор, пока один из игроков не выйграет

            Console.Clear(); 
            Board(); 

            if (flag == 1)// Значение 1 присвается последнему походившему игроку
            {
                Console.WriteLine("Игрок {0} победил", (player % 2) + 1);
            }

            else
            {
                Console.WriteLine("Ничья");
            }
            Console.ReadLine();
        }

        // метод, создающий поле

        private static void Board()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      \n");
        }



        //Проверка выйгрыша

        private static int CheckWin(){

            #region Horzontal Winning Condtion

            //Выйгрышные условия для данной строки 

            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }

            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
  
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }

            #endregion

            #region vertical Winning Condtion

            //Выйгрышные условия для данной колонки     

            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
  
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }      

            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition

            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }

            #endregion

            #region Checking For Draw

            // Если ячейки заполнены, значит игрок выйграл матч 

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9') {
                return -1;
            }
            #endregion

            else{
                return 0;
            }
        }
    }
}