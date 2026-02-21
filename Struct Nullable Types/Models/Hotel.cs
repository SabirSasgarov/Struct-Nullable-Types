using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Struct_Nullable_Types.Exceptions;

namespace Struct_Nullable_Types.Models
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms = new Room[0];

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room;
            Console.WriteLine("Room has been added.");
        }

        public void Reserve(int? roomId)
        {
            foreach(var room in Rooms)
            {
                if(room.Id == roomId)
                {
                    if (room.IsAvailable)
                    {
                        room.IsAvailable = false;
                        Console.WriteLine("Room has been reserved.");
                    }
                    throw new NotAvailableException("Room is not available.");
                }
                throw new NotFoundException("Room with this id is not found.");

            }
        }


        public Hotel this[int index]
        {
            get
            {
                return new Hotel("salam");
            }
        }

        public Hotel(string name)
        {
            Name = name;
        }
    }
}
