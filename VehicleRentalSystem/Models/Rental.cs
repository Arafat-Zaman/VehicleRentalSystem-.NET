using System;

namespace VehicleRentalSystem.Models
{
    public class Rental
    {
        public Vehicle Vehicle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal CalculateTotalRentalFee()
        {
            var rentalDuration = (EndDate - StartDate).Days;
            return rentalDuration * Vehicle.RentalRate;
        }
    }
}
