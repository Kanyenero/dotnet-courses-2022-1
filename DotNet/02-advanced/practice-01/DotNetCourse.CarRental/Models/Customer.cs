using System.ComponentModel;

namespace DotNetCourse.CarRental.Models
{
    public class Customer : IEquatable<Customer>
    {
        [DisplayName("Id")]
        public int Id
        {
            get;
            set;
        } = default!;

        [DisplayName("First Name")]
        public string FirstName
        {
            get;
            set;
        } = default!;

        [DisplayName("Last Name")]
        public string LastName
        {
            get;
            set;
        } = default!;

        [DisplayName("Drv. License")]
        public string DriverLicenseNumber
        {
            get;
            set;
        } = default!;

        [Browsable(false)]
        public bool HasRentedVehicle
        {
            get;
            set;
        } = default!;

        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string driverLicenseNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DriverLicenseNumber = driverLicenseNumber;
        }

        public override string ToString()
        {
            return 
                $"[{FirstName} " +
                $"{LastName}] " +
                $"[{DriverLicenseNumber}]";
        }

        public bool Equals(Customer? other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Id == other.Id &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   DriverLicenseNumber == other.DriverLicenseNumber;
        }
    }
}
