namespace LastTasks
{
    class Programm
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n0) Выход;");
                Console.WriteLine("1) Поиск простых чисел от 0 до N;");
                Console.WriteLine("2) Проверка года (ХХХХ) на високосность;");
                Console.WriteLine("3) ");
                Console.WriteLine("4) ");
                Console.WriteLine("5) ");
                Console.WriteLine("6) ");
                Console.WriteLine("7) ");
                Console.WriteLine("8) ");
                int Mode;
                while (true)
                {
                    try
                    {
                        Console.Write("Введите номер для выбора режима: ");
                        Mode = Convert.ToInt32(Console.ReadLine());
                        if (Mode >=0 && Mode <= 8)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Соблюдайте нумерацию режимов");
                        }
                    } catch
                    {
                        Console.WriteLine("Вы ввели не корректный номер. ");
                    }
                }
                if (Mode == 0)
                {
                    break;
                }
                if (Mode == 1)
                {
                    Task_1 task_1 = new Task_1();
                    task_1.ReadNumberFromConsole();
                    task_1.FillingInArrays();
                    task_1.CheckPrimeNums();
                }
                if (Mode == 2)
                {
                    Task_2 task_2 = new Task_2();
                    task_2.ReadYearFromConsole();
                    task_2.ViewAnswer();
                }
                if (Mode == 3)
                {

                }
            }
        }
    }
}