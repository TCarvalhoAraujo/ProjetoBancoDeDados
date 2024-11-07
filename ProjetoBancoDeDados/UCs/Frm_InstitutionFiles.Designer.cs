namespace ProjetoBancoDeDados.UCs
{
    partial class Frm_InstitutionFiles
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_SearchFileByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Dgv_InstitutionFiles = new System.Windows.Forms.DataGridView();
            this.Btn_Comment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InstitutionFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.Btn_Comment);
            this.panel1.Controls.Add(this.txt_SearchFileByName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_OpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 88);
            this.panel1.TabIndex = 1;
            // 
            // txt_SearchFileByName
            // 
            this.txt_SearchFileByName.BackColor = System.Drawing.Color.Azure;
            this.txt_SearchFileByName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchFileByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SearchFileByName.Location = new System.Drawing.Point(165, 30);
            this.txt_SearchFileByName.Name = "txt_SearchFileByName";
            this.txt_SearchFileByName.Size = new System.Drawing.Size(203, 22);
            this.txt_SearchFileByName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by Name: ";
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.BackColor = System.Drawing.Color.Azure;
            this.Btn_OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OpenFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_OpenFile.Location = new System.Drawing.Point(749, 18);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(131, 44);
            this.Btn_OpenFile.TabIndex = 2;
            this.Btn_OpenFile.Text = "Open File";
            this.Btn_OpenFile.UseVisualStyleBackColor = false;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Dgv_InstitutionFiles
            // 
            this.Dgv_InstitutionFiles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_InstitutionFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_InstitutionFiles.Location = new System.Drawing.Point(24, 120);
            this.Dgv_InstitutionFiles.Name = "Dgv_InstitutionFiles";
            this.Dgv_InstitutionFiles.Size = new System.Drawing.Size(856, 353);
            this.Dgv_InstitutionFiles.TabIndex = 2;
            // 
            // Btn_Comment
            // 
            this.Btn_Comment.BackColor = System.Drawing.Color.Azure;
            this.Btn_Comment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Comment.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Comment.Location = new System.Drawing.Point(580, 18);
            this.Btn_Comment.Name = "Btn_Comment";
            this.Btn_Comment.Size = new System.Drawing.Size(131, 44);
            this.Btn_Comment.TabIndex = 5;
            this.Btn_Comment.Text = "Add a Comment";
            this.Btn_Comment.UseVisualStyleBackColor = false;
            // 
            // Frm_InstitutionFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dgv_InstitutionFiles);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_InstitutionFiles";
            this.Size = new System.Drawing.Size(929, 559);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InstitutionFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_SearchFileByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.DataGridView Dgv_InstitutionFiles;
        private System.Windows.Forms.Button Btn_Comment;
    }
}
