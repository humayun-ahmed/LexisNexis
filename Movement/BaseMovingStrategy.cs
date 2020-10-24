namespace Movement
{
	/// <summary>
	/// base strategy
	/// </summary>
	public abstract class BaseMovingStrategy
	{
		/// <summary>
		/// base move
		/// </summary>
		/// <param name="context"></param>
		public abstract void Move(MovingContext context);
	}
}