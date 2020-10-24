using DataStructure.StackException;
using NUnit.Framework;

namespace DataStructure.Tests
{
	[TestFixture]
	public class StackTest
	{
		private const int MAX = 3;

		[Test]
		public void Creation()
		{
			var s = new Stack<int>(MAX);
			Assert.AreEqual(0, s.Size);
		}

		[Test]
		public void Peek_Element()
		{
			var s = new Stack<int>(MAX);
			s.Push(7);
			s.Push(2);
			var value = s.Peek();
			Assert.AreEqual(2, value);
			Assert.AreEqual(2, s.Size);
		}

		[Test]
		public void Peek_Exception()
		{
			var s = new Stack<int>(MAX);
			Assert.Throws<ExpenditureProhibitedException>(() => s.Peek());
		}

		[Test]
		public void Push_Pop()
		{
			var s = new Stack<int>(MAX);
			s.Push(7);
			s.Push(8);
			s.Push(3);
			var value = s.Pop();
			Assert.AreEqual(3, value);
			Assert.AreEqual(2, s.Size);
		}

		[Test]
		public void Too_Much_Pop()
		{
			var s = new Stack<int>(MAX);
			Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());
		}

		[Test]
		public void Too_Much_Push()
		{
			var s = new Stack<int>(MAX);
			s.Push(1);
			s.Push(1);
			s.Push(1);
			Assert.Throws<ExceededSizeException>(() => s.Push(3));
		}
	}
}