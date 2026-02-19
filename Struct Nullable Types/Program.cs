using Struct_Nullable_Types.Models;
using System.Dynamic;
using Struct_Nullable_Types.Enums;

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
            //Console.WriteLine();
            //// employees[0].CheckEmployees(new DateTime(1950, 4, 23),new DateTime(2026,02,12),2000);
            //Employee.CheckEmployees(employees,new DateTime(1950, 4, 23), new DateTime(2026, 02, 12), 2000);

            #endregion

            //Need some changes in task2 bc we dont have indexer in hotel part
            #region Task2



            #endregion

            #region Task3
            Weapon glock17 = new Weapon(17,15,TimeSpan.FromSeconds(15),WeaponShootType.SingleShot);
            //glock17.Fire();
            glock17.GetRemainBulletCount();
            Console.WriteLine(glock17);
            Console.WriteLine("What do u wanna do?");
            char? operation = char.Parse(Console.ReadLine());
            while (operation!=null)
            {
                Console.WriteLine("What do u wanna do?");
                operation = char.Parse(Console.ReadLine());
                switch (operation)
                {
                    case '0':
                        break;
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case 'T':
                        break;
                    case 'S':
                        break;
                    case 'D':
                        break;
                }
            }
            #endregion
        }
    }
}