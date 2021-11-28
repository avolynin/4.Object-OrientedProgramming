using Mallenom.Lessons.OOP.Vehicles.Components;

namespace Mallenom.Lessons.OOP.Vehicles.TypeVehicles
{
	public class Car : Vehicle
	{
		private float maxDistance = 500;

		public Car(FuelTank fuelTank)
		{
			fuelTank.AverageFuelConsumption = fuelTank.MaxAmoutFuel / maxDistance;
			createFuelTank(fuelTank);
		}
	}
}
