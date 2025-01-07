using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        String[] username = { "jerome.pacheco@yahoo.com",
                              "jam.conception@yahoo.com",
                              "poginiarman21@yahoo.com",
                              "vlue.afurong@gmail.com",
                              "jericho.jkl",
                              "cy.123@outlook.com",
                              "admin"};

        String[] password = { "iamjerome",
                              "molaelel24",
                              "kengkoy222",
                              "sanaakonalang",
                              "123654",
                              "weeehhh",
                              "admin"};

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int check = 0;
            for (int count = 0; count <= 6; count++)
            {
                if (this.txtusername.Text == username[count] && this.txtpassword.Text == password[count])
                {
                    new Home().Show();
                    this.Hide();
                    check++;
                }
            }
            if (check == 0)
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
