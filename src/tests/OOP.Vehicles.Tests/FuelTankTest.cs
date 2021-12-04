using NUnit.Framework;

using Mallenom.Lessons.OOP.Vehicles.Components;
using Mallenom.Lessons.OOP.Vehicles.Items;

using Moq;

namespace OOP.Vehicles.Tests
{
	[TestFixture]
	class FuelTankTest
	{
		private FuelTank _fuelTank;
		public bool wasCalled;

		[SetUp]
		public void SetUp()
		{
			wasCalled = false;
			_fuelTank = new FuelTank(100);
			_fuelTank.NoFuel += delegate { wasCalled = true; };
		}
		[Test]
		public void NoFuel_AmoutFuel0_Called()
		{
			_fuelTank.AmoutFuel = 0;

			Assert.IsTrue(wasCalled);
		}
		[Test]
		public void NoFuel_AmoutFuel1_NoCalled()
		{
			_fuelTank.AmoutFuel = 1;

			Assert.IsFalse(wasCalled);
		}
	}
}
