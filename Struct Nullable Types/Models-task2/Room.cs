using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Nullable_Types.Models
{
    internal class Room
    {
        private static int ID;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }
        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            ID++;
            Id = ID;
            IsAvailable = true;
        }

        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Person Capacity: {PersonCapacity}, Is Available: {IsAvailable}";
        }
        override public string ToString()
        {
            return ShowInfo();
        }



    }
}
