using Struct_Nullable_Types.Enums;
using Struct_Nullable_Types.Exceptions;
using Struct_Nullable_Types.Interfaces;
using Struct_Nullable_Types.Models;
using System.Dynamic;
using System.Threading.Tasks;
using Struct_Nullable_Types.Services;
namespace Struct_Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

			#region Task1
			//IEmployeeService employeeService = new EmployeeService();
			//try
			//{
			//	Employee employee1 = new Employee(new DateTime(1990, 5, 15)) { Name = "John", Surname = "Snow", Salary = 50000 };
			//	Employee employee2 = new Employee(new DateTime(1985, 10, 20)) { Name = "Jane", Surname = "Sand", Salary = 60000 };
			//	Employee employee3 = new Employee(new DateTime(1975, 10, 20)) { Name = "Dany", Surname = "Stormborn", Salary = 70000 };
			//	Employee employee4 = new Employee(new DateTime(2005, 10, 20)) { Name = "Robb", Surname = "Stark", Salary = 55000 };
			//	Employee employee5 = new Employee(new DateTime(2015, 10, 20)) { Name = "Kiddo", Surname = "Smith", Salary = 10000 };


			//	employeeService.AddEmployee(employee1);
			//	employeeService.AddEmployee(employee2);
			//	employeeService.AddEmployee(employee3);
			//	employeeService.AddEmployee(employee4);
			//	employeeService.AddEmployee(employee5);


			//	employeeService.CheckEmployees(new DateTime(1980, 4, 23), new DateTime(2014, 02, 12), 30000);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}
			#endregion

			#region Task2
			//Hotel hotel1 = new Hotel("Sumqayit hotel");
			//Room room1 = new Room("roomname1",325,3);
			//Room room2 = new Room("roomname2", 510, 4);
			//Room room3 = new Room("roomname3", 270, 2);
			//Room room4 = new Room("roomname4", 285, 2);
			//Room room5 = new Room("roomname5", 350, 3);
			//try
			//{
			//hotel1.AddRoom(room1);
			//hotel1.AddRoom(room2);
			//hotel1.AddRoom(room3);
			//hotel1.AddRoom(room4);
			//hotel1.AddRoom(room5);
			
			////hotel1.Reserve(3);
			////.Reserve(4);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}
			//Console.WriteLine(hotel1[0]);
			//Console.WriteLine(hotel1[1]);
			//Console.WriteLine(hotel1[2]);
			//Console.WriteLine(hotel1[3]);
			//Console.WriteLine(hotel1[4]);

			//Room room6 = hotel1[1];
			//hotel1[2] = room5;

			//Console.WriteLine("\n\n");
			//Console.WriteLine(hotel1[0]);
			//Console.WriteLine(hotel1[1]);
			//Console.WriteLine(hotel1[2]);
			//Console.WriteLine(hotel1[3]);
			//Console.WriteLine(hotel1[4]);
			#endregion

			#region Task3
			//Weapon glock17 = new Weapon(17, 15, TimeSpan.FromSeconds(15), WeaponShootType.SingleShot);
			//string? operation = string.Empty;
			//    while (operation != null)
			//    {
			//        Console.WriteLine("What do u wanna do?");
			//        operation = Console.ReadLine();
			//        switch (operation)
			//        {
			//            case "0":
			//                Console.WriteLine(glock17.ToString());
			//                break;
			//            case "1":
			//                glock17.Shoot();
			//                break;
			//            case "2":
			//                glock17.Fire();
			//                break;
			//            case "3":
			//                glock17.GetRemainBulletCount();
			//                break;
			//            case "4":
			//                glock17.Reload();
			//                break;
			//            case "5":
			//                glock17.ChangeFireMode();
			//                break;
			//            case "6":
			//                operation = null;
			//                break;
			//            case "7":
			//                Console.WriteLine("Edit Gun: (T,S,D)");
			//                string editOperation = Console.ReadLine();
			//                switch (editOperation)
			//                {
			//                    case "T":
			//                        Console.WriteLine("Enter New Fire Method: ");
			//                        string newFireMethod = Console.ReadLine();
			//                        WeaponShootType fireMethod;
			//                        if (!Enum.TryParse(newFireMethod, out fireMethod))
			//                        {
			//                            Console.WriteLine(new NotFoundException("The method u have tried to enter is not valid!").Message);
			//                        }
			//                        glock17.FireMode = fireMethod;
			//                        break;
			//                    case "S":
			//                        Console.WriteLine("Enter new bullet count: ");
			//                        int newMag = int.Parse(Console.ReadLine());
			//                        glock17.BulletCapacity = newMag;
			//                        Console.WriteLine("Changed Succesfully!");
			//                        break;
			//                    case "D":
			//                        Console.WriteLine("Enter new time to spend all bullets: ");
			//                        int newSec = int.Parse(Console.ReadLine());
			//                        glock17.SecondsToFireAllBullets = TimeSpan.FromSeconds(newSec);
			//                        break;
			//                    default:
			//                        Console.WriteLine("Wrong operation!");
			//                        break;
			//                }
			//                break;
			//            default:
			//                Console.WriteLine("Wrong operation!");
			//                break;
			//        }
			//    }
			#endregion

		}
	}
}