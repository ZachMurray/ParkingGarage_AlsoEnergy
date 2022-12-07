using ParkingGarage_AlsoEnergy.Models.Parking;

namespace ParkingGarage_AlsoEnergy.Models.Vehicle
{
    public abstract class Vehicle
    {
        public int Id = UUID_Ticketer.IncrementId();
        public virtual string Type { get; set; } = "Vehicle";
        public virtual VehicleParkingSpot.ParkingSpotTypes[] ParkingSpaceAllowables { get; set; } = { };
        public virtual int? Size { get; set; } = 1;
    }

    public static class UUID_Ticketer
    {
        private static int id = 1;
        public static int IncrementId()
        {
            return id++;
        }
    }
}
