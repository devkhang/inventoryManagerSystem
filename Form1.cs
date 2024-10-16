using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            db = Db4oFactory.OpenFile("Test LINQ");
            db.Ext();
        }
        public void textchange(object sender, EventArgs e)
        {
            String name = txt1.Text;
            IEnumerator<User> result = from User p in db.Query<User>()
        }
    }
    public class User
    {
        public User()
        {
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public String username { get; set; }
        public String password { get; set; }


    }
}