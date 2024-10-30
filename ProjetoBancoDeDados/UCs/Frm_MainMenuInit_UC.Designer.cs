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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.Lbl_Username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 144);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back, ";
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Username.Location = new System.Drawing.Point(398, 56);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(125, 32);
            this.Lbl_Username.TabIndex = 1;
            this.Lbl_Username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recently Viewed Files";
            // 
            // Frm_MainMenuInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_MainMenuInit";
            this.Size = new System.Drawing.Size(728, 493);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
