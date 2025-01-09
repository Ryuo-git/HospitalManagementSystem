namespace HospitalManagementSystem
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnProcessAppointment = new System.Windows.Forms.Button();
            this.lsAppointment = new System.Windows.Forms.ListBox();
            this.btnViewAppointment = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "For Appointment ID :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(200, 61);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(300, 25);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentId.Location = new System.Drawing.Point(200, 92);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(300, 25);
            this.txtAppointmentId.TabIndex = 3;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.Location = new System.Drawing.Point(276, 120);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(182, 25);
            this.btnAddAppointment.TabIndex = 4;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnProcessAppointment
            // 
            this.btnProcessAppointment.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessAppointment.Location = new System.Drawing.Point(305, 317);
            this.btnProcessAppointment.Name = "btnProcessAppointment";
            this.btnProcessAppointment.Size = new System.Drawing.Size(195, 31);
            this.btnProcessAppointment.TabIndex = 5;
            this.btnProcessAppointment.Text = "Process Appointment";
            this.btnProcessAppointment.UseVisualStyleBackColor = true;
            this.btnProcessAppointment.Click += new System.EventHandler(this.btnProcessAppointment_Click);
            // 
            // lsAppointment
            // 
            this.lsAppointment.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsAppointment.FormattingEnabled = true;
            this.lsAppointment.ItemHeight = 18;
            this.lsAppointment.Location = new System.Drawing.Point(37, 163);
            this.lsAppointment.Name = "lsAppointment";
            this.lsAppointment.Size = new System.Drawing.Size(463, 148);
            this.lsAppointment.TabIndex = 6;
            // 
            // btnViewAppointment
            // 
            this.btnViewAppointment.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAppointment.Location = new System.Drawing.Point(37, 317);
            this.btnViewAppointment.Name = "btnViewAppointment";
            this.btnViewAppointment.Size = new System.Drawing.Size(192, 31);
            this.btnViewAppointment.TabIndex = 7;
            this.btnViewAppointment.Text = "View Appointment";
            this.btnViewAppointment.UseVisualStyleBackColor = true;
            this.btnViewAppointment.Click += new System.EventHandler(this.btnViewAppointment_Click);
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Transparent;
            this.btnx.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnx.FlatAppearance.BorderSize = 0;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnx.Image = ((System.Drawing.Image)(resources.GetObject("btnx.Image")));
            this.btnx.Location = new System.Drawing.Point(477, 0);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(45, 52);
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
            this.panel1.Size = new System.Drawing.Size(522, 52);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(522, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewAppointment);
            this.Controls.Add(this.lsAppointment);
            this.Controls.Add(this.btnProcessAppointment);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.txtAppointmentId);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnProcessAppointment;
        private System.Windows.Forms.ListBox lsAppointment;
        private System.Windows.Forms.Button btnViewAppointment;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}