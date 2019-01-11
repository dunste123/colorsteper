namespace colorStepper_14_sept_17 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnStepDSte = new System.Windows.Forms.Button();
            this.lblStepDSte = new System.Windows.Forms.Label();
            this.ptbColorDSte = new System.Windows.Forms.PictureBox();
            this.btnGreenDSte = new System.Windows.Forms.Button();
            this.btnRedDSte = new System.Windows.Forms.Button();
            this.btnBlueDSte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorDSte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStepDSte
            // 
            this.btnStepDSte.Location = new System.Drawing.Point(12, 12);
            this.btnStepDSte.Name = "btnStepDSte";
            this.btnStepDSte.Size = new System.Drawing.Size(75, 23);
            this.btnStepDSte.TabIndex = 0;
            this.btnStepDSte.Text = "Step";
            this.btnStepDSte.UseVisualStyleBackColor = true;
            this.btnStepDSte.Click += new System.EventHandler(this.BtnStepDSte_Click);
            // 
            // lblStepDSte
            // 
            this.lblStepDSte.AutoSize = true;
            this.lblStepDSte.Location = new System.Drawing.Point(117, 22);
            this.lblStepDSte.Name = "lblStepDSte";
            this.lblStepDSte.Size = new System.Drawing.Size(16, 13);
            this.lblStepDSte.TabIndex = 1;
            this.lblStepDSte.Text = "...";
            // 
            // ptbColorDSte
            // 
            this.ptbColorDSte.BackColor = System.Drawing.Color.White;
            this.ptbColorDSte.Location = new System.Drawing.Point(192, 125);
            this.ptbColorDSte.Name = "ptbColorDSte";
            this.ptbColorDSte.Size = new System.Drawing.Size(100, 81);
            this.ptbColorDSte.TabIndex = 2;
            this.ptbColorDSte.TabStop = false;
            // 
            // btnGreenDSte
            // 
            this.btnGreenDSte.Location = new System.Drawing.Point(12, 154);
            this.btnGreenDSte.Name = "btnGreenDSte";
            this.btnGreenDSte.Size = new System.Drawing.Size(75, 23);
            this.btnGreenDSte.TabIndex = 3;
            this.btnGreenDSte.Text = "Green";
            this.btnGreenDSte.UseVisualStyleBackColor = true;
            this.btnGreenDSte.Click += new System.EventHandler(this.btnGreenDSte_Click);
            // 
            // btnRedDSte
            // 
            this.btnRedDSte.Location = new System.Drawing.Point(12, 125);
            this.btnRedDSte.Name = "btnRedDSte";
            this.btnRedDSte.Size = new System.Drawing.Size(75, 23);
            this.btnRedDSte.TabIndex = 4;
            this.btnRedDSte.Text = "Red";
            this.btnRedDSte.UseVisualStyleBackColor = true;
            this.btnRedDSte.Click += new System.EventHandler(this.btnRedDSte_Click);
            // 
            // btnBlueDSte
            // 
            this.btnBlueDSte.Location = new System.Drawing.Point(12, 183);
            this.btnBlueDSte.Name = "btnBlueDSte";
            this.btnBlueDSte.Size = new System.Drawing.Size(75, 23);
            this.btnBlueDSte.TabIndex = 5;
            this.btnBlueDSte.Text = "Blue";
            this.btnBlueDSte.UseVisualStyleBackColor = true;
            this.btnBlueDSte.Click += new System.EventHandler(this.btnBlueDSte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 304);
            this.Controls.Add(this.btnBlueDSte);
            this.Controls.Add(this.btnRedDSte);
            this.Controls.Add(this.btnGreenDSte);
            this.Controls.Add(this.ptbColorDSte);
            this.Controls.Add(this.lblStepDSte);
            this.Controls.Add(this.btnStepDSte);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorDSte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStepDSte;
        private System.Windows.Forms.Label lblStepDSte;
        private System.Windows.Forms.PictureBox ptbColorDSte;
        private System.Windows.Forms.Button btnGreenDSte;
        private System.Windows.Forms.Button btnRedDSte;
        private System.Windows.Forms.Button btnBlueDSte;
    }
}

