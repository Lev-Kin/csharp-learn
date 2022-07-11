
namespace ProjectCSharp
{
    abstract class Transport
    {
        public abstract int this[string type] { get; }
        public abstract int Count { get; }
        public abstract int Seat { get; }

        public string IdVehicle { get; set; }
        public string PointOfDeparture { get; set; }
        public string Destination { get; set; }

        protected int[] price;

        protected Transport(string idVehicle, string pointOfDeparture, string destination)
        {
            IdVehicle = idVehicle;
            PointOfDeparture = pointOfDeparture;
            Destination = destination;
        }

        public virtual void Show() { }
    }
}
