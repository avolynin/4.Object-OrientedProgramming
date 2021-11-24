using System;

namespace Mallenom.Lessons.OOP.Shapes
{
	/// <summary>Двумерный прямоугольник.</summary>
	public class Rectangle2D : Shape2D
	{
		/// <summary>Высота прямоугольника.</summary>
		private float _height;
		/// <summary>Ширина прямоугольника.</summary>
		private float _width;

		/// <summary>Возвращает и устанавливает ширину прямоугольника.</summary>
		public float Width 
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
		/// <summary>Возвращает и устанавливает высоту прямоугольника.</summary>
		public float Height 
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

		/// <summary>Создает прямоугольник на указанных координатах с данной длиной и шириной.</summary>
		/// <param name="x">Координата X верхнего левого угла прямоугольника.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника.</param>
		/// <param name="height">Высота прямоугольника.</param>
		/// <param name="width">Ширина прямоугольника.</param>
		public Rectangle2D(float x, float y, float height, float width) : base(x, y)
		{
			Width = width;
			Height = height;
		}

		/// <summary>Создает прямоугольник на нулевых координатах (X = 0, Y = 0) с данной длиной и шириной.</summary>
		/// <param name="height">Высота прямоугольника.</param>
		/// <param name="width">Ширина прямоугольника.</param>
		public Rectangle2D(float height, float width)
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
