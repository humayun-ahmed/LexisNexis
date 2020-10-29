using System;

namespace Movement
{
	public class WrongMovementException: Exception
	{
		public WrongMovementException():base("Wrong movement!!!")
		{
			
		}
	}
}
