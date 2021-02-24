
namespace CovidVaccination
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Login2 = new System.Windows.Forms.Button();
            this.GetHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.motto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Copyright © 2021 Created by the Agile Warriors";
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Location = new System.Drawing.Point(358, 250);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(299, 26);
            this.UsernametextBox.TabIndex = 7;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(358, 302);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(299, 26);
            this.PasswordtextBox.TabIndex = 8;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(252, 253);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 9;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(257, 305);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 10;
            this.Password.Text = "Password";
            // 
            // Login2
            // 
            this.Login2.Location = new System.Drawing.Point(437, 356);
            this.Login2.Name = "Login2";
            this.Login2.Size = new System.Drawing.Size(125, 37);
            this.Login2.TabIndex = 11;
            this.Login2.Text = "Login";
            this.Login2.UseVisualStyleBackColor = true;
            this.Login2.Click += new System.EventHandler(this.Login2_Click);
            // 
            // GetHelp
            // 
            this.GetHelp.Location = new System.Drawing.Point(400, 410);
            this.GetHelp.Name = "GetHelp";
            this.GetHelp.Size = new System.Drawing.Size(204, 37);
            this.GetHelp.TabIndex = 12;
            this.GetHelp.Text = "Get Help";
            this.GetHelp.UseVisualStyleBackColor = true;
            this.GetHelp.Click += new System.EventHandler(this.GetHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::CovidVaccination.Properties.Resources.background;
            this.label2.Location = new System.Drawing.Point(428, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 49);
            this.label2.TabIndex = 14;
            this.label2.Text = "LOGIN";
            // 
            // motto
            // 
            this.motto.AutoSize = true;
            this.motto.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motto.Image = global::CovidVaccination.Properties.Resources.background;
            this.motto.Location = new System.Drawing.Point(186, 172);
            this.motto.Name = "motto";
            this.motto.Size = new System.Drawing.Size(619, 40);
            this.motto.TabIndex = 13;
            this.motto.Text = "Remember to wear a mask and mainatin a safe distance!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CovidVaccination.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.motto);
            this.Controls.Add(this.GetHelp);
            this.Controls.Add(this.Login2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UsernametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Login2;
        private System.Windows.Forms.Button GetHelp;
        private System.Windows.Forms.Label motto;
        private System.Windows.Forms.Label label2;
    }
}