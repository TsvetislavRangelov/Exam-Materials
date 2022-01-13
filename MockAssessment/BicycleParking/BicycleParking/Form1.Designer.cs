namespace BicycleParking
{
    partial class Form1
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
            this.lblTicketNumber = new System.Windows.Forms.Label();
            this.cbbTicketnumbers = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbnTandem = new System.Windows.Forms.RadioButton();
            this.rbnNormal = new System.Windows.Forms.RadioButton();
            this.rbnFolding = new System.Windows.Forms.RadioButton();
            this.rbnElectric = new System.Windows.Forms.RadioButton();
            this.btnParkBicycle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnregisterBicycle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPartialZipcode = new System.Windows.Forms.TextBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicketNumber
            // 
            this.lblTicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNumber.Location = new System.Drawing.Point(17, 91);
            this.lblTicketNumber.Name = "lblTicketNumber";
            this.lblTicketNumber.Size = new System.Drawing.Size(354, 36);
            this.lblTicketNumber.TabIndex = 2;
            this.lblTicketNumber.Text = "[ticket number]";
            this.lblTicketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbTicketnumbers
            // 
            this.cbbTicketnumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTicketnumbers.FormattingEnabled = true;
            this.cbbTicketnumbers.Location = new System.Drawing.Point(95, 155);
            this.cbbTicketnumbers.Name = "cbbTicketnumbers";
            this.cbbTicketnumbers.Size = new System.Drawing.Size(97, 21);
            this.cbbTicketnumbers.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbnTandem);
            this.groupBox1.Controls.Add(this.lblTicketNumber);
            this.groupBox1.Controls.Add(this.rbnNormal);
            this.groupBox1.Controls.Add(this.rbnFolding);
            this.groupBox1.Controls.Add(this.rbnElectric);
            this.groupBox1.Controls.Add(this.btnParkBicycle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Park bicycle";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bicycle type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rbnTandem
            // 
            this.rbnTandem.AutoSize = true;
            this.rbnTandem.Location = new System.Drawing.Point(300, 42);
            this.rbnTandem.Name = "rbnTandem";
            this.rbnTandem.Size = new System.Drawing.Size(71, 17);
            this.rbnTandem.TabIndex = 7;
            this.rbnTandem.Text = "TANDEM";
            this.rbnTandem.UseVisualStyleBackColor = true;
            // 
            // rbnNormal
            // 
            this.rbnNormal.AutoSize = true;
            this.rbnNormal.Checked = true;
            this.rbnNormal.Location = new System.Drawing.Point(213, 42);
            this.rbnNormal.Name = "rbnNormal";
            this.rbnNormal.Size = new System.Drawing.Size(71, 17);
            this.rbnNormal.TabIndex = 6;
            this.rbnNormal.TabStop = true;
            this.rbnNormal.Text = "NORMAL";
            this.rbnNormal.UseVisualStyleBackColor = true;
            // 
            // rbnFolding
            // 
            this.rbnFolding.AutoSize = true;
            this.rbnFolding.Location = new System.Drawing.Point(114, 42);
            this.rbnFolding.Name = "rbnFolding";
            this.rbnFolding.Size = new System.Drawing.Size(72, 17);
            this.rbnFolding.TabIndex = 5;
            this.rbnFolding.Text = "FOLDING";
            this.rbnFolding.UseVisualStyleBackColor = true;
            // 
            // rbnElectric
            // 
            this.rbnElectric.AutoSize = true;
            this.rbnElectric.Location = new System.Drawing.Point(21, 42);
            this.rbnElectric.Name = "rbnElectric";
            this.rbnElectric.Size = new System.Drawing.Size(77, 17);
            this.rbnElectric.TabIndex = 4;
            this.rbnElectric.Text = "ELECTRIC";
            this.rbnElectric.UseVisualStyleBackColor = true;
            // 
            // btnParkBicycle
            // 
            this.btnParkBicycle.Location = new System.Drawing.Point(18, 65);
            this.btnParkBicycle.Name = "btnParkBicycle";
            this.btnParkBicycle.Size = new System.Drawing.Size(353, 23);
            this.btnParkBicycle.TabIndex = 3;
            this.btnParkBicycle.Text = "Park bicycle";
            this.btnParkBicycle.UseVisualStyleBackColor = true;
            this.btnParkBicycle.Click += new System.EventHandler(this.btnParkBicycle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ticket numbers:";
            // 
            // btnUnregisterBicycle
            // 
            this.btnUnregisterBicycle.Location = new System.Drawing.Point(198, 155);
            this.btnUnregisterBicycle.Name = "btnUnregisterBicycle";
            this.btnUnregisterBicycle.Size = new System.Drawing.Size(200, 23);
            this.btnUnregisterBicycle.TabIndex = 6;
            this.btnUnregisterBicycle.Text = "Retrieve parked bicycle";
            this.btnUnregisterBicycle.UseVisualStyleBackColor = true;
            this.btnUnregisterBicycle.Click += new System.EventHandler(this.btnRetrieveBicycle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Partial zipcode:";
            // 
            // tbxPartialZipcode
            // 
            this.tbxPartialZipcode.Location = new System.Drawing.Point(95, 187);
            this.tbxPartialZipcode.Name = "tbxPartialZipcode";
            this.tbxPartialZipcode.Size = new System.Drawing.Size(97, 20);
            this.tbxPartialZipcode.TabIndex = 8;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(198, 185);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(200, 23);
            this.btnStatistics.TabIndex = 9;
            this.btnStatistics.Text = "Show statistics of retrieved bicycles";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 218);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.tbxPartialZipcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUnregisterBicycle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTicketnumbers);
            this.Name = "Form1";
            this.Text = "Bicycle Parking Facility";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTicketNumber;
        private System.Windows.Forms.ComboBox cbbTicketnumbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnTandem;
        private System.Windows.Forms.RadioButton rbnNormal;
        private System.Windows.Forms.RadioButton rbnFolding;
        private System.Windows.Forms.RadioButton rbnElectric;
        private System.Windows.Forms.Button btnParkBicycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnregisterBicycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPartialZipcode;
        private System.Windows.Forms.Button btnStatistics;
    }
}

