namespace ProjetoBancoDeDados
{
    partial class Frm_MyFiles_UC
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
            this.Btn_DeleteFile = new System.Windows.Forms.Button();
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Btn_NewFile = new System.Windows.Forms.Button();
            this.Dgv_MyFiles = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MyFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txt_SearchFileByName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_DeleteFile);
            this.panel1.Controls.Add(this.Btn_OpenFile);
            this.panel1.Controls.Add(this.Btn_NewFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 88);
            this.panel1.TabIndex = 0;
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
            // Btn_DeleteFile
            // 
            this.Btn_DeleteFile.BackColor = System.Drawing.Color.Azure;
            this.Btn_DeleteFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_DeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteFile.Location = new System.Drawing.Point(744, 18);
            this.Btn_DeleteFile.Name = "Btn_DeleteFile";
            this.Btn_DeleteFile.Size = new System.Drawing.Size(131, 44);
            this.Btn_DeleteFile.TabIndex = 1;
            this.Btn_DeleteFile.Text = "Delete File";
            this.Btn_DeleteFile.UseVisualStyleBackColor = false;
            this.Btn_DeleteFile.Click += new System.EventHandler(this.Btn_DeleteFile_Click);
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.BackColor = System.Drawing.Color.Azure;
            this.Btn_OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OpenFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_OpenFile.Location = new System.Drawing.Point(597, 18);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(131, 44);
            this.Btn_OpenFile.TabIndex = 2;
            this.Btn_OpenFile.Text = "Open File";
            this.Btn_OpenFile.UseVisualStyleBackColor = false;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Btn_NewFile
            // 
            this.Btn_NewFile.BackColor = System.Drawing.Color.Azure;
            this.Btn_NewFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_NewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_NewFile.Location = new System.Drawing.Point(447, 18);
            this.Btn_NewFile.Name = "Btn_NewFile";
            this.Btn_NewFile.Size = new System.Drawing.Size(131, 44);
            this.Btn_NewFile.TabIndex = 0;
            this.Btn_NewFile.Text = "New File";
            this.Btn_NewFile.UseVisualStyleBackColor = false;
            this.Btn_NewFile.Click += new System.EventHandler(this.Btn_NewFile_Click);
            // 
            // Dgv_MyFiles
            // 
            this.Dgv_MyFiles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_MyFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MyFiles.Location = new System.Drawing.Point(19, 112);
            this.Dgv_MyFiles.Name = "Dgv_MyFiles";
            this.Dgv_MyFiles.RowHeadersWidth = 45;
            this.Dgv_MyFiles.Size = new System.Drawing.Size(856, 384);
            this.Dgv_MyFiles.TabIndex = 1;
            // 
            // Frm_MyFiles_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Dgv_MyFiles);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_MyFiles_UC";
            this.Size = new System.Drawing.Size(929, 559);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MyFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_NewFile;
        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.Button Btn_DeleteFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchFileByName;
        private System.Windows.Forms.DataGridView Dgv_MyFiles;
    }
}
