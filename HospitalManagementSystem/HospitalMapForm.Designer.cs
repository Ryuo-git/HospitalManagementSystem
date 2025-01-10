namespace HospitalManagementSystem
{
    partial class HospitalMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalMapForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayGraph = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoom1 = new System.Windows.Forms.TextBox();
            this.lsDisplayGraph = new System.Windows.Forms.ListBox();
            this.txtRoom2 = new System.Windows.Forms.TextBox();
            this.btnx = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Map Navigation";
            // 
            // btnDisplayGraph
            // 
            this.btnDisplayGraph.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayGraph.Location = new System.Drawing.Point(44, 212);
            this.btnDisplayGraph.Name = "btnDisplayGraph";
            this.btnDisplayGraph.Size = new System.Drawing.Size(157, 36);
            this.btnDisplayGraph.TabIndex = 2;
            this.btnDisplayGraph.Text = "Display Graph";
            this.btnDisplayGraph.UseVisualStyleBackColor = true;
            this.btnDisplayGraph.Click += new System.EventHandler(this.btnDisplayGraph_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(44, 116);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(144, 25);
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConnection.Location = new System.Drawing.Point(44, 147);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(144, 25);
            this.btnAddConnection.TabIndex = 4;
            this.btnAddConnection.Text = "Add Connection";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(207, 119);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(549, 25);
            this.txtRoomName.TabIndex = 5;
            // 
            // txtRoom1
            // 
            this.txtRoom1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom1.Location = new System.Drawing.Point(207, 147);
            this.txtRoom1.Name = "txtRoom1";
            this.txtRoom1.Size = new System.Drawing.Size(549, 25);
            this.txtRoom1.TabIndex = 6;
            // 
            // lsDisplayGraph
            // 
            this.lsDisplayGraph.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsDisplayGraph.FormattingEnabled = true;
            this.lsDisplayGraph.ItemHeight = 16;
            this.lsDisplayGraph.Location = new System.Drawing.Point(207, 214);
            this.lsDisplayGraph.Name = "lsDisplayGraph";
            this.lsDisplayGraph.Size = new System.Drawing.Size(549, 212);
            this.lsDisplayGraph.TabIndex = 7;
            // 
            // txtRoom2
            // 
            this.txtRoom2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom2.Location = new System.Drawing.Point(207, 175);
            this.txtRoom2.Name = "txtRoom2";
            this.txtRoom2.Size = new System.Drawing.Size(549, 25);
            this.txtRoom2.TabIndex = 8;
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Transparent;
            this.btnx.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnx.FlatAppearance.BorderSize = 0;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnx.Image = ((System.Drawing.Image)(resources.GetObject("btnx.Image")));
            this.btnx.Location = new System.Drawing.Point(755, 0);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(45, 46);
            this.btnx.TabIndex = 1;
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnx);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HospitalMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRoom2);
            this.Controls.Add(this.lsDisplayGraph);
            this.Controls.Add(this.txtRoom1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.btnAddConnection);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnDisplayGraph);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HospitalMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalMapForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayGraph;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtRoom1;
        private System.Windows.Forms.ListBox lsDisplayGraph;
        private System.Windows.Forms.TextBox txtRoom2;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}