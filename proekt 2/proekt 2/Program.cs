namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Список доступных прграмм:\r\n" +
                "1. Игра - угадай число \r\n" +
                "2. Таблица умножения \r\n" +
                "3. Найти цедые делители числа \r\n" +
                "4. Выход из прораммы");
            Console.Write("Введите номер программы которую хотите выполнить: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                GuesseTheNumber();
            }
            else if (choice == 2)
            {
                MultiplicationTable();
            }
            else if (choice == 3)
            {
                NumberDivisor();
            }
            else if (choice == 4)
            {
                Exit();
            }
            else if (choice > 4 || choice <= 0)///я все это хаваю, у меня нет выбора... если конечно хочу чтобы работало красиво... см описание метода стр124
            {
                Error();
            }
        }
        static void GuesseTheNumber()
        {
            Console.WriteLine();
            int number = new Random().Next(100);
            Console.WriteLine("Угадай число");
            Console.WriteLine("Компьютер загадал число от 1 до 100");
            bool numberRight = true;
            do
            {
                Console.WriteLine("Введите число: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                if (number == inputNumber)
                {
                    Console.WriteLine("Вы угадали число!");
                    numberRight = false;
                }
                else if (number > inputNumber)
                {
                    Console.WriteLine("Нужно больше");
                }
                else if (number < inputNumber)
                {
                    Console.WriteLine("Нужно меньше");
                }
            } while (numberRight == true);
            Menu();
        }
        static void MultiplicationTable()
        {
            Console.WriteLine();
            int[,] TableMeaning = new int[10, 10];
            for (int i = 1; i < TableMeaning.GetLength(0); i++)
            {
                for (int j = 1; j < TableMeaning.GetLength(1); j++)
                {
                    int mean = i * j;
                    if (i == j)
                    {
                        TableMeaning[i, j] = mean;
                        Console.Write(TableMeaning[i, j] + "\t");
                    }
                    else if (i < j)
                    {
                        TableMeaning[i, j] = mean;
                        Console.Write(TableMeaning[i, j] + "\t");
                    }
                    else if (i > j)
                    {
                        TableMeaning[i, j] = mean;
                        Console.Write(TableMeaning[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
            Menu();
        }
        static void NumberDivisor()
        {
            Console.WriteLine();
            Console.WriteLine("Для выхода введите exit");
            Console.WriteLine("введите первое число");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int delNumber = Convert.ToInt32(input);
                for (int a = 1; a <= delNumber; a++)
                {
                    if (delNumber % a == 0)
                    {
                        Console.Write(a + "\t");

                    }
                }
                Console.WriteLine();
                Console.WriteLine("введите следующее число");
                input = Console.ReadLine();
            }
            Menu();
        }
        static void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("Вы успешно вышли из прораммы!");
        }
        static void Error()
        // Это не будыжник - это итальянский мрамор!
        //описания лучше не придумать, особенно после непосредственного прочтения метода.
        // меня просто не устрааааивал вариант с тем, что после ввода пользователем неправильного числа в консоль менюхи
        //оно просто завершает прогу, и я захотел сделать бесшовный преход с этой темой, странно перетусовав эти методы.
        // но оно работает...

        {
            Console.WriteLine("Ошибка! Введите номер программы, которую хотите выполнить");
            int select = Convert.ToInt32(Console.ReadLine()); // я категорически извиняюсь за тот GRINGE что вы увидите далее.
            if (select == 1)
            {
                GuesseTheNumber();//после бутылки пива это может показаться вполне логичным.
            }
            else if (select == 2)
            {
                MultiplicationTable();
            }
            else if (select == 3)
            {
                NumberDivisor();
            }
            else if (select == 4)
            {
                Exit();
            }
            else
            {
                Error();
            }
        }
    }
}


