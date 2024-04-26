namespace ConsoleApp
{
    class Worker
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;
        public string Surname 
        {
            get { return surname; }
            set { surname = value; }
        }

        private int rate;
        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private int days;
        public int Days 
        {
            get { return days; }
            set { days = value; }
        }

        public int GetSalary()
        {
            int salary = days * rate;
            return salary;
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Worker worker = new Worker()
            {
                Name = "Darya",
                Surname = "Sergeeva",
                Rate = 1500,
                Days = 31
            };
            Console.WriteLine("Вывести зарплату сотрудника?");
            Console.WriteLine("1 - Да; 0 - Нет.");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine(worker.GetSalary());
            }
        }
    }    
}