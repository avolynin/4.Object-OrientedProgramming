using System;

namespace Mallenom.Lessons.OOP.Shapes
{
	/// <summary>Двумерный квадрат.</summary>
	public class Square2D : Shape2D
	{
		/// <summary>Длина сторон квадрата.</summary>
		private float _sideSize;

		/// <summary>Возвращает и устанавливает длину сторон квадрата.</summary>
		public float SideSize
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
					Area = (float)Math.Pow(SideSize, 2);
					Perimeter = 4 * SideSize;
				}
			}
		}

		/// <summary>Создает квадрат на нулевых координатах (X = 0, Y = 0) с данной длиной сторон.</summary>
		/// <param name="sideSize">Длина сторон квадрата.</param>
		public Square2D(float sideSize)
		{
			SideSize = sideSize;
		}
		/// <summary>Создает квадрат на указанных координатах с данной длиной сторон.</summary>
		/// <param name="x">Координата X верхнего левого угла квадрата.</param>
		/// <param name="y">Координата Y верхнего левого угла квадрата.</param>
		/// <param name="sideSize">Длина сторон квадрата.</param>
		public Square2D(float x, float y, float sideSize) : base(x, y)
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
