namespace DotNetCourse.CarRental
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnMenuCustomerHistory = new System.Windows.Forms.Button();
            this.btnMenuVehicles = new System.Windows.Forms.Button();
            this.btnMenuSelectVehicle = new System.Windows.Forms.Button();
            this.btnMenuRegisterRental = new System.Windows.Forms.Button();
            this.btnMenuRegisterReturn = new System.Windows.Forms.Button();
            this.btnMenuCustomers = new System.Windows.Forms.Button();
            this.btnMenuCustomerRegistration = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tctrlBody = new System.Windows.Forms.TabControl();
            this.tpgAbout = new System.Windows.Forms.TabPage();
            this.lblAbout = new System.Windows.Forms.Label();
            this.tpgVehicles = new System.Windows.Forms.TabPage();
            this.pnlVehiclesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.btnVehiclesRegisterRental = new System.Windows.Forms.Button();
            this.tpgVehicleSelection = new System.Windows.Forms.TabPage();
            this.pnlSelectVehicleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSelectVehicle = new System.Windows.Forms.DataGridView();
            this.btnSelectVehicleRegisterRental = new System.Windows.Forms.Button();
            this.pnlSelectVehicleFiltersLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSelectVehicleFiltersLayoutRight = new System.Windows.Forms.Panel();
            this.tbxSelectVehiclePricePerHour = new System.Windows.Forms.TextBox();
            this.tbxSelectVehicleInsuranceAmount = new System.Windows.Forms.TextBox();
            this.tbxSelectVehiclePassengerCapacity = new System.Windows.Forms.TextBox();
            this.lblSelectVehiclePricePerHour = new System.Windows.Forms.Label();
            this.lblSelectVehicleInsuranceAmount = new System.Windows.Forms.Label();
            this.lblSelectVehiclePassengerCapacity = new System.Windows.Forms.Label();
            this.btnSelectVehicleApplyFilters = new System.Windows.Forms.Button();
            this.pnlSelectVehicleFiltersLayoutLeft = new System.Windows.Forms.Panel();
            this.tbxSelectVehicleMileage = new System.Windows.Forms.TextBox();
            this.tbxSelectVehicleYearOfProduction = new System.Windows.Forms.TextBox();
            this.tbxSelectVehicleModel = new System.Windows.Forms.TextBox();
            this.tbxSelectVehicleManufacturer = new System.Windows.Forms.TextBox();
            this.tbxSelectVehicleEngineVolume = new System.Windows.Forms.TextBox();
            this.lblSelectVehicleEngineVolume = new System.Windows.Forms.Label();
            this.lblSelectVehicleMileage = new System.Windows.Forms.Label();
            this.lblSelectVehicleYearOfManufacture = new System.Windows.Forms.Label();
            this.lblSelectVehicleModel = new System.Windows.Forms.Label();
            this.lblSelectVehicleManufacturer = new System.Windows.Forms.Label();
            this.tpgRegisterRental = new System.Windows.Forms.TabPage();
            this.pnlRegisterVehicleRentalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRegisterVehicleRentalLeft = new System.Windows.Forms.Panel();
            this.dtpRegisterVehicleRentalVehicleReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegisterVehicleRentalVehicleReturnDate = new System.Windows.Forms.Label();
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalVehiclePricePerHour = new System.Windows.Forms.TextBox();
            this.lblRegisterVehicleRentalVehiclePricePerHour = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalVehicleInsuranceAmount = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalVehiclePassengerCapacity = new System.Windows.Forms.Label();
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalVehicleMileage = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalVehicleEngineVolume = new System.Windows.Forms.TextBox();
            this.lblRegisterVehicleRentalVehicleEngineVolume = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalVehicleMileage = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalVehicleRegistrationNumber = new System.Windows.Forms.Label();
            this.tbxRegisterVehicleRentalVehicleManufacturer = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalVehicleModel = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalVehicleYearOfProduction = new System.Windows.Forms.TextBox();
            this.lblRegisterVehicleRentalVehicleYearOfProduction = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalVehicleModel = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalVehicleManufacturer = new System.Windows.Forms.Label();
            this.btnRegisterVehicleRental = new System.Windows.Forms.Button();
            this.pnlRegisterVehicleRentalRight = new System.Windows.Forms.Panel();
            this.btnRegisterRentalApplyCustomerFilters = new System.Windows.Forms.Button();
            this.dgvRegisterVehicleRentalCustomers = new System.Windows.Forms.DataGridView();
            this.tbxRegisterVehicleRentalCustomerFirstName = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalCustomerLastName = new System.Windows.Forms.TextBox();
            this.tbxRegisterVehicleRentalCustomerDriverLicense = new System.Windows.Forms.TextBox();
            this.lblRegisterVehicleRentalCustomerDriverLicense = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalCustomerLastName = new System.Windows.Forms.Label();
            this.lblRegisterVehicleRentalCustomerFirstName = new System.Windows.Forms.Label();
            this.tpgRegisterReturn = new System.Windows.Forms.TabPage();
            this.pnlRegisterVehicleReturnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRegisterCarReturnLower = new System.Windows.Forms.Panel();
            this.pnlRegisterVehicleReturnCustomerFilters = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegisterVehicleReturnCustomerApplyFilter = new System.Windows.Forms.Button();
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber = new System.Windows.Forms.Label();
            this.tbxRegisterVehicleReturnCustomerDriverLicenseNumber = new System.Windows.Forms.TextBox();
            this.dgvRegisterVehicleReturnCustomers = new System.Windows.Forms.DataGridView();
            this.btnRegisterVehicleReturn = new System.Windows.Forms.Button();
            this.pnlRegisterCarReturnUpper = new System.Windows.Forms.Panel();
            this.pnlRegisterVehicleReturnVehicleFilters = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegisterVehicleReturnVehicleApplyFilter = new System.Windows.Forms.Button();
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber = new System.Windows.Forms.Label();
            this.tbxRegisterVehicleReturnVehicleRegistrationNumber = new System.Windows.Forms.TextBox();
            this.dgvRegisterVehicleReturnVehicles = new System.Windows.Forms.DataGridView();
            this.tpgCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tpgCustomerRegistration = new System.Windows.Forms.TabPage();
            this.pnlRegisterNewCustomerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRegisterNewCustomer = new System.Windows.Forms.DataGridView();
            this.pnlRegisterNewCustomerFilters = new System.Windows.Forms.Panel();
            this.btnRegisterNewCustomerApplyFilters = new System.Windows.Forms.Button();
            this.tbxRegisterNewCustomerDriverLicenseNumber = new System.Windows.Forms.TextBox();
            this.lblRegisterNewCustomerDriverLicenseNumber = new System.Windows.Forms.Label();
            this.tbxRegisterNewCustomerLastName = new System.Windows.Forms.TextBox();
            this.tbxRegisterNewCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblRegisterNewCustomerLastName = new System.Windows.Forms.Label();
            this.lblRegisterNewCustomerFirstName = new System.Windows.Forms.Label();
            this.btnRegisterNewCustomer = new System.Windows.Forms.Button();
            this.tpgCustomerHistory = new System.Windows.Forms.TabPage();
            this.pnlCustomerHistoryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCustomerHistory = new System.Windows.Forms.DataGridView();
            this.dgvCustomerHistoryCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustomerHistoryFilters = new System.Windows.Forms.Panel();
            this.btnCustomerHistoryApplyFilters = new System.Windows.Forms.Button();
            this.tbxCustomerHistoryCustomerFirstName = new System.Windows.Forms.TextBox();
            this.tbxCustomerHistoryCustomerDriverLicenseNumber = new System.Windows.Forms.TextBox();
            this.lblCustomerHistoryCustomerFirstName = new System.Windows.Forms.Label();
            this.lblCustomerHistoryCustomerDriverLicenseNumber = new System.Windows.Forms.Label();
            this.lblCustomerHistoryCustomerLastName = new System.Windows.Forms.Label();
            this.tbxCustomerHistoryCustomerLastName = new System.Windows.Forms.TextBox();
            this.mstpTopMenu = new System.Windows.Forms.MenuStrip();
            this.mstpTopMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpTopMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpTopMenuFileExportToXml = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpTopMenuFileExportToXmlFreeVehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpTopMenuFileExportToXmlCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLayout.SuspendLayout();
            this.pnlMenuLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.tctrlBody.SuspendLayout();
            this.tpgAbout.SuspendLayout();
            this.tpgVehicles.SuspendLayout();
            this.pnlVehiclesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.tpgVehicleSelection.SuspendLayout();
            this.pnlSelectVehicleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectVehicle)).BeginInit();
            this.pnlSelectVehicleFiltersLayout.SuspendLayout();
            this.pnlSelectVehicleFiltersLayoutRight.SuspendLayout();
            this.pnlSelectVehicleFiltersLayoutLeft.SuspendLayout();
            this.tpgRegisterRental.SuspendLayout();
            this.pnlRegisterVehicleRentalLayout.SuspendLayout();
            this.pnlRegisterVehicleRentalLeft.SuspendLayout();
            this.pnlRegisterVehicleRentalRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterVehicleRentalCustomers)).BeginInit();
            this.tpgRegisterReturn.SuspendLayout();
            this.pnlRegisterVehicleReturnLayout.SuspendLayout();
            this.pnlRegisterCarReturnLower.SuspendLayout();
            this.pnlRegisterVehicleReturnCustomerFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterVehicleReturnCustomers)).BeginInit();
            this.pnlRegisterCarReturnUpper.SuspendLayout();
            this.pnlRegisterVehicleReturnVehicleFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterVehicleReturnVehicles)).BeginInit();
            this.tpgCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tpgCustomerRegistration.SuspendLayout();
            this.pnlRegisterNewCustomerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterNewCustomer)).BeginInit();
            this.pnlRegisterNewCustomerFilters.SuspendLayout();
            this.tpgCustomerHistory.SuspendLayout();
            this.pnlCustomerHistoryLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistoryCustomers)).BeginInit();
            this.pnlCustomerHistoryFilters.SuspendLayout();
            this.mstpTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayout
            // 
            this.pnlLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlLayout.ColumnCount = 2;
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLayout.Controls.Add(this.pnlMenuLayout, 0, 0);
            this.pnlLayout.Controls.Add(this.tctrlBody, 1, 0);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.Location = new System.Drawing.Point(0, 28);
            this.pnlLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.RowCount = 1;
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLayout.Size = new System.Drawing.Size(1135, 666);
            this.pnlLayout.TabIndex = 0;
            // 
            // pnlMenuLayout
            // 
            this.pnlMenuLayout.ColumnCount = 1;
            this.pnlMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMenuLayout.Controls.Add(this.btnMenuCustomerHistory, 0, 7);
            this.pnlMenuLayout.Controls.Add(this.btnMenuVehicles, 0, 1);
            this.pnlMenuLayout.Controls.Add(this.btnMenuSelectVehicle, 0, 2);
            this.pnlMenuLayout.Controls.Add(this.btnMenuRegisterRental, 0, 3);
            this.pnlMenuLayout.Controls.Add(this.btnMenuRegisterReturn, 0, 4);
            this.pnlMenuLayout.Controls.Add(this.btnMenuCustomers, 0, 5);
            this.pnlMenuLayout.Controls.Add(this.btnMenuCustomerRegistration, 0, 6);
            this.pnlMenuLayout.Controls.Add(this.pbxLogo, 0, 0);
            this.pnlMenuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuLayout.Location = new System.Drawing.Point(1, 1);
            this.pnlMenuLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuLayout.Name = "pnlMenuLayout";
            this.pnlMenuLayout.RowCount = 8;
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMenuLayout.Size = new System.Drawing.Size(300, 664);
            this.pnlMenuLayout.TabIndex = 0;
            // 
            // btnMenuCustomerHistory
            // 
            this.btnMenuCustomerHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuCustomerHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuCustomerHistory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenuCustomerHistory.Location = new System.Drawing.Point(3, 589);
            this.btnMenuCustomerHistory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMenuCustomerHistory.Name = "btnMenuCustomerHistory";
            this.btnMenuCustomerHistory.Size = new System.Drawing.Size(294, 74);
            this.btnMenuCustomerHistory.TabIndex = 6;
            this.btnMenuCustomerHistory.TabStop = false;
            this.btnMenuCustomerHistory.Text = "Customer History";
            this.btnMenuCustomerHistory.UseVisualStyleBackColor = true;
            this.btnMenuCustomerHistory.Click += new System.EventHandler(this.btnMenuCustomerHistory_Click);
            // 
            // btnMenuVehicles
            // 
            this.btnMenuVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuVehicles.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuVehicles.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenuVehicles.Location = new System.Drawing.Point(3, 151);
            this.btnMenuVehicles.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMenuVehicles.Name = "btnMenuVehicles";
            this.btnMenuVehicles.Size = new System.Drawing.Size(294, 71);
            this.btnMenuVehicles.TabIndex = 0;
            this.btnMenuVehicles.TabStop = false;
            this.btnMenuVehicles.Text = "Vehicles";
            this.btnMenuVehicles.UseVisualStyleBackColor = true;
            this.btnMenuVehicles.Click += new System.EventHandler(this.btnMenuVehicles_Click);
            // 
            // btnMenuSelectVehicle
            // 
            this.btnMenuSelectVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuSelectVehicle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuSelectVehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenuSelectVehicle.Location = new System.Drawing.Point(3, 224);
            this.btnMenuSelectVehicle.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMenuSelectVehicle.Name = "btnMenuSelectVehicle";
            this.btnMenuSelectVehicle.Size = new System.Drawing.Size(294, 71);
            this.btnMenuSelectVehicle.TabIndex = 1;
            this.btnMenuSelectVehicle.TabStop = false;
            this.btnMenuSelectVehicle.Text = "Select Vehicle";
            this.btnMenuSelectVehicle.UseVisualStyleBackColor = true;
            this.btnMenuSelectVehicle.Click += new System.EventHandler(this.btnMenuSelectVehicle_Click);
            // 
            // btnMenuRegisterRental
            // 
            this.btnMenuRegisterRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuRegisterRental.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuRegisterRental.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenuRegisterRental.Location = new System.Drawing.Point(3, 297);
            this.btnMenuRegisterRental.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMenuRegisterRental.Name = "btnMenuRegisterRental";
            this.btnMenuRegisterRental.Size = new System.Drawing.Size(294, 71);
            this.btnMenuRegisterRental.TabIndex = 2;
            this.btnMenuRegisterRental.TabStop = false;
            this.btnMenuRegisterRental.Text = "Register Rental";
            this.btnMenuRegisterRental.UseVisualStyleBackColor = true;
            this.btnMenuRegisterRental.Click += new System.EventHandler(this.btnMenuRegisterRental_Click);
            // 
            // btnMenuRegisterReturn
            // 
            this.btnMenuRegisterReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuRegisterReturn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuRegisterReturn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenuRegisterReturn.Location = new System.Drawing.Point(3, 370);
            this.btnMenuRegisterReturn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMenuRegisterReturn.Name = "btnMenuRegisterReturn";
            this.btnMenuRegisterReturn.Size = new System.Drawing.Size(294, 71);
            this.btnMenuRegisterReturn.TabIndex = 3;
            this.btnMenuRegisterReturn.TabStop = false;
            this.btnMenuRegisterReturn.Text = "Register Return";
            this.btnMenuRegisterReturn.UseVisualStyleBackColor = true;
            this.btnMenuRegisterReturn.Click += new System.EventHandler(this.btnMenuRegisterReturn_Click);
            // 
            // btnMenuCustomers
            // 
            this.btnMenuCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuCustomers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuCustomers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenuCustomers.Location = new System.Drawing.Point(3, 443);
            this.btnMenuCustomers.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMenuCustomers.Name = "btnMenuCustomers";
            this.btnMenuCustomers.Size = new System.Drawing.Size(294, 71);
            this.btnMenuCustomers.TabIndex = 4;
            this.btnMenuCustomers.TabStop = false;
            this.btnMenuCustomers.Text = "Customers";
            this.btnMenuCustomers.UseVisualStyleBackColor = true;
            this.btnMenuCustomers.Click += new System.EventHandler(this.btnMenuCustomers_Click);
            // 
            // btnMenuCustomerRegistration
            // 
            this.btnMenuCustomerRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuCustomerRegistration.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuCustomerRegistration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenuCustomerRegistration.Location = new System.Drawing.Point(3, 516);
            this.btnMenuCustomerRegistration.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMenuCustomerRegistration.Name = "btnMenuCustomerRegistration";
            this.btnMenuCustomerRegistration.Size = new System.Drawing.Size(294, 71);
            this.btnMenuCustomerRegistration.TabIndex = 5;
            this.btnMenuCustomerRegistration.TabStop = false;
            this.btnMenuCustomerRegistration.Text = "Register New Customer";
            this.btnMenuCustomerRegistration.UseVisualStyleBackColor = true;
            this.btnMenuCustomerRegistration.Click += new System.EventHandler(this.btnMenuCustomerRegistration_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = global::DotNetCourse.CarRental.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(300, 150);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // tctrlBody
            // 
            this.tctrlBody.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tctrlBody.Controls.Add(this.tpgAbout);
            this.tctrlBody.Controls.Add(this.tpgVehicles);
            this.tctrlBody.Controls.Add(this.tpgVehicleSelection);
            this.tctrlBody.Controls.Add(this.tpgRegisterRental);
            this.tctrlBody.Controls.Add(this.tpgRegisterReturn);
            this.tctrlBody.Controls.Add(this.tpgCustomers);
            this.tctrlBody.Controls.Add(this.tpgCustomerRegistration);
            this.tctrlBody.Controls.Add(this.tpgCustomerHistory);
            this.tctrlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlBody.ItemSize = new System.Drawing.Size(0, 1);
            this.tctrlBody.Location = new System.Drawing.Point(302, 1);
            this.tctrlBody.Margin = new System.Windows.Forms.Padding(0);
            this.tctrlBody.Name = "tctrlBody";
            this.tctrlBody.SelectedIndex = 0;
            this.tctrlBody.Size = new System.Drawing.Size(832, 664);
            this.tctrlBody.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctrlBody.TabIndex = 1;
            this.tctrlBody.Selected += new System.Windows.Forms.TabControlEventHandler(this.tctrlBody_Selected);
            // 
            // tpgAbout
            // 
            this.tpgAbout.Controls.Add(this.lblAbout);
            this.tpgAbout.Location = new System.Drawing.Point(4, 5);
            this.tpgAbout.Margin = new System.Windows.Forms.Padding(0);
            this.tpgAbout.Name = "tpgAbout";
            this.tpgAbout.Size = new System.Drawing.Size(824, 655);
            this.tpgAbout.TabIndex = 7;
            // 
            // lblAbout
            // 
            this.lblAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbout.Location = new System.Drawing.Point(0, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(824, 655);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "This is about page :)";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpgVehicles
            // 
            this.tpgVehicles.BackColor = System.Drawing.SystemColors.Control;
            this.tpgVehicles.Controls.Add(this.pnlVehiclesLayout);
            this.tpgVehicles.Location = new System.Drawing.Point(4, 5);
            this.tpgVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.tpgVehicles.Name = "tpgVehicles";
            this.tpgVehicles.Size = new System.Drawing.Size(824, 655);
            this.tpgVehicles.TabIndex = 0;
            // 
            // pnlVehiclesLayout
            // 
            this.pnlVehiclesLayout.ColumnCount = 1;
            this.pnlVehiclesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlVehiclesLayout.Controls.Add(this.dgvVehicles, 0, 0);
            this.pnlVehiclesLayout.Controls.Add(this.btnVehiclesRegisterRental, 0, 1);
            this.pnlVehiclesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehiclesLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlVehiclesLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVehiclesLayout.Name = "pnlVehiclesLayout";
            this.pnlVehiclesLayout.RowCount = 2;
            this.pnlVehiclesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlVehiclesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlVehiclesLayout.Size = new System.Drawing.Size(824, 655);
            this.pnlVehiclesLayout.TabIndex = 1;
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToOrderColumns = true;
            this.dgvVehicles.AllowUserToResizeColumns = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicles.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 29;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(824, 622);
            this.dgvVehicles.TabIndex = 0;
            // 
            // btnVehiclesRegisterRental
            // 
            this.btnVehiclesRegisterRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVehiclesRegisterRental.Location = new System.Drawing.Point(337, 625);
            this.btnVehiclesRegisterRental.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnVehiclesRegisterRental.Name = "btnVehiclesRegisterRental";
            this.btnVehiclesRegisterRental.Size = new System.Drawing.Size(150, 30);
            this.btnVehiclesRegisterRental.TabIndex = 1;
            this.btnVehiclesRegisterRental.Text = "Rent";
            this.btnVehiclesRegisterRental.UseVisualStyleBackColor = true;
            this.btnVehiclesRegisterRental.Click += new System.EventHandler(this.btnVehiclesRegisterRental_Click);
            // 
            // tpgVehicleSelection
            // 
            this.tpgVehicleSelection.BackColor = System.Drawing.SystemColors.Control;
            this.tpgVehicleSelection.Controls.Add(this.pnlSelectVehicleLayout);
            this.tpgVehicleSelection.Location = new System.Drawing.Point(4, 5);
            this.tpgVehicleSelection.Margin = new System.Windows.Forms.Padding(0);
            this.tpgVehicleSelection.Name = "tpgVehicleSelection";
            this.tpgVehicleSelection.Size = new System.Drawing.Size(824, 655);
            this.tpgVehicleSelection.TabIndex = 1;
            // 
            // pnlSelectVehicleLayout
            // 
            this.pnlSelectVehicleLayout.ColumnCount = 1;
            this.pnlSelectVehicleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSelectVehicleLayout.Controls.Add(this.dgvSelectVehicle, 0, 1);
            this.pnlSelectVehicleLayout.Controls.Add(this.btnSelectVehicleRegisterRental, 0, 2);
            this.pnlSelectVehicleLayout.Controls.Add(this.pnlSelectVehicleFiltersLayout, 0, 0);
            this.pnlSelectVehicleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectVehicleLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectVehicleLayout.Name = "pnlSelectVehicleLayout";
            this.pnlSelectVehicleLayout.RowCount = 3;
            this.pnlSelectVehicleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.pnlSelectVehicleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSelectVehicleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSelectVehicleLayout.Size = new System.Drawing.Size(824, 655);
            this.pnlSelectVehicleLayout.TabIndex = 0;
            // 
            // dgvSelectVehicle
            // 
            this.dgvSelectVehicle.AllowUserToAddRows = false;
            this.dgvSelectVehicle.AllowUserToDeleteRows = false;
            this.dgvSelectVehicle.AllowUserToOrderColumns = true;
            this.dgvSelectVehicle.AllowUserToResizeColumns = false;
            this.dgvSelectVehicle.AllowUserToResizeRows = false;
            this.dgvSelectVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectVehicle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSelectVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectVehicle.Location = new System.Drawing.Point(0, 200);
            this.dgvSelectVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSelectVehicle.MultiSelect = false;
            this.dgvSelectVehicle.Name = "dgvSelectVehicle";
            this.dgvSelectVehicle.ReadOnly = true;
            this.dgvSelectVehicle.RowHeadersVisible = false;
            this.dgvSelectVehicle.RowHeadersWidth = 51;
            this.dgvSelectVehicle.RowTemplate.Height = 29;
            this.dgvSelectVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectVehicle.Size = new System.Drawing.Size(824, 422);
            this.dgvSelectVehicle.TabIndex = 0;
            // 
            // btnSelectVehicleRegisterRental
            // 
            this.btnSelectVehicleRegisterRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectVehicleRegisterRental.Location = new System.Drawing.Point(337, 625);
            this.btnSelectVehicleRegisterRental.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSelectVehicleRegisterRental.Name = "btnSelectVehicleRegisterRental";
            this.btnSelectVehicleRegisterRental.Size = new System.Drawing.Size(150, 30);
            this.btnSelectVehicleRegisterRental.TabIndex = 1;
            this.btnSelectVehicleRegisterRental.TabStop = false;
            this.btnSelectVehicleRegisterRental.Text = "Rent";
            this.btnSelectVehicleRegisterRental.UseVisualStyleBackColor = true;
            this.btnSelectVehicleRegisterRental.Click += new System.EventHandler(this.btnSelectVehicleRegisterRental_Click);
            // 
            // pnlSelectVehicleFiltersLayout
            // 
            this.pnlSelectVehicleFiltersLayout.ColumnCount = 2;
            this.pnlSelectVehicleFiltersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSelectVehicleFiltersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSelectVehicleFiltersLayout.Controls.Add(this.pnlSelectVehicleFiltersLayoutRight, 1, 0);
            this.pnlSelectVehicleFiltersLayout.Controls.Add(this.btnSelectVehicleApplyFilters, 0, 1);
            this.pnlSelectVehicleFiltersLayout.Controls.Add(this.pnlSelectVehicleFiltersLayoutLeft, 0, 0);
            this.pnlSelectVehicleFiltersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectVehicleFiltersLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectVehicleFiltersLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelectVehicleFiltersLayout.Name = "pnlSelectVehicleFiltersLayout";
            this.pnlSelectVehicleFiltersLayout.RowCount = 2;
            this.pnlSelectVehicleFiltersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSelectVehicleFiltersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSelectVehicleFiltersLayout.Size = new System.Drawing.Size(824, 200);
            this.pnlSelectVehicleFiltersLayout.TabIndex = 2;
            // 
            // pnlSelectVehicleFiltersLayoutRight
            // 
            this.pnlSelectVehicleFiltersLayoutRight.Controls.Add(this.tbxSelectVehiclePricePerHour);
            this.pnlSelectVehicleFiltersLayoutRight.Controls.Add(this.tbxSelectVehicleInsuranceAmount);
            this.pnlSelectVehicleFiltersLayoutRight.Controls.Add(this.tbxSelectVehiclePassengerCapacity);
            this.pnlSelectVehicleFiltersLayoutRight.Controls.Add(this.lblSelectVehiclePricePerHour);
            this.pnlSelectVehicleFiltersLayoutRight.Controls.Add(this.lblSelectVehicleInsuranceAmount);
            this.pnlSelectVehicleFiltersLayoutRight.Controls.Add(this.lblSelectVehiclePassengerCapacity);
            this.pnlSelectVehicleFiltersLayoutRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectVehicleFiltersLayoutRight.Location = new System.Drawing.Point(412, 0);
            this.pnlSelectVehicleFiltersLayoutRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelectVehicleFiltersLayoutRight.Name = "pnlSelectVehicleFiltersLayoutRight";
            this.pnlSelectVehicleFiltersLayoutRight.Size = new System.Drawing.Size(412, 161);
            this.pnlSelectVehicleFiltersLayoutRight.TabIndex = 2;
            // 
            // tbxSelectVehiclePricePerHour
            // 
            this.tbxSelectVehiclePricePerHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehiclePricePerHour.Location = new System.Drawing.Point(147, 60);
            this.tbxSelectVehiclePricePerHour.Name = "tbxSelectVehiclePricePerHour";
            this.tbxSelectVehiclePricePerHour.Size = new System.Drawing.Size(258, 27);
            this.tbxSelectVehiclePricePerHour.TabIndex = 8;
            // 
            // tbxSelectVehicleInsuranceAmount
            // 
            this.tbxSelectVehicleInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehicleInsuranceAmount.Location = new System.Drawing.Point(147, 30);
            this.tbxSelectVehicleInsuranceAmount.Name = "tbxSelectVehicleInsuranceAmount";
            this.tbxSelectVehicleInsuranceAmount.Size = new System.Drawing.Size(258, 27);
            this.tbxSelectVehicleInsuranceAmount.TabIndex = 7;
            // 
            // tbxSelectVehiclePassengerCapacity
            // 
            this.tbxSelectVehiclePassengerCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehiclePassengerCapacity.Location = new System.Drawing.Point(147, 0);
            this.tbxSelectVehiclePassengerCapacity.Name = "tbxSelectVehiclePassengerCapacity";
            this.tbxSelectVehiclePassengerCapacity.Size = new System.Drawing.Size(258, 27);
            this.tbxSelectVehiclePassengerCapacity.TabIndex = 6;
            // 
            // lblSelectVehiclePricePerHour
            // 
            this.lblSelectVehiclePricePerHour.AutoSize = true;
            this.lblSelectVehiclePricePerHour.Location = new System.Drawing.Point(3, 63);
            this.lblSelectVehiclePricePerHour.Name = "lblSelectVehiclePricePerHour";
            this.lblSelectVehiclePricePerHour.Size = new System.Drawing.Size(83, 20);
            this.lblSelectVehiclePricePerHour.TabIndex = 2;
            this.lblSelectVehiclePricePerHour.Text = "Price/Hour:";
            // 
            // lblSelectVehicleInsuranceAmount
            // 
            this.lblSelectVehicleInsuranceAmount.AutoSize = true;
            this.lblSelectVehicleInsuranceAmount.Location = new System.Drawing.Point(3, 33);
            this.lblSelectVehicleInsuranceAmount.Name = "lblSelectVehicleInsuranceAmount";
            this.lblSelectVehicleInsuranceAmount.Size = new System.Drawing.Size(131, 20);
            this.lblSelectVehicleInsuranceAmount.TabIndex = 1;
            this.lblSelectVehicleInsuranceAmount.Text = "Insurance Amount:";
            // 
            // lblSelectVehiclePassengerCapacity
            // 
            this.lblSelectVehiclePassengerCapacity.AutoSize = true;
            this.lblSelectVehiclePassengerCapacity.Location = new System.Drawing.Point(3, 3);
            this.lblSelectVehiclePassengerCapacity.Name = "lblSelectVehiclePassengerCapacity";
            this.lblSelectVehiclePassengerCapacity.Size = new System.Drawing.Size(138, 20);
            this.lblSelectVehiclePassengerCapacity.TabIndex = 0;
            this.lblSelectVehiclePassengerCapacity.Text = "Passenger Capacity:";
            // 
            // btnSelectVehicleApplyFilters
            // 
            this.btnSelectVehicleApplyFilters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSelectVehicleFiltersLayout.SetColumnSpan(this.btnSelectVehicleApplyFilters, 2);
            this.btnSelectVehicleApplyFilters.Location = new System.Drawing.Point(337, 164);
            this.btnSelectVehicleApplyFilters.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.btnSelectVehicleApplyFilters.Name = "btnSelectVehicleApplyFilters";
            this.btnSelectVehicleApplyFilters.Size = new System.Drawing.Size(150, 30);
            this.btnSelectVehicleApplyFilters.TabIndex = 0;
            this.btnSelectVehicleApplyFilters.TabStop = false;
            this.btnSelectVehicleApplyFilters.Text = "Apply Filters";
            this.btnSelectVehicleApplyFilters.UseVisualStyleBackColor = true;
            this.btnSelectVehicleApplyFilters.Click += new System.EventHandler(this.btnSelectVehicleApplyFilters_Click);
            // 
            // pnlSelectVehicleFiltersLayoutLeft
            // 
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.tbxSelectVehicleMileage);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.tbxSelectVehicleYearOfProduction);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.tbxSelectVehicleModel);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.tbxSelectVehicleManufacturer);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.tbxSelectVehicleEngineVolume);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.lblSelectVehicleEngineVolume);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.lblSelectVehicleMileage);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.lblSelectVehicleYearOfManufacture);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.lblSelectVehicleModel);
            this.pnlSelectVehicleFiltersLayoutLeft.Controls.Add(this.lblSelectVehicleManufacturer);
            this.pnlSelectVehicleFiltersLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectVehicleFiltersLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectVehicleFiltersLayoutLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelectVehicleFiltersLayoutLeft.Name = "pnlSelectVehicleFiltersLayoutLeft";
            this.pnlSelectVehicleFiltersLayoutLeft.Size = new System.Drawing.Size(412, 161);
            this.pnlSelectVehicleFiltersLayoutLeft.TabIndex = 1;
            // 
            // tbxSelectVehicleMileage
            // 
            this.tbxSelectVehicleMileage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehicleMileage.Location = new System.Drawing.Point(120, 90);
            this.tbxSelectVehicleMileage.Name = "tbxSelectVehicleMileage";
            this.tbxSelectVehicleMileage.Size = new System.Drawing.Size(280, 27);
            this.tbxSelectVehicleMileage.TabIndex = 9;
            // 
            // tbxSelectVehicleYearOfProduction
            // 
            this.tbxSelectVehicleYearOfProduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehicleYearOfProduction.Location = new System.Drawing.Point(120, 60);
            this.tbxSelectVehicleYearOfProduction.Name = "tbxSelectVehicleYearOfProduction";
            this.tbxSelectVehicleYearOfProduction.Size = new System.Drawing.Size(280, 27);
            this.tbxSelectVehicleYearOfProduction.TabIndex = 8;
            // 
            // tbxSelectVehicleModel
            // 
            this.tbxSelectVehicleModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehicleModel.Location = new System.Drawing.Point(120, 30);
            this.tbxSelectVehicleModel.Name = "tbxSelectVehicleModel";
            this.tbxSelectVehicleModel.Size = new System.Drawing.Size(280, 27);
            this.tbxSelectVehicleModel.TabIndex = 7;
            // 
            // tbxSelectVehicleManufacturer
            // 
            this.tbxSelectVehicleManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehicleManufacturer.Location = new System.Drawing.Point(120, 0);
            this.tbxSelectVehicleManufacturer.Name = "tbxSelectVehicleManufacturer";
            this.tbxSelectVehicleManufacturer.Size = new System.Drawing.Size(280, 27);
            this.tbxSelectVehicleManufacturer.TabIndex = 6;
            // 
            // tbxSelectVehicleEngineVolume
            // 
            this.tbxSelectVehicleEngineVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSelectVehicleEngineVolume.Location = new System.Drawing.Point(120, 120);
            this.tbxSelectVehicleEngineVolume.Name = "tbxSelectVehicleEngineVolume";
            this.tbxSelectVehicleEngineVolume.Size = new System.Drawing.Size(280, 27);
            this.tbxSelectVehicleEngineVolume.TabIndex = 5;
            // 
            // lblSelectVehicleEngineVolume
            // 
            this.lblSelectVehicleEngineVolume.AutoSize = true;
            this.lblSelectVehicleEngineVolume.Location = new System.Drawing.Point(3, 123);
            this.lblSelectVehicleEngineVolume.Name = "lblSelectVehicleEngineVolume";
            this.lblSelectVehicleEngineVolume.Size = new System.Drawing.Size(111, 20);
            this.lblSelectVehicleEngineVolume.TabIndex = 4;
            this.lblSelectVehicleEngineVolume.Text = "Engine Volume:";
            // 
            // lblSelectVehicleMileage
            // 
            this.lblSelectVehicleMileage.AutoSize = true;
            this.lblSelectVehicleMileage.Location = new System.Drawing.Point(3, 93);
            this.lblSelectVehicleMileage.Name = "lblSelectVehicleMileage";
            this.lblSelectVehicleMileage.Size = new System.Drawing.Size(66, 20);
            this.lblSelectVehicleMileage.TabIndex = 3;
            this.lblSelectVehicleMileage.Text = "Mileage:";
            // 
            // lblSelectVehicleYearOfManufacture
            // 
            this.lblSelectVehicleYearOfManufacture.AutoSize = true;
            this.lblSelectVehicleYearOfManufacture.Location = new System.Drawing.Point(3, 63);
            this.lblSelectVehicleYearOfManufacture.Name = "lblSelectVehicleYearOfManufacture";
            this.lblSelectVehicleYearOfManufacture.Size = new System.Drawing.Size(40, 20);
            this.lblSelectVehicleYearOfManufacture.TabIndex = 2;
            this.lblSelectVehicleYearOfManufacture.Text = "Year:";
            // 
            // lblSelectVehicleModel
            // 
            this.lblSelectVehicleModel.AutoSize = true;
            this.lblSelectVehicleModel.Location = new System.Drawing.Point(3, 33);
            this.lblSelectVehicleModel.Name = "lblSelectVehicleModel";
            this.lblSelectVehicleModel.Size = new System.Drawing.Size(55, 20);
            this.lblSelectVehicleModel.TabIndex = 1;
            this.lblSelectVehicleModel.Text = "Model:";
            // 
            // lblSelectVehicleManufacturer
            // 
            this.lblSelectVehicleManufacturer.AutoSize = true;
            this.lblSelectVehicleManufacturer.Location = new System.Drawing.Point(3, 3);
            this.lblSelectVehicleManufacturer.Name = "lblSelectVehicleManufacturer";
            this.lblSelectVehicleManufacturer.Size = new System.Drawing.Size(100, 20);
            this.lblSelectVehicleManufacturer.TabIndex = 0;
            this.lblSelectVehicleManufacturer.Text = "Manufacturer:";
            // 
            // tpgRegisterRental
            // 
            this.tpgRegisterRental.Controls.Add(this.pnlRegisterVehicleRentalLayout);
            this.tpgRegisterRental.Location = new System.Drawing.Point(4, 5);
            this.tpgRegisterRental.Margin = new System.Windows.Forms.Padding(0);
            this.tpgRegisterRental.Name = "tpgRegisterRental";
            this.tpgRegisterRental.Size = new System.Drawing.Size(824, 655);
            this.tpgRegisterRental.TabIndex = 2;
            this.tpgRegisterRental.UseVisualStyleBackColor = true;
            // 
            // pnlRegisterVehicleRentalLayout
            // 
            this.pnlRegisterVehicleRentalLayout.ColumnCount = 2;
            this.pnlRegisterVehicleRentalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRegisterVehicleRentalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRegisterVehicleRentalLayout.Controls.Add(this.pnlRegisterVehicleRentalLeft, 0, 0);
            this.pnlRegisterVehicleRentalLayout.Controls.Add(this.btnRegisterVehicleRental, 0, 1);
            this.pnlRegisterVehicleRentalLayout.Controls.Add(this.pnlRegisterVehicleRentalRight, 1, 0);
            this.pnlRegisterVehicleRentalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterVehicleRentalLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterVehicleRentalLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterVehicleRentalLayout.Name = "pnlRegisterVehicleRentalLayout";
            this.pnlRegisterVehicleRentalLayout.RowCount = 2;
            this.pnlRegisterVehicleRentalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterVehicleRentalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlRegisterVehicleRentalLayout.Size = new System.Drawing.Size(824, 655);
            this.pnlRegisterVehicleRentalLayout.TabIndex = 0;
            // 
            // pnlRegisterVehicleRentalLeft
            // 
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.dtpRegisterVehicleRentalVehicleReturnDate);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleReturnDate);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehiclePassengerCapacity);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehicleInsuranceAmount);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehiclePricePerHour);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehiclePricePerHour);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleInsuranceAmount);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehiclePassengerCapacity);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehicleRegistrationNumber);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehicleMileage);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehicleEngineVolume);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleEngineVolume);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleMileage);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleRegistrationNumber);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehicleManufacturer);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehicleModel);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.tbxRegisterVehicleRentalVehicleYearOfProduction);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleYearOfProduction);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleModel);
            this.pnlRegisterVehicleRentalLeft.Controls.Add(this.lblRegisterVehicleRentalVehicleManufacturer);
            this.pnlRegisterVehicleRentalLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterVehicleRentalLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterVehicleRentalLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterVehicleRentalLeft.Name = "pnlRegisterVehicleRentalLeft";
            this.pnlRegisterVehicleRentalLeft.Size = new System.Drawing.Size(412, 620);
            this.pnlRegisterVehicleRentalLeft.TabIndex = 3;
            // 
            // dtpRegisterVehicleRentalVehicleReturnDate
            // 
            this.dtpRegisterVehicleRentalVehicleReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRegisterVehicleRentalVehicleReturnDate.Location = new System.Drawing.Point(123, 386);
            this.dtpRegisterVehicleRentalVehicleReturnDate.MinDate = new System.DateTime(2022, 7, 21, 0, 0, 0, 0);
            this.dtpRegisterVehicleRentalVehicleReturnDate.Name = "dtpRegisterVehicleRentalVehicleReturnDate";
            this.dtpRegisterVehicleRentalVehicleReturnDate.Size = new System.Drawing.Size(282, 27);
            this.dtpRegisterVehicleRentalVehicleReturnDate.TabIndex = 21;
            // 
            // lblRegisterVehicleRentalVehicleReturnDate
            // 
            this.lblRegisterVehicleRentalVehicleReturnDate.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleReturnDate.Location = new System.Drawing.Point(4, 391);
            this.lblRegisterVehicleRentalVehicleReturnDate.Name = "lblRegisterVehicleRentalVehicleReturnDate";
            this.lblRegisterVehicleRentalVehicleReturnDate.Size = new System.Drawing.Size(91, 20);
            this.lblRegisterVehicleRentalVehicleReturnDate.TabIndex = 19;
            this.lblRegisterVehicleRentalVehicleReturnDate.Text = "Return Date:";
            // 
            // tbxRegisterVehicleRentalVehiclePassengerCapacity
            // 
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity.Location = new System.Drawing.Point(123, 259);
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity.Name = "tbxRegisterVehicleRentalVehiclePassengerCapacity";
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity.TabIndex = 18;
            this.tbxRegisterVehicleRentalVehiclePassengerCapacity.TabStop = false;
            // 
            // tbxRegisterVehicleRentalVehicleInsuranceAmount
            // 
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount.Location = new System.Drawing.Point(123, 301);
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount.Name = "tbxRegisterVehicleRentalVehicleInsuranceAmount";
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount.TabIndex = 17;
            this.tbxRegisterVehicleRentalVehicleInsuranceAmount.TabStop = false;
            // 
            // tbxRegisterVehicleRentalVehiclePricePerHour
            // 
            this.tbxRegisterVehicleRentalVehiclePricePerHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehiclePricePerHour.Location = new System.Drawing.Point(123, 344);
            this.tbxRegisterVehicleRentalVehiclePricePerHour.Name = "tbxRegisterVehicleRentalVehiclePricePerHour";
            this.tbxRegisterVehicleRentalVehiclePricePerHour.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehiclePricePerHour.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehiclePricePerHour.TabIndex = 16;
            this.tbxRegisterVehicleRentalVehiclePricePerHour.TabStop = false;
            // 
            // lblRegisterVehicleRentalVehiclePricePerHour
            // 
            this.lblRegisterVehicleRentalVehiclePricePerHour.AutoSize = true;
            this.lblRegisterVehicleRentalVehiclePricePerHour.Location = new System.Drawing.Point(4, 347);
            this.lblRegisterVehicleRentalVehiclePricePerHour.Name = "lblRegisterVehicleRentalVehiclePricePerHour";
            this.lblRegisterVehicleRentalVehiclePricePerHour.Size = new System.Drawing.Size(83, 20);
            this.lblRegisterVehicleRentalVehiclePricePerHour.TabIndex = 15;
            this.lblRegisterVehicleRentalVehiclePricePerHour.Text = "Price/Hour:";
            // 
            // lblRegisterVehicleRentalVehicleInsuranceAmount
            // 
            this.lblRegisterVehicleRentalVehicleInsuranceAmount.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleInsuranceAmount.Location = new System.Drawing.Point(4, 304);
            this.lblRegisterVehicleRentalVehicleInsuranceAmount.Name = "lblRegisterVehicleRentalVehicleInsuranceAmount";
            this.lblRegisterVehicleRentalVehicleInsuranceAmount.Size = new System.Drawing.Size(74, 20);
            this.lblRegisterVehicleRentalVehicleInsuranceAmount.TabIndex = 14;
            this.lblRegisterVehicleRentalVehicleInsuranceAmount.Text = "Insurance:";
            // 
            // lblRegisterVehicleRentalVehiclePassengerCapacity
            // 
            this.lblRegisterVehicleRentalVehiclePassengerCapacity.AutoSize = true;
            this.lblRegisterVehicleRentalVehiclePassengerCapacity.Location = new System.Drawing.Point(3, 262);
            this.lblRegisterVehicleRentalVehiclePassengerCapacity.Name = "lblRegisterVehicleRentalVehiclePassengerCapacity";
            this.lblRegisterVehicleRentalVehiclePassengerCapacity.Size = new System.Drawing.Size(71, 20);
            this.lblRegisterVehicleRentalVehiclePassengerCapacity.TabIndex = 13;
            this.lblRegisterVehicleRentalVehiclePassengerCapacity.Text = "Psg. Cap.:";
            // 
            // tbxRegisterVehicleRentalVehicleRegistrationNumber
            // 
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber.Location = new System.Drawing.Point(123, 131);
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber.Name = "tbxRegisterVehicleRentalVehicleRegistrationNumber";
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber.TabIndex = 12;
            this.tbxRegisterVehicleRentalVehicleRegistrationNumber.TabStop = false;
            // 
            // tbxRegisterVehicleRentalVehicleMileage
            // 
            this.tbxRegisterVehicleRentalVehicleMileage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehicleMileage.Location = new System.Drawing.Point(123, 173);
            this.tbxRegisterVehicleRentalVehicleMileage.Name = "tbxRegisterVehicleRentalVehicleMileage";
            this.tbxRegisterVehicleRentalVehicleMileage.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehicleMileage.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehicleMileage.TabIndex = 11;
            this.tbxRegisterVehicleRentalVehicleMileage.TabStop = false;
            // 
            // tbxRegisterVehicleRentalVehicleEngineVolume
            // 
            this.tbxRegisterVehicleRentalVehicleEngineVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehicleEngineVolume.Location = new System.Drawing.Point(123, 216);
            this.tbxRegisterVehicleRentalVehicleEngineVolume.Name = "tbxRegisterVehicleRentalVehicleEngineVolume";
            this.tbxRegisterVehicleRentalVehicleEngineVolume.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehicleEngineVolume.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehicleEngineVolume.TabIndex = 10;
            this.tbxRegisterVehicleRentalVehicleEngineVolume.TabStop = false;
            // 
            // lblRegisterVehicleRentalVehicleEngineVolume
            // 
            this.lblRegisterVehicleRentalVehicleEngineVolume.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleEngineVolume.Location = new System.Drawing.Point(4, 219);
            this.lblRegisterVehicleRentalVehicleEngineVolume.Name = "lblRegisterVehicleRentalVehicleEngineVolume";
            this.lblRegisterVehicleRentalVehicleEngineVolume.Size = new System.Drawing.Size(85, 20);
            this.lblRegisterVehicleRentalVehicleEngineVolume.TabIndex = 9;
            this.lblRegisterVehicleRentalVehicleEngineVolume.Text = "Engine Vol.:";
            // 
            // lblRegisterVehicleRentalVehicleMileage
            // 
            this.lblRegisterVehicleRentalVehicleMileage.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleMileage.Location = new System.Drawing.Point(4, 176);
            this.lblRegisterVehicleRentalVehicleMileage.Name = "lblRegisterVehicleRentalVehicleMileage";
            this.lblRegisterVehicleRentalVehicleMileage.Size = new System.Drawing.Size(66, 20);
            this.lblRegisterVehicleRentalVehicleMileage.TabIndex = 8;
            this.lblRegisterVehicleRentalVehicleMileage.Text = "Mileage:";
            // 
            // lblRegisterVehicleRentalVehicleRegistrationNumber
            // 
            this.lblRegisterVehicleRentalVehicleRegistrationNumber.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleRegistrationNumber.Location = new System.Drawing.Point(3, 134);
            this.lblRegisterVehicleRentalVehicleRegistrationNumber.Name = "lblRegisterVehicleRentalVehicleRegistrationNumber";
            this.lblRegisterVehicleRentalVehicleRegistrationNumber.Size = new System.Drawing.Size(99, 20);
            this.lblRegisterVehicleRentalVehicleRegistrationNumber.TabIndex = 7;
            this.lblRegisterVehicleRentalVehicleRegistrationNumber.Text = "Reg. Number:";
            // 
            // tbxRegisterVehicleRentalVehicleManufacturer
            // 
            this.tbxRegisterVehicleRentalVehicleManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehicleManufacturer.Location = new System.Drawing.Point(123, 3);
            this.tbxRegisterVehicleRentalVehicleManufacturer.Name = "tbxRegisterVehicleRentalVehicleManufacturer";
            this.tbxRegisterVehicleRentalVehicleManufacturer.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehicleManufacturer.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehicleManufacturer.TabIndex = 5;
            this.tbxRegisterVehicleRentalVehicleManufacturer.TabStop = false;
            // 
            // tbxRegisterVehicleRentalVehicleModel
            // 
            this.tbxRegisterVehicleRentalVehicleModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehicleModel.Location = new System.Drawing.Point(123, 45);
            this.tbxRegisterVehicleRentalVehicleModel.Name = "tbxRegisterVehicleRentalVehicleModel";
            this.tbxRegisterVehicleRentalVehicleModel.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehicleModel.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehicleModel.TabIndex = 4;
            this.tbxRegisterVehicleRentalVehicleModel.TabStop = false;
            // 
            // tbxRegisterVehicleRentalVehicleYearOfProduction
            // 
            this.tbxRegisterVehicleRentalVehicleYearOfProduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalVehicleYearOfProduction.Location = new System.Drawing.Point(123, 88);
            this.tbxRegisterVehicleRentalVehicleYearOfProduction.Name = "tbxRegisterVehicleRentalVehicleYearOfProduction";
            this.tbxRegisterVehicleRentalVehicleYearOfProduction.ReadOnly = true;
            this.tbxRegisterVehicleRentalVehicleYearOfProduction.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalVehicleYearOfProduction.TabIndex = 3;
            this.tbxRegisterVehicleRentalVehicleYearOfProduction.TabStop = false;
            // 
            // lblRegisterVehicleRentalVehicleYearOfProduction
            // 
            this.lblRegisterVehicleRentalVehicleYearOfProduction.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleYearOfProduction.Location = new System.Drawing.Point(4, 91);
            this.lblRegisterVehicleRentalVehicleYearOfProduction.Name = "lblRegisterVehicleRentalVehicleYearOfProduction";
            this.lblRegisterVehicleRentalVehicleYearOfProduction.Size = new System.Drawing.Size(78, 20);
            this.lblRegisterVehicleRentalVehicleYearOfProduction.TabIndex = 2;
            this.lblRegisterVehicleRentalVehicleYearOfProduction.Text = "Prod. Year:";
            // 
            // lblRegisterVehicleRentalVehicleModel
            // 
            this.lblRegisterVehicleRentalVehicleModel.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleModel.Location = new System.Drawing.Point(4, 48);
            this.lblRegisterVehicleRentalVehicleModel.Name = "lblRegisterVehicleRentalVehicleModel";
            this.lblRegisterVehicleRentalVehicleModel.Size = new System.Drawing.Size(55, 20);
            this.lblRegisterVehicleRentalVehicleModel.TabIndex = 1;
            this.lblRegisterVehicleRentalVehicleModel.Text = "Model:";
            // 
            // lblRegisterVehicleRentalVehicleManufacturer
            // 
            this.lblRegisterVehicleRentalVehicleManufacturer.AutoSize = true;
            this.lblRegisterVehicleRentalVehicleManufacturer.Location = new System.Drawing.Point(3, 6);
            this.lblRegisterVehicleRentalVehicleManufacturer.Name = "lblRegisterVehicleRentalVehicleManufacturer";
            this.lblRegisterVehicleRentalVehicleManufacturer.Size = new System.Drawing.Size(100, 20);
            this.lblRegisterVehicleRentalVehicleManufacturer.TabIndex = 0;
            this.lblRegisterVehicleRentalVehicleManufacturer.Text = "Manufacturer:";
            // 
            // btnRegisterVehicleRental
            // 
            this.btnRegisterVehicleRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRegisterVehicleRentalLayout.SetColumnSpan(this.btnRegisterVehicleRental, 2);
            this.btnRegisterVehicleRental.Location = new System.Drawing.Point(337, 625);
            this.btnRegisterVehicleRental.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRegisterVehicleRental.Name = "btnRegisterVehicleRental";
            this.btnRegisterVehicleRental.Size = new System.Drawing.Size(150, 30);
            this.btnRegisterVehicleRental.TabIndex = 0;
            this.btnRegisterVehicleRental.TabStop = false;
            this.btnRegisterVehicleRental.Text = "Register Rental";
            this.btnRegisterVehicleRental.UseVisualStyleBackColor = true;
            this.btnRegisterVehicleRental.Click += new System.EventHandler(this.btnRegisterVehicleRental_Click);
            // 
            // pnlRegisterVehicleRentalRight
            // 
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.btnRegisterRentalApplyCustomerFilters);
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.dgvRegisterVehicleRentalCustomers);
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.tbxRegisterVehicleRentalCustomerFirstName);
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.tbxRegisterVehicleRentalCustomerLastName);
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.tbxRegisterVehicleRentalCustomerDriverLicense);
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.lblRegisterVehicleRentalCustomerDriverLicense);
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.lblRegisterVehicleRentalCustomerLastName);
            this.pnlRegisterVehicleRentalRight.Controls.Add(this.lblRegisterVehicleRentalCustomerFirstName);
            this.pnlRegisterVehicleRentalRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterVehicleRentalRight.Location = new System.Drawing.Point(412, 0);
            this.pnlRegisterVehicleRentalRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterVehicleRentalRight.Name = "pnlRegisterVehicleRentalRight";
            this.pnlRegisterVehicleRentalRight.Size = new System.Drawing.Size(412, 620);
            this.pnlRegisterVehicleRentalRight.TabIndex = 2;
            // 
            // btnRegisterRentalApplyCustomerFilters
            // 
            this.btnRegisterRentalApplyCustomerFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterRentalApplyCustomerFilters.Location = new System.Drawing.Point(3, 130);
            this.btnRegisterRentalApplyCustomerFilters.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRegisterRentalApplyCustomerFilters.Name = "btnRegisterRentalApplyCustomerFilters";
            this.btnRegisterRentalApplyCustomerFilters.Size = new System.Drawing.Size(402, 30);
            this.btnRegisterRentalApplyCustomerFilters.TabIndex = 8;
            this.btnRegisterRentalApplyCustomerFilters.TabStop = false;
            this.btnRegisterRentalApplyCustomerFilters.Text = "Apply Filters";
            this.btnRegisterRentalApplyCustomerFilters.UseVisualStyleBackColor = true;
            this.btnRegisterRentalApplyCustomerFilters.Click += new System.EventHandler(this.btnRegisterRentalApplyCustomerFilters_Click);
            // 
            // dgvRegisterVehicleRentalCustomers
            // 
            this.dgvRegisterVehicleRentalCustomers.AllowUserToAddRows = false;
            this.dgvRegisterVehicleRentalCustomers.AllowUserToDeleteRows = false;
            this.dgvRegisterVehicleRentalCustomers.AllowUserToOrderColumns = true;
            this.dgvRegisterVehicleRentalCustomers.AllowUserToResizeColumns = false;
            this.dgvRegisterVehicleRentalCustomers.AllowUserToResizeRows = false;
            this.dgvRegisterVehicleRentalCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegisterVehicleRentalCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisterVehicleRentalCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRegisterVehicleRentalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegisterVehicleRentalCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterVehicleRentalCustomers.Location = new System.Drawing.Point(3, 173);
            this.dgvRegisterVehicleRentalCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRegisterVehicleRentalCustomers.MultiSelect = false;
            this.dgvRegisterVehicleRentalCustomers.Name = "dgvRegisterVehicleRentalCustomers";
            this.dgvRegisterVehicleRentalCustomers.ReadOnly = true;
            this.dgvRegisterVehicleRentalCustomers.RowHeadersVisible = false;
            this.dgvRegisterVehicleRentalCustomers.RowHeadersWidth = 51;
            this.dgvRegisterVehicleRentalCustomers.RowTemplate.Height = 29;
            this.dgvRegisterVehicleRentalCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisterVehicleRentalCustomers.Size = new System.Drawing.Size(402, 447);
            this.dgvRegisterVehicleRentalCustomers.TabIndex = 7;
            // 
            // tbxRegisterVehicleRentalCustomerFirstName
            // 
            this.tbxRegisterVehicleRentalCustomerFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalCustomerFirstName.Location = new System.Drawing.Point(123, 3);
            this.tbxRegisterVehicleRentalCustomerFirstName.Name = "tbxRegisterVehicleRentalCustomerFirstName";
            this.tbxRegisterVehicleRentalCustomerFirstName.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalCustomerFirstName.TabIndex = 5;
            // 
            // tbxRegisterVehicleRentalCustomerLastName
            // 
            this.tbxRegisterVehicleRentalCustomerLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalCustomerLastName.Location = new System.Drawing.Point(123, 45);
            this.tbxRegisterVehicleRentalCustomerLastName.Name = "tbxRegisterVehicleRentalCustomerLastName";
            this.tbxRegisterVehicleRentalCustomerLastName.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalCustomerLastName.TabIndex = 4;
            // 
            // tbxRegisterVehicleRentalCustomerDriverLicense
            // 
            this.tbxRegisterVehicleRentalCustomerDriverLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterVehicleRentalCustomerDriverLicense.Location = new System.Drawing.Point(123, 88);
            this.tbxRegisterVehicleRentalCustomerDriverLicense.Name = "tbxRegisterVehicleRentalCustomerDriverLicense";
            this.tbxRegisterVehicleRentalCustomerDriverLicense.Size = new System.Drawing.Size(282, 27);
            this.tbxRegisterVehicleRentalCustomerDriverLicense.TabIndex = 3;
            // 
            // lblRegisterVehicleRentalCustomerDriverLicense
            // 
            this.lblRegisterVehicleRentalCustomerDriverLicense.AutoSize = true;
            this.lblRegisterVehicleRentalCustomerDriverLicense.Location = new System.Drawing.Point(3, 91);
            this.lblRegisterVehicleRentalCustomerDriverLicense.Name = "lblRegisterVehicleRentalCustomerDriverLicense";
            this.lblRegisterVehicleRentalCustomerDriverLicense.Size = new System.Drawing.Size(104, 20);
            this.lblRegisterVehicleRentalCustomerDriverLicense.TabIndex = 2;
            this.lblRegisterVehicleRentalCustomerDriverLicense.Text = "Driver License:";
            // 
            // lblRegisterVehicleRentalCustomerLastName
            // 
            this.lblRegisterVehicleRentalCustomerLastName.AutoSize = true;
            this.lblRegisterVehicleRentalCustomerLastName.Location = new System.Drawing.Point(3, 48);
            this.lblRegisterVehicleRentalCustomerLastName.Name = "lblRegisterVehicleRentalCustomerLastName";
            this.lblRegisterVehicleRentalCustomerLastName.Size = new System.Drawing.Size(82, 20);
            this.lblRegisterVehicleRentalCustomerLastName.TabIndex = 1;
            this.lblRegisterVehicleRentalCustomerLastName.Text = "Last Name:";
            // 
            // lblRegisterVehicleRentalCustomerFirstName
            // 
            this.lblRegisterVehicleRentalCustomerFirstName.AutoSize = true;
            this.lblRegisterVehicleRentalCustomerFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblRegisterVehicleRentalCustomerFirstName.Name = "lblRegisterVehicleRentalCustomerFirstName";
            this.lblRegisterVehicleRentalCustomerFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblRegisterVehicleRentalCustomerFirstName.TabIndex = 0;
            this.lblRegisterVehicleRentalCustomerFirstName.Text = "First Name:";
            // 
            // tpgRegisterReturn
            // 
            this.tpgRegisterReturn.Controls.Add(this.pnlRegisterVehicleReturnLayout);
            this.tpgRegisterReturn.Location = new System.Drawing.Point(4, 5);
            this.tpgRegisterReturn.Margin = new System.Windows.Forms.Padding(0);
            this.tpgRegisterReturn.Name = "tpgRegisterReturn";
            this.tpgRegisterReturn.Size = new System.Drawing.Size(824, 655);
            this.tpgRegisterReturn.TabIndex = 3;
            this.tpgRegisterReturn.UseVisualStyleBackColor = true;
            // 
            // pnlRegisterVehicleReturnLayout
            // 
            this.pnlRegisterVehicleReturnLayout.ColumnCount = 1;
            this.pnlRegisterVehicleReturnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterVehicleReturnLayout.Controls.Add(this.pnlRegisterCarReturnLower, 0, 1);
            this.pnlRegisterVehicleReturnLayout.Controls.Add(this.btnRegisterVehicleReturn, 0, 2);
            this.pnlRegisterVehicleReturnLayout.Controls.Add(this.pnlRegisterCarReturnUpper, 0, 0);
            this.pnlRegisterVehicleReturnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterVehicleReturnLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterVehicleReturnLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterVehicleReturnLayout.Name = "pnlRegisterVehicleReturnLayout";
            this.pnlRegisterVehicleReturnLayout.RowCount = 3;
            this.pnlRegisterVehicleReturnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRegisterVehicleReturnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRegisterVehicleReturnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlRegisterVehicleReturnLayout.Size = new System.Drawing.Size(824, 655);
            this.pnlRegisterVehicleReturnLayout.TabIndex = 0;
            // 
            // pnlRegisterCarReturnLower
            // 
            this.pnlRegisterCarReturnLower.Controls.Add(this.pnlRegisterVehicleReturnCustomerFilters);
            this.pnlRegisterCarReturnLower.Controls.Add(this.dgvRegisterVehicleReturnCustomers);
            this.pnlRegisterCarReturnLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterCarReturnLower.Location = new System.Drawing.Point(0, 310);
            this.pnlRegisterCarReturnLower.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterCarReturnLower.Name = "pnlRegisterCarReturnLower";
            this.pnlRegisterCarReturnLower.Size = new System.Drawing.Size(824, 310);
            this.pnlRegisterCarReturnLower.TabIndex = 4;
            // 
            // pnlRegisterVehicleReturnCustomerFilters
            // 
            this.pnlRegisterVehicleReturnCustomerFilters.ColumnCount = 3;
            this.pnlRegisterVehicleReturnCustomerFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlRegisterVehicleReturnCustomerFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterVehicleReturnCustomerFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlRegisterVehicleReturnCustomerFilters.Controls.Add(this.btnRegisterVehicleReturnCustomerApplyFilter, 2, 0);
            this.pnlRegisterVehicleReturnCustomerFilters.Controls.Add(this.lblRegisterVehicleReturnCustomerDriverLicenseNumber, 0, 0);
            this.pnlRegisterVehicleReturnCustomerFilters.Controls.Add(this.tbxRegisterVehicleReturnCustomerDriverLicenseNumber, 1, 0);
            this.pnlRegisterVehicleReturnCustomerFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegisterVehicleReturnCustomerFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterVehicleReturnCustomerFilters.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterVehicleReturnCustomerFilters.Name = "pnlRegisterVehicleReturnCustomerFilters";
            this.pnlRegisterVehicleReturnCustomerFilters.RowCount = 1;
            this.pnlRegisterVehicleReturnCustomerFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterVehicleReturnCustomerFilters.Size = new System.Drawing.Size(824, 33);
            this.pnlRegisterVehicleReturnCustomerFilters.TabIndex = 7;
            // 
            // btnRegisterVehicleReturnCustomerApplyFilter
            // 
            this.btnRegisterVehicleReturnCustomerApplyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterVehicleReturnCustomerApplyFilter.Location = new System.Drawing.Point(703, 1);
            this.btnRegisterVehicleReturnCustomerApplyFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterVehicleReturnCustomerApplyFilter.Name = "btnRegisterVehicleReturnCustomerApplyFilter";
            this.btnRegisterVehicleReturnCustomerApplyFilter.Size = new System.Drawing.Size(121, 30);
            this.btnRegisterVehicleReturnCustomerApplyFilter.TabIndex = 5;
            this.btnRegisterVehicleReturnCustomerApplyFilter.TabStop = false;
            this.btnRegisterVehicleReturnCustomerApplyFilter.Text = "Apply";
            this.btnRegisterVehicleReturnCustomerApplyFilter.UseVisualStyleBackColor = true;
            this.btnRegisterVehicleReturnCustomerApplyFilter.Click += new System.EventHandler(this.btnRegisterVehicleReturnCustomerApplyFilter_Click);
            // 
            // lblRegisterVehicleReturnCustomerDriverLicenseNumber
            // 
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber.AutoSize = true;
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber.Location = new System.Drawing.Point(3, 6);
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber.Name = "lblRegisterVehicleReturnCustomerDriverLicenseNumber";
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber.Size = new System.Drawing.Size(162, 20);
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber.TabIndex = 3;
            this.lblRegisterVehicleReturnCustomerDriverLicenseNumber.Text = "Driver License Number:";
            // 
            // tbxRegisterVehicleReturnCustomerDriverLicenseNumber
            // 
            this.tbxRegisterVehicleReturnCustomerDriverLicenseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRegisterVehicleReturnCustomerDriverLicenseNumber.Location = new System.Drawing.Point(171, 3);
            this.tbxRegisterVehicleReturnCustomerDriverLicenseNumber.Name = "tbxRegisterVehicleReturnCustomerDriverLicenseNumber";
            this.tbxRegisterVehicleReturnCustomerDriverLicenseNumber.Size = new System.Drawing.Size(529, 27);
            this.tbxRegisterVehicleReturnCustomerDriverLicenseNumber.TabIndex = 4;
            // 
            // dgvRegisterVehicleReturnCustomers
            // 
            this.dgvRegisterVehicleReturnCustomers.AllowUserToAddRows = false;
            this.dgvRegisterVehicleReturnCustomers.AllowUserToDeleteRows = false;
            this.dgvRegisterVehicleReturnCustomers.AllowUserToOrderColumns = true;
            this.dgvRegisterVehicleReturnCustomers.AllowUserToResizeColumns = false;
            this.dgvRegisterVehicleReturnCustomers.AllowUserToResizeRows = false;
            this.dgvRegisterVehicleReturnCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegisterVehicleReturnCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisterVehicleReturnCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRegisterVehicleReturnCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegisterVehicleReturnCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterVehicleReturnCustomers.Location = new System.Drawing.Point(0, 36);
            this.dgvRegisterVehicleReturnCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRegisterVehicleReturnCustomers.MultiSelect = false;
            this.dgvRegisterVehicleReturnCustomers.Name = "dgvRegisterVehicleReturnCustomers";
            this.dgvRegisterVehicleReturnCustomers.ReadOnly = true;
            this.dgvRegisterVehicleReturnCustomers.RowHeadersVisible = false;
            this.dgvRegisterVehicleReturnCustomers.RowHeadersWidth = 51;
            this.dgvRegisterVehicleReturnCustomers.RowTemplate.Height = 29;
            this.dgvRegisterVehicleReturnCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisterVehicleReturnCustomers.Size = new System.Drawing.Size(824, 279);
            this.dgvRegisterVehicleReturnCustomers.TabIndex = 2;
            // 
            // btnRegisterVehicleReturn
            // 
            this.btnRegisterVehicleReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterVehicleReturn.Location = new System.Drawing.Point(337, 625);
            this.btnRegisterVehicleReturn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRegisterVehicleReturn.Name = "btnRegisterVehicleReturn";
            this.btnRegisterVehicleReturn.Size = new System.Drawing.Size(150, 30);
            this.btnRegisterVehicleReturn.TabIndex = 1;
            this.btnRegisterVehicleReturn.TabStop = false;
            this.btnRegisterVehicleReturn.Text = "Return Car";
            this.btnRegisterVehicleReturn.UseVisualStyleBackColor = true;
            this.btnRegisterVehicleReturn.Click += new System.EventHandler(this.btnRegisterVehicleReturn_Click);
            // 
            // pnlRegisterCarReturnUpper
            // 
            this.pnlRegisterCarReturnUpper.Controls.Add(this.pnlRegisterVehicleReturnVehicleFilters);
            this.pnlRegisterCarReturnUpper.Controls.Add(this.dgvRegisterVehicleReturnVehicles);
            this.pnlRegisterCarReturnUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterCarReturnUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterCarReturnUpper.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterCarReturnUpper.Name = "pnlRegisterCarReturnUpper";
            this.pnlRegisterCarReturnUpper.Size = new System.Drawing.Size(824, 310);
            this.pnlRegisterCarReturnUpper.TabIndex = 3;
            // 
            // pnlRegisterVehicleReturnVehicleFilters
            // 
            this.pnlRegisterVehicleReturnVehicleFilters.ColumnCount = 3;
            this.pnlRegisterVehicleReturnVehicleFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlRegisterVehicleReturnVehicleFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterVehicleReturnVehicleFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlRegisterVehicleReturnVehicleFilters.Controls.Add(this.btnRegisterVehicleReturnVehicleApplyFilter, 2, 0);
            this.pnlRegisterVehicleReturnVehicleFilters.Controls.Add(this.lblRegisterVehicleReturnVehicleRegistrarionNumber, 0, 0);
            this.pnlRegisterVehicleReturnVehicleFilters.Controls.Add(this.tbxRegisterVehicleReturnVehicleRegistrationNumber, 1, 0);
            this.pnlRegisterVehicleReturnVehicleFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegisterVehicleReturnVehicleFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterVehicleReturnVehicleFilters.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterVehicleReturnVehicleFilters.Name = "pnlRegisterVehicleReturnVehicleFilters";
            this.pnlRegisterVehicleReturnVehicleFilters.RowCount = 1;
            this.pnlRegisterVehicleReturnVehicleFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterVehicleReturnVehicleFilters.Size = new System.Drawing.Size(824, 33);
            this.pnlRegisterVehicleReturnVehicleFilters.TabIndex = 6;
            // 
            // btnRegisterVehicleReturnVehicleApplyFilter
            // 
            this.btnRegisterVehicleReturnVehicleApplyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterVehicleReturnVehicleApplyFilter.Location = new System.Drawing.Point(703, 1);
            this.btnRegisterVehicleReturnVehicleApplyFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterVehicleReturnVehicleApplyFilter.Name = "btnRegisterVehicleReturnVehicleApplyFilter";
            this.btnRegisterVehicleReturnVehicleApplyFilter.Size = new System.Drawing.Size(121, 30);
            this.btnRegisterVehicleReturnVehicleApplyFilter.TabIndex = 5;
            this.btnRegisterVehicleReturnVehicleApplyFilter.TabStop = false;
            this.btnRegisterVehicleReturnVehicleApplyFilter.Text = "Apply";
            this.btnRegisterVehicleReturnVehicleApplyFilter.UseVisualStyleBackColor = true;
            this.btnRegisterVehicleReturnVehicleApplyFilter.Click += new System.EventHandler(this.btnRegisterVehicleReturnVehicleApplyFilter_Click);
            // 
            // lblRegisterVehicleReturnVehicleRegistrarionNumber
            // 
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber.AutoSize = true;
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber.Location = new System.Drawing.Point(3, 6);
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber.Name = "lblRegisterVehicleReturnVehicleRegistrarionNumber";
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber.Size = new System.Drawing.Size(150, 20);
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber.TabIndex = 3;
            this.lblRegisterVehicleReturnVehicleRegistrarionNumber.Text = "Registration Number:";
            // 
            // tbxRegisterVehicleReturnVehicleRegistrationNumber
            // 
            this.tbxRegisterVehicleReturnVehicleRegistrationNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRegisterVehicleReturnVehicleRegistrationNumber.Location = new System.Drawing.Point(159, 3);
            this.tbxRegisterVehicleReturnVehicleRegistrationNumber.Name = "tbxRegisterVehicleReturnVehicleRegistrationNumber";
            this.tbxRegisterVehicleReturnVehicleRegistrationNumber.Size = new System.Drawing.Size(541, 27);
            this.tbxRegisterVehicleReturnVehicleRegistrationNumber.TabIndex = 4;
            // 
            // dgvRegisterVehicleReturnVehicles
            // 
            this.dgvRegisterVehicleReturnVehicles.AllowUserToAddRows = false;
            this.dgvRegisterVehicleReturnVehicles.AllowUserToDeleteRows = false;
            this.dgvRegisterVehicleReturnVehicles.AllowUserToOrderColumns = true;
            this.dgvRegisterVehicleReturnVehicles.AllowUserToResizeColumns = false;
            this.dgvRegisterVehicleReturnVehicles.AllowUserToResizeRows = false;
            this.dgvRegisterVehicleReturnVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegisterVehicleReturnVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisterVehicleReturnVehicles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRegisterVehicleReturnVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegisterVehicleReturnVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterVehicleReturnVehicles.Location = new System.Drawing.Point(0, 36);
            this.dgvRegisterVehicleReturnVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRegisterVehicleReturnVehicles.MultiSelect = false;
            this.dgvRegisterVehicleReturnVehicles.Name = "dgvRegisterVehicleReturnVehicles";
            this.dgvRegisterVehicleReturnVehicles.ReadOnly = true;
            this.dgvRegisterVehicleReturnVehicles.RowHeadersVisible = false;
            this.dgvRegisterVehicleReturnVehicles.RowHeadersWidth = 51;
            this.dgvRegisterVehicleReturnVehicles.RowTemplate.Height = 29;
            this.dgvRegisterVehicleReturnVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisterVehicleReturnVehicles.Size = new System.Drawing.Size(824, 277);
            this.dgvRegisterVehicleReturnVehicles.TabIndex = 2;
            // 
            // tpgCustomers
            // 
            this.tpgCustomers.Controls.Add(this.dgvCustomers);
            this.tpgCustomers.Location = new System.Drawing.Point(4, 5);
            this.tpgCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.tpgCustomers.Name = "tpgCustomers";
            this.tpgCustomers.Size = new System.Drawing.Size(824, 655);
            this.tpgCustomers.TabIndex = 4;
            this.tpgCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 29;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(824, 655);
            this.dgvCustomers.TabIndex = 8;
            // 
            // tpgCustomerRegistration
            // 
            this.tpgCustomerRegistration.Controls.Add(this.pnlRegisterNewCustomerLayout);
            this.tpgCustomerRegistration.Location = new System.Drawing.Point(4, 5);
            this.tpgCustomerRegistration.Margin = new System.Windows.Forms.Padding(0);
            this.tpgCustomerRegistration.Name = "tpgCustomerRegistration";
            this.tpgCustomerRegistration.Size = new System.Drawing.Size(824, 655);
            this.tpgCustomerRegistration.TabIndex = 5;
            this.tpgCustomerRegistration.UseVisualStyleBackColor = true;
            // 
            // pnlRegisterNewCustomerLayout
            // 
            this.pnlRegisterNewCustomerLayout.ColumnCount = 1;
            this.pnlRegisterNewCustomerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterNewCustomerLayout.Controls.Add(this.dgvRegisterNewCustomer, 0, 1);
            this.pnlRegisterNewCustomerLayout.Controls.Add(this.pnlRegisterNewCustomerFilters, 0, 0);
            this.pnlRegisterNewCustomerLayout.Controls.Add(this.btnRegisterNewCustomer, 0, 2);
            this.pnlRegisterNewCustomerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterNewCustomerLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterNewCustomerLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterNewCustomerLayout.Name = "pnlRegisterNewCustomerLayout";
            this.pnlRegisterNewCustomerLayout.RowCount = 3;
            this.pnlRegisterNewCustomerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.pnlRegisterNewCustomerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegisterNewCustomerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlRegisterNewCustomerLayout.Size = new System.Drawing.Size(824, 655);
            this.pnlRegisterNewCustomerLayout.TabIndex = 0;
            // 
            // dgvRegisterNewCustomer
            // 
            this.dgvRegisterNewCustomer.AllowUserToAddRows = false;
            this.dgvRegisterNewCustomer.AllowUserToDeleteRows = false;
            this.dgvRegisterNewCustomer.AllowUserToOrderColumns = true;
            this.dgvRegisterNewCustomer.AllowUserToResizeColumns = false;
            this.dgvRegisterNewCustomer.AllowUserToResizeRows = false;
            this.dgvRegisterNewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisterNewCustomer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRegisterNewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegisterNewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterNewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegisterNewCustomer.Location = new System.Drawing.Point(0, 140);
            this.dgvRegisterNewCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRegisterNewCustomer.MultiSelect = false;
            this.dgvRegisterNewCustomer.Name = "dgvRegisterNewCustomer";
            this.dgvRegisterNewCustomer.ReadOnly = true;
            this.dgvRegisterNewCustomer.RowHeadersVisible = false;
            this.dgvRegisterNewCustomer.RowHeadersWidth = 51;
            this.dgvRegisterNewCustomer.RowTemplate.Height = 29;
            this.dgvRegisterNewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisterNewCustomer.Size = new System.Drawing.Size(824, 482);
            this.dgvRegisterNewCustomer.TabIndex = 6;
            // 
            // pnlRegisterNewCustomerFilters
            // 
            this.pnlRegisterNewCustomerFilters.Controls.Add(this.btnRegisterNewCustomerApplyFilters);
            this.pnlRegisterNewCustomerFilters.Controls.Add(this.tbxRegisterNewCustomerDriverLicenseNumber);
            this.pnlRegisterNewCustomerFilters.Controls.Add(this.lblRegisterNewCustomerDriverLicenseNumber);
            this.pnlRegisterNewCustomerFilters.Controls.Add(this.tbxRegisterNewCustomerLastName);
            this.pnlRegisterNewCustomerFilters.Controls.Add(this.tbxRegisterNewCustomerFirstName);
            this.pnlRegisterNewCustomerFilters.Controls.Add(this.lblRegisterNewCustomerLastName);
            this.pnlRegisterNewCustomerFilters.Controls.Add(this.lblRegisterNewCustomerFirstName);
            this.pnlRegisterNewCustomerFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterNewCustomerFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterNewCustomerFilters.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRegisterNewCustomerFilters.Name = "pnlRegisterNewCustomerFilters";
            this.pnlRegisterNewCustomerFilters.Size = new System.Drawing.Size(824, 140);
            this.pnlRegisterNewCustomerFilters.TabIndex = 3;
            // 
            // btnRegisterNewCustomerApplyFilters
            // 
            this.btnRegisterNewCustomerApplyFilters.Location = new System.Drawing.Point(92, 102);
            this.btnRegisterNewCustomerApplyFilters.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRegisterNewCustomerApplyFilters.Name = "btnRegisterNewCustomerApplyFilters";
            this.btnRegisterNewCustomerApplyFilters.Size = new System.Drawing.Size(150, 30);
            this.btnRegisterNewCustomerApplyFilters.TabIndex = 6;
            this.btnRegisterNewCustomerApplyFilters.TabStop = false;
            this.btnRegisterNewCustomerApplyFilters.Text = "Apply Filters";
            this.btnRegisterNewCustomerApplyFilters.UseVisualStyleBackColor = true;
            this.btnRegisterNewCustomerApplyFilters.Click += new System.EventHandler(this.btnRegisterNewCustomerApplyFilters_Click);
            // 
            // tbxRegisterNewCustomerDriverLicenseNumber
            // 
            this.tbxRegisterNewCustomerDriverLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterNewCustomerDriverLicenseNumber.Location = new System.Drawing.Point(92, 69);
            this.tbxRegisterNewCustomerDriverLicenseNumber.Name = "tbxRegisterNewCustomerDriverLicenseNumber";
            this.tbxRegisterNewCustomerDriverLicenseNumber.Size = new System.Drawing.Size(729, 27);
            this.tbxRegisterNewCustomerDriverLicenseNumber.TabIndex = 5;
            // 
            // lblRegisterNewCustomerDriverLicenseNumber
            // 
            this.lblRegisterNewCustomerDriverLicenseNumber.AutoSize = true;
            this.lblRegisterNewCustomerDriverLicenseNumber.Location = new System.Drawing.Point(3, 72);
            this.lblRegisterNewCustomerDriverLicenseNumber.Name = "lblRegisterNewCustomerDriverLicenseNumber";
            this.lblRegisterNewCustomerDriverLicenseNumber.Size = new System.Drawing.Size(60, 20);
            this.lblRegisterNewCustomerDriverLicenseNumber.TabIndex = 4;
            this.lblRegisterNewCustomerDriverLicenseNumber.Text = "License:";
            // 
            // tbxRegisterNewCustomerLastName
            // 
            this.tbxRegisterNewCustomerLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterNewCustomerLastName.Location = new System.Drawing.Point(92, 36);
            this.tbxRegisterNewCustomerLastName.Name = "tbxRegisterNewCustomerLastName";
            this.tbxRegisterNewCustomerLastName.Size = new System.Drawing.Size(729, 27);
            this.tbxRegisterNewCustomerLastName.TabIndex = 3;
            // 
            // tbxRegisterNewCustomerFirstName
            // 
            this.tbxRegisterNewCustomerFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegisterNewCustomerFirstName.Location = new System.Drawing.Point(92, 3);
            this.tbxRegisterNewCustomerFirstName.Name = "tbxRegisterNewCustomerFirstName";
            this.tbxRegisterNewCustomerFirstName.Size = new System.Drawing.Size(729, 27);
            this.tbxRegisterNewCustomerFirstName.TabIndex = 2;
            // 
            // lblRegisterNewCustomerLastName
            // 
            this.lblRegisterNewCustomerLastName.AutoSize = true;
            this.lblRegisterNewCustomerLastName.Location = new System.Drawing.Point(3, 39);
            this.lblRegisterNewCustomerLastName.Name = "lblRegisterNewCustomerLastName";
            this.lblRegisterNewCustomerLastName.Size = new System.Drawing.Size(82, 20);
            this.lblRegisterNewCustomerLastName.TabIndex = 1;
            this.lblRegisterNewCustomerLastName.Text = "Last Name:";
            // 
            // lblRegisterNewCustomerFirstName
            // 
            this.lblRegisterNewCustomerFirstName.AutoSize = true;
            this.lblRegisterNewCustomerFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblRegisterNewCustomerFirstName.Name = "lblRegisterNewCustomerFirstName";
            this.lblRegisterNewCustomerFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblRegisterNewCustomerFirstName.TabIndex = 0;
            this.lblRegisterNewCustomerFirstName.Text = "First Name:";
            // 
            // btnRegisterNewCustomer
            // 
            this.btnRegisterNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterNewCustomer.Location = new System.Drawing.Point(337, 625);
            this.btnRegisterNewCustomer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRegisterNewCustomer.Name = "btnRegisterNewCustomer";
            this.btnRegisterNewCustomer.Size = new System.Drawing.Size(150, 30);
            this.btnRegisterNewCustomer.TabIndex = 2;
            this.btnRegisterNewCustomer.TabStop = false;
            this.btnRegisterNewCustomer.Text = "Register";
            this.btnRegisterNewCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterNewCustomer.Click += new System.EventHandler(this.btnRegisterNewCustomer_Click);
            // 
            // tpgCustomerHistory
            // 
            this.tpgCustomerHistory.Controls.Add(this.pnlCustomerHistoryLayout);
            this.tpgCustomerHistory.Location = new System.Drawing.Point(4, 5);
            this.tpgCustomerHistory.Margin = new System.Windows.Forms.Padding(0);
            this.tpgCustomerHistory.Name = "tpgCustomerHistory";
            this.tpgCustomerHistory.Size = new System.Drawing.Size(824, 655);
            this.tpgCustomerHistory.TabIndex = 6;
            this.tpgCustomerHistory.UseVisualStyleBackColor = true;
            // 
            // pnlCustomerHistoryLayout
            // 
            this.pnlCustomerHistoryLayout.ColumnCount = 1;
            this.pnlCustomerHistoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCustomerHistoryLayout.Controls.Add(this.dgvCustomerHistory, 0, 2);
            this.pnlCustomerHistoryLayout.Controls.Add(this.dgvCustomerHistoryCustomers, 0, 1);
            this.pnlCustomerHistoryLayout.Controls.Add(this.pnlCustomerHistoryFilters, 0, 0);
            this.pnlCustomerHistoryLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerHistoryLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerHistoryLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCustomerHistoryLayout.Name = "pnlCustomerHistoryLayout";
            this.pnlCustomerHistoryLayout.RowCount = 3;
            this.pnlCustomerHistoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.pnlCustomerHistoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlCustomerHistoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlCustomerHistoryLayout.Size = new System.Drawing.Size(824, 655);
            this.pnlCustomerHistoryLayout.TabIndex = 16;
            // 
            // dgvCustomerHistory
            // 
            this.dgvCustomerHistory.AllowUserToAddRows = false;
            this.dgvCustomerHistory.AllowUserToDeleteRows = false;
            this.dgvCustomerHistory.AllowUserToOrderColumns = true;
            this.dgvCustomerHistory.AllowUserToResizeColumns = false;
            this.dgvCustomerHistory.AllowUserToResizeRows = false;
            this.dgvCustomerHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomerHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerHistory.Location = new System.Drawing.Point(0, 253);
            this.dgvCustomerHistory.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dgvCustomerHistory.MultiSelect = false;
            this.dgvCustomerHistory.Name = "dgvCustomerHistory";
            this.dgvCustomerHistory.ReadOnly = true;
            this.dgvCustomerHistory.RowHeadersVisible = false;
            this.dgvCustomerHistory.RowHeadersWidth = 51;
            this.dgvCustomerHistory.RowTemplate.Height = 29;
            this.dgvCustomerHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerHistory.Size = new System.Drawing.Size(824, 402);
            this.dgvCustomerHistory.TabIndex = 9;
            // 
            // dgvCustomerHistoryCustomers
            // 
            this.dgvCustomerHistoryCustomers.AllowUserToAddRows = false;
            this.dgvCustomerHistoryCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomerHistoryCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomerHistoryCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomerHistoryCustomers.AllowUserToResizeRows = false;
            this.dgvCustomerHistoryCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerHistoryCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomerHistoryCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerHistoryCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerHistoryCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerHistoryCustomers.Location = new System.Drawing.Point(0, 140);
            this.dgvCustomerHistoryCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCustomerHistoryCustomers.MultiSelect = false;
            this.dgvCustomerHistoryCustomers.Name = "dgvCustomerHistoryCustomers";
            this.dgvCustomerHistoryCustomers.ReadOnly = true;
            this.dgvCustomerHistoryCustomers.RowHeadersVisible = false;
            this.dgvCustomerHistoryCustomers.RowHeadersWidth = 51;
            this.dgvCustomerHistoryCustomers.RowTemplate.Height = 29;
            this.dgvCustomerHistoryCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerHistoryCustomers.Size = new System.Drawing.Size(824, 103);
            this.dgvCustomerHistoryCustomers.TabIndex = 10;
            this.dgvCustomerHistoryCustomers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomerHistoryCustomers_MouseClick);
            // 
            // pnlCustomerHistoryFilters
            // 
            this.pnlCustomerHistoryFilters.Controls.Add(this.btnCustomerHistoryApplyFilters);
            this.pnlCustomerHistoryFilters.Controls.Add(this.tbxCustomerHistoryCustomerFirstName);
            this.pnlCustomerHistoryFilters.Controls.Add(this.tbxCustomerHistoryCustomerDriverLicenseNumber);
            this.pnlCustomerHistoryFilters.Controls.Add(this.lblCustomerHistoryCustomerFirstName);
            this.pnlCustomerHistoryFilters.Controls.Add(this.lblCustomerHistoryCustomerDriverLicenseNumber);
            this.pnlCustomerHistoryFilters.Controls.Add(this.lblCustomerHistoryCustomerLastName);
            this.pnlCustomerHistoryFilters.Controls.Add(this.tbxCustomerHistoryCustomerLastName);
            this.pnlCustomerHistoryFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerHistoryFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerHistoryFilters.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCustomerHistoryFilters.Name = "pnlCustomerHistoryFilters";
            this.pnlCustomerHistoryFilters.Size = new System.Drawing.Size(824, 140);
            this.pnlCustomerHistoryFilters.TabIndex = 11;
            // 
            // btnCustomerHistoryApplyFilters
            // 
            this.btnCustomerHistoryApplyFilters.Location = new System.Drawing.Point(92, 102);
            this.btnCustomerHistoryApplyFilters.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCustomerHistoryApplyFilters.Name = "btnCustomerHistoryApplyFilters";
            this.btnCustomerHistoryApplyFilters.Size = new System.Drawing.Size(150, 30);
            this.btnCustomerHistoryApplyFilters.TabIndex = 16;
            this.btnCustomerHistoryApplyFilters.TabStop = false;
            this.btnCustomerHistoryApplyFilters.Text = "Apply Filters";
            this.btnCustomerHistoryApplyFilters.UseVisualStyleBackColor = true;
            this.btnCustomerHistoryApplyFilters.Click += new System.EventHandler(this.btnCustomerHistoryApplyFilters_Click);
            // 
            // tbxCustomerHistoryCustomerFirstName
            // 
            this.tbxCustomerHistoryCustomerFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerHistoryCustomerFirstName.Location = new System.Drawing.Point(92, 3);
            this.tbxCustomerHistoryCustomerFirstName.Name = "tbxCustomerHistoryCustomerFirstName";
            this.tbxCustomerHistoryCustomerFirstName.Size = new System.Drawing.Size(729, 27);
            this.tbxCustomerHistoryCustomerFirstName.TabIndex = 12;
            // 
            // tbxCustomerHistoryCustomerDriverLicenseNumber
            // 
            this.tbxCustomerHistoryCustomerDriverLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerHistoryCustomerDriverLicenseNumber.Location = new System.Drawing.Point(92, 69);
            this.tbxCustomerHistoryCustomerDriverLicenseNumber.Name = "tbxCustomerHistoryCustomerDriverLicenseNumber";
            this.tbxCustomerHistoryCustomerDriverLicenseNumber.Size = new System.Drawing.Size(729, 27);
            this.tbxCustomerHistoryCustomerDriverLicenseNumber.TabIndex = 15;
            // 
            // lblCustomerHistoryCustomerFirstName
            // 
            this.lblCustomerHistoryCustomerFirstName.AutoSize = true;
            this.lblCustomerHistoryCustomerFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblCustomerHistoryCustomerFirstName.Name = "lblCustomerHistoryCustomerFirstName";
            this.lblCustomerHistoryCustomerFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblCustomerHistoryCustomerFirstName.TabIndex = 10;
            this.lblCustomerHistoryCustomerFirstName.Text = "First Name:";
            // 
            // lblCustomerHistoryCustomerDriverLicenseNumber
            // 
            this.lblCustomerHistoryCustomerDriverLicenseNumber.AutoSize = true;
            this.lblCustomerHistoryCustomerDriverLicenseNumber.Location = new System.Drawing.Point(3, 72);
            this.lblCustomerHistoryCustomerDriverLicenseNumber.Name = "lblCustomerHistoryCustomerDriverLicenseNumber";
            this.lblCustomerHistoryCustomerDriverLicenseNumber.Size = new System.Drawing.Size(60, 20);
            this.lblCustomerHistoryCustomerDriverLicenseNumber.TabIndex = 14;
            this.lblCustomerHistoryCustomerDriverLicenseNumber.Text = "License:";
            // 
            // lblCustomerHistoryCustomerLastName
            // 
            this.lblCustomerHistoryCustomerLastName.AutoSize = true;
            this.lblCustomerHistoryCustomerLastName.Location = new System.Drawing.Point(3, 39);
            this.lblCustomerHistoryCustomerLastName.Name = "lblCustomerHistoryCustomerLastName";
            this.lblCustomerHistoryCustomerLastName.Size = new System.Drawing.Size(82, 20);
            this.lblCustomerHistoryCustomerLastName.TabIndex = 11;
            this.lblCustomerHistoryCustomerLastName.Text = "Last Name:";
            // 
            // tbxCustomerHistoryCustomerLastName
            // 
            this.tbxCustomerHistoryCustomerLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerHistoryCustomerLastName.Location = new System.Drawing.Point(92, 36);
            this.tbxCustomerHistoryCustomerLastName.Name = "tbxCustomerHistoryCustomerLastName";
            this.tbxCustomerHistoryCustomerLastName.Size = new System.Drawing.Size(729, 27);
            this.tbxCustomerHistoryCustomerLastName.TabIndex = 13;
            // 
            // mstpTopMenu
            // 
            this.mstpTopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstpTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstpTopMenuFile,
            this.mstpTopMenuAbout});
            this.mstpTopMenu.Location = new System.Drawing.Point(0, 0);
            this.mstpTopMenu.Name = "mstpTopMenu";
            this.mstpTopMenu.Size = new System.Drawing.Size(1135, 28);
            this.mstpTopMenu.TabIndex = 1;
            this.mstpTopMenu.Text = "menuStrip1";
            // 
            // mstpTopMenuFile
            // 
            this.mstpTopMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstpTopMenuFileExportToXml});
            this.mstpTopMenuFile.Name = "mstpTopMenuFile";
            this.mstpTopMenuFile.Size = new System.Drawing.Size(46, 24);
            this.mstpTopMenuFile.Text = "File";
            // 
            // mstpTopMenuAbout
            // 
            this.mstpTopMenuAbout.Name = "mstpTopMenuAbout";
            this.mstpTopMenuAbout.Size = new System.Drawing.Size(64, 24);
            this.mstpTopMenuAbout.Text = "About";
            this.mstpTopMenuAbout.Click += new System.EventHandler(this.mstpTopMenuAbout_Click);
            // 
            // mstpTopMenuFileExportToXml
            // 
            this.mstpTopMenuFileExportToXml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstpTopMenuFileExportToXmlFreeVehicles,
            this.mstpTopMenuFileExportToXmlCustomers});
            this.mstpTopMenuFileExportToXml.Name = "mstpTopMenuFileExportToXml";
            this.mstpTopMenuFileExportToXml.Size = new System.Drawing.Size(224, 26);
            this.mstpTopMenuFileExportToXml.Text = "Export to Xml";
            // 
            // mstpTopMenuFileExportToXmlFreeVehicles
            // 
            this.mstpTopMenuFileExportToXmlFreeVehicles.Name = "mstpTopMenuFileExportToXmlFreeVehicles";
            this.mstpTopMenuFileExportToXmlFreeVehicles.Size = new System.Drawing.Size(224, 26);
            this.mstpTopMenuFileExportToXmlFreeVehicles.Text = "Free Vehicles";
            this.mstpTopMenuFileExportToXmlFreeVehicles.Click += new System.EventHandler(this.mstpTopMenuFileExportToXmlFreeVehicles_Click);
            // 
            // mstpTopMenuFileExportToXmlCustomers
            // 
            this.mstpTopMenuFileExportToXmlCustomers.Name = "mstpTopMenuFileExportToXmlCustomers";
            this.mstpTopMenuFileExportToXmlCustomers.Size = new System.Drawing.Size(224, 26);
            this.mstpTopMenuFileExportToXmlCustomers.Text = "Customers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 694);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.mstpTopMenu);
            this.MainMenuStrip = this.mstpTopMenu;
            this.MinimumSize = new System.Drawing.Size(920, 480);
            this.Name = "MainForm";
            this.Text = "Vehicle Rental";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlLayout.ResumeLayout(false);
            this.pnlMenuLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.tctrlBody.ResumeLayout(false);
            this.tpgAbout.ResumeLayout(false);
            this.tpgVehicles.ResumeLayout(false);
            this.pnlVehiclesLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.tpgVehicleSelection.ResumeLayout(false);
            this.pnlSelectVehicleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectVehicle)).EndInit();
            this.pnlSelectVehicleFiltersLayout.ResumeLayout(false);
            this.pnlSelectVehicleFiltersLayoutRight.ResumeLayout(false);
            this.pnlSelectVehicleFiltersLayoutRight.PerformLayout();
            this.pnlSelectVehicleFiltersLayoutLeft.ResumeLayout(false);
            this.pnlSelectVehicleFiltersLayoutLeft.PerformLayout();
            this.tpgRegisterRental.ResumeLayout(false);
            this.pnlRegisterVehicleRentalLayout.ResumeLayout(false);
            this.pnlRegisterVehicleRentalLeft.ResumeLayout(false);
            this.pnlRegisterVehicleRentalLeft.PerformLayout();
            this.pnlRegisterVehicleRentalRight.ResumeLayout(false);
            this.pnlRegisterVehicleRentalRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterVehicleRentalCustomers)).EndInit();
            this.tpgRegisterReturn.ResumeLayout(false);
            this.pnlRegisterVehicleReturnLayout.ResumeLayout(false);
            this.pnlRegisterCarReturnLower.ResumeLayout(false);
            this.pnlRegisterVehicleReturnCustomerFilters.ResumeLayout(false);
            this.pnlRegisterVehicleReturnCustomerFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterVehicleReturnCustomers)).EndInit();
            this.pnlRegisterCarReturnUpper.ResumeLayout(false);
            this.pnlRegisterVehicleReturnVehicleFilters.ResumeLayout(false);
            this.pnlRegisterVehicleReturnVehicleFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterVehicleReturnVehicles)).EndInit();
            this.tpgCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tpgCustomerRegistration.ResumeLayout(false);
            this.pnlRegisterNewCustomerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterNewCustomer)).EndInit();
            this.pnlRegisterNewCustomerFilters.ResumeLayout(false);
            this.pnlRegisterNewCustomerFilters.PerformLayout();
            this.tpgCustomerHistory.ResumeLayout(false);
            this.pnlCustomerHistoryLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistoryCustomers)).EndInit();
            this.pnlCustomerHistoryFilters.ResumeLayout(false);
            this.pnlCustomerHistoryFilters.PerformLayout();
            this.mstpTopMenu.ResumeLayout(false);
            this.mstpTopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel pnlLayout;
        private TableLayoutPanel pnlMenuLayout;
        private Button btnMenuVehicles;
        private Button btnMenuCustomerHistory;
        private Button btnMenuSelectVehicle;
        private Button btnMenuRegisterRental;
        private Button btnMenuRegisterReturn;
        private Button btnMenuCustomers;
        private Button btnMenuCustomerRegistration;
        private PictureBox pbxLogo;
        private TabControl tctrlBody;
        private TabPage tpgVehicles;
        private TabPage tpgVehicleSelection;
        private TabPage tpgRegisterRental;
        private TabPage tpgRegisterReturn;
        private TabPage tpgCustomers;
        private TabPage tpgCustomerRegistration;
        private TabPage tpgCustomerHistory;
        private DataGridView dgvVehicles;
        private TableLayoutPanel pnlSelectVehicleLayout;
        private DataGridView dgvSelectVehicle;
        private Button btnSelectVehicleRegisterRental;
        private TableLayoutPanel pnlSelectVehicleFiltersLayout;
        private TableLayoutPanel pnlVehiclesLayout;
        private Button btnVehiclesRegisterRental;
        private Button btnSelectVehicleApplyFilters;
        private Panel pnlSelectVehicleFiltersLayoutRight;
        private Panel pnlSelectVehicleFiltersLayoutLeft;
        private TableLayoutPanel pnlRegisterVehicleRentalLayout;
        private Button btnRegisterVehicleRental;
        private Panel pnlRegisterVehicleRentalRight;
        private TextBox tbxRegisterVehicleRentalCustomerFirstName;
        private TextBox tbxRegisterVehicleRentalCustomerLastName;
        private TextBox tbxRegisterVehicleRentalCustomerDriverLicense;
        private Label lblRegisterVehicleRentalCustomerDriverLicense;
        private Label lblRegisterVehicleRentalCustomerLastName;
        private Label lblRegisterVehicleRentalCustomerFirstName;
        private Label lblSelectVehicleEngineVolume;
        private Label lblSelectVehicleMileage;
        private Label lblSelectVehicleYearOfManufacture;
        private Label lblSelectVehicleModel;
        private Label lblSelectVehicleManufacturer;
        private Label lblSelectVehiclePassengerCapacity;
        private Label lblSelectVehiclePricePerHour;
        private Label lblSelectVehicleInsuranceAmount;
        private Panel pnlRegisterVehicleRentalLeft;
        private TextBox tbxRegisterVehicleRentalVehicleManufacturer;
        private TextBox tbxRegisterVehicleRentalVehicleModel;
        private TextBox tbxRegisterVehicleRentalVehicleYearOfProduction;
        private Label lblRegisterVehicleRentalVehicleYearOfProduction;
        private Label lblRegisterVehicleRentalVehicleModel;
        private Label lblRegisterVehicleRentalVehicleManufacturer;
        private TextBox tbxRegisterVehicleRentalVehiclePassengerCapacity;
        private TextBox tbxRegisterVehicleRentalVehicleInsuranceAmount;
        private TextBox tbxRegisterVehicleRentalVehiclePricePerHour;
        private Label lblRegisterVehicleRentalVehiclePricePerHour;
        private Label lblRegisterVehicleRentalVehicleInsuranceAmount;
        private Label lblRegisterVehicleRentalVehiclePassengerCapacity;
        private TextBox tbxRegisterVehicleRentalVehicleRegistrationNumber;
        private TextBox tbxRegisterVehicleRentalVehicleMileage;
        private TextBox tbxRegisterVehicleRentalVehicleEngineVolume;
        private Label lblRegisterVehicleRentalVehicleEngineVolume;
        private Label lblRegisterVehicleRentalVehicleMileage;
        private Label lblRegisterVehicleRentalVehicleRegistrationNumber;
        private DataGridView dgvRegisterVehicleRentalCustomers;
        private Button btnRegisterRentalApplyCustomerFilters;
        private DateTimePicker dtpRegisterVehicleRentalVehicleReturnDate;
        private Label lblRegisterVehicleRentalVehicleReturnDate;
        private TabPage tpgAbout;
        private Label lblAbout;
        private MenuStrip mstpTopMenu;
        private ToolStripMenuItem mstpTopMenuFile;
        private ToolStripMenuItem mstpTopMenuAbout;
        private DataGridView dgvCustomers;
        private DataGridView dgvCustomerHistory;
        private TextBox tbxSelectVehiclePricePerHour;
        private TextBox tbxSelectVehicleInsuranceAmount;
        private TextBox tbxSelectVehiclePassengerCapacity;
        private TextBox tbxSelectVehicleMileage;
        private TextBox tbxSelectVehicleYearOfProduction;
        private TextBox tbxSelectVehicleModel;
        private TextBox tbxSelectVehicleManufacturer;
        private TextBox tbxSelectVehicleEngineVolume;
        private TableLayoutPanel pnlRegisterVehicleReturnLayout;
        private Button btnRegisterVehicleReturn;
        private Panel pnlRegisterCarReturnUpper;
        private TextBox tbxRegisterVehicleReturnVehicleRegistrationNumber;
        private Label lblRegisterVehicleReturnVehicleRegistrarionNumber;
        private DataGridView dgvRegisterVehicleReturnVehicles;
        private Panel pnlRegisterCarReturnLower;
        private Button btnRegisterVehicleReturnVehicleApplyFilter;
        private DataGridView dgvRegisterVehicleReturnCustomers;
        private TableLayoutPanel pnlRegisterVehicleReturnVehicleFilters;
        private TableLayoutPanel pnlRegisterVehicleReturnCustomerFilters;
        private Button btnRegisterVehicleReturnCustomerApplyFilter;
        private Label lblRegisterVehicleReturnCustomerDriverLicenseNumber;
        private TextBox tbxRegisterVehicleReturnCustomerDriverLicenseNumber;
        private TableLayoutPanel pnlRegisterNewCustomerLayout;
        private Button btnRegisterNewCustomer;
        private Panel pnlRegisterNewCustomerFilters;
        private TextBox tbxRegisterNewCustomerDriverLicenseNumber;
        private Label lblRegisterNewCustomerDriverLicenseNumber;
        private TextBox tbxRegisterNewCustomerLastName;
        private TextBox tbxRegisterNewCustomerFirstName;
        private Label lblRegisterNewCustomerLastName;
        private Label lblRegisterNewCustomerFirstName;
        private DataGridView dgvRegisterNewCustomer;
        private TextBox tbxCustomerHistoryCustomerDriverLicenseNumber;
        private Label lblCustomerHistoryCustomerDriverLicenseNumber;
        private TextBox tbxCustomerHistoryCustomerLastName;
        private TextBox tbxCustomerHistoryCustomerFirstName;
        private Label lblCustomerHistoryCustomerLastName;
        private Label lblCustomerHistoryCustomerFirstName;
        private TableLayoutPanel pnlCustomerHistoryLayout;
        private DataGridView dgvCustomerHistoryCustomers;
        private Panel pnlCustomerHistoryFilters;
        private Button btnCustomerHistoryApplyFilters;
        private Button btnRegisterNewCustomerApplyFilters;
        private ToolStripMenuItem mstpTopMenuFileExportToXml;
        private ToolStripMenuItem mstpTopMenuFileExportToXmlFreeVehicles;
        private ToolStripMenuItem mstpTopMenuFileExportToXmlCustomers;
    }
}