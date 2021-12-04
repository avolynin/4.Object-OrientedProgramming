using Mallenom.Lessons.OOP.Vehicles.Components;

namespace Mallenom.Lessons.OOP.Vehicles.TypeVehicles
{
	public class Car : Vehicle
	{
		public Car(float maxSpeed, FuelTank fuelTank) : base(maxSpeed, fuelTank)
		{
			fuelTank.MaxDistance = 500;
		}
	}
}
