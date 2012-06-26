using System;
using NUnit.Framework;

namespace GameUtils
{
	[TestFixture]
	public class TestDice
	{
		Dice rng;

		[SetUp]
		public void Init ()
		{
			rng = new Dice (17);
		}
					
		[Test]
		public void CheckScore ()
		{
			int score = rng.Roll (3);
			Assert.That (score, Is.EqualTo (9));
		}

	}
}

