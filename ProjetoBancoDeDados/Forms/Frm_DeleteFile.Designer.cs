namespace ProjetoBancoDeDados.Forms
{
    partial class Frm_DeleteFile
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
            this.Btn_DeleteFile = new System.Windows.Forms.Button();
            this.Txt_Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rdb_Txt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Btn_DeleteFile
            // 
            this.Btn_DeleteFile.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_DeleteFile.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteFile.Location = new System.Drawing.Point(106, 200);
            this.Btn_DeleteFile.Name = "Btn_DeleteFile";
            this.Btn_DeleteFile.Size = new System.Drawing.Size(167, 57);
            this.Btn_DeleteFile.TabIndex = 31;
            this.Btn_DeleteFile.Text = "Delete File";
            this.Btn_DeleteFile.UseVisualStyleBackColor = false;
            this.Btn_DeleteFile.Click += new System.EventHandler(this.Btn_DeleteFile_Click);
            // 
            // Txt_Title
            // 
            this.Txt_Title.BackColor = System.Drawing.Color.Azure;
            this.Txt_Title.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Title.Location = new System.Drawing.Point(145, 65);
            this.Txt_Title.Name = "Txt_Title";
            this.Txt_Title.Size = new System.Drawing.Size(88, 22);
            this.Txt_Title.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Enter File ID:";
            // 
            // Rdb_Txt
            // 
            this.Rdb_Txt.AutoSize = true;
            this.Rdb_Txt.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Txt.Location = new System.Drawing.Point(57, 128);
            this.Rdb_Txt.Name = "Rdb_Txt";
            this.Rdb_Txt.Size = new System.Drawing.Size(265, 20);
            this.Rdb_Txt.TabIndex = 39;
            this.Rdb_Txt.TabStop = true;
            this.Rdb_Txt.Text = "I agree that by deleting this file, i can\'t get it back";
            this.Rdb_Txt.UseVisualStyleBackColor = true;
            // 
            // Frm_DeleteFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(368, 323);
            this.Controls.Add(this.Rdb_Txt);
            this.Controls.Add(this.Txt_Title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_DeleteFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DeleteFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_DeleteFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_DeleteFile;
        private System.Windows.Forms.TextBox Txt_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Rdb_Txt;
    }
}