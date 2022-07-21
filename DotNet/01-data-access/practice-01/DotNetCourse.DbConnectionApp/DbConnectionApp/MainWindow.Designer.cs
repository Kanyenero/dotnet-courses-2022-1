namespace DotNetCourse.DbConnectionApp.UserInterface
{
    partial class MainWindow
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
            this.lblDataProvider = new System.Windows.Forms.Label();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.cboDataProvider = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataProvider
            // 
            this.lblDataProvider.AutoSize = true;
            this.lblDataProvider.Location = new System.Drawing.Point(12, 48);
            this.lblDataProvider.Name = "lblDataProvider";
            this.lblDataProvider.Size = new System.Drawing.Size(103, 20);
            this.lblDataProvider.TabIndex = 0;
            this.lblDataProvider.Text = "Data Provider:";
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(12, 15);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(130, 20);
            this.lblConnectionString.TabIndex = 1;
            this.lblConnectionString.Text = "Connection String:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(152, 12);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(351, 27);
            this.txtConnectionString.TabIndex = 2;
            // 
            // cboDataProvider
            // 
            this.cboDataProvider.FormattingEnabled = true;
            this.cboDataProvider.Location = new System.Drawing.Point(152, 45);
            this.cboDataProvider.Name = "cboDataProvider";
            this.cboDataProvider.Size = new System.Drawing.Size(253, 28);
            this.cboDataProvider.TabIndex = 3;
            this.cboDataProvider.SelectedIndexChanged += new System.EventHandler(this.cboDataProvider_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(411, 45);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 29);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(16, 92);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(42, 20);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Info: ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 134);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboDataProvider);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.lblDataProvider);
            this.Name = "MainWindow";
            this.Text = "Practice 01. DBO connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDataProvider;
        private Label lblConnectionString;
        private TextBox txtConnectionString;
        private ComboBox cboDataProvider;
        private Button btnConnect;
        private Label lblInfo;
    }
}