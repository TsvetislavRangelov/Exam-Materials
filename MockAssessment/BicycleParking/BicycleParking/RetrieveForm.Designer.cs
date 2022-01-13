namespace BicycleParking
{
    partial class RetrieveForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOwnerZipcode = new System.Windows.Forms.TextBox();
            this.btnRetrieveBicycle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxHoursInParking = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Owner zipcode:";
            // 
            // tbxOwnerZipcode
            // 
            this.tbxOwnerZipcode.Location = new System.Drawing.Point(115, 32);
            this.tbxOwnerZipcode.Name = "tbxOwnerZipcode";
            this.tbxOwnerZipcode.Size = new System.Drawing.Size(100, 20);
            this.tbxOwnerZipcode.TabIndex = 2;
            // 
            // btnRetrieveBicycle
            // 
            this.btnRetrieveBicycle.Location = new System.Drawing.Point(15, 58);
            this.btnRetrieveBicycle.Name = "btnRetrieveBicycle";
            this.btnRetrieveBicycle.Size = new System.Drawing.Size(199, 23);
            this.btnRetrieveBicycle.TabIndex = 3;
            this.btnRetrieveBicycle.Text = "Retrieve bicycle";
            this.btnRetrieveBicycle.UseVisualStyleBackColor = true;
            this.btnRetrieveBicycle.Click += new System.EventHandler(this.btnRetrieveBicycle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hours in parking:";
            // 
            // tbxHoursInParking
            // 
            this.tbxHoursInParking.Location = new System.Drawing.Point(115, 6);
            this.tbxHoursInParking.Name = "tbxHoursInParking";
            this.tbxHoursInParking.Size = new System.Drawing.Size(100, 20);
            this.tbxHoursInParking.TabIndex = 6;
            this.tbxHoursInParking.Text = "1";
            // 
            // RetrieveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 91);
            this.Controls.Add(this.tbxHoursInParking);
            this.Controls.Add(this.tbxOwnerZipcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRetrieveBicycle);
            this.Controls.Add(this.label1);
            this.Name = "RetrieveForm";
            this.Text = "RetrieveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxOwnerZipcode;
        private System.Windows.Forms.Button btnRetrieveBicycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxHoursInParking;
    }
}