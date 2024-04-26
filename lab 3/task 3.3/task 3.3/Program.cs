namespace ConsoleApp
{
    class Calculation
    {
        public string calculationLine { get; set; }

        public void SetCalculationLine(string newCalculationLine)
        {
            calculationLine = newCalculationLine;
        }

        public void SetLastSymbolCalculationLine(string lastSymbol)
        {
            calculationLine = calculationLine + lastSymbol;
        }

        public void GetCalculationLine()
        {
            Console.WriteLine($"Значение свойства: {calculationLine}");
        }

        public void GetLastSymbol(int index)
        {
            Console.WriteLine($"Последний символ: {calculationLine[index]}");
        }

        public void DeleteLastSymbol(int index)
        {
            calculationLine = calculationLine.Remove(index);
            Console.WriteLine($"Новое значение свойства: {calculationLine}");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Calculation calculation = new Calculation()
            {
                calculationLine = "8430"
            };
            
            Console.WriteLine("Введите номер операции которую хотите выполнить: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - изменение значения свойства.");
            Console.WriteLine("2 - добавление нового символа.");
            Console.WriteLine("3 - вывод значения свойства.");
            Console.WriteLine("4 - вывод последнего символа.");
            Console.WriteLine("5 - удаление последнего символа.");
            Console.WriteLine("0 - завершение.");
            int num = 1;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case (1):
                    {
                        Console.WriteLine("Введите новое значение свойства: ");
                        string newCalculationLine = Console.ReadLine();
                        calculation.SetCalculationLine(newCalculationLine);
                        break;
                    }
                    case (2):
                    {
                        Console.WriteLine("Введите последний символ: ");
                        string lastSymbol = Console.ReadLine();
                        calculation.SetLastSymbolCalculationLine(lastSymbol);
                        break;
                    }
                    case (3):
                    {
                        calculation.GetCalculationLine();
                        break;
                    }
                    case (4):
                    {
                        string str = Convert.ToString(calculation.calculationLine);
                        int index = str.Length - 1;
                        calculation.GetLastSymbol(index);
                        break;
                    }
                    case (5):
                    {
                        string str = Convert.ToString(calculation.calculationLine);
                        int index = str.Length - 1;
                        calculation.DeleteLastSymbol(index);
                        break;
                    }
                }
            }
        }
    }    
}