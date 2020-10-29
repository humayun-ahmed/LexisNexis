using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Movement;


namespace MovingStrategy.Tests
{
	[TestFixture]
	public class MovingStrategyTest
	{
		[Test]
		public void TestMove_MoveUp_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Up"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Up Move"),"Up movement failed");
		}

		[Test]
		public void TestMove_MoveDown_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Down"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Down Move"), "Down movement failed");
		}

		[Test]
		public void TestMove_MoveLeft_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Left"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Left Move"), "Left movement failed");
		}

		[Test]
		public void TestMove_MoveRight_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Right"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Basic Right Move"), "Right movement failed");
		}

		[Test]
		public void TestMove_MoveCombo_Success()
		{
			MovingContext context = new MovingContext();

			context.SetStrategy(StrategyFactory.GetStrategy("Combo"));
			var moveName = context.Move();
			Assert.IsTrue(moveName.Equals("Up Up Down Down Combo Move"), "Combo movement failed");
		}

		[Test]
		public void TestMove_WrongMovement_Success()
		{
			Assert.Throws<WrongMovementException>(() => StrategyFactory.GetStrategy("!@$%"));
		}
	}
}
