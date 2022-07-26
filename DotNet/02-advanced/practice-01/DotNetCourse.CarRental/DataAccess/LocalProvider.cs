using DotNetCourse.CarRental.Models;
using DotNetCourse.Utils.Runtime;
using DotNetCourse.Utils.Collections;

namespace DotNetCourse.CarRental.DataAccess
{
    public class LocalDataProvider : IDataProvider
    {
        private readonly List<Vehicle> _vehicles = new()
        {
            new Vehicle
            {
                Id = 0,
                Manufacturer = "Kia",
                Model = "Rio",
                YearOfProduction = 2022,
                RegistrationNumber = "ве435к",
                Mileage = 28,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1500,
                IsRented = false,
                PricePerHour = 1.2m
            },

            new Vehicle
            {
                Id = 1,
                Manufacturer = "Kia",
                Model = "Rio",
                YearOfProduction = 2011,
                RegistrationNumber = "кт939е",
                Mileage = 3500,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1500,
                IsRented = false,
                PricePerHour = 1.2m
            },

            new Vehicle
            {
                Id = 2,
                Manufacturer = "Kia",
                Model = "Rio",
                YearOfProduction = 2013,
                RegistrationNumber = "ак122н",
                Mileage = 8200,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1500,
                IsRented = false,
                PricePerHour = 1.2m
            },

            new Vehicle
            {
                Id = 3,
                Manufacturer = "Hyundai",
                Model = "Solaris",
                YearOfProduction = 2015,
                RegistrationNumber = "рм884н",
                Mileage = 1000,
                EngineVolume = 1.4,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1350,
                IsRented = false,
                PricePerHour = 1.1m
            },

            new Vehicle
            {
                Id = 4,
                Manufacturer = "Hyundai",
                Model = "Solaris",
                YearOfProduction = 2013,
                RegistrationNumber = "ов782е",
                Mileage = 1000,
                EngineVolume = 1.4,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1350,
                IsRented = false,
                PricePerHour = 1.1m
            },

            new Vehicle
            {
                Id = 5,
                Manufacturer = "Hyundai",
                Model = "Solaris",
                YearOfProduction = 2022,
                RegistrationNumber = "мр341а",
                Mileage = 10,
                EngineVolume = 1.4,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1350,
                IsRented = false,
                PricePerHour = 1.1m
            },

            new Vehicle
            {
                Id = 6,
                Manufacturer = "Volkswagen",
                Model = "Transporter",
                YearOfProduction = 2019,
                RegistrationNumber = "хв216е",
                Mileage = 50,
                EngineVolume = 2.0,
                MaxPassengerCapacity = 9,
                InsuranceAmountPerYear = 2700,
                IsRented = false,
                PricePerHour = 1.9m
            },

            new Vehicle
            {
                Id = 7,
                Manufacturer = "Renault",
                Model = "Logan",
                YearOfProduction = 2013,
                RegistrationNumber = "ке202а",
                Mileage = 25000,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1000,
                IsRented = false,
                PricePerHour = 0.85m
            },

            new Vehicle
            {
                Id = 8,
                Manufacturer = "Renault",
                Model = "Logan",
                YearOfProduction = 2016,
                RegistrationNumber = "рк934н",
                Mileage = 13000,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1000,
                IsRented = false,
                PricePerHour = 0.85m
            },

            new Vehicle
            {
                Id = 9,
                Manufacturer = "Chevrolet",
                Model = "Cruse",
                YearOfProduction = 2015,
                RegistrationNumber = "ок114т",
                Mileage = 16800,
                EngineVolume = 1.8,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 1277,
                IsRented = false,
                PricePerHour = 1.0m
            },

            new Vehicle
            {
                Id = 10,
                Manufacturer = "Mini",
                Model = "Cooper",
                YearOfProduction = 2018,
                RegistrationNumber = "со255в",
                Mileage = 3200,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 4,
                InsuranceAmountPerYear = 1276,
                IsRented = false,
                PricePerHour = 1.4m
            },

            new Vehicle
            {
                Id = 11,
                Manufacturer = "Volkswagen",
                Model = "Polo",
                YearOfProduction = 2017,
                RegistrationNumber = "ак844р",
                Mileage = 8700,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 950,
                IsRented = false,
                PricePerHour = 1.1m
            },

            new Vehicle
            {
                Id = 12,
                Manufacturer = "Volkswagen",
                Model = "Polo",
                YearOfProduction = 2017,
                RegistrationNumber = "ку712р",
                Mileage = 10500,
                EngineVolume = 1.6,
                MaxPassengerCapacity = 5,
                InsuranceAmountPerYear = 950,
                IsRented = false,
                PricePerHour = 1.1m
            }
        };
        private readonly List<Customer> _customers = new()
        {
            new Customer
            {
                Id = 0,
                FirstName = "Alexey",
                LastName = "Dolgov",
                DriverLicenseNumber = "1234567890"
            },

            new Customer
            {
                Id = 1,
                FirstName = "Vladimir",
                LastName = "Sleptsov",
                DriverLicenseNumber = "0987654321"
            },

            new Customer
            {
                Id = 2,
                FirstName = "Anna",
                LastName = "Eremina",
                DriverLicenseNumber = "1946099312"
            },

            new Customer
            {
                Id = 3,
                FirstName = "Den",
                LastName = "Khrapov",
                DriverLicenseNumber = "4729856730"
            },

            new Customer
            {
                Id = 4,
                FirstName = "Ivan",
                LastName = "Nechaev",
                DriverLicenseNumber = "2245288957"
            },

            new Customer
            {
                Id = 5,
                FirstName = "Olga",
                LastName = "Vasnetsova",
                DriverLicenseNumber = "9077834511"
            },

            new Customer
            {
                Id = 6,
                FirstName = "Grigory",
                LastName = "Kamalov",
                DriverLicenseNumber = "8997400671"
            },

            new Customer
            {
                Id = 7,
                FirstName = "Alexandra",
                LastName = "Nevskikh",
                DriverLicenseNumber = "3674894460"
            },

            new Customer
            {
                Id = 8,
                FirstName = "Peter",
                LastName = "Nosov",
                DriverLicenseNumber = "5600091834"
            },

            new Customer
            {
                Id = 9,
                FirstName = "Liza",
                LastName = "Kravtsova",
                DriverLicenseNumber = "7433806889"
            }
        };
        private readonly List<Rent> _rents = new() { };

        public LocalDataProvider()
        {
        }

        public bool TryRegisterVehicleRental(
            Vehicle vehicle,
            Customer customer,
            DateTime registrationTime,
            DateTime expectedReturnTime)
        {
            bool rentCreated = TryCreateRent(
                vehicle,
                customer,
                registrationTime,
                expectedReturnTime,
                out Rent rent);

            if (!rentCreated)
                return false;

            UpdateRents(rent, activeState: true);

            return true;
        }

        private bool TryCreateRent(
            Vehicle vehicle,
            Customer customer,
            DateTime registrationTime,
            DateTime expectedReturnTime,
            out Rent rent)
        {
            rent = new Rent(vehicle, customer, registrationTime, expectedReturnTime);

            if (_rents.Contains(rent))
                return false;

            return true;
        }

        public bool TryRegisterVehicleReturn(
            Vehicle vehicle,
            Customer customer,
            DateTime actualReturnTime,
            out decimal? refund)
        {
            refund = null;

            bool rentExists = TryGetRent(vehicle, customer, activeState: true, out Rent rent);

            if (!rentExists)
                return false;

            UpdateRents(rent, activeState: false);

            refund = CalculateRefund(
                rent.Vehicle.PricePerHour,
                rent.RegistrationTime,
                rent.ReturnTime,
                actualReturnTime);

            return true;

            static decimal CalculateRefund(
                decimal pricePerHour,
                DateTime registration,
                DateTime expectedReturn,
                DateTime actualReturn)
            {
                var expectedHours = (expectedReturn - registration).TotalHours;
                var actualHours = (actualReturn - expectedReturn).TotalHours;

                int unusedHours = (int)(expectedHours - actualHours);

                return pricePerHour * unusedHours;
            }
        }

        private bool TryGetRent(
            Vehicle vehicle,
            Customer customer,
            bool activeState,
            out Rent rent)
        {
            rent = _rents
                .Where(r =>
                    r.IsActive == activeState &&
                    r.Vehicle.Equals(vehicle) &&
                    r.Customer.Equals(customer))
                .SingleOrDefault()!;

            if (rent == null)
                return false;

            return true;
        }

        private void UpdateRents(
            Rent rent,
            bool activeState)
        {
            rent.IsActive = activeState;
            rent.Vehicle.IsRented = activeState;
            rent.Customer.HasRentedVehicle = activeState;

            if (activeState == true)
                _rents.Add(rent);

            UpdateCustomers(rent.Customer.Id, rent.Customer.HasRentedVehicle);
            UpdateVehicles(rent.Vehicle.Id, rent.Vehicle.IsRented);
        }

        private void UpdateCustomers(
            int id,
            bool hasRentedVehicle)
        {
            bool customerExists = _customers.TryGetItemOn(c => c.Id == id, out Customer customer);

            if (customerExists)
                customer.TrySetProperty("HasRentedVehicle", hasRentedVehicle);
        }

        private void UpdateVehicles(
            int id,
            bool isRented)
        {
            bool vehicleExists = _vehicles.TryGetItemOn(v => v.Id == id, out Vehicle vehicle);

            if (vehicleExists)
                _ = vehicle.TrySetProperty("IsRented", isRented);
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return _vehicles;
        }

        public IEnumerable<Vehicle> GetVehiclesBy(
            string? manufacturer,
            string? model,
            int? yearOfProduction,
            string? registrationNumber,
            double? mileage,
            double? engineVolume,
            int? passengerCapacity,
            decimal? insuranceAmountPerYear,
            decimal? pricePerHour,
            bool? isRented)
        {
            var filter = new GenericFilter<Vehicle>();

            if (manufacturer != null)
                filter.AddFilter("Manufacturer", GenericFilter<Vehicle>.FilterType.Equal, manufacturer);

            if (model != null)
                filter.AddFilter("Model", GenericFilter<Vehicle>.FilterType.Equal, model);

            if (yearOfProduction != null)
                filter.AddFilter("YearOfProduction", GenericFilter<Vehicle>.FilterType.LessThan, (int)yearOfProduction);

            if (registrationNumber != null)
                filter.AddFilter("RegistrationNumber", GenericFilter<Vehicle>.FilterType.Equal, registrationNumber);

            if (mileage != null)
                filter.AddFilter("Mileage", GenericFilter<Vehicle>.FilterType.LessThan, (double)mileage);

            if (engineVolume != null)
                filter.AddFilter("EngineVolume", GenericFilter<Vehicle>.FilterType.Equal, (double)engineVolume);

            if (passengerCapacity != null)
                filter.AddFilter("MaxPassengerCapacity", GenericFilter<Vehicle>.FilterType.Equal, (int)passengerCapacity);

            if (insuranceAmountPerYear != null)
                filter.AddFilter("InsuranceAmountPerYear", GenericFilter<Vehicle>.FilterType.LessThan, (decimal)insuranceAmountPerYear);

            if (pricePerHour != null)
                filter.AddFilter("PricePerHour", GenericFilter<Vehicle>.FilterType.LessThan, (decimal)pricePerHour);

            if (isRented != null)
                filter.AddFilter("IsRented", GenericFilter<Vehicle>.FilterType.Equal, (bool)isRented);

            return filter.Apply(_vehicles.AsQueryable());
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customers;
        }

        public IEnumerable<Customer> GetCustomersBy(
            string? firstName,
            string? lastName,
            string? driverLicenseNumber,
            bool? hasRentedVehicle)
        {
            var filter = new GenericFilter<Customer>();

            if (firstName != null)
                filter.AddFilter("FirstName", GenericFilter<Customer>.FilterType.Equal, firstName);

            if (lastName != null)
                filter.AddFilter("LastName", GenericFilter<Customer>.FilterType.Equal, lastName);

            if (driverLicenseNumber != null)
                filter.AddFilter("DriverLicenseNumber", GenericFilter<Customer>.FilterType.Equal, driverLicenseNumber);

            if (hasRentedVehicle != null)
                filter.AddFilter("HasRentedVehicle", GenericFilter<Customer>.FilterType.Equal, (bool)hasRentedVehicle);

            return filter.Apply(_customers.AsQueryable());
        }

        public bool TryRegisterCustomer(
            Customer customer)
        {
            if (_customers.Contains(customer))
                return false;

            customer.Id = _customers.Max(c => c.Id) + 1;

            _customers.Add(customer);

            return true;
        }

        public IEnumerable<Rent> GetCustomerHistory(
            Customer customer)
        {
            return _rents.Where(r => r.Customer.Id == customer.Id);
        }
    }
}
