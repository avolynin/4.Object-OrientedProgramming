using Mallenom.Lessons.OOP.Vehicles.Components;

namespace Mallenom.Lessons.OOP.Vehicles.TypeVehicles
{
	public class Truck : Vehicle
	{
		private float maxDistance = 250;

		public Truck(FuelTank fuelTank)
		{
			fuelTank.AverageFuelConsumption = fuelTank.MaxAmoutFuel / maxDistance;
			createFuelTank(fuelTank);
		}
	}
}
