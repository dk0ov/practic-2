namespace ConsoleApp
{
    class Count
    {
        public int currentCounter { get; set; }
        
        public void CountChange(int counter)
        {
            currentCounter = counter;
        }
        
        public void CountPlus()
        {
            currentCounter++;
        }
        
        public void CountMinus()
        {
            currentCounter--;
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Count count = new Count()
            {
                currentCounter = 0
            };
            
            Console.WriteLine("Введите номер операции которую хотите выполнить: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - вывод текущего состояния счетчика.");
            Console.WriteLine("2 - присваивание счетчику произвольного значения.");
            Console.WriteLine("3 - увеличение счетчика на 1.");
            Console.WriteLine("4 - уменьшение счетчика на 1.");
            Console.WriteLine("0 - завершение.");
            int num = 1;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case (1):
                    {
                        Console.WriteLine($"Текущее состояние счетчика: {count.currentCounter}");
                        break;
                    }
                    case (2):
                    {
                        Console.WriteLine("Введите новое значение для счетчика: ");
                        int counter = int.Parse(Console.ReadLine());
                        count.CountChange(counter);
                        Console.WriteLine("Значение счетчика изменено");
                        break;
                    }
                    case (3):
                    {
                        count.CountPlus();
                        Console.WriteLine("Значение счетчика увеличено");
                        break;
                    }
                    case (4):
                    {
                        count.CountMinus();
                        Console.WriteLine("Значение счетчика уменьшено");
                        break;
                    }
                }
            }
        }
    }    
}