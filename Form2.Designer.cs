namespace BTL
{
    partial class Form2
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
            this.Username = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Confirm_Password = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.Label();
            this.Date_of_Birth = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winformDBDataSet = new BTL.WinformDBDataSet();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rolesTableAdapter = new BTL.WinformDBDataSetTableAdapters.RolesTableAdapter();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.IsActive = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winformDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Location = new System.Drawing.Point(521, 160);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(78, 18);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username: ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Location = new System.Drawing.Point(521, 191);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(55, 18);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email:   ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(521, 219);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(75, 18);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password: ";
            // 
            // Confirm_Password
            // 
            this.Confirm_Password.AutoSize = true;
            this.Confirm_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Confirm_Password.Location = new System.Drawing.Point(521, 247);
            this.Confirm_Password.Name = "Confirm_Password";
            this.Confirm_Password.Size = new System.Drawing.Size(120, 18);
            this.Confirm_Password.TabIndex = 6;
            this.Confirm_Password.Text = "Confirm Password:";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.First_Name.Location = new System.Drawing.Point(521, 275);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(77, 18);
            this.First_Name.TabIndex = 7;
            this.First_Name.Text = "First Name:";
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Last_Name.Location = new System.Drawing.Point(521, 305);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(80, 18);
            this.Last_Name.TabIndex = 8;
            this.Last_Name.Text = "Last Name: ";
            // 
            // Date_of_Birth
            // 
            this.Date_of_Birth.AutoSize = true;
            this.Date_of_Birth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_of_Birth.Location = new System.Drawing.Point(521, 331);
            this.Date_of_Birth.Name = "Date_of_Birth";
            this.Date_of_Birth.Size = new System.Drawing.Size(84, 18);
            this.Date_of_Birth.TabIndex = 9;
            this.Date_of_Birth.Text = "Date of Birth:";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Role.Location = new System.Drawing.Point(521, 360);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(41, 18);
            this.Role.TabIndex = 10;
            this.Role.Text = "Role:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(642, 156);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(225, 22);
            this.txtUsername.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(642, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(642, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(225, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(642, 243);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(225, 22);
            this.txtConfirmPassword.TabIndex = 15;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(642, 271);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 22);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(642, 301);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 22);
            this.txtLastName.TabIndex = 17;
            // 
            // cmbRole
            // 
            this.cmbRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolesBindingSource, "RoleID", true));
            this.cmbRole.DataSource = this.rolesBindingSource;
            this.cmbRole.DisplayMember = "RoleName";
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(642, 360);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(174, 24);
            this.cmbRole.TabIndex = 18;
            this.cmbRole.ValueMember = "RoleID";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.winformDBDataSet;
            // 
            // winformDBDataSet
            // 
            this.winformDBDataSet.DataSetName = "WinformDBDataSet";
            this.winformDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(642, 329);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(96, 22);
            this.dtpDateOfBirth.TabIndex = 19;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BTL.Properties.Resources.calendar;
            this.pictureBox4.Location = new System.Drawing.Point(744, 329);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BTL.Properties.Resources.gradient_color;
            this.btnCancel.Location = new System.Drawing.Point(761, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 44);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = global::BTL.Properties.Resources.gradient_color;
            this.btn_clear.Location = new System.Drawing.Point(642, 433);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 44);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackgroundImage = global::BTL.Properties.Resources.gradient_color;
            this.btn_Register.Location = new System.Drawing.Point(521, 433);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(96, 44);
            this.btn_Register.TabIndex = 11;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BTL.Properties.Resources.sign_up;
            this.pictureBox3.Location = new System.Drawing.Point(632, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BTL.Properties.Resources.hanghoa1_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(99, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL.Properties.Resources._1554440107UeHQLKQFUhtzL6p;
            this.pictureBox1.Location = new System.Drawing.Point(-181, -302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 1076);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(849, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 42);
            this.button4.TabIndex = 23;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // IsActive
            // 
            this.IsActive.AutoSize = true;
            this.IsActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IsActive.Location = new System.Drawing.Point(521, 396);
            this.IsActive.Name = "IsActive";
            this.IsActive.Size = new System.Drawing.Size(44, 18);
            this.IsActive.TabIndex = 24;
            this.IsActive.Text = "status";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(642, 396);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(66, 20);
            this.chkIsActive.TabIndex = 25;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 489);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.IsActive);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Date_of_Birth);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.Confirm_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winformDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Confirm_Password;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label Date_of_Birth;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private WinformDBDataSet winformDBDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private WinformDBDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label IsActive;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}