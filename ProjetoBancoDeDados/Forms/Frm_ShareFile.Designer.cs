namespace ProjetoBancoDeDados.Forms
{
    partial class Frm_ShareFile
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
            this.Btn_Share = new System.Windows.Forms.Button();
            this.Txt_LoginPassword = new System.Windows.Forms.TextBox();
            this.Txt_LoginEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Share
            // 
            this.Btn_Share.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Share.FlatAppearance.BorderSize = 0;
            this.Btn_Share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Share.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Share.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Share.Location = new System.Drawing.Point(45, 169);
            this.Btn_Share.Name = "Btn_Share";
            this.Btn_Share.Size = new System.Drawing.Size(140, 46);
            this.Btn_Share.TabIndex = 4;
            this.Btn_Share.Text = "Share";
            this.Btn_Share.UseVisualStyleBackColor = false;
            // 
            // Txt_LoginPassword
            // 
            this.Txt_LoginPassword.Location = new System.Drawing.Point(31, 112);
            this.Txt_LoginPassword.Name = "Txt_LoginPassword";
            this.Txt_LoginPassword.Size = new System.Drawing.Size(176, 20);
            this.Txt_LoginPassword.TabIndex = 9;
            // 
            // Txt_LoginEmail
            // 
            this.Txt_LoginEmail.Location = new System.Drawing.Point(30, 52);
            this.Txt_LoginEmail.Name = "Txt_LoginEmail";
            this.Txt_LoginEmail.Size = new System.Drawing.Size(176, 20);
            this.Txt_LoginEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter receiver username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter File ID:";
            // 
            // Frm_ShareFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(245, 249);
            this.Controls.Add(this.Txt_LoginPassword);
            this.Controls.Add(this.Txt_LoginEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Share);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_ShareFile";
            this.Text = "Share File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Share;
        private System.Windows.Forms.TextBox Txt_LoginPassword;
        private System.Windows.Forms.TextBox Txt_LoginEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}