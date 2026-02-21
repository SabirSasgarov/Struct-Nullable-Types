using Struct_Nullable_Types.Enums;
using Struct_Nullable_Types.Exceptions;
using Struct_Nullable_Types.Models;
using System.Dynamic;
using System.Threading.Tasks;

namespace Struct_Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Need some changes in task1 bc we dont have proper method
            #region Task1

            //Employee[] employees = new Employee[2];
            //employees[0] = new Employee(new DateTime(1990, 5, 15)) { Name = "John", Surname = "Doe", Salary = 50000 };
            //employees[1] = new Employee(new DateTime(1985, 10, 20)) { Name = "Jane", Surname = "Smith", Salary = 60000 };
            //// employees[0].CheckEmployees(new DateTime(1950, 4, 23), new DateTime(2026,02,12), 2000);
            //Employee.CheckEmployees(employees, new DateTime(1987, 4, 23), new DateTime(2026, 02, 12), 2000);

            #endregion

            //Need some changes in task2 bc we dont have indexer in hotel part
            #region Task2



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