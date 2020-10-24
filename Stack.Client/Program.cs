namespace Stack.Client
{
	using DataStructure;
	using System;
	using System.Linq;
	internal class Program
	{
		private static void Main(string[] args)
		{
			Stack<int?> stack =new Stack<int?>(10);
			Console.WriteLine("Max size of stack is 10.");
			Console.WriteLine("Press 1 for push");
			Console.WriteLine("Press 2 for pop");
			Console.WriteLine("Press 3 for peek");
			Console.WriteLine("Press 4 for show stack current size");
			Console.WriteLine("Press the Escape (Esc) key to quit:");
			ConsoleKeyInfo cki;
			do
			{
				cki = Console.ReadKey();				
				try
				{
					switch (cki.KeyChar)
					{
						case '1':
							stack.Push(GetRandomNumber());
							ShowStackContents(stack);
							break;
						case '2':
							stack.Pop();
							ShowStackContents(stack);
							break;
						case '3':
							var current = stack.Peek();
							Console.WriteLine($"\nPeek is {current}");
							ShowStackContents(stack);
							break;
						case '4':							
							Console.WriteLine($"\nStack current size is {stack.Size}");
							ShowStackContents(stack);
							break;
						default:
							Console.WriteLine($"\nPlease press 1 or 2 or 3 or 4.");
							break;
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine($"\n{ex.Message}");
				}
			} while (cki.Key != ConsoleKey.Escape);
		}

		private static void ShowStackContents(Stack<int?> stack)
		{
			var stackContents = stack.GetStackContents();
			if (stackContents[0] == null)
			{
				Console.WriteLine("\nStack got empty.");
			}
			else
			{
				Console.WriteLine($"\n{string.Join(",", stackContents.Where(s => s != null))}");
			}
		}
		private static int GetRandomNumber()
		{
			Random rnd = new Random();
			return rnd.Next(1, 13);
		}
	}
}