namespace ConsoleApp
{
    class Class
    {
        public int numberClass { get; set; }
        public string stringClass { get; set; }

        public Class(int number, string text)
        {
            numberClass = number;
            stringClass = text;
        }

        public Class()
        {
            numberClass = 0;
            stringClass = "text";
        } 
    }
    
    class Program
    {
        public static void Main()
        {
            Class firstObject = new Class(8, "number");
            Class secondObject = new Class();

            Console.WriteLine("Введите номер операции которую хотите выполнить: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - вывод значений первого объекта.");
            Console.WriteLine("2 - вывод значений второго объекта.");
            Console.WriteLine("0 - завершение.");
            int num = 1;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case (1):
                    {
                        Console.WriteLine($"numberClass - {firstObject.numberClass}, stringClass: {firstObject.stringClass}");
                        break;
                    }
                    case (2):
                    {
                        Console.WriteLine($"numberClass - {secondObject.numberClass}, stringClass: {secondObject.stringClass}");
                        break;
                    }
                }
            }
        }
    }    
}