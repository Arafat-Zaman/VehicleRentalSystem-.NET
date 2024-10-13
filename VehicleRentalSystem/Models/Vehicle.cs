namespace VehicleRentalSystem.Models
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalRate { get; set; } // Rate per day

        public virtual string GetVehicleInfo()
        {
            return $"{Brand} {Model} - Rate: {RentalRate:C} per day";
        }
    }
}
