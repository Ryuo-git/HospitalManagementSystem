using HospitalManagementSystem.Data_Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Data_Structures;

namespace HospitalManagementSystem
{
    public partial class DoctorForm : Form
    {
        private DoctorTree doctorTree = new DoctorTree();

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            string name = txtDoctorName.Text;
            int experience = int.Parse(txtDoctorExperience.Text);
            string specialization = txtDoctorSpecialization.Text;

            doctorTree.AddDoctor(name, experience, specialization);
            MessageBox.Show("Doctor added successfully!");
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            var doctors = doctorTree.GetAllDoctors();
            lsDoctors.Items.Clear(); // Clear the ListBox first.

            foreach (var doctor in doctors)
            {
                lsDoctors.Items.Add($"Name: {doctor.Name}, " +
                                    $"Experience: {doctor.Experience} years, " +
                                    $"Specialization: {doctor.Specialization}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //pctHome
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
