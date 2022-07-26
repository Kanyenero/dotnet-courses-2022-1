using System.ComponentModel;

namespace DotNetCourse.CarRental.Models
{
    public class Vehicle : IEquatable<Vehicle>
    {
        [DisplayName("Id")]
        public int Id
        {
            get;
            set;
        } = default!;

        [DisplayName("Mfr.")]
        public string Manufacturer
        {
            get;
            set;
        } = default!;

        [DisplayName("Mdl.")]
        public string Model
        {
            get;
            set;
        } = default!;

        [DisplayName("Prod. Year")]
        public int YearOfProduction
        {
            get;
            set;
        } = default!;

        [DisplayName("Reg. Num.")]
        public string RegistrationNumber
        {
            get;
            set;
        } = default!;

        [DisplayName("Mlg. (km)")]
        public double Mileage
        {
            get;
            set;
        } = default!;

        [DisplayName("Eng. Vol. (liters)")]
        public double EngineVolume
        {
            get;
            set;
        } = default!;

        [DisplayName("Psg. Cap.")]
        public int MaxPassengerCapacity
        {
            get;
            set;
        } = default!;

        [DisplayName("Ins. (USD)")]
        public decimal InsuranceAmountPerYear
        {
            get;
            set;
        } = default!;

        [DisplayName("Price/Hour")]
        public decimal PricePerHour
        {
            get;
            set;
        } = default!;

        [Browsable(false)]
        public bool IsRented
        {
            get;
            set;
        } = default!;

        public Vehicle()
        {
        }

        public override string ToString()
        {
            return
                $"[{Manufacturer} " +
                $"{Model}, " +
                $"{YearOfProduction}] " +
                $"[{RegistrationNumber}]";
        }

        public bool Equals(Vehicle? other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Id == other.Id &&
                   Manufacturer == other.Manufacturer &&
                   Model == other.Model &&
                   YearOfProduction == other.YearOfProduction &&
                   RegistrationNumber == other.RegistrationNumber &&
                   Mileage == other.Mileage &&
                   EngineVolume == other.EngineVolume &&
                   MaxPassengerCapacity == other.MaxPassengerCapacity &&
                   InsuranceAmountPerYear == other.InsuranceAmountPerYear &&
                   PricePerHour == other.PricePerHour;
        }
    }
}
