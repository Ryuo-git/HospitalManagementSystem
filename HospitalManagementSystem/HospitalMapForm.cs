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
    public partial class HospitalMapForm : Form
    {
        private HospitalGraph hospitalGraph = new HospitalGraph();

        public HospitalMapForm()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string room = txtRoomName.Text.Trim();
            if (!string.IsNullOrEmpty(room))
            {
                hospitalGraph.AddRoom(room);
                MessageBox.Show($"Room '{room}' added successfully!");
            }
            else
            {
                MessageBox.Show("Room name cannot be empty!");
            }

        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            string room1 = txtRoom1.Text.Trim();
            string room2 = txtRoom2.Text.Trim();
            if (!string.IsNullOrEmpty(room1) && !string.IsNullOrEmpty(room2))
            {
                hospitalGraph.AddConnection(room1, room2);
                MessageBox.Show($"Connection added between '{room1}' and '{room2}'!");
            }
            else
            {
                MessageBox.Show("Both room names must be provided!");
            }
        }

        private void btnDisplayGraph_Click(object sender, EventArgs e)
        {
            var graph = hospitalGraph.GetGraph();
            lsDisplayGraph.Items.Clear();

            foreach (var room in graph.Keys)
            {
                string connections = string.Join(", ", graph[room]);
                lsDisplayGraph.Items.Add($"Room: {room} → Connected to: {connections}");
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
