
using System;

namespace Mallenom.Lessons.OOP.Shapes
{
	public class Circle2D : Shape2D
	{
		private double _radius;

		public double Radius
		{
			get
			{
				return _radius;
			}
			set
			{
				if(value >= 0)
				{
					_radius = value;
					Area = Math.PI * Math.Pow(Radius, 2);
					Perimeter = 2 * Math.PI * Radius;
				}
			}
		}

		public Circle2D(double x, double y, double radius) : base(x, y)
		{
			Radius = radius;
		}

		public Circle2D(double radius) : base(0, 0)
		{
			Radius = radius;
		}

		public override string ToString()
		{
			string tmp =
				base.ToString() +
				$"Radius: {Radius}\n";
			return tmp;
		}
	}
}
