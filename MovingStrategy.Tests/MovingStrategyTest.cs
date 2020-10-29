using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movement;

namespace MovingStrategy.Tests
{
	[TestClass]
	public class MovingStrategyTest
	{
		[TestMethod]
		public void TestMove_MoveUp_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Up"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Up Move"),"Up movement failed");
		}

		[TestMethod]
		public void TestMove_MoveDown_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Down"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Down Move"), "Down movement failed");
		}

		[TestMethod]
		public void TestMove_MoveLeft_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Left"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Left Move"), "Left movement failed");
		}

		[TestMethod]
		public void TestMove_MoveRight_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Right"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Right Move"), "Right movement failed");
		}

		[TestMethod]
		public void TestMove_MoveCombo_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Combo"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Up Up Down Down Combo Move"), "Combo movement failed");
		}

		[TestMethod]
		[ExpectedException(typeof(WrongMovementException))]
		public void TestMove_WrongMovement_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("!@$%"));
			var moveName = context.Move();
		}
	}
}
