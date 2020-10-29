using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement
{
	public class StrategyFactory
	{
		public static BaseMovingStrategy GetStrategy(string movement)
		{
			switch (movement)
			{
				case "Up":
					return new MovingUpStrategy();
				case "Down":
					return new MovingDownStrategy();
				case "Left":
					return new MovingLeftStrategy();
				case "Right":
					return new MovingRightStrategy();
				case "Combo":
					return new MovingComboStrategy();
				default:
					throw new WrongMovementException();
			}
		}
	}
}
