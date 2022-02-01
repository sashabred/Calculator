
namespace Calculator
{
    partial class Form2
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
            this.but_pow = new System.Windows.Forms.Button();
            this.but_sqrt = new System.Windows.Forms.Button();
            this.but_x2 = new System.Windows.Forms.Button();
            this.butt_recnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_pow
            // 
            this.but_pow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_pow.Location = new System.Drawing.Point(270, 74);
            this.but_pow.Name = "but_pow";
            this.but_pow.Size = new System.Drawing.Size(48, 46);
            this.but_pow.TabIndex = 62;
            this.but_pow.Text = "x^y";
            this.but_pow.UseVisualStyleBackColor = false;
            this.but_pow.Click += new System.EventHandler(this.but_pow_Click);
            // 
            // but_sqrt
            // 
            this.but_sqrt.AccessibleName = "sqrt";
            this.but_sqrt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_sqrt.Location = new System.Drawing.Point(270, 120);
            this.but_sqrt.Name = "but_sqrt";
            this.but_sqrt.Size = new System.Drawing.Size(48, 46);
            this.but_sqrt.TabIndex = 63;
            this.but_sqrt.Text = "√";
            this.but_sqrt.UseVisualStyleBackColor = false;
            this.but_sqrt.Click += new System.EventHandler(this.but_sqrt_Click_1);
            // 
            // but_x2
            // 
            this.but_x2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_x2.Location = new System.Drawing.Point(270, 166);
            this.but_x2.Name = "but_x2";
            this.but_x2.Size = new System.Drawing.Size(48, 46);
            this.but_x2.TabIndex = 64;
            this.but_x2.Text = "X^2";
            this.but_x2.UseVisualStyleBackColor = false;
            this.but_x2.Click += new System.EventHandler(this.button1_Click);
            // 
            // butt_recnum
            // 
            this.butt_recnum.BackColor = System.Drawing.Color.LightSkyBlue;
            this.butt_recnum.Location = new System.Drawing.Point(270, 213);
            this.butt_recnum.Name = "butt_recnum";
            this.butt_recnum.Size = new System.Drawing.Size(48, 46);
            this.butt_recnum.TabIndex = 65;
            this.butt_recnum.Text = "1/x";
            this.butt_recnum.UseVisualStyleBackColor = false;
            this.butt_recnum.Click += new System.EventHandler(this.butt_recnum_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(342, 283);
            this.Controls.Add(this.butt_recnum);
            this.Controls.Add(this.but_x2);
            this.Controls.Add(this.but_sqrt);
            this.Controls.Add(this.but_pow);
            this.Name = "Form2";
            this.Controls.SetChildIndex(this.but_pow, 0);
            this.Controls.SetChildIndex(this.but_sqrt, 0);
            this.Controls.SetChildIndex(this.but_x2, 0);
            this.Controls.SetChildIndex(this.butt_recnum, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_pow;
        private System.Windows.Forms.Button but_sqrt;
        private System.Windows.Forms.Button but_x2;
        private System.Windows.Forms.Button butt_recnum;
    }
}
