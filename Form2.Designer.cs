
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
            this.SuspendLayout();
            // 
            // but_pow
            // 
            this.but_pow.BackColor = System.Drawing.Color.PowderBlue;
            this.but_pow.Location = new System.Drawing.Point(289, 86);
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
            this.but_sqrt.Location = new System.Drawing.Point(289, 139);
            this.but_sqrt.Name = "but_sqrt";
            this.but_sqrt.Size = new System.Drawing.Size(48, 33);
            this.but_sqrt.TabIndex = 63;
            this.but_sqrt.Text = "sqrt";
            this.but_sqrt.UseVisualStyleBackColor = true;
            this.but_sqrt.Click += new System.EventHandler(this.but_sqrt_Click_1);
            
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(352, 304);
            this.Controls.Add(this.but_sqrt);
            this.Controls.Add(this.but_pow);
            this.Name = "Form2";
            this.Controls.SetChildIndex(this.but_pow, 0);
            this.Controls.SetChildIndex(this.but_sqrt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion

        private System.Windows.Forms.Button but_pow;
        private System.Windows.Forms.Button but_sqrt;
    }
}
