namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tireQuantity;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires the vehicle you want to build has.");
                input = int.TryParse(Console.ReadLine(), out tireQuantity);
            } while (input == false);

            var vehicles = VehicleFactory.GetVehicle(tireQuantity);

            vehicles.Drive();

            
        }
    }
}
