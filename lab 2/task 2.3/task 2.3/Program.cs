namespace ConsoleApp
{
    class Numbers
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }

        public void FirstNumberChange(int newFirstNumber)
        {
            firstNumber = newFirstNumber;
        }
        
        public void SecondNumberChange(int newSecondNumber)
        {
            firstNumber = newSecondNumber;
        }
        
        public void NumbersPrint()
        {
            Console.WriteLine($"Первое число: {firstNumber}");
            Console.WriteLine($"Второе число: {secondNumber}");
        }

        public int FindSum()
        {
            int sum = 0;
            sum = firstNumber + secondNumber;
            return sum;
        }

        public int FindMax()
        {
            int maxNum = firstNumber;
            if (secondNumber > maxNum)
            {
                maxNum = secondNumber;
            }
            return maxNum;
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Numbers numbers = new Numbers()
            {
                firstNumber = 8,
                secondNumber = 10
            };
            
            Console.WriteLine("Введите номер операции которую хотите выполнить: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - вывод всех чисел.");
            Console.WriteLine("2 - изменение первого числа.");
            Console.WriteLine("3 - изменение второго числа.");
            Console.WriteLine("4 - нахождение суммы чисел.");
            Console.WriteLine("5 - нахождение максимального числа.");
            Console.WriteLine("0 - завершение.");
            int num = 1;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case (1):
                    {
                        numbers.NumbersPrint();
                        break;
                    }
                    case (2):
                    {
                        Console.WriteLine("Введите новое число: ");
                        int newFirstNumber = int.Parse(Console.ReadLine());
                        numbers.FirstNumberChange(newFirstNumber);
                        break;
                    }
                    case (3):
                    {
                        Console.WriteLine("Введите новое число: ");
                        int newSecondNumber = int.Parse(Console.ReadLine());
                        numbers.SecondNumberChange(newSecondNumber);
                        break;
                    }
                    case (4):
                    {
                        Console.WriteLine($"Сумма чисел: {numbers.FindSum()}");
                        break;
                    }
                    case (5):
                    {
                        Console.WriteLine($"Максимальное из двух чисел: {numbers.FindMax()}");
                        break;
                    }
                }
            }
        }
    }    
}