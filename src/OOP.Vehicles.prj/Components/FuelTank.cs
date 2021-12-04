using System;

using Mallenom.Lessons.OOP.Vehicles.Items;

namespace Mallenom.Lessons.OOP.Vehicles.Components
{
	public class FuelTank
	{
		public delegate void FuelTankHandler(string message);
		public event FuelTankHandler NoFuel;
		public event FuelTankHandler InvalidTypeFuel;

		private int _maxDistance;
		internal int MaxDistance
		{
			get
			{
				return _maxDistance;
			}
			set
			{
				_maxDistance = value;
				AverageFuelConsumption = MaxAmoutFuel / _maxDistance;
			}
		}
		public float AverageFuelConsumption { get; set; }
		public float MaxAmoutFuel { get; }
		private float _amountFuel;
		private TypeFuel? _typeFuel;

		public float AmoutFuel
		{
			get
			{
				return _amountFuel;
			}
			set
			{
				if(value <= 0.0f)
				{
					_amountFuel = 0;
					_typeFuel = null;
					NoFuel?.Invoke("Топливо отсутствует");
				}
				else if(value <= MaxAmoutFuel && value > 0)
				{
					_amountFuel = value;
				}
			}
		}
		public TypeFuel? TypeFuel
		{
			get
			{
				return _typeFuel;
			}
			private set
			{
				if(value == _typeFuel || _amountFuel > 0.0f) _typeFuel = value;
				else if (_amountFuel <= 0.0f)
				{
					_typeFuel = null;
					InvalidTypeFuel?.Invoke("Количество топлива равно нулю");
				}
				else InvalidTypeFuel?.Invoke("Тип топлива не совпадает с существующим");
			}
		}

		public FuelTank(float maxAmoutFuel, TypeFuel? typeFuel = null, float amoutFuel = 0.0f)
		{
			MaxAmoutFuel = maxAmoutFuel;
			FillUp(typeFuel, amoutFuel);
		}

		public void FillUp(TypeFuel? typeFuel, float amoutFuel)
		{
			TypeFuel = typeFuel;
			AmoutFuel = amoutFuel;
		}
	}
}
