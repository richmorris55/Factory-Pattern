using System;
namespace FactoryPattern
{
	public class Automobile : IVehicle
	{
		public Automobile()
		{
		}

        public void Drive()
        {
            Console.WriteLine("Building a new Automobile");
        }
    }
}

