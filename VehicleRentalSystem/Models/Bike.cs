namespace VehicleRentalSystem.Models
{
    public class Bike : Vehicle
    {
        public bool HasHelmet { get; set; }

        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} (Bike) - Helmet: {(HasHelmet ? "Included" : "Not included")} - Rate: {RentalRate:C} per day";
        }
    }
}
