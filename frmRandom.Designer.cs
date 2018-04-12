namespace Exercie_5
{
    partial class frmRandom
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
            this.lbl_Nombre_frmRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Nombre_frmRandom
            // 
            this.lbl_Nombre_frmRandom.AutoSize = true;
            this.lbl_Nombre_frmRandom.Location = new System.Drawing.Point(12, 22);
            this.lbl_Nombre_frmRandom.Name = "lbl_Nombre_frmRandom";
            this.lbl_Nombre_frmRandom.Size = new System.Drawing.Size(88, 13);
            this.lbl_Nombre_frmRandom.TabIndex = 2;
            this.lbl_Nombre_frmRandom.Text = "Nombre Aléatoire";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 141);
            this.Controls.Add(this.lbl_Nombre_frmRandom);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre_frmRandom;
    }
}