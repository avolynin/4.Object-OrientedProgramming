using Mallenom.Lessons.OOP.Vehicles.Components;

namespace Mallenom.Lessons.OOP.Vehicles.TypeVehicles
{
	public class Truck : Vehicle
	{
		public Truck(float maxSpeed, FuelTank fuelTank) : base(maxSpeed, fuelTank)
		{
			fuelTank.MaxDistance = 250;
		}
	}
}
