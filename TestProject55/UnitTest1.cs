namespace TransformToPrime
{
	using NUnit.Framework;
	using System;
	using System.Linq;

	[TestFixture]
	public class Tests
	{
		[Test]
		public void BasicTests()
		{
			Assert.AreEqual(1, Solution.MinimumNumber(new int[] { 3, 1, 2 }));
			Assert.AreEqual(0, Solution.MinimumNumber(new int[] { 5, 2 }));
			Assert.AreEqual(0, Solution.MinimumNumber(new int[] { 1, 1, 1 }));
			Assert.AreEqual(5, Solution.MinimumNumber(new int[] { 2, 12, 8, 4, 6 }));
			Assert.AreEqual(2, Solution.MinimumNumber(new int[] { 50, 39, 49, 6, 17, 28 }));
		}
	}
}