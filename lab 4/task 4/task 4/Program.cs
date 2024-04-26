class Program
{
    private static Dictionary<char, int> numbers = new Dictionary<char, int>
    {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };
 
    public static int ConvertNumber(string text)
    {
        int totalNumber = 0;
        int previousNumber = 0;
        foreach (var c in text)
        {
            if (!numbers.ContainsKey(c))
            {
                return 0;
            }
            var currentNumber = numbers[c];
            totalNumber = totalNumber + currentNumber;
            if (previousNumber != 0 && previousNumber < currentNumber)
            {
                if (previousNumber == 1 && (currentNumber == 5 || currentNumber == 10) || previousNumber == 10 && (currentNumber == 50 || currentNumber == 100) || previousNumber == 100 && (currentNumber == 500 || currentNumber == 1000))
                {
                    totalNumber = totalNumber - 2 * previousNumber;   
                }
                else
                {
                    return 0;
                }
            }
            previousNumber = currentNumber;
        }
        return totalNumber;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число римскими цифрами:");
        string number = Console.ReadLine();
        int num = ConvertNumber(number);
        Console.WriteLine($"Переведенное число: {num}");
    }
}