using System;

using Mallenom.Lessons.OOP.Shapes;

namespace Mallenom.Lessons.OOP
{

	class Program
	{
		static void Main(string[] args)
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
	}
}
