namespace ConsoleApp
{
    class Train
    {
        public string distination { get; set; }
        public TimeOnly timeGoing { get; set; }
        public int numberOfTrain { get; set; }

        public void DataPrint()
        {
            Console.WriteLine($"Номер поезда: {numberOfTrain}");
            Console.WriteLine($"Пункт назначения: {distination}");
            Console.WriteLine($"Время отправления: {timeGoing}");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Train train = new Train()
            {
                distination = "Moscow",
                timeGoing = new TimeOnly(18, 45),
                numberOfTrain = 52
            };
            
            Console.WriteLine("Введите номер операции которую хотите выполнить: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - вывод информации о поезде.");
            Console.WriteLine("0 - завершение.");
            int num = 1;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case (1):
                    {
                        Console.WriteLine("Введите номер поезда");
                        int trainNumber = int.Parse(Console.ReadLine());
                        if (trainNumber == train.numberOfTrain)
                        {
                            train.DataPrint();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректные данные!");
                            break;
                        }
                    }
                }
            }
        }
    }    
}