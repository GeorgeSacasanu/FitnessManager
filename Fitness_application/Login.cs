using EntityFramework_db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var db = new Model1();
            var found = db.Users.Where(m => m.username == username_tb.Text).Where(m => m.password == password_tb.Text).FirstOrDefault();
            if(found == null)
            {
                MessageBox.Show("Incorrect username or password!");
            }
            else
            {
                bool isAdmin = found.isAdmin;


                this.Hide();
                var f = new FirstForm(found.username, isAdmin);
                f.Closed += (s, args) => this.Close();
                f.Show();
                
            }
        }
    }
}
