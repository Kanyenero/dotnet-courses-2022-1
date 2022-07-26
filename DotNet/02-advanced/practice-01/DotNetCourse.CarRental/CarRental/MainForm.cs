using DotNetCourse.CarRental.DataAccess;
using DotNetCourse.CarRental.Models;

namespace DotNetCourse.CarRental
{
    public partial class MainForm : Form
    {
        private Vehicle _vehicle = new();
        private Customer _customer = new();

        private readonly IDataProvider _dataProvider;
        private ISerializer _serializer;

        public MainForm(IDataProvider dataProvider)
        {
            InitializeComponent();

            SubscribeEvents();

            _dataProvider = dataProvider;
        }

        private void SubscribeEvents()
        {
            mstpTopMenuAbout.Click              += OnEventResetActiveControl;
            btnMenuVehicles.Click               += OnEventResetActiveControl;
            btnMenuSelectVehicle.Click          += OnEventResetActiveControl;
            btnRegisterVehicleRental.Click      += OnEventResetActiveControl;
            btnRegisterVehicleReturn.Click      += OnEventResetActiveControl;
            btnMenuCustomers.Click              += OnEventResetActiveControl;
            btnMenuCustomerRegistration.Click   += OnEventResetActiveControl;
            btnMenuCustomerHistory.Click        += OnEventResetActiveControl;

            btnVehiclesRegisterRental.Click                     += OnEventResetActiveControl;
            btnSelectVehicleApplyFilters.Click                  += OnEventResetActiveControl;
            btnSelectVehicleRegisterRental.Click                += OnEventResetActiveControl;
            btnRegisterRentalApplyCustomerFilters.Click         += OnEventResetActiveControl;
            btnRegisterVehicleRental.Click                      += OnEventResetActiveControl;
            btnRegisterVehicleReturnCustomerApplyFilter.Click   += OnEventResetActiveControl;
            btnRegisterVehicleReturnVehicleApplyFilter.Click    += OnEventResetActiveControl;
            btnRegisterVehicleReturn.Click                      += OnEventResetActiveControl;
            btnRegisterNewCustomerApplyFilters.Click            += OnEventResetActiveControl;
            btnRegisterNewCustomer.Click                        += OnEventResetActiveControl;
            btnCustomerHistoryApplyFilters.Click                += OnEventResetActiveControl;
        }

        private void OnEventResetActiveControl(object? sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgAbout);
        }

        private void mstpTopMenuFileExportToXmlFreeVehicles_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                FileName = "New XML Document.xml",
                Filter = "XML files (*.xml)|*.xml",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var collectionToSerialize = _dataProvider.GetVehiclesBy(
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    isRented: false)
                    .ToList();

                _serializer = new XmlSerializer(saveFileDialog.FileName);

                bool collectionSerialized = _serializer.TrySerializeCollection(collectionToSerialize);

                if (collectionSerialized)
                {
                    MessageBox.Show(
                        "The export operation was successful.",
                        "Export to Xml",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show(
                    "The export operation failed.",
                    "Export to Xml",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void mstpTopMenuAbout_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgAbout);
        }

        private void btnMenuVehicles_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgVehicles);
        }

        private void btnMenuSelectVehicle_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgVehicleSelection);
        }

        private void btnMenuRegisterRental_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgRegisterRental);
        }

        private void btnMenuRegisterReturn_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgRegisterReturn);
        }

        private void btnMenuCustomers_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgCustomers);
        }

        private void btnMenuCustomerRegistration_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgCustomerRegistration);
        }

        private void btnMenuCustomerHistory_Click(object sender, EventArgs e)
        {
            tctrlBody.SelectTab(tpgCustomerHistory);
        }

        private void tctrlBody_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tpgVehicles)
            {
                dgvVehicles.DataSource = _dataProvider.GetVehiclesBy(
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    isRented: false)
                    .ToList();

                return;
            }

            if (e.TabPage == tpgVehicleSelection)
            {
                tbxSelectVehicleManufacturer.Text       = string.Empty;
                tbxSelectVehicleModel.Text              = string.Empty;
                tbxSelectVehicleYearOfProduction.Text   = string.Empty;
                tbxSelectVehicleMileage.Text            = string.Empty;
                tbxSelectVehiclePassengerCapacity.Text  = string.Empty;
                tbxSelectVehicleEngineVolume.Text       = string.Empty;
                tbxSelectVehicleInsuranceAmount.Text    = string.Empty;
                tbxSelectVehiclePricePerHour.Text       = string.Empty;

                dgvSelectVehicle.DataSource = _dataProvider.GetVehicles().ToList();

                return;
            }

            if (e.TabPage == tpgRegisterRental)
            {
                tbxRegisterVehicleRentalCustomerFirstName.Text      = string.Empty;
                tbxRegisterVehicleRentalCustomerLastName.Text       = string.Empty;
                tbxRegisterVehicleRentalCustomerDriverLicense.Text  = string.Empty;

                dgvRegisterVehicleRentalCustomers.DataSource = _dataProvider.GetCustomersBy(
                    null,
                    null,
                    null,
                    hasRentedVehicle: false)
                    .ToList();

                return;
            }

            if (e.TabPage == tpgRegisterReturn)
            {
                tbxRegisterVehicleReturnVehicleRegistrationNumber.Text      = string.Empty;
                tbxRegisterVehicleReturnCustomerDriverLicenseNumber.Text    = string.Empty;

                dgvRegisterVehicleReturnCustomers.DataSource = _dataProvider.GetCustomersBy(
                    null,
                    null,
                    null,
                    hasRentedVehicle: true)
                    .ToList();

                dgvRegisterVehicleReturnVehicles.DataSource = _dataProvider.GetVehiclesBy(
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    isRented: true)
                    .ToList();

                return;
            }

            if (e.TabPage == tpgCustomers)
            {
                dgvCustomers.DataSource = _dataProvider.GetCustomers().ToList();

                return;
            }

            if (e.TabPage == tpgCustomerRegistration)
            {
                tbxRegisterNewCustomerFirstName.Text            = string.Empty;
                tbxRegisterNewCustomerLastName.Text             = string.Empty;
                tbxRegisterNewCustomerDriverLicenseNumber.Text  = string.Empty;

                dgvRegisterNewCustomer.DataSource = _dataProvider.GetCustomers().ToList();

                return;
            }

            if (e.TabPage == tpgCustomerHistory)
            {
                tbxCustomerHistoryCustomerFirstName.Text            = string.Empty;
                tbxCustomerHistoryCustomerLastName.Text             = string.Empty;
                tbxCustomerHistoryCustomerDriverLicenseNumber.Text  = string.Empty;

                dgvCustomerHistoryCustomers.DataSource = _dataProvider.GetCustomers().ToList();

                return;
            }
        }

        private static bool TryGetFromDgvRow<T>(DataGridViewRow row, out T itemToGet)
            where T : class
        {
            itemToGet = row.DataBoundItem as T;

            if (itemToGet == null)
                return false;

            return true;
        }

        private void btnVehiclesRegisterRental_Click(object sender, EventArgs e)
        {
            RegisterRentalHandle(dgvVehicles);
        }

        private void btnSelectVehicleRegisterRental_Click(object sender, EventArgs e)
        {
            RegisterRentalHandle(dgvSelectVehicle);
        }

        private void RegisterRentalHandle(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
                return;

            bool vehicleStored = TryGetFromDgvRow(dgv.SelectedRows[0], out _vehicle);

            if (vehicleStored)
            {
                tctrlBody.SelectTab(tpgRegisterRental);

                tbxRegisterVehicleRentalVehicleManufacturer.Text = _vehicle.Manufacturer;
                tbxRegisterVehicleRentalVehicleModel.Text = _vehicle.Model;
                tbxRegisterVehicleRentalVehicleYearOfProduction.Text = _vehicle.YearOfProduction.ToString();
                tbxRegisterVehicleRentalVehicleRegistrationNumber.Text = _vehicle.RegistrationNumber;
                tbxRegisterVehicleRentalVehicleMileage.Text = _vehicle.Mileage.ToString();
                tbxRegisterVehicleRentalVehicleEngineVolume.Text = _vehicle.EngineVolume.ToString();
                tbxRegisterVehicleRentalVehiclePassengerCapacity.Text = _vehicle.MaxPassengerCapacity.ToString();
                tbxRegisterVehicleRentalVehicleInsuranceAmount.Text = _vehicle.InsuranceAmountPerYear.ToString();
                tbxRegisterVehicleRentalVehiclePricePerHour.Text = _vehicle.PricePerHour.ToString();
            }
        }

        private static string? GetControlText(string text)
        {
            if (text == string.Empty)
                return null;

            return text;
        }

        private void btnSelectVehicleApplyFilters_Click(object sender, EventArgs e)
        {
            if (tbxSelectVehicleManufacturer.Text == string.Empty &&
                tbxSelectVehicleModel.Text == string.Empty &&
                tbxSelectVehicleYearOfProduction.Text == string.Empty &&
                tbxSelectVehicleMileage.Text == string.Empty &&
                tbxSelectVehicleEngineVolume.Text == string.Empty &&
                tbxSelectVehiclePassengerCapacity.Text == string.Empty &&
                tbxSelectVehicleInsuranceAmount.Text == string.Empty &&
                tbxSelectVehiclePricePerHour.Text == string.Empty)
            {
                dgvSelectVehicle.DataSource = _dataProvider.GetVehicles().ToList();

                return;
            }

            string? manufacturer = GetControlText(tbxSelectVehicleManufacturer.Text);
            string? model = GetControlText(tbxSelectVehicleModel.Text);

            int? yearOfProduction = null;

            if (int.TryParse(tbxSelectVehicleYearOfProduction.Text, out int yearOfProductionParsedValue))
                yearOfProduction = yearOfProductionParsedValue;

            double? mileage = null;

            if (double.TryParse(tbxSelectVehicleMileage.Text, out double mileageParsedValue))
                mileage = mileageParsedValue;

            double? engineVolume = null;

            if (double.TryParse(tbxSelectVehicleEngineVolume.Text, out double engineVolumeParsedValue))
                engineVolume = engineVolumeParsedValue;

            int? passengerCapacity = null;

            if (int.TryParse(tbxSelectVehiclePassengerCapacity.Text, out int passengerCapacityParsedValue))
                passengerCapacity = passengerCapacityParsedValue;

            decimal? insuranceAmount = null;

            if (decimal.TryParse(tbxSelectVehicleInsuranceAmount.Text, out decimal insuranceAmountParsedValue))
                insuranceAmount = insuranceAmountParsedValue;

            decimal? pricePerHour = null;

            if (decimal.TryParse(tbxSelectVehiclePricePerHour.Text, out decimal pricePerHourParsedValue))
                pricePerHour = pricePerHourParsedValue;

            dgvSelectVehicle.DataSource = _dataProvider.GetVehiclesBy(
                manufacturer,
                model,
                yearOfProduction,
                null,
                mileage,
                engineVolume,
                passengerCapacity,
                insuranceAmount,
                pricePerHour,
                isRented: false)
                .ToList();
        }

        private void btnRegisterRentalApplyCustomerFilters_Click(object sender, EventArgs e)
        {
            string? firstName = GetControlText(tbxRegisterVehicleRentalCustomerFirstName.Text);
            string? lastName = GetControlText(tbxRegisterVehicleRentalCustomerLastName.Text);
            string? driverLicense = GetControlText(tbxRegisterVehicleRentalCustomerDriverLicense.Text);

            dgvRegisterVehicleRentalCustomers.DataSource = _dataProvider.GetCustomersBy(
                firstName,
                lastName,
                driverLicense,
                hasRentedVehicle: false)
                .ToList();
        }

        private void btnRegisterVehicleRental_Click(object sender, EventArgs e)
        {
            if (_vehicle == null)
            {
                MessageBox.Show(
                    "Select vehicle first!",
                    "New Rental Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvRegisterVehicleRentalCustomers.SelectedRows.Count == 0)
                return;

            bool customerStored = TryGetFromDgvRow(dgvRegisterVehicleRentalCustomers.SelectedRows[0], out _customer);

            if (!customerStored)
                return;

            var registrationDate = DateTime.Now;
            var expectedReturnDate = dtpRegisterVehicleRentalVehicleReturnDate.Value;

            var rentalRegistered = _dataProvider.TryRegisterVehicleRental(
                _vehicle,
                _customer,
                registrationDate,
                expectedReturnDate);

            if (rentalRegistered)
            {
                MessageBox.Show(
                    "Successfully registered a new rental!\n" +
                    $"Customer: {_customer}\n" +
                    $"Vehicle: {_vehicle}\n" +
                    $"Registration Date: {registrationDate}\n" +
                    $"Expected Return Date: {expectedReturnDate}", 
                    "New Rental Registration", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                tctrlBody.SelectTab(tpgVehicles);

                return;
            }
        }

        private void btnRegisterVehicleReturnCustomerApplyFilter_Click(object sender, EventArgs e)
        {
            string? driverLicense = GetControlText(tbxRegisterVehicleReturnCustomerDriverLicenseNumber.Text);

            dgvRegisterVehicleReturnCustomers.DataSource = _dataProvider.GetCustomersBy(
                null,
                null,
                driverLicense,
                hasRentedVehicle: true)
                .ToList();
        }

        private void btnRegisterVehicleReturnVehicleApplyFilter_Click(object sender, EventArgs e)
        {
            string? registrationNumber = GetControlText(tbxRegisterVehicleReturnVehicleRegistrationNumber.Text);

            dgvRegisterVehicleReturnVehicles.DataSource = _dataProvider.GetVehiclesBy(
                null,
                null,
                null,
                registrationNumber,
                null,
                null,
                null,
                null,
                null,
                isRented: true)
                .ToList();
        }

        private void btnRegisterVehicleReturn_Click(object sender, EventArgs e)
        {
            if (dgvRegisterVehicleReturnVehicles.SelectedRows.Count == 0 || 
                dgvRegisterVehicleReturnCustomers.SelectedRows.Count == 0)
                return;

            bool vehicleStored = TryGetFromDgvRow(dgvRegisterVehicleReturnVehicles.SelectedRows[0], out _vehicle);
            bool customerStored = TryGetFromDgvRow(dgvRegisterVehicleReturnCustomers.SelectedRows[0], out _customer);

            if (vehicleStored && customerStored)
            {
                bool returnRegistered = _dataProvider.TryRegisterVehicleReturn(
                    _vehicle,
                    _customer,
                    DateTime.Now,
                    out decimal? refund);

                if (returnRegistered == false)
                    return;

                MessageBox.Show(
                    $"{refund}$", 
                    "Refund", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                tctrlBody.SelectTab(tpgVehicles);
            }
        }

        private void btnRegisterNewCustomerApplyFilters_Click(object sender, EventArgs e)
        {
            string? firstName = GetControlText(tbxRegisterNewCustomerFirstName.Text);
            string? lastName = GetControlText(tbxRegisterNewCustomerLastName.Text);
            string? driverLicenseNumber = GetControlText(tbxRegisterNewCustomerDriverLicenseNumber.Text);

            dgvRegisterNewCustomer.DataSource = _dataProvider.GetCustomersBy(
                firstName,
                lastName,
                driverLicenseNumber,
                null)
                .ToList();
        }

        private void btnRegisterNewCustomer_Click(object sender, EventArgs e)
        {
            if (tbxRegisterNewCustomerFirstName.Text == string.Empty ||
                tbxRegisterNewCustomerLastName.Text == string.Empty ||
                tbxRegisterNewCustomerDriverLicenseNumber.Text == string.Empty)
                return;

            _customer = new Customer(
                tbxRegisterNewCustomerFirstName.Text,
                tbxRegisterNewCustomerLastName.Text,
                tbxRegisterNewCustomerDriverLicenseNumber.Text);

            bool customerRegistered = _dataProvider.TryRegisterCustomer(_customer);

            if (customerRegistered)
            {
                MessageBox.Show(
                    "Successfully registered a new customer!\n\n" +
                    $"{_customer}", 
                    "New Customer Registration", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show(
                "A customer with these parameters is already registered!", 
                "New Customer Registration", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnCustomerHistoryApplyFilters_Click(object sender, EventArgs e)
        {
            string? firstName = GetControlText(tbxCustomerHistoryCustomerFirstName.Text);
            string? lastName = GetControlText(tbxCustomerHistoryCustomerLastName.Text);
            string? driverLicenseNumber = GetControlText(tbxCustomerHistoryCustomerDriverLicenseNumber.Text);

            dgvCustomerHistoryCustomers.DataSource = _dataProvider.GetCustomersBy(
                firstName,
                lastName,
                driverLicenseNumber,
                null)
                .ToList();
        }

        private void dgvCustomerHistoryCustomers_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCustomerHistoryCustomers.SelectedRows.Count == 0)
                return;

            bool customerStored = TryGetFromDgvRow(dgvCustomerHistoryCustomers.SelectedRows[0], out _customer);

            if (customerStored)
            {
                dgvCustomerHistory.DataSource = _dataProvider.GetCustomerHistory(_customer)
                    .Select(rent => (GridViewRent)rent)
                    .ToList();
            }
        }
    }
}
