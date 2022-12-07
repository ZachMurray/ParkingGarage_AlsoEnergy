namespace ParkingGarage_AlsoEnergy.Models.Parking
{
    public class VehicleParkingSpot
    {
        public enum ParkingSpotTypes { Motorcycle, Compact, Large };
        public ParkingSpotTypes? ParkingSpot { get; set; } = null;
    }
}
