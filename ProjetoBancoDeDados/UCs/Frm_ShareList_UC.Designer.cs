namespace ProjetoBancoDeDados
{
    partial class Frm_ShareList_UC
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
            this.Btn_ShareFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgv_SharedFiles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_ReceivedFiles = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SharedFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ReceivedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.Btn_ShareFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 97);
            this.panel1.TabIndex = 0;
            // 
            // Btn_ShareFile
            // 
            this.Btn_ShareFile.BackColor = System.Drawing.Color.LightCyan;
            this.Btn_ShareFile.FlatAppearance.BorderSize = 0;
            this.Btn_ShareFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ShareFile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_ShareFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_ShareFile.Location = new System.Drawing.Point(688, 27);
            this.Btn_ShareFile.Name = "Btn_ShareFile";
            this.Btn_ShareFile.Size = new System.Drawing.Size(177, 46);
            this.Btn_ShareFile.TabIndex = 4;
            this.Btn_ShareFile.Text = "Share File";
            this.Btn_ShareFile.UseVisualStyleBackColor = false;
            this.Btn_ShareFile.Click += new System.EventHandler(this.Btn_ShareFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Share List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.Dgv_SharedFiles);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 429);
            this.panel2.TabIndex = 1;
            // 
            // Dgv_SharedFiles
            // 
            this.Dgv_SharedFiles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_SharedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SharedFiles.GridColor = System.Drawing.Color.Azure;
            this.Dgv_SharedFiles.Location = new System.Drawing.Point(41, 119);
            this.Dgv_SharedFiles.Name = "Dgv_SharedFiles";
            this.Dgv_SharedFiles.Size = new System.Drawing.Size(365, 239);
            this.Dgv_SharedFiles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(145, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shared Files ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(613, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Received Files ";
            // 
            // Dgv_ReceivedFiles
            // 
            this.Dgv_ReceivedFiles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_ReceivedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ReceivedFiles.GridColor = System.Drawing.Color.Azure;
            this.Dgv_ReceivedFiles.Location = new System.Drawing.Point(500, 216);
            this.Dgv_ReceivedFiles.Name = "Dgv_ReceivedFiles";
            this.Dgv_ReceivedFiles.Size = new System.Drawing.Size(365, 239);
            this.Dgv_ReceivedFiles.TabIndex = 4;
            // 
            // Frm_ShareList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dgv_ReceivedFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ShareList_UC";
            this.Size = new System.Drawing.Size(913, 526);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SharedFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ReceivedFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_ShareFile;
        private System.Windows.Forms.DataGridView Dgv_SharedFiles;
        private System.Windows.Forms.DataGridView Dgv_ReceivedFiles;
    }
}
