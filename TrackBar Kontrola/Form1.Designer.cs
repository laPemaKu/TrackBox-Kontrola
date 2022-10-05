namespace TrackBar_Kontrola
{
    partial class Form1
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
            this.trbBroj = new System.Windows.Forms.TrackBar();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // trbBroj
            // 
            this.trbBroj.Location = new System.Drawing.Point(26, 26);
            this.trbBroj.Maximum = 100;
            this.trbBroj.Name = "trbBroj";
            this.trbBroj.Size = new System.Drawing.Size(403, 45);
            this.trbBroj.TabIndex = 0;
            this.trbBroj.TickFrequency = 5;
            this.trbBroj.Scroll += new System.EventHandler(this.trbBroj_Scroll);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(153, 89);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(75, 20);
            this.txtIspis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Postavljena vrijednost je:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.trbBroj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbBroj;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Label label1;
    }
}

