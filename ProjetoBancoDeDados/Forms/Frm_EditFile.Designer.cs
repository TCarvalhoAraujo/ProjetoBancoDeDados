namespace ProjetoBancoDeDados.Forms
{
    partial class Frm_EditFile
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
            this.Txt_Title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Content = new System.Windows.Forms.TextBox();
            this.Btn_UpdateFile = new System.Windows.Forms.Button();
            this.Btn_HistoryVersion = new System.Windows.Forms.Button();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.Txt_Permissao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_URL = new System.Windows.Forms.TextBox();
            this.Txt_FileID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_UserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Size = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Date = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Title
            // 
            this.Txt_Title.BackColor = System.Drawing.Color.Azure;
            this.Txt_Title.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Title.Location = new System.Drawing.Point(79, 23);
            this.Txt_Title.Name = "Txt_Title";
            this.Txt_Title.Size = new System.Drawing.Size(289, 22);
            this.Txt_Title.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "File Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Privacy Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "File Content:";
            // 
            // Txt_Content
            // 
            this.Txt_Content.BackColor = System.Drawing.Color.Azure;
            this.Txt_Content.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Content.Location = new System.Drawing.Point(36, 152);
            this.Txt_Content.Multiline = true;
            this.Txt_Content.Name = "Txt_Content";
            this.Txt_Content.Size = new System.Drawing.Size(643, 361);
            this.Txt_Content.TabIndex = 17;
            // 
            // Btn_UpdateFile
            // 
            this.Btn_UpdateFile.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_UpdateFile.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateFile.Location = new System.Drawing.Point(555, 23);
            this.Btn_UpdateFile.Name = "Btn_UpdateFile";
            this.Btn_UpdateFile.Size = new System.Drawing.Size(124, 52);
            this.Btn_UpdateFile.TabIndex = 16;
            this.Btn_UpdateFile.Text = "Save Changes";
            this.Btn_UpdateFile.UseVisualStyleBackColor = false;
            this.Btn_UpdateFile.Click += new System.EventHandler(this.Btn_UpdateFile_Click);
            // 
            // Btn_HistoryVersion
            // 
            this.Btn_HistoryVersion.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_HistoryVersion.FlatAppearance.BorderSize = 0;
            this.Btn_HistoryVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_HistoryVersion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HistoryVersion.Location = new System.Drawing.Point(555, 86);
            this.Btn_HistoryVersion.Name = "Btn_HistoryVersion";
            this.Btn_HistoryVersion.Size = new System.Drawing.Size(124, 56);
            this.Btn_HistoryVersion.TabIndex = 30;
            this.Btn_HistoryVersion.Text = "History Version";
            this.Btn_HistoryVersion.UseVisualStyleBackColor = false;
            this.Btn_HistoryVersion.Click += new System.EventHandler(this.Btn_HistoryVersion_Click);
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.BackColor = System.Drawing.Color.Azure;
            this.Txt_Tipo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tipo.Location = new System.Drawing.Point(108, 93);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(42, 22);
            this.Txt_Tipo.TabIndex = 31;
            // 
            // Txt_Permissao
            // 
            this.Txt_Permissao.BackColor = System.Drawing.Color.Azure;
            this.Txt_Permissao.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Permissao.Location = new System.Drawing.Point(268, 94);
            this.Txt_Permissao.Name = "Txt_Permissao";
            this.Txt_Permissao.Size = new System.Drawing.Size(100, 22);
            this.Txt_Permissao.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "URL:";
            // 
            // Txt_URL
            // 
            this.Txt_URL.BackColor = System.Drawing.Color.Azure;
            this.Txt_URL.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_URL.Location = new System.Drawing.Point(78, 60);
            this.Txt_URL.Name = "Txt_URL";
            this.Txt_URL.ReadOnly = true;
            this.Txt_URL.Size = new System.Drawing.Size(289, 22);
            this.Txt_URL.TabIndex = 34;
            // 
            // Txt_FileID
            // 
            this.Txt_FileID.BackColor = System.Drawing.Color.Azure;
            this.Txt_FileID.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FileID.Location = new System.Drawing.Point(462, 22);
            this.Txt_FileID.Name = "Txt_FileID";
            this.Txt_FileID.ReadOnly = true;
            this.Txt_FileID.Size = new System.Drawing.Size(52, 22);
            this.Txt_FileID.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "File ID:";
            // 
            // Txt_UserID
            // 
            this.Txt_UserID.BackColor = System.Drawing.Color.Azure;
            this.Txt_UserID.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserID.Location = new System.Drawing.Point(462, 59);
            this.Txt_UserID.Name = "Txt_UserID";
            this.Txt_UserID.ReadOnly = true;
            this.Txt_UserID.Size = new System.Drawing.Size(52, 22);
            this.Txt_UserID.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "User ID:";
            // 
            // Txt_Size
            // 
            this.Txt_Size.BackColor = System.Drawing.Color.Azure;
            this.Txt_Size.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Size.Location = new System.Drawing.Point(462, 94);
            this.Txt_Size.Name = "Txt_Size";
            this.Txt_Size.ReadOnly = true;
            this.Txt_Size.Size = new System.Drawing.Size(52, 22);
            this.Txt_Size.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Last Changed:";
            // 
            // Txt_Date
            // 
            this.Txt_Date.BackColor = System.Drawing.Color.Azure;
            this.Txt_Date.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Date.Location = new System.Drawing.Point(268, 124);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.ReadOnly = true;
            this.Txt_Date.Size = new System.Drawing.Size(99, 22);
            this.Txt_Date.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(390, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Location:";
            // 
            // Txt_Location
            // 
            this.Txt_Location.BackColor = System.Drawing.Color.Azure;
            this.Txt_Location.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Location.Location = new System.Drawing.Point(462, 124);
            this.Txt_Location.Name = "Txt_Location";
            this.Txt_Location.Size = new System.Drawing.Size(52, 22);
            this.Txt_Location.TabIndex = 44;
            // 
            // Frm_EditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(713, 536);
            this.Controls.Add(this.Txt_Location);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Size);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_UserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_FileID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_URL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Permissao);
            this.Controls.Add(this.Txt_Tipo);
            this.Controls.Add(this.Btn_HistoryVersion);
            this.Controls.Add(this.Txt_Title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Content);
            this.Controls.Add(this.Btn_UpdateFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_EditFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Content;
        private System.Windows.Forms.Button Btn_UpdateFile;
        private System.Windows.Forms.Button Btn_HistoryVersion;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.TextBox Txt_Permissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_URL;
        private System.Windows.Forms.TextBox Txt_FileID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_UserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Size;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Location;
    }
}