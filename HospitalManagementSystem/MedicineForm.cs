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
    public partial class MedicineForm : Form
    {
        private MedicineStack medicineStack = new MedicineStack();

        public MedicineForm()
        {
            InitializeComponent();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string name = txtMedicineName.Text;
            int quantity = int.Parse(txtMedicineQuantity.Text);

            medicineStack.AddMedicine(name, quantity);
            MessageBox.Show("Medicine added successfully!");
        }

        private void btnRemoveMedicine_Click(object sender, EventArgs e)
        {
            var medicine = medicineStack.RemoveMedicine();

            if (medicine != null)
            {
                MessageBox.Show($"Removed Medicine - Name: {medicine.Name}, Quantity: {medicine.Quantity}");
            }
            else
            {
                MessageBox.Show("No medicines in stock.");
            }
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            var medicines = medicineStack.GetMedicines();
            lsMedicine.Items.Clear(); // Clear the ListBox first.

            foreach (var medicine in medicines)
            {
                lsMedicine.Items.Add($"Name: {medicine.Name}, " +
                                     $"Quantity: {medicine.Quantity}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
