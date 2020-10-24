using System.ComponentModel;

namespace Movement
{
	public class MovingUpStrategy : BaseMovingStrategy
	{
		public override void Move(MovingContext context)
		{
			context.MoveUp();
		}
	}
}