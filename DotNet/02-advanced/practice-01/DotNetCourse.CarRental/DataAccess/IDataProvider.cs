using DotNetCourse.CarRental.Models;

namespace DotNetCourse.CarRental.DataAccess
{
    public interface IDataProvider
    {
        IEnumerable<Vehicle> GetVehicles();

        IEnumerable<Vehicle> GetVehiclesBy(
            string? manufacturer,
            string? model,
            int? yearOfProduction,
            string? registrationNumber,
            double? mileage,
            double? engineVolume,
            int? passengerCapacity,
            decimal? insuranceAmountPerYear,
            decimal? pricePerHour,
            bool? isRented);

        bool TryRegisterVehicleRental(
            Vehicle vehicle, 
            Customer customer, 
            DateTime registrationTime, 
            DateTime expectedReturnTime);

        bool TryRegisterVehicleReturn(
            Vehicle vehicle,
            Customer customer,
            DateTime actualReturnTime,
            out decimal? refund);

        IEnumerable<Customer> GetCustomers();

        IEnumerable<Customer> GetCustomersBy(
            string? firstName, 
            string? lastName,
            string? driverLicenseNumber,
            bool? hasRentedVehicle);

        bool TryRegisterCustomer(
            Customer customer);

        IEnumerable<Rent> GetCustomerHistory(
            Customer customer);
    }
}
