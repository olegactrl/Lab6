namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork transportNetwork = new TransportNetwork();
            Car car = new Car { Speed = 90, Capacity = 6, Type = "tesla" };
            Bus bus = new Bus { Speed = 80, Capacity = 12, Seats = 50 };
            Train train = new Train { Speed = 70, Capacity = 24, Number = 10 };
            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);
            transportNetwork.MoveAllVehicles();
        }
    }
}