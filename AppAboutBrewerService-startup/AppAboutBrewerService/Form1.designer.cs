namespace AppAboutBrewerService
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
            this.btnRequestForTank = new System.Windows.Forms.Button();
            this.btnMakeTankEmpty = new System.Windows.Forms.Button();
            this.btnShowBrewerInfo = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowTanks = new System.Windows.Forms.Button();
            this.btnShowBrewers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdTank = new System.Windows.Forms.TextBox();
            this.tbIdBrewer = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequestForTank
            // 
            this.btnRequestForTank.Location = new System.Drawing.Point(6, 99);
            this.btnRequestForTank.Name = "btnRequestForTank";
            this.btnRequestForTank.Size = new System.Drawing.Size(179, 41);
            this.btnRequestForTank.TabIndex = 0;
            this.btnRequestForTank.Text = "request for tank";
            this.btnRequestForTank.UseVisualStyleBackColor = true;
            this.btnRequestForTank.Click += new System.EventHandler(this.btnRequestForTank_Click);
            // 
            // btnMakeTankEmpty
            // 
            this.btnMakeTankEmpty.Location = new System.Drawing.Point(35, 155);
            this.btnMakeTankEmpty.Name = "btnMakeTankEmpty";
            this.btnMakeTankEmpty.Size = new System.Drawing.Size(179, 38);
            this.btnMakeTankEmpty.TabIndex = 1;
            this.btnMakeTankEmpty.Text = "make tank empty";
            this.btnMakeTankEmpty.UseVisualStyleBackColor = true;
            this.btnMakeTankEmpty.Click += new System.EventHandler(this.btnMakeTankEmpty_Click);
            // 
            // btnShowBrewerInfo
            // 
            this.btnShowBrewerInfo.Location = new System.Drawing.Point(35, 211);
            this.btnShowBrewerInfo.Name = "btnShowBrewerInfo";
            this.btnShowBrewerInfo.Size = new System.Drawing.Size(179, 45);
            this.btnShowBrewerInfo.TabIndex = 3;
            this.btnShowBrewerInfo.Text = "show brewer info";
            this.btnShowBrewerInfo.UseVisualStyleBackColor = true;
            this.btnShowBrewerInfo.Click += new System.EventHandler(this.btnShowBrewerInfo_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 18;
            this.lbInfo.Location = new System.Drawing.Point(299, 21);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(495, 400);
            this.lbInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "id brewer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "id tank";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.btnShowTanks);
            this.groupBox1.Controls.Add(this.btnShowBrewers);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnShowTanks
            // 
            this.btnShowTanks.Location = new System.Drawing.Point(28, 23);
            this.btnShowTanks.Name = "btnShowTanks";
            this.btnShowTanks.Size = new System.Drawing.Size(185, 28);
            this.btnShowTanks.TabIndex = 2;
            this.btnShowTanks.Text = "show info tanks";
            this.btnShowTanks.UseVisualStyleBackColor = true;
            this.btnShowTanks.Click += new System.EventHandler(this.btnShowTanks_Click);
            // 
            // btnShowBrewers
            // 
            this.btnShowBrewers.Location = new System.Drawing.Point(28, 57);
            this.btnShowBrewers.Name = "btnShowBrewers";
            this.btnShowBrewers.Size = new System.Drawing.Size(185, 28);
            this.btnShowBrewers.TabIndex = 1;
            this.btnShowBrewers.Text = "show info brewers";
            this.btnShowBrewers.UseVisualStyleBackColor = true;
            this.btnShowBrewers.Click += new System.EventHandler(this.btnShowBrewers_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbIdTank);
            this.panel1.Controls.Add(this.tbIdBrewer);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnShowBrewerInfo);
            this.panel1.Controls.Add(this.btnRequestForTank);
            this.panel1.Controls.Add(this.btnMakeTankEmpty);
            this.panel1.Location = new System.Drawing.Point(9, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 301);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "amount";
            // 
            // tbIdTank
            // 
            this.tbIdTank.Location = new System.Drawing.Point(178, 29);
            this.tbIdTank.Name = "tbIdTank";
            this.tbIdTank.Size = new System.Drawing.Size(78, 24);
            this.tbIdTank.TabIndex = 12;
            // 
            // tbIdBrewer
            // 
            this.tbIdBrewer.Location = new System.Drawing.Point(17, 30);
            this.tbIdBrewer.Name = "tbIdBrewer";
            this.tbIdBrewer.Size = new System.Drawing.Size(109, 24);
            this.tbIdBrewer.TabIndex = 11;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(195, 99);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(69, 24);
            this.tbAmount.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequestForTank;
        private System.Windows.Forms.Button btnMakeTankEmpty;
        private System.Windows.Forms.Button btnShowBrewerInfo;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowTanks;
        private System.Windows.Forms.Button btnShowBrewers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbIdTank;
        private System.Windows.Forms.TextBox tbIdBrewer;
        private System.Windows.Forms.Label label3;
    }
}

