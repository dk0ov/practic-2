namespace ConsoleApp
{
    class Program
    {
        public static void Main()
        {
            string J = "драгоценности";
            string S = "камни";
            int counterJ = 0;

            for (int i = 0; i < J.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if (S[j] == J[i])
                    {
                        counterJ++;
                    }
                }
            }
            Console.WriteLine($"Количество символов: {counterJ}");
        }
    }    
}