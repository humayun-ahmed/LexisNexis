using System.ComponentModel;

namespace Movement
{
	/// <summary>
	/// combo strategy
	/// </summary>
	public class MovingComboStrategy : BaseMovingStrategy
	{
		/// <summary>
		/// combo move
		/// </summary>
		/// <param name="context">object need to be move</param>
		public override void Move(MovingContext context)
		{
			/*Combo also can be more dynamic instead instead of below only 4 movements, if we take these trigger from input, if no input then different combo strategy need to add*/
			context.MoveUp();
			context.MoveUp();
			context.MoveDown();
			context.MoveDown();
		}
	}
}