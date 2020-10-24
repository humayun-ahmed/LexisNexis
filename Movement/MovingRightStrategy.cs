using System.ComponentModel;

namespace Movement
{
	/// <summary>
	/// Right strategy
	/// </summary>
	public class MovingRightStrategy : BaseMovingStrategy
	{
		/// <summary>
		/// Right move
		/// </summary>
		/// <param name="context">object need to be move</param>
		public override void Move(MovingContext context)
		{
			context.MoveRight();
		}
	}
}