namespace VehicleRentalSystem.Models
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public string FuelType { get; set; }

        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} (Car) - {FuelType}, {NumberOfDoors} doors - Rate: {RentalRate:C} per day";
        }
    }
}
