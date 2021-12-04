using System;

using Mallenom.Lessons.OOP.Shapes;

using Mallenom.Lessons.OOP.Vehicles.TypeVehicles;
using Mallenom.Lessons.OOP.Vehicles.Components;
using Mallenom.Lessons.OOP.Vehicles.Items;

namespace Mallenom.Lessons.OOP
{
	class Program
	{
		static void ShapeCapabilityCode()
		{
			Circle2D circle = new Circle2D(50, 50, 10);
			Rectangle2D rectangle = new Rectangle2D(10, 20);
			Shape2D square = new Square2D(25);

			Shape2D[] shapes = new Shape2D[3] { circle, rectangle, square };

			rectangle.MoveTo(100, 100);
			((Square2D)square).SideSize = 10;
			circle.Radius = 5;

			foreach(var shape in shapes)
			{
				Console.Write(shape);
				Console.WriteLine($"Area: {shape.Area}; Perimeter: {shape.Perimeter};\n");
			}
		}

		static void VehicleCapabilityCode()
		{
			Car car = new Car(120, new FuelTank(50));
			Bus bus = new Bus(60, new FuelTank(70));
			Truck truck = new Truck(100, new FuelTank(170));

			car.fuelTank.NoFuel += delegate (string message) { Console.WriteLine(message); };

			car.CurrentSpeed = 1.0f;
			car.fuelTank.FillUp(TypeFuel.PETROL_95, car.fuelTank.MaxAmoutFuel);

			car.Move((int)Math.Ceiling(500 / car.CurrentSpeed));
		}

		static void Main(string[] args)
		{
			ShapeCapabilityCode();
			VehicleCapabilityCode();
		}
	}
}
