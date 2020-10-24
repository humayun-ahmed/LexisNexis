using System;
using Movement;

namespace Moving.Client
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var moveName = string.Empty;
			Console.WriteLine("Write Up/Down/Left/Right/Combo (case sensitive) for move, 'e' for exit");

			while (true) 
			{
				string line = Console.ReadLine(); 
				if (line == "e") 
				{
					break;
				}

				/*//if need dynamically find the strategy
				var strategyType = typeof(BaseMovingStrategy).Assembly.GetTypes().FirstOrDefault(t => t.Name == $"Moving{line}Strategy");
				if(strategyType!=null)
					moveName = new MovingContext(Activator.CreateInstance(strategyType) as BaseMovingStrategy).Move();
					*/
				switch (line)
				{
					case "Up":
						moveName = new MovingContext(new MovingUpStrategy()).Move();
						break;
					case "Down":
						moveName = new MovingContext(new MovingDownStrategy()).Move();
						break;
					case "Left":
						moveName = new MovingContext(new MovingLeftStrategy()).Move();
						break;
					case "Right":
						moveName = new MovingContext(new MovingRightStrategy()).Move();
						break;
					case "Combo":
						moveName = new MovingContext(new MovingComboStrategy()).Move();
						break;
					default:
						Console.WriteLine("\nWrong movement value.");
						break;
				}
				if (!string.IsNullOrEmpty(moveName))
				{
					Console.WriteLine(moveName);
					moveName = string.Empty;
				}
			}
		}
	}
}