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
        private static Room[] Rooms = new Room[0];

        public void AddRoom(Room room)
        {
            foreach (var currentRoom in Rooms)
            {
                if (room.Name == currentRoom.Name)
                {
                    throw new Conflict("You can not add the room with same name!");
                }
			}
			Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room;
            Console.WriteLine("Room has been added.");
        }

        public void Reserve(int? roomId)
        {
            bool isFound = false;
            foreach(var room in Rooms)
            {
                if(room.Id == roomId)
                {
                    if (room.IsAvailable)
                    {
                        isFound = true;
                        room.IsAvailable = false;
                        Console.WriteLine("Room has been reserved.");
                    }
                    else
                        throw new NotAvailableException("Room is not available.");
                }
            }
            if(!isFound)
                throw new NotFoundException("Room with this id is not found.");
        }

        public Room this[int index]
        {
            get
            {
                return Rooms[index];
            }
            set
            {
				Rooms[index] = value;
			}
        }

        public Hotel(string name)
        {
            Name = name;
        }
    }
}
