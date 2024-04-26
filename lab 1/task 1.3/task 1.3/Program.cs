namespace ConsoleApp
{
    class Program
    {
        public static bool FindNums(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        public static void Main()
        {
            int[] nums = new [] { 8, 2, 5, 4, 9, 6, 8, 1 };
            
            Console.WriteLine(FindNums(nums));
        }
    }    
}