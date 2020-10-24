using System.Collections.Generic;

namespace Movement
{
	/// <summary>
	/// movement object
	/// </summary>
	public class MovingContext
	{
		private readonly BaseMovingStrategy _strategy;
		private readonly List<string> moveList = new List<string>();

		/// <summary>
		/// movement object initialization
		/// </summary>
		/// <param name="strategy"></param>
		public MovingContext(BaseMovingStrategy strategy)
		{
			_strategy = strategy;
		}

		private string moveName { get; set; }

		/// <summary>
		/// moving
		/// </summary>
		/// <returns>movement report</returns>
		public string Move()
		{
			_strategy.Move(this);
			BuildMovement();
			return moveName;
		}

		/// <summary>
		/// moveup
		/// </summary>
		internal void MoveUp()
		{
			moveList.Add("Up");
		}

		/// <summary>
		/// move down
		/// </summary>
		internal void MoveDown()
		{
			moveList.Add("Down");
		}

		/// <summary>
		/// move left
		/// </summary>
		internal void MoveLeft()
		{
			moveList.Add("Left");
		}

		/// <summary>
		/// move right
		/// </summary>
		internal void MoveRight()
		{
			moveList.Add("Right");
		}

		private void BuildMovement()
		{
			if (moveList.Count == 1)
				moveName = $"Basic {moveList[0]} Move";
			else if (moveList.Count > 1) moveName = $"{string.Join(" ", moveList)} Combo Move";
		}
	}
}