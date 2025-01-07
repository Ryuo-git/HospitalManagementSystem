namespace HospitalManagementSystem
{
    partial class DoctorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtDoctorExperience = new System.Windows.Forms.TextBox();
            this.txtDoctorSpecialization = new System.Windows.Forms.TextBox();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.lsDoctors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Experience :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specialization :";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(134, 78);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(243, 22);
            this.txtDoctorName.TabIndex = 3;
            // 
            // txtDoctorExperience
            // 
            this.txtDoctorExperience.Location = new System.Drawing.Point(134, 106);
            this.txtDoctorExperience.Name = "txtDoctorExperience";
            this.txtDoctorExperience.Size = new System.Drawing.Size(243, 22);
            this.txtDoctorExperience.TabIndex = 4;
            // 
            // txtDoctorSpecialization
            // 
            this.txtDoctorSpecialization.Location = new System.Drawing.Point(134, 138);
            this.txtDoctorSpecialization.Name = "txtDoctorSpecialization";
            this.txtDoctorSpecialization.Size = new System.Drawing.Size(243, 22);
            this.txtDoctorSpecialization.TabIndex = 5;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(189, 174);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(117, 28);
            this.btnAddDoctor.TabIndex = 6;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.Location = new System.Drawing.Point(34, 212);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(94, 28);
            this.btnViewDoctor.TabIndex = 7;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = true;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // lsDoctors
            // 
            this.lsDoctors.FormattingEnabled = true;
            this.lsDoctors.ItemHeight = 16;
            this.lsDoctors.Location = new System.Drawing.Point(134, 217);
            this.lsDoctors.Name = "lsDoctors";
            this.lsDoctors.Size = new System.Drawing.Size(242, 180);
            this.lsDoctors.TabIndex = 8;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 454);
            this.Controls.Add(this.lsDoctors);
            this.Controls.Add(this.btnViewDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.txtDoctorSpecialization);
            this.Controls.Add(this.txtDoctorExperience);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtDoctorExperience;
        private System.Windows.Forms.TextBox txtDoctorSpecialization;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.ListBox lsDoctors;
    }
}