
using System;

namespace Mallenom.Lessons.OOP.Shapes
{
	/// <summary>Двумерный круг.</summary>
	public class Circle2D : Shape2D
	{
		/// <summary>Радиус круга.</summary>
		private float _radius;

		/// <summary>Возвращает и устанавливает радиус круга.</summary>
		public float Radius
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
					Area = (float)(Math.PI * Math.Pow(Radius, 2));
					Perimeter = (float)(2 * Math.PI * Radius);
				}
			}
		}

		/// <summary>Создает круг на указанных координатах и с данным радиусом.</summary>
		/// <param name="x">Координата X верхнего левого угла окружности.</param>
		/// <param name="y">Координата Y верхнего левого угла окружности.</param>
		/// <param name="radius">Радиус окружности.</param>
		public Circle2D(float x, float y, float radius) : base(x, y)
		{
			Radius = radius;
		}

		/// <summary>Создает круг на нулевых координатах (X = 0, Y = 0) с данным радиусом.</summary>
		/// <param name="radius">Радиус окружности.</param>
		public Circle2D(float radius)
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
