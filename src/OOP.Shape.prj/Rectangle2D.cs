using System;

namespace Mallenom.Lessons.OOP.Shapes
{
	public class Rectangle2D : Shape2D
	{
		private double _height;
		private double _width;

		public double Width 
		{
			get
			{
				return _width;
			}
			set
			{
				if(value >= 0)
				{
					_width = value;
					Area = Width * Height;
					Perimeter = 2 * (Width + Height);
				}
			}
		}
		public double Height 
		{ 
			get
			{
				return _height;
			}
			set
			{
				if(value >= 0)
				{
					_height = value;
					Area = Width * Height;
					Perimeter = 2 * (Width + Height);
				}
			}
		}

		public override double Area { get; private protected set; }
		public override double Perimeter { get; private protected set; }

		public Rectangle2D(double x, double y, double height, double width) : base(x, y)
		{
			Width = width;
			Height = height;
		}

		public Rectangle2D(double height, double width) : base(0, 0)
		{
			Width = width;
			Height = height;
		}

		public override string ToString()
		{
			string tmp =
				base.ToString() +
				$"Width: {Width}\n" +
				$"Height: {Height}\n";
			return tmp;
		}
	}
}
