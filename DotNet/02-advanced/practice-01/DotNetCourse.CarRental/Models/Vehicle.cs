using System.ComponentModel;

namespace DotNetCourse.CarRental.Models
{
    public class Vehicle : IEquatable<Vehicle>, IComparable<Vehicle>
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

        public int CompareTo(Vehicle? other)
        {
            if (other == null) 
                throw new ArgumentNullException(nameof(other));

            if (this == other) 
                return 0;

            int result;

            result = Id.CompareTo(other.Id);
            if (result != 0) return result;

            result = Manufacturer.CompareTo(other.Manufacturer);
            if (result != 0) return result;

            result = Model.CompareTo(other.Model);
            if (result != 0) return result;

            result = YearOfProduction.CompareTo(other.YearOfProduction);
            if (result != 0) return result;

            result = RegistrationNumber.CompareTo(other.RegistrationNumber);
            if (result != 0) return result;

            result = Mileage.CompareTo(other.Mileage);
            if (result != 0) return result;

            result = EngineVolume.CompareTo(other.EngineVolume);
            if (result != 0) return result;

            result = MaxPassengerCapacity.CompareTo(other.MaxPassengerCapacity);
            if (result != 0) return result;

            result = InsuranceAmountPerYear.CompareTo(other.InsuranceAmountPerYear);
            if (result != 0) return result;

            return PricePerHour.CompareTo(other.PricePerHour);
        }
    }
}
