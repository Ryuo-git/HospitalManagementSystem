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

        //username and password for log in.

        String[] username = { "jerome.pacheco",
                              "jam.conception",
                              "poginiarman21",
                              "vlue.afurong",
                              "jericho.jkl",
                              "cy.123",
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
