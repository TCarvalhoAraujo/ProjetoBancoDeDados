namespace ProjetoBancoDeDados.Forms
{
    partial class Frm_Comment
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
            this.Btn_Comment = new System.Windows.Forms.Button();
            this.Txt_Content = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Comment
            // 
            this.Btn_Comment.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Comment.FlatAppearance.BorderSize = 0;
            this.Btn_Comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Comment.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Comment.Location = new System.Drawing.Point(290, 26);
            this.Btn_Comment.Name = "Btn_Comment";
            this.Btn_Comment.Size = new System.Drawing.Size(124, 52);
            this.Btn_Comment.TabIndex = 17;
            this.Btn_Comment.Text = "Comment";
            this.Btn_Comment.UseVisualStyleBackColor = false;
            this.Btn_Comment.Click += new System.EventHandler(this.Btn_Comment_Click);
            // 
            // Txt_Content
            // 
            this.Txt_Content.BackColor = System.Drawing.Color.Azure;
            this.Txt_Content.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Content.Location = new System.Drawing.Point(29, 109);
            this.Txt_Content.Multiline = true;
            this.Txt_Content.Name = "Txt_Content";
            this.Txt_Content.Size = new System.Drawing.Size(385, 194);
            this.Txt_Content.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Write a Comment:";
            // 
            // Frm_Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(446, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Content);
            this.Controls.Add(this.Btn_Comment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Comment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Comment;
        private System.Windows.Forms.TextBox Txt_Content;
        private System.Windows.Forms.Label label4;
    }
}