using Microsoft.AspNetCore.Mvc;
using VehicleRentalSystem.Models;
using System;
using System.Collections.Generic;

namespace VehicleRentalSystem.Controllers
{
    public class RentalController : Controller
    {
        private List<Vehicle> availableVehicles = new List<Vehicle>
        {
            new Car { Id = 1, Brand = "Toyota", Model = "Corolla", RentalRate = 50, NumberOfDoors = 4, FuelType = "Gasoline" },
            new Bike { Id = 2, Brand = "Yamaha", Model = "R15", RentalRate = 20, HasHelmet = true },
            new Truck { Id = 3, Brand = "Ford", Model = "F-150", RentalRate = 100, LoadCapacity = 2000 }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(availableVehicles);
        }

        [HttpPost]
        public IActionResult RentVehicle(int vehicleId, DateTime startDate, DateTime endDate)
        {
            var vehicle = availableVehicles.Find(v => v.Id == vehicleId);
            if (vehicle != null)
            {
                var rental = new Rental
                {
                    Vehicle = vehicle,
                    StartDate = startDate,
                    EndDate = endDate
                };
                var totalFee = rental.CalculateTotalRentalFee();

                ViewBag.TotalFee = totalFee;
                return View("RentalDetails", rental);
            }
            return NotFound();
        }
    }
}
