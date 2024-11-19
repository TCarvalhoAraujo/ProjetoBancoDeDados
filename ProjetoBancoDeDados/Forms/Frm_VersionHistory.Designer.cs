namespace ProjetoBancoDeDados.Forms
{
    partial class Frm_VersionHistory
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
            this.Txt_Version = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Operation = new System.Windows.Forms.TextBox();
            this.Dgv_HistoryVersion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HistoryVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Version
            // 
            this.Txt_Version.BackColor = System.Drawing.Color.Azure;
            this.Txt_Version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Version.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Version.Location = new System.Drawing.Point(153, 31);
            this.Txt_Version.Name = "Txt_Version";
            this.Txt_Version.Size = new System.Drawing.Size(34, 21);
            this.Txt_Version.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "File Name:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.Color.Azure;
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Name.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.Location = new System.Drawing.Point(425, 31);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(149, 21);
            this.Txt_Name.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Changed:";
            // 
            // Txt_Date
            // 
            this.Txt_Date.BackColor = System.Drawing.Color.Azure;
            this.Txt_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Date.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Date.Location = new System.Drawing.Point(134, 64);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Size = new System.Drawing.Size(102, 21);
            this.Txt_Date.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Operation:";
            // 
            // Txt_Operation
            // 
            this.Txt_Operation.BackColor = System.Drawing.Color.Azure;
            this.Txt_Operation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Operation.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Operation.Location = new System.Drawing.Point(461, 65);
            this.Txt_Operation.Name = "Txt_Operation";
            this.Txt_Operation.Size = new System.Drawing.Size(113, 21);
            this.Txt_Operation.TabIndex = 13;
            // 
            // Dgv_HistoryVersion
            // 
            this.Dgv_HistoryVersion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_HistoryVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_HistoryVersion.Location = new System.Drawing.Point(12, 121);
            this.Dgv_HistoryVersion.Name = "Dgv_HistoryVersion";
            this.Dgv_HistoryVersion.Size = new System.Drawing.Size(603, 213);
            this.Dgv_HistoryVersion.TabIndex = 14;
            // 
            // Frm_VersionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(639, 346);
            this.Controls.Add(this.Dgv_HistoryVersion);
            this.Controls.Add(this.Txt_Operation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Version);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_VersionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History Version";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HistoryVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Operation;
        private System.Windows.Forms.DataGridView Dgv_HistoryVersion;
    }
}