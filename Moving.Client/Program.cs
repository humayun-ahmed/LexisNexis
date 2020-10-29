using System;
using Movement;

namespace Moving.Client
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			
			Console.WriteLine("Write Up/Down/Left/Right/Combo (case sensitive) for move, 'e' for exit");

			MovingContext context = new MovingContext();
			while (true) 
			{
				try
				{
					var line = Console.ReadLine();
					if (line == "e")
					{
						break;
					}

					/*//if need dynamically find the strategy by using attribute or Mediator pattern
					var strategyType = typeof(BaseMovingStrategy).Assembly.GetTypes().FirstOrDefault(t => t.Name == $"Moving{line}Strategy");
					if(strategyType!=null)
						moveName = new MovingContext(Activator.CreateInstance(strategyType) as BaseMovingStrategy).Move();
						*/
					context.SetStrategy(StrategyFactory.GetStrategy(line));
					var moveName = context.Move();

					if (!string.IsNullOrEmpty(moveName))
					{
						Console.WriteLine(moveName);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
				}
			}
		}
	}
}