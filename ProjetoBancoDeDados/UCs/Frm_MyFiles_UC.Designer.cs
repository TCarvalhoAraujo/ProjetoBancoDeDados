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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SearchFileByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_DeleteFile = new System.Windows.Forms.Button();
            this.Btn_UpdateFile = new System.Windows.Forms.Button();
            this.Btn_NewFile = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_SearchFileByName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_DeleteFile);
            this.panel1.Controls.Add(this.Btn_UpdateFile);
            this.panel1.Controls.Add(this.Btn_NewFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 98);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(353, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filters:";
            // 
            // txt_SearchFileByName
            // 
            this.txt_SearchFileByName.BackColor = System.Drawing.Color.Azure;
            this.txt_SearchFileByName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchFileByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SearchFileByName.Location = new System.Drawing.Point(82, 30);
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
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search: ";
            // 
            // Btn_DeleteFile
            // 
            this.Btn_DeleteFile.BackColor = System.Drawing.Color.Azure;
            this.Btn_DeleteFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_DeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteFile.Location = new System.Drawing.Point(771, 18);
            this.Btn_DeleteFile.Name = "Btn_DeleteFile";
            this.Btn_DeleteFile.Size = new System.Drawing.Size(131, 44);
            this.Btn_DeleteFile.TabIndex = 1;
            this.Btn_DeleteFile.Text = "Delete File";
            this.Btn_DeleteFile.UseVisualStyleBackColor = false;
            this.Btn_DeleteFile.Click += new System.EventHandler(this.Btn_DeleteFile_Click);
            // 
            // Btn_UpdateFile
            // 
            this.Btn_UpdateFile.BackColor = System.Drawing.Color.Azure;
            this.Btn_UpdateFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_UpdateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_UpdateFile.Location = new System.Drawing.Point(621, 18);
            this.Btn_UpdateFile.Name = "Btn_UpdateFile";
            this.Btn_UpdateFile.Size = new System.Drawing.Size(131, 44);
            this.Btn_UpdateFile.TabIndex = 2;
            this.Btn_UpdateFile.Text = "Edit File";
            this.Btn_UpdateFile.UseVisualStyleBackColor = false;
            this.Btn_UpdateFile.Click += new System.EventHandler(this.Btn_UpdateFile_Click);
            // 
            // Btn_NewFile
            // 
            this.Btn_NewFile.BackColor = System.Drawing.Color.Azure;
            this.Btn_NewFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_NewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_NewFile.Location = new System.Drawing.Point(471, 18);
            this.Btn_NewFile.Name = "Btn_NewFile";
            this.Btn_NewFile.Size = new System.Drawing.Size(131, 44);
            this.Btn_NewFile.TabIndex = 0;
            this.Btn_NewFile.Text = "New File";
            this.Btn_NewFile.UseVisualStyleBackColor = false;
            this.Btn_NewFile.Click += new System.EventHandler(this.Btn_NewFile_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Azure;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Frm_MyFiles_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Frm_MyFiles_UC";
            this.Size = new System.Drawing.Size(929, 559);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_NewFile;
        private System.Windows.Forms.Button Btn_UpdateFile;
        private System.Windows.Forms.Button Btn_DeleteFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchFileByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
