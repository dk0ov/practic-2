namespace GarageConsoleApp;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер операции, которую хотите выполнить: ");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("1 - просмотр типов машин."); // est
        Console.WriteLine("2 - добавление типов машин."); // est
        Console.WriteLine("3 - просмотр водителей."); // est
        Console.WriteLine("4 - просмотр категорий прав водителей"); // est
        Console.WriteLine("5 - добавление водителей."); // est
        Console.WriteLine("6 - добавление прав водителю."); // est
        Console.WriteLine("7 - просмотр всех категорий прав."); // est
        Console.WriteLine("8 - добавление категории прав."); // est
        Console.WriteLine("9 - просмотр машин."); // est
        Console.WriteLine("10 - добавление машин."); // est
        Console.WriteLine("11 - просмотр маршрутов."); // est
        Console.WriteLine("12 - добавление маршрутов."); // est
        Console.WriteLine("13 - просмотр рейсов.");
        Console.WriteLine("14 - добавление рейсов.");
        Console.WriteLine("0 - завершение.");

        int number = 1;
        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case (1):
                {
                    DatabaseRequests.GetTypeCarQuery();
                    break;
                }
                case (2):
                {
                    Console.WriteLine("Введите новый тип автомобиля:");
                    string name = Console.ReadLine();
                    DatabaseRequests.AddTypeCarQuery(name);
                    break;
                }
                case (3):
                {
                    DatabaseRequests.GetDriverQuery();
                    break;
                }
                case (4):
                {
                    Console.WriteLine("Введите id водителя, права которого хотите просмотреть: ");
                    int driver = int.Parse(Console.ReadLine());
                    DatabaseRequests.GetDriverRightsCategoryQuery(driver);
                    break;
                }
                case (5):
                {
                    Console.WriteLine("Введите имя, фамилию и дату рождения водителя: ");
                    string firstname = Console.ReadLine();
                    string lastname = Console.ReadLine();
                    DateOnly birthdate = DateOnly.Parse(Console.ReadLine());
                    DatabaseRequests.AddDriverQuery(firstname, lastname, birthdate);
                    break;
                }
                case (6):
                {
                    Console.WriteLine("Введите id водителя и id категории прав:");
                    int driver = int.Parse(Console.ReadLine());
                    int category = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddDriverRightsCategoryQuery(driver, category);
                    break;
                }
                case (7):
                {
                    DatabaseRequests.GetRightsCategoryQuery();
                    break;
                }
                case (8):
                {
                    Console.WriteLine("Введите категорию прав: ");
                    string name = Console.ReadLine();
                    DatabaseRequests.AddRightsCategoryQuery(name);
                    break;
                }
                case (9):
                {
                    DatabaseRequests.GetCarsQuery();
                    break;
                }
                case (10):
                {
                    Console.WriteLine("Введите номер типа автомобиля, его модель, номер и количество пассажиров: ");
                    int car_type = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string car_number = Console.ReadLine();
                    int quantity = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddCarsQuery(car_type, name, car_number, quantity);
                    break;
                }
                case (11):
                {
                    DatabaseRequests.GetItineraryQuery();
                    break;
                }
                case (12):
                {
                    Console.WriteLine("Введите маршрут: ");
                    string name = Console.ReadLine();
                    DatabaseRequests.AddItineraryQuery(name);
                    break;
                }
                case (13):
                {
                    DatabaseRequests.GetRouteQuery();
                    break;
                }
                case (14):
                {
                    Console.WriteLine("Введите id водителя, id машины, номер маршрута и количество пассажиров: ");
                    int driver = int.Parse(Console.ReadLine());
                    int car = int.Parse(Console.ReadLine());
                    int itinerary = int.Parse(Console.ReadLine());
                    int quantity = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddRouteQuery(driver, car, itinerary, quantity);
                    break;
                }
            }
        }
    }
}