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
    public partial class AppointmentForm : Form
    {
        private AppointmentQueue appointmentQueue = new AppointmentQueue();

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            string patientName = txtPatientName.Text;
            int id = int.Parse(txtAppointmentId.Text);

            appointmentQueue.AddAppointment(id, patientName);
            MessageBox.Show("Appointment added successfully!");
        }

        private void btnProcessAppointment_Click(object sender, EventArgs e)
        {
            var appointment = appointmentQueue.ProcessAppointment();

            if (appointment != null)
            {
                MessageBox.Show($"Processed Appointment - ID: {appointment.ID}, " +
                                $"Patient: {appointment.PatientName}");
            }
            else
            {
                MessageBox.Show("No appointments to process.");
            }
        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
            var appointments = appointmentQueue.GetAppointments();
            lsAppointment.Items.Clear(); // Clear the ListBox first.

            foreach (var appointment in appointments)
            {
                lsAppointment.Items.Add($"ID: {appointment.ID}, Patient: {appointment.PatientName}");
            }
        }
    }
}
