using System.ComponentModel;

namespace DotNetCourse.CarRental.Models
{
    public class GridViewRent
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

        //[DisplayName("Eng. Vol. (liters)")]
        //public double EngineVolume
        //{
        //    get;
        //    set;
        //} = default!;

        //[DisplayName("Psg. Cap.")]
        //public int MaxPassengerCapacity
        //{
        //    get;
        //    set;
        //} = default!;

        //[DisplayName("Ins. (USD)")]
        //public decimal InsuranceAmountPerYear
        //{
        //    get;
        //    set;
        //} = default!;

        //[DisplayName("Price/Hour")]
        //public decimal PricePerHour
        //{
        //    get;
        //    set;
        //} = default!;

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

        public GridViewRent(Rent rent)
        {
            Id                      = rent.Vehicle.Id;
            Manufacturer            = rent.Vehicle.Manufacturer;
            Model                   = rent.Vehicle.Model;
            YearOfProduction        = rent.Vehicle.YearOfProduction;
            RegistrationNumber      = rent.Vehicle.RegistrationNumber;
            Mileage                 = rent.Vehicle.Mileage;
            //EngineVolume            = rent.Vehicle.EngineVolume;
            //MaxPassengerCapacity    = rent.Vehicle.MaxPassengerCapacity;
            //InsuranceAmountPerYear  = rent.Vehicle.InsuranceAmountPerYear;
            //PricePerHour            = rent.Vehicle.PricePerHour;
            RegistrationTime        = rent.RegistrationTime;
            ReturnTime              = rent.ReturnTime;
        }
    }
}
