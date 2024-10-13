namespace VehicleRentalSystem.Models
{
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; } // In kilograms

        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} (Truck) - Capacity: {LoadCapacity} kg - Rate: {RentalRate:C} per day";
        }
    }
}
