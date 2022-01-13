namespace BicycleParking
{
    partial class StatisticsForm
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
            this.lbxBicycles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxBicycles
            // 
            this.lbxBicycles.FormattingEnabled = true;
            this.lbxBicycles.Location = new System.Drawing.Point(12, 12);
            this.lbxBicycles.Name = "lbxBicycles";
            this.lbxBicycles.Size = new System.Drawing.Size(556, 186);
            this.lbxBicycles.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 213);
            this.Controls.Add(this.lbxBicycles);
            this.Name = "StatisticsForm";
            this.Text = "Statistics of retrieved bicycles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBicycles;
    }
}