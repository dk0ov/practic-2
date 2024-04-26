class Program
{
    static void Main(string[] args)
    {
        int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
        int target = 8;
        
        List<List<int>> combinations = new List<List<int>>();
        
        Array.Sort(candidates);
        
        FindCombinations(candidates, target, new List<int>(), 0, combinations);
        
        Console.WriteLine("Уникальные комбинации чисел:");
        foreach (var combination in combinations)
        {
            Console.Write("[");
            Console.WriteLine(string.Join(", ", combination) + "]");
        }
    }
    
    static void FindCombinations(int[] candidates, int target, List<int> currentCombination, int startIndex, List<List<int>> combinations)
    {
        if (target == 0)
        {
            combinations.Add(new List<int>(currentCombination));
            return;
        }
        else if (target < 0 || startIndex >= candidates.Length)
        {
            return;
        }
        
        for (int i = startIndex; i < candidates.Length; i++)
        {
            if (i > startIndex && candidates[i] == candidates[i - 1])
            {
                continue;
            }
            currentCombination.Add(candidates[i]);
            
            FindCombinations(candidates, target - candidates[i], currentCombination, i + 1, combinations);
            
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}