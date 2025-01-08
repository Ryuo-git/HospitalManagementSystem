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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            // si MERTs to
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
            this.Hide();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.Show();
            this.Hide();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            HospitalMapForm hospitalMapForm = new HospitalMapForm();
            hospitalMapForm.Show();
            this.Hide();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
