using ParkingGarage_AlsoEnergy.Models.Parking;

namespace ParkingGarage_AlsoEnergy.Models.Vehicle
{
    public class Car : Vehicle
    {
        public override string Type { get; set; } = "Car";
        public override VehicleParkingSpot.ParkingSpotTypes[] ParkingSpaceAllowables { get; set; } = { VehicleParkingSpot.ParkingSpotTypes.Compact, VehicleParkingSpot.ParkingSpotTypes.Large };
        public override int? Size { get; set; } = 1;
    }
}
