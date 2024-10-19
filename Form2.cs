using Db4objects.Db4o.Config;
using Db4objects.Db4o.Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BTL
{
    
    public partial class Form2 : Form
    {
        private String connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = WinformDB; Integrated Security = True; TrustServerCertificate=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winformDBDataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.winformDBDataSet.Roles);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // Thu thập dữ liệu từ các TextBox và ComboBox
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime? dateOfBirth = dtpDateOfBirth.Checked ? (DateTime?)dtpDateOfBirth.Value.Date : null;
            int roleId = cmbRole.SelectedValue != null ? Convert.ToInt32(cmbRole.SelectedValue) : 0;
            bool isActive = chkIsActive.Checked;

            // Kiểm tra tính hợp lệ của dữ liệu nhập
            if (!ValidateInputs(username, email, password, confirmPassword))
                return;

            // Tạo hash và salt cho mật khẩu
            PasswordHelper.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            // Thực hiện chèn dữ liệu vào cơ sở dữ liệu
            string query = @"INSERT INTO UserAccount (Username, Email, PasswordHash, PasswordSalt, FirstName, LastName, DateOfBirth, RoleID, IsActive)
                             VALUES (@Username, @Email, @PasswordHash, @PasswordSalt, @FirstName, @LastName, @DateOfBirth, @RoleID, @IsActive)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Thêm các tham số để tránh SQL Injection
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@PasswordSalt", passwordSalt);
                command.Parameters.AddWithValue("@FirstName", (object)firstName ?? DBNull.Value);
                command.Parameters.AddWithValue("@LastName", (object)lastName ?? DBNull.Value);
                command.Parameters.AddWithValue("@DateOfBirth", (object)dateOfBirth ?? DBNull.Value);
                command.Parameters.AddWithValue("@RoleID", roleId);
                command.Parameters.AddWithValue("@IsActive", isActive);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                catch (SqlException ex)
                {
                    // Kiểm tra lỗi trùng lặp Username hoặc Email
                    if (ex.Number == 2627) // Unique constraint error
                    {
                        MessageBox.Show("Username hoặc Email đã được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool ValidateInputs(string username, string email, string password, string confirmPassword)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập Username.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập Email.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Password.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập Confirm Password.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Định dạng Email không hợp lệ.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Kiểm tra mật khẩu và xác nhận mật khẩu khớp nhau
            if (password != confirmPassword)
            {
                MessageBox.Show("Password và Confirm Password không khớp nhau.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            // Kiểm tra độ mạnh của mật khẩu (tuỳ chọn)
            if (!IsStrongPassword(password))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ cái và số.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Sử dụng Regex để kiểm tra định dạng email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        // Phương thức kiểm tra độ mạnh của mật khẩu
        private bool IsStrongPassword(string password)
        {
            // Độ mạnh tối thiểu: 8 ký tự, bao gồm chữ cái và số
            if (password.Length < 8)
                return false;

            bool hasLetter = false, hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (hasLetter && hasDigit) return true;
            }
            return false;
        }
        private void ClearInputs()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            cmbRole.SelectedIndex = 0;
            chkIsActive.Checked = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
    public static class PasswordHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA256())
            {
                // Tạo salt ngẫu nhiên
                passwordSalt = hmac.Key;
                // Tạo hash từ mật khẩu
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA256(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                // So sánh hash đã tính với hash lưu trữ
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }
            return true;
        }
    }
}
