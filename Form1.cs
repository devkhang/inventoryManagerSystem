using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace BTL
{
    public partial class Form1 : Form
    {
        public IObjectContainer db;
        String connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=WinformDB;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtPassWord.Text.Trim();
            string username = txtUserName.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.",
                                "Thông Báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            User user = getUserByName();
            if (user == null)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại. Vui lòng thử lại.",
                                "Đăng Nhập Thất Bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool isPasswordValid = PasswordHelper.VerifyPassword(password, user.PasswordHash, user.PasswordSalt);
                if (isPasswordValid)
                {
                    //trả về form chính
                    Form2 form = new Form2();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("mật khẩu không chính xác. Vui lòng thử lại.",
                                    "Đăng Nhập Thất Bại",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
            }
        }
        public User getUserByName()
        {
            User user = null;
            string username = txtUserName.Text;
            string query = "select * from UserAccount where UserName = @username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString(),
                                Email = reader["Email"].ToString(),
                                PasswordHash = (byte[])reader["PasswordHash"],
                                PasswordSalt = (byte[])reader["PasswordSalt"],
                                FirstName = reader["FirstName"] as string,
                                LastName = reader["LastName"] as string,
                                DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["DateOfBirth"]) : null,
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                LastLogin = reader["LastLogin"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["LastLogin"]) : null,
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                RoleID = Convert.ToInt32(reader["RoleID"])
                            };
                        }
                    }
                }
            }
            return user;
        }
    }
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }
        public int RoleID { get; set; }

        // Optional: Thuộc tính điều hướng nếu sử dụng ORM
        // public virtual Role Role { get; set; }
    }
}