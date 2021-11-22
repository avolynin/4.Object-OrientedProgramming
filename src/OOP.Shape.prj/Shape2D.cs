using System;

using Mallenom.Lessons.OOP.Shared;

namespace Mallenom.Lessons.OOP.Shapes
{
	public abstract class Shape2D : IMovable
	{
		public double X { get; private protected set; }
		public double Y { get; private protected set; }
		public virtual double Area { get; private protected set; }
		public virtual double Perimeter { get; private protected set; }

		public Shape2D(double startX, double startY)
		{
			MoveTo(startX, startY);
		}

		public void MoveTo(double x, double y)
		{
			X = x;
			Y = y;
		}

		public override string ToString()
		{
			string tmp =
				$"Name: {GetType().Name}\n" +
				$"Position: ({X}, {Y})\n";
			return tmp;
		}
	}
}
