using System;

namespace Mallenom.Lessons.OOP.Shapes
{
	public class Square2D : Shape2D
	{
		private double _sideSize;
		
		public override double Area { get; private protected set; }
		public override double Perimeter { get; private protected set; }

		public double SideSize
		{
			get
			{
				return _sideSize;
			}
			set
			{
				if(value >= 0)
				{
					_sideSize = value;
					Area = Math.Pow(SideSize, 2);
					Perimeter = 4 * SideSize;
				}
			}
		}

		public Square2D(double sideSize) : base(0, 0)
		{
			SideSize = sideSize;
		}
		public Square2D(double x, double y, double sideSize) : base(x, y)
		{
			SideSize = sideSize;
		}

		public override string ToString()
		{
			string tmp =
				base.ToString() +
				$"Width: {SideSize}\n" +
				$"Height: {SideSize}\n";
			return tmp;
		}
	}
}
