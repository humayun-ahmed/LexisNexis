using System.ComponentModel;

namespace Movement
{
	/// <summary>
	/// down strategy
	/// </summary>
	public class MovingDownStrategy : BaseMovingStrategy
	{
		/// <summary>
		/// Down move
		/// </summary>
		/// <param name="context">object need to be move</param>
		public override void Move(MovingContext context)
		{
			context.MoveDown();
		}
	}
}