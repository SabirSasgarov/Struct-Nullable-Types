using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Nullable_Types.Exceptions
{
	internal class Conflict : Exception
	{
		public Conflict(string Message) : base(Message)
		{	
		}
	}
}
