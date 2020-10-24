using System;

namespace DataStructure.StackException
{
	public class ExceededSizeException : Exception
	{
		public ExceededSizeException() : base("Exceeds the size of the Stack.")
		{
		}
	}
}