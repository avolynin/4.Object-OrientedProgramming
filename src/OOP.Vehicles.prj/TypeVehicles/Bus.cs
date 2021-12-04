using Mallenom.Lessons.OOP.Vehicles.Components;

namespace Mallenom.Lessons.OOP.Vehicles.TypeVehicles
{
	public class Bus : Vehicle
	{
		public Bus(float maxSpeed, FuelTank fuelTank) : base(maxSpeed, fuelTank)
		{
			fuelTank.MaxDistance = 150;
		}
	}
}
