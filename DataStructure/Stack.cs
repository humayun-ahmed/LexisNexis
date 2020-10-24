using DataStructure.StackException;

namespace DataStructure
{
	/// <summary>
	/// stack implementation for generic type object
	/// Following features not supported
	/// 1. Dynamic array size which is different implmentation, not given as maximumLenth requirement defined
	/// 2. Not thread safe
	/// 3. No distributed environment supported
	/// </summary>
	/// <typeparam name="T">generic type</typeparam>
	public class Stack<T>
	{
		private readonly int maximumLength;
		private readonly T[] stackArray;

		/// <summary>
		/// initialization of stack
		/// </summary>
		/// <param name="maximumLength">maximum size of stack</param>
		public Stack(int maximumLength)
		{
			this.maximumLength = maximumLength;
			this.stackArray = new T[this.maximumLength];
			this.Size = 0;
		}

		/// <summary>
		/// Size of the stack
		/// </summary>
		public int Size { get; private set; }

		/// <summary>
		/// Push to stack
		/// </summary>
		/// <param name="value">pushed data</param>
		public void Push(T value)
		{
			if (Size < maximumLength)
				stackArray[Size++] = value;
			else
				throw new ExceededSizeException();
		}

		/// <summary>
		/// pop from stack
		/// </summary>
		/// <returns>pooped data</returns>
		public T Pop()
		{
			if (Size == 0)
				throw new ExpenditureProhibitedException();
			var currentData = stackArray[--Size];
			stackArray[Size] = default(T);
			return currentData;
		}

		/// <summary>
		/// peek last data of stack
		/// </summary>
		/// <returns>last data</returns>
		public T Peek()
		{
			if (Size == 0)
				throw new ExpenditureProhibitedException();
			return stackArray[Size - 1];
		}

		/// <summary>
		/// get all elements of stack
		/// </summary>
		/// <returns>all elements of stack</returns>
		public T[] GetStackContents()
		{
			return stackArray;
		}
	}
}