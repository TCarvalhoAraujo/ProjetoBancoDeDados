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
            this.Txt_ReceiverUsername = new System.Windows.Forms.TextBox();
            this.Txt_FileID = new System.Windows.Forms.TextBox();
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
            this.Btn_Share.Click += new System.EventHandler(this.Btn_Share_Click);
            // 
            // Txt_ReceiverUsername
            // 
            this.Txt_ReceiverUsername.Location = new System.Drawing.Point(31, 112);
            this.Txt_ReceiverUsername.Name = "Txt_ReceiverUsername";
            this.Txt_ReceiverUsername.Size = new System.Drawing.Size(176, 20);
            this.Txt_ReceiverUsername.TabIndex = 9;
            // 
            // Txt_FileID
            // 
            this.Txt_FileID.Location = new System.Drawing.Point(30, 52);
            this.Txt_FileID.Name = "Txt_FileID";
            this.Txt_FileID.Size = new System.Drawing.Size(176, 20);
            this.Txt_FileID.TabIndex = 8;
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
            this.Controls.Add(this.Txt_ReceiverUsername);
            this.Controls.Add(this.Txt_FileID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Share);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_ShareFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Share;
        private System.Windows.Forms.TextBox Txt_ReceiverUsername;
        private System.Windows.Forms.TextBox Txt_FileID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}