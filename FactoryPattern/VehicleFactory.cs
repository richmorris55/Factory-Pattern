using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
		public static IVehicle GetVehicle(int tireQuantity)
		{
			switch (tireQuantity)
			{
				case 4 :
					return new Automobile();

				case 2 :
					return new Utv();
				default:
					return new Automobile();
			}

		}
	}
}

