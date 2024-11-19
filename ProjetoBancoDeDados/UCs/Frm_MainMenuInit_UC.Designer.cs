namespace ProjetoBancoDeDados.UCs
{
    partial class Frm_MainMenuInit_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_RecentFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recently Viewed Files";
            // 
            // Lbl_Welcome
            // 
            this.Lbl_Welcome.AutoSize = true;
            this.Lbl_Welcome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Welcome.Location = new System.Drawing.Point(321, 41);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(124, 32);
            this.Lbl_Welcome.TabIndex = 0;
            this.Lbl_Welcome.Text = "Welcome, ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_Welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 113);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(738, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "@MetalCompany";
            // 
            // Btn_RecentFile
            // 
            this.Btn_RecentFile.BackColor = System.Drawing.Color.LightCyan;
            this.Btn_RecentFile.FlatAppearance.BorderSize = 0;
            this.Btn_RecentFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RecentFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_RecentFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_RecentFile.Location = new System.Drawing.Point(106, 108);
            this.Btn_RecentFile.Name = "Btn_RecentFile";
            this.Btn_RecentFile.Size = new System.Drawing.Size(159, 54);
            this.Btn_RecentFile.TabIndex = 5;
            this.Btn_RecentFile.Text = "Open Last Viewed File";
            this.Btn_RecentFile.UseVisualStyleBackColor = false;
            this.Btn_RecentFile.Click += new System.EventHandler(this.Btn_RecentFile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Btn_RecentFile);
            this.panel2.Location = new System.Drawing.Point(527, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 434);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Release Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 156);
            this.label4.TabIndex = 7;
            this.label4.Text = "- Support is now available!\r\n- Share your files with some friends!\r\n- Track your " +
    "activity!\r\n- See your colleagues work!\r\n- Add comments!\r\n- Check you history ver" +
    "sion!\r\n";
            // 
            // Frm_MainMenuInit_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_MainMenuInit_UC";
            this.Size = new System.Drawing.Size(909, 547);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_RecentFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
