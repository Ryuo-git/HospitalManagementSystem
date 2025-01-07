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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayGraph = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoom1 = new System.Windows.Forms.TextBox();
            this.lsDisplayGraph = new System.Windows.Forms.ListBox();
            this.txtRoom2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Map Navigation";
            // 
            // btnDisplayGraph
            // 
            this.btnDisplayGraph.Location = new System.Drawing.Point(44, 179);
            this.btnDisplayGraph.Name = "btnDisplayGraph";
            this.btnDisplayGraph.Size = new System.Drawing.Size(144, 25);
            this.btnDisplayGraph.TabIndex = 2;
            this.btnDisplayGraph.Text = "Display Graph";
            this.btnDisplayGraph.UseVisualStyleBackColor = true;
            this.btnDisplayGraph.Click += new System.EventHandler(this.btnDisplayGraph_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(44, 83);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(144, 25);
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Location = new System.Drawing.Point(44, 114);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(144, 25);
            this.btnAddConnection.TabIndex = 4;
            this.btnAddConnection.Text = "Add Connection";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(207, 86);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(549, 22);
            this.txtRoomName.TabIndex = 5;
            // 
            // txtRoom1
            // 
            this.txtRoom1.Location = new System.Drawing.Point(207, 114);
            this.txtRoom1.Name = "txtRoom1";
            this.txtRoom1.Size = new System.Drawing.Size(549, 22);
            this.txtRoom1.TabIndex = 6;
            // 
            // lsDisplayGraph
            // 
            this.lsDisplayGraph.FormattingEnabled = true;
            this.lsDisplayGraph.ItemHeight = 16;
            this.lsDisplayGraph.Location = new System.Drawing.Point(207, 181);
            this.lsDisplayGraph.Name = "lsDisplayGraph";
            this.lsDisplayGraph.Size = new System.Drawing.Size(549, 212);
            this.lsDisplayGraph.TabIndex = 7;
            // 
            // txtRoom2
            // 
            this.txtRoom2.Location = new System.Drawing.Point(207, 142);
            this.txtRoom2.Name = "txtRoom2";
            this.txtRoom2.Size = new System.Drawing.Size(549, 22);
            this.txtRoom2.TabIndex = 8;
            // 
            // HospitalMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRoom2);
            this.Controls.Add(this.lsDisplayGraph);
            this.Controls.Add(this.txtRoom1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.btnAddConnection);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnDisplayGraph);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HospitalMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalMapForm";
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
    }
}