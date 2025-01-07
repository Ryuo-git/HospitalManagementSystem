﻿namespace HospitalManagementSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnProcessAppointment = new System.Windows.Forms.Button();
            this.lsAppointment = new System.Windows.Forms.ListBox();
            this.btnViewAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "For Appointment ID :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(170, 61);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(212, 22);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Location = new System.Drawing.Point(170, 92);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(212, 22);
            this.txtAppointmentId.TabIndex = 3;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(200, 120);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(151, 23);
            this.btnAddAppointment.TabIndex = 4;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnProcessAppointment
            // 
            this.btnProcessAppointment.Location = new System.Drawing.Point(243, 303);
            this.btnProcessAppointment.Name = "btnProcessAppointment";
            this.btnProcessAppointment.Size = new System.Drawing.Size(151, 23);
            this.btnProcessAppointment.TabIndex = 5;
            this.btnProcessAppointment.Text = "Process Appointment";
            this.btnProcessAppointment.UseVisualStyleBackColor = true;
            this.btnProcessAppointment.Click += new System.EventHandler(this.btnProcessAppointment_Click);
            // 
            // lsAppointment
            // 
            this.lsAppointment.FormattingEnabled = true;
            this.lsAppointment.ItemHeight = 16;
            this.lsAppointment.Location = new System.Drawing.Point(37, 149);
            this.lsAppointment.Name = "lsAppointment";
            this.lsAppointment.Size = new System.Drawing.Size(357, 148);
            this.lsAppointment.TabIndex = 6;
            // 
            // btnViewAppointment
            // 
            this.btnViewAppointment.Location = new System.Drawing.Point(37, 303);
            this.btnViewAppointment.Name = "btnViewAppointment";
            this.btnViewAppointment.Size = new System.Drawing.Size(151, 23);
            this.btnViewAppointment.TabIndex = 7;
            this.btnViewAppointment.Text = "View Appointment";
            this.btnViewAppointment.UseVisualStyleBackColor = true;
            this.btnViewAppointment.Click += new System.EventHandler(this.btnViewAppointment_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 374);
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
    }
}