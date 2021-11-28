using Mallenom.Lessons.OOP.Vehicles.Components;

namespace Mallenom.Lessons.OOP.Vehicles.TypeVehicles
{
	public class Bus : Vehicle
	{
		private float maxDistance = 150;

		public Bus(FuelTank fuelTank)
		{
			fuelTank.AverageFuelConsumption = fuelTank.MaxAmoutFuel / maxDistance;
			createFuelTank(fuelTank);
		}
	}
}
