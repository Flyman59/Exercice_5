namespace Exercie_5
{
    partial class frmExo5
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
            this.lbl_Chrono_frmExo5 = new System.Windows.Forms.Label();
            this.lbl_Nombre_frmExo5 = new System.Windows.Forms.Label();
            this.textBox_Chrono_Exo5 = new System.Windows.Forms.TextBox();
            this.textBox_Nombre_Exo5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Chrono_frmExo5
            // 
            this.lbl_Chrono_frmExo5.AutoSize = true;
            this.lbl_Chrono_frmExo5.Location = new System.Drawing.Point(12, 23);
            this.lbl_Chrono_frmExo5.Name = "lbl_Chrono_frmExo5";
            this.lbl_Chrono_frmExo5.Size = new System.Drawing.Size(41, 13);
            this.lbl_Chrono_frmExo5.TabIndex = 0;
            this.lbl_Chrono_frmExo5.Text = "Chrono";
            this.lbl_Chrono_frmExo5.Click += new System.EventHandler(this.lbl_Chrono_frmExo5_Click);
            // 
            // lbl_Nombre_frmExo5
            // 
            this.lbl_Nombre_frmExo5.AutoSize = true;
            this.lbl_Nombre_frmExo5.Location = new System.Drawing.Point(12, 61);
            this.lbl_Nombre_frmExo5.Name = "lbl_Nombre_frmExo5";
            this.lbl_Nombre_frmExo5.Size = new System.Drawing.Size(88, 13);
            this.lbl_Nombre_frmExo5.TabIndex = 1;
            this.lbl_Nombre_frmExo5.Text = "Nombre Aléatoire";
            this.lbl_Nombre_frmExo5.Click += new System.EventHandler(this.lbl_Nombre_frmExo5_Click);
            // 
            // textBox_Chrono_Exo5
            // 
            this.textBox_Chrono_Exo5.Location = new System.Drawing.Point(106, 23);
            this.textBox_Chrono_Exo5.Name = "textBox_Chrono_Exo5";
            this.textBox_Chrono_Exo5.Size = new System.Drawing.Size(136, 20);
            this.textBox_Chrono_Exo5.TabIndex = 2;
            // 
            // textBox_Nombre_Exo5
            // 
            this.textBox_Nombre_Exo5.Location = new System.Drawing.Point(106, 58);
            this.textBox_Nombre_Exo5.Name = "textBox_Nombre_Exo5";
            this.textBox_Nombre_Exo5.Size = new System.Drawing.Size(136, 20);
            this.textBox_Nombre_Exo5.TabIndex = 3;
            // 
            // frmExo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 98);
            this.Controls.Add(this.textBox_Nombre_Exo5);
            this.Controls.Add(this.textBox_Chrono_Exo5);
            this.Controls.Add(this.lbl_Nombre_frmExo5);
            this.Controls.Add(this.lbl_Chrono_frmExo5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExo5";
            this.Text = "frmExo5";
            this.Load += new System.EventHandler(this.frmExo5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Chrono_frmExo5;
        private System.Windows.Forms.Label lbl_Nombre_frmExo5;
        private System.Windows.Forms.TextBox textBox_Chrono_Exo5;
        private System.Windows.Forms.TextBox textBox_Nombre_Exo5;
    }
}