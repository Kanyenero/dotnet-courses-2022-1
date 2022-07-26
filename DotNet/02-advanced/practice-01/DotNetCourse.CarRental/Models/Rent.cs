using System.ComponentModel;

namespace DotNetCourse.CarRental.Models
{
    public class Rent : IEquatable<Rent>
    {
        [DisplayName("Vehicle")]
        public Vehicle Vehicle 
        { 
            get; 
            set;
        } = default!;

        [DisplayName("Customer")]
        public Customer Customer
        {
            get;
            set;
        } = default!;

        [DisplayName("Registration")]
        public DateTime RegistrationTime 
        { 
            get;
            set;
        } = default!;

        [DisplayName("Return")]
        public DateTime ReturnTime
        {
            get;
            set;
        } = default!;

        [Browsable(false)]
        public bool IsActive
        {
            get;
            set;
        } = default!;

        public Rent()
        {
        }

        public Rent(Vehicle vehicle, Customer customer, DateTime registrationTime, DateTime returnTime)
        {
            Vehicle = vehicle;
            Customer = customer;
            RegistrationTime = registrationTime;
            ReturnTime = returnTime;
        }

        public static explicit operator GridViewRent(Rent rent) => new(rent);

        public bool Equals(Rent? other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Vehicle.Equals(other.Vehicle) && 
                   Customer.Equals(other.Customer) &&
                   RegistrationTime == other.RegistrationTime && 
                   ReturnTime == other.ReturnTime;
        }
    }
}
