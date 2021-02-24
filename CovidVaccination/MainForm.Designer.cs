
namespace CovidVaccination
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinePatientsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Vaccine_PatientsDataSet = new CovidVaccination._Vaccine_PatientsDataSet();
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.GetHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.motto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinePatientsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vaccine_PatientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.AutoGenerateColumns = false;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID});
            this.gridview.DataSource = this.vaccinePatientsDataSetBindingSource;
            this.gridview.Location = new System.Drawing.Point(157, 60);
            this.gridview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 62;
            this.gridview.RowTemplate.Height = 28;
            this.gridview.Size = new System.Drawing.Size(482, 274);
            this.gridview.TabIndex = 1;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellContentClick);
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "PatientID ";
            this.PatientID.MinimumWidth = 8;
            this.PatientID.Name = "PatientID";
            this.PatientID.Width = 150;
            // 
            // vaccinePatientsDataSetBindingSource
            // 
            this.vaccinePatientsDataSetBindingSource.DataSource = this._Vaccine_PatientsDataSet;
            this.vaccinePatientsDataSetBindingSource.Position = 0;
            // 
            // _Vaccine_PatientsDataSet
            // 
            this._Vaccine_PatientsDataSet.DataSetName = "_Vaccine_PatientsDataSet";
            this._Vaccine_PatientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(27, 60);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(97, 25);
            this.Login.TabIndex = 2;
            this.Login.Text = "Log-in";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(27, 99);
            this.Register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(97, 25);
            this.Register.TabIndex = 3;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // GetHelp
            // 
            this.GetHelp.Location = new System.Drawing.Point(27, 136);
            this.GetHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetHelp.Name = "GetHelp";
            this.GetHelp.Size = new System.Drawing.Size(97, 25);
            this.GetHelp.TabIndex = 4;
            this.GetHelp.Text = "Get Help";
            this.GetHelp.UseVisualStyleBackColor = true;
            this.GetHelp.Click += new System.EventHandler(this.GetHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copyright © 2021 Created by the Agile Warriors";
            // 
            // motto
            // 
            this.motto.AutoSize = true;
            this.motto.Font = new System.Drawing.Font("Sitka Banner", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motto.Image = global::CovidVaccination.Properties.Resources.background;
            this.motto.Location = new System.Drawing.Point(239, 18);
            this.motto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motto.Name = "motto";
            this.motto.Size = new System.Drawing.Size(399, 33);
            this.motto.TabIndex = 6;
            this.motto.Text = "Working together to heal our community.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CovidVaccination.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 422);
            this.Controls.Add(this.motto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetHelp);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinePatientsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vaccine_PatientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.BindingSource vaccinePatientsDataSetBindingSource;
        private _Vaccine_PatientsDataSet _Vaccine_PatientsDataSet;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button GetHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label motto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
    }
}