namespace ConsoleApp
{
    class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int rate { get; set; }
        public int days { get; set; }

        public void GetSalary()
        {
            int salary = days * rate;
            Console.WriteLine($"Зарплата работника равна: {salary}");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Worker worker = new Worker()
            {
                name = "Darya",
                surname = "Sergeeva",
                rate = 1500,
                days = 31
            };
            Console.WriteLine("Вывести зарплату сотрудника?");
            Console.WriteLine("1 - Да; 0 - Нет.");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                worker.GetSalary();
            }
        }
    }    
}