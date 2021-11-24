using System;

namespace Mallenom.Lessons.OOP.Shapes
{
	/// <summary>Базовый класс для двумерных фигур.</summary>
	public abstract class Shape2D : IMovable
	{		
		/// <summary>Площадь фигуры.</summary>
		private float _area;
		/// <summary>Периметр фигуры.</summary>
		private float _perimeter;

		/// <summary>Возвращает и устанавливает X координату.</summary>
		public float X { get; private protected set; }
		/// <summary>Возвращает и устанавливает Y координату.</summary>
		public float Y { get; private protected set; }
		/// <summary>Возвращает и устанавливает площадь фигуры.</summary>
		public virtual float Area { get; private protected set; }
		/// <summary>Возвращает и устанавливает периметр фигуры.</summary>
		public virtual float Perimeter { get; private protected set; }

		/// <summary>Базовый конструктор для создания фигур на нулевых координатах (X = 0, Y = 0).</summary>
		public Shape2D() : this(0, 0)
		{

		}
		/// <summary>Базовый конструктор для создания фигур на указанных координатах.</summary>
		public Shape2D(float x, float y)
		{
			MoveTo(x, y);
		}

		/// <summary>Перемещает фигуру на указанные координаты.</summary>
		/// <param name="x">Новая координата X верхнего левого угла фигуры.</param>
		/// <param name="y">Новая координата Y верхнего левого угла фигуры.</param>
		public void MoveTo(float x, float y)
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
