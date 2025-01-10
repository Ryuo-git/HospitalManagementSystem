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
        DataTable table = new DataTable("Table");
        int index;

        public PatientForm()
        {
            InitializeComponent();
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

        private void PatientForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Age", Type.GetType("System.Int32"));
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Illness", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = String.Empty;
            txt2.Text = String.Empty;
            txt3.Text = String.Empty;
            txt4.Text = String.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt1.Text = row.Cells[0].Value?.ToString();
                txt2.Text = row.Cells[1].Value?.ToString();
                txt3.Text = row.Cells[2].Value?.ToString();
                txt4.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[0].Value = txt1.Text;
                selectedRow.Cells[1].Value = txt2.Text;
                selectedRow.Cells[2].Value = txt3.Text;
                selectedRow.Cells[3].Value = txt4.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
