using System;
namespace FactoryPattern
{
	public class Utv : IVehicle
	{
		public Utv()
		{
		}

        public void Drive()
        {
            Console.WriteLine("Building a new Utv.");
        }
    }
}

