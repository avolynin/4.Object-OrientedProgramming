using System;

using Mallenom.Lessons.OOP.Shapes;

using Mallenom.Lessons.OOP.Vehicles.TypeVehicles;
using Mallenom.Lessons.OOP.Vehicles.Components;

namespace Mallenom.Lessons.OOP
{
	class Program
	{
		void ShapeCapabilityCode()
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

		static void Main(string[] args)
		{
			Car car = new Car(new FuelTank(50));
			Bus bus = new Bus(new FuelTank(70));
			Truck truck = new Truck(new FuelTank(170));

			car.fuelTank.NoFuel += delegate (string message) { Console.WriteLine(message); };

			car.CurrentSpeed = 50;
			car.Move((int)car.CurrentSpeed * 500);
		}
	}
}
