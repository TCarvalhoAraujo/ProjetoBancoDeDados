namespace ProjetoBancoDeDados
{
    partial class Frm_GetHelp_UC
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_GetHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_FileID = new System.Windows.Forms.TextBox();
            this.Txt_Descricao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Assistance Over a File";
            // 
            // Btn_GetHelp
            // 
            this.Btn_GetHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_GetHelp.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_GetHelp.FlatAppearance.BorderSize = 0;
            this.Btn_GetHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GetHelp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetHelp.Location = new System.Drawing.Point(671, 113);
            this.Btn_GetHelp.Name = "Btn_GetHelp";
            this.Btn_GetHelp.Size = new System.Drawing.Size(222, 62);
            this.Btn_GetHelp.TabIndex = 1;
            this.Btn_GetHelp.Text = "Send Help Request";
            this.Btn_GetHelp.UseVisualStyleBackColor = false;
            this.Btn_GetHelp.Click += new System.EventHandler(this.Btn_GetHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the File ID you need help with:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "How can we help you?";
            // 
            // Txt_FileID
            // 
            this.Txt_FileID.BackColor = System.Drawing.Color.Azure;
            this.Txt_FileID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_FileID.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FileID.Location = new System.Drawing.Point(305, 113);
            this.Txt_FileID.Name = "Txt_FileID";
            this.Txt_FileID.Size = new System.Drawing.Size(34, 21);
            this.Txt_FileID.TabIndex = 4;
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Descricao.BackColor = System.Drawing.Color.Azure;
            this.Txt_Descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descricao.Location = new System.Drawing.Point(18, 190);
            this.Txt_Descricao.Multiline = true;
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(875, 284);
            this.Txt_Descricao.TabIndex = 6;
            // 
            // Frm_GetHelp_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Txt_Descricao);
            this.Controls.Add(this.Txt_FileID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_GetHelp);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_GetHelp_UC";
            this.Size = new System.Drawing.Size(929, 559);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_GetHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_FileID;
        private System.Windows.Forms.TextBox Txt_Descricao;
    }
}
