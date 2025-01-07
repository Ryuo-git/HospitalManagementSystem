namespace HospitalManagementSystem
{
    partial class MedicineForm
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
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtMedicineQuantity = new System.Windows.Forms.TextBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnRemoveMedicine = new System.Windows.Forms.Button();
            this.lsMedicine = new System.Windows.Forms.ListBox();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity :";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(146, 55);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(192, 22);
            this.txtMedicineName.TabIndex = 2;
            // 
            // txtMedicineQuantity
            // 
            this.txtMedicineQuantity.Location = new System.Drawing.Point(146, 84);
            this.txtMedicineQuantity.Name = "txtMedicineQuantity";
            this.txtMedicineQuantity.Size = new System.Drawing.Size(192, 22);
            this.txtMedicineQuantity.TabIndex = 3;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(191, 112);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(100, 24);
            this.btnAddMedicine.TabIndex = 4;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnRemoveMedicine
            // 
            this.btnRemoveMedicine.Location = new System.Drawing.Point(35, 137);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Size = new System.Drawing.Size(127, 24);
            this.btnRemoveMedicine.TabIndex = 5;
            this.btnRemoveMedicine.Text = "Remove Medicine";
            this.btnRemoveMedicine.UseVisualStyleBackColor = true;
            this.btnRemoveMedicine.Click += new System.EventHandler(this.btnRemoveMedicine_Click);
            // 
            // lsMedicine
            // 
            this.lsMedicine.FormattingEnabled = true;
            this.lsMedicine.ItemHeight = 16;
            this.lsMedicine.Location = new System.Drawing.Point(174, 143);
            this.lsMedicine.Name = "lsMedicine";
            this.lsMedicine.Size = new System.Drawing.Size(139, 196);
            this.lsMedicine.TabIndex = 6;
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.Location = new System.Drawing.Point(35, 167);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(127, 24);
            this.btnViewMedicine.TabIndex = 7;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.UseVisualStyleBackColor = true;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 373);
            this.Controls.Add(this.btnViewMedicine);
            this.Controls.Add(this.lsMedicine);
            this.Controls.Add(this.btnRemoveMedicine);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.txtMedicineQuantity);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtMedicineQuantity;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnRemoveMedicine;
        private System.Windows.Forms.ListBox lsMedicine;
        private System.Windows.Forms.Button btnViewMedicine;
    }
}