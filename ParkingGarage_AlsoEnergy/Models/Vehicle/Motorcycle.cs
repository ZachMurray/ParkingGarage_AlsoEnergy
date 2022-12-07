using ParkingGarage_AlsoEnergy.Models.Parking;

namespace ParkingGarage_AlsoEnergy.Models.Vehicle
{
    public class Motorcycle : Vehicle
    {
        public override string Type { get; set; } = "Motorcycle";
        public override VehicleParkingSpot.ParkingSpotTypes[] ParkingSpaceAllowables { get; set; } = { VehicleParkingSpot.ParkingSpotTypes.Motorcycle, VehicleParkingSpot.ParkingSpotTypes.Compact, VehicleParkingSpot.ParkingSpotTypes.Large };
        public override int? Size { get; set; } = 1;
    }
}