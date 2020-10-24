using System;

namespace DataStructure.StackException
{
	public class ExpenditureProhibitedException : Exception
	{
		public ExpenditureProhibitedException() : base("Stack is empty.")
		{
		}
	}
}