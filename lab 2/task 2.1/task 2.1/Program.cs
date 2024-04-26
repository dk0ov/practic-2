namespace ConsoleApp
{
    class Student
    {
        public string lastName { get; set; }
        public DateOnly dateOfBirth { get; set; }
        public int numberOfGroup { get; set; }
        public int[] progress { get; set; }

        public void LastNameChange(string newLastName)
        {
            lastName = newLastName;
        }

        public void DateOfBirthChange(DateOnly newDateOfBirth)
        {
            dateOfBirth = newDateOfBirth;
        }

        public void NumberOfGroupChange(int newNumberOfGroup)
        {
            numberOfGroup = newNumberOfGroup;
        }

        public void DataPrint()
        {
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Дата рождения: {dateOfBirth}");
            Console.WriteLine($"Номер группы: {numberOfGroup}");
            Console.WriteLine($"Успеваемость: ");

            for (int i = 0; i < progress.Length; i++)
            {
                Console.Write(progress[i] + " ");
                Console.WriteLine();
            }
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Student student = new Student()
            {
                lastName = "Sergeeva",
                dateOfBirth = new DateOnly(2006, 08, 01),
                numberOfGroup = 666,
                progress = new [] { 5, 4, 5, 5, 4 }
            };
            
            Console.WriteLine("Введите номер операции которую хотите выполнить: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - вывод всей информации.");
            Console.WriteLine("2 - вывод информации о конкретном студенте.");
            Console.WriteLine("3 - изменение информации о студенте.");
            Console.WriteLine("0 - завершение.");
            int num = 1;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case (1):
                    {
                        student.DataPrint();
                        break;
                    }
                    case (2):
                    {
                        Console.WriteLine("Введите фамилию и дату рождения студента: ");
                        string name = Console.ReadLine();
                        DateOnly date = DateOnly.Parse(Console.ReadLine());
                        if (name == student.lastName && date == student.dateOfBirth)
                        {
                            student.DataPrint();
                        }
                        else
                        {
                            Console.WriteLine("Некорректные данные!");
                        }
                        break;
                    }
                    case (3):
                    {
                        Console.WriteLine("Введите новую фамилию: ");
                        string newLastname = Console.ReadLine();
                        student.LastNameChange(newLastname);
                        
                        Console.WriteLine("Введите новую дату рождения в формате ДД.ММ.ГГГГ: ");
                        DateOnly newDateOfBirth = DateOnly.Parse(Console.ReadLine());
                        student.DateOfBirthChange(newDateOfBirth);
                        
                        Console.WriteLine("Введите новую группу: ");
                        int newNumberOfGroup = int.Parse(Console.ReadLine());
                        student.NumberOfGroupChange(newNumberOfGroup);
                        break;
                    }
                }
            }
        }
    }    
}