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
    public partial class PatientForm : Form
    {
        private PatientLinkedList patientList = new PatientLinkedList();

        public PatientForm()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string name = txtPatientName.Text;
            int age = int.Parse(txtPatientAge.Text);
            int id = int.Parse(txtPatientID.Text);
            string illness = txtPatientIllness.Text;

            patientList.AddPatient(name, age, id, illness);
            MessageBox.Show("Patient added successfully!");
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPatientID.Text);
            patientList.DeletePatient(id);
            MessageBox.Show("Patient deleted successfully!");
        }

        private void button3_Click(object sender, EventArgs e) //btnViewPatient
        {
            var patients = patientList.GetPatients();
            lsPatients.Items.Clear(); // Clear the ListBox first.

            foreach (var patient in patients)
            {
                lsPatients.Items.Add($"Name: {patient.Name}, " +
                                     $"Age: {patient.Age}," +
                                     $"ID: {patient.ID}, " +
                                     $"Illness: {patient.Illness}");
            }
        }

       
    }
}
