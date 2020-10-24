using System.ComponentModel;

namespace Movement
{
	/// <summary>
	/// Left strategy
	/// </summary>
	public class MovingLeftStrategy : BaseMovingStrategy
	{
		/// <summary>
		/// Left move
		/// </summary>
		/// <param name="context">object need to be move</param>
		public override void Move(MovingContext context)
		{
			context.MoveLeft();
		}
	}
}