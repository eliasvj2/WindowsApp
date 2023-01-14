
namespace ARMSWinClient
{
    partial class frmMailWelcomeForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnERP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(286, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10);
            this.lblTitle.Size = new System.Drawing.Size(153, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "EZRental POS System";
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Location = new System.Drawing.Point(226, 144);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(269, 35);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "Point-of-Sales and Rentals";
            this.btnPOS.UseVisualStyleBackColor = false;
            // 
            // btnERP
            // 
            this.btnERP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnERP.Location = new System.Drawing.Point(226, 204);
            this.btnERP.Name = "btnERP";
            this.btnERP.Size = new System.Drawing.Size(269, 36);
            this.btnERP.TabIndex = 2;
            this.btnERP.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.btnERP.UseVisualStyleBackColor = false;
            this.btnERP.Click += new System.EventHandler(this.btnERP_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(289, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMailWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnERP);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMailWelcomeForm";
            this.Text = "EZRental POS System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnERP;
        private System.Windows.Forms.Button btnExit;
    }
}

