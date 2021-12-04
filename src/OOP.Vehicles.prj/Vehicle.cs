using System;

using Mallenom.Lessons.OOP.Vehicles.Components;
using Mallenom.Lessons.OOP.Vehicles.Items;

namespace Mallenom.Lessons.OOP.Vehicles
{
	public class Vehicle : IMovable
	{
		private float _currentSpeed;
		
		public float MaxSpeed { get; set; }
		

		public FuelTank fuelTank;

		public string RegistrationPlates { get; set; }
		public float Mileage { get; private set; }
		public float CurrentSpeed 
		{ 
			get
			{
				return _currentSpeed;
			}
			set
			{
				if(value <= MaxSpeed && value >= 0)
				{
					_currentSpeed = value;
				}
			}
		}

		public Vehicle(float maxSpeed, FuelTank fuelTank = null)
		{
			MaxSpeed = maxSpeed;
			this.fuelTank = fuelTank;
		}

		public float Move(int hours)
		{
			float distance = hours * CurrentSpeed;
			fuelTank.AmoutFuel -= fuelTank.AverageFuelConsumption * distance;
			Mileage += distance;
			return distance;
		}
	}
}
