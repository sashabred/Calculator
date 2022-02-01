using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace Calculator
{
 

    public class Calc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btn_sbros;
		private System.Windows.Forms.Button btnChangesign;
		private System.Windows.Forms.Button btnpoint;
		private System.Windows.Forms.Button btn_ravno;
		private System.Windows.Forms.Button btn_delenie;
		private System.Windows.Forms.Button btn_umnojenie;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
        private IContainer components;

        /// <summary>
        /// Объявляем и инициализируем переменные, которые будут
        ///  возникать на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string odin = "1";
		private const string dva = "2";
		private const string tri = "3";
		private const string chetire = "4";
		private const string pyat = "5";
		private const string shest = "6";
		private const string sem = "7";
		private const string vosem = "8";
		private const string devyat = "9";
        private ContextMenuStrip contextMenuStrip1;
        protected MenuStrip menuStrip1;
        protected ToolStripMenuItem baseMenuStrip;
        protected ToolStripMenuItem standartFormToolStripMenuItem;
        private const string nul = "0";

		public Calc()
		{
			InitializeComponent();
			// При запуске приложения на экране будет нуль
			txtOutput.Text = "0";
			Cursor = Cursors.Hand;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.standartFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(12, 38);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(252, 30);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            this.txtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutput_KeyPress);
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.BackColor = System.Drawing.Color.Tomato;
            this.btn_sbros.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn_sbros.Location = new System.Drawing.Point(216, 74);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(48, 92);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.btn_sbros.UseVisualStyleBackColor = false;
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangesign.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btnChangesign.Location = new System.Drawing.Point(60, 213);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(48, 46);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.UseVisualStyleBackColor = false;
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnpoint.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btnpoint.Location = new System.Drawing.Point(108, 213);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(48, 46);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_ravno.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn_ravno.Location = new System.Drawing.Point(216, 166);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(48, 93);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.btn_ravno.UseVisualStyleBackColor = false;
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_delenie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delenie.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn_delenie.Location = new System.Drawing.Point(162, 74);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(48, 46);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.btn_delenie.UseVisualStyleBackColor = false;
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_umnojenie.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn_umnojenie.Location = new System.Drawing.Point(162, 120);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(48, 46);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.btn_umnojenie.UseVisualStyleBackColor = false;
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.BackColor = System.Drawing.Color.Salmon;
            this.btn_plus.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn_plus.Location = new System.Drawing.Point(162, 213);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(48, 46);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.BackColor = System.Drawing.Color.Salmon;
            this.btn_minus.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn_minus.Location = new System.Drawing.Point(162, 166);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(48, 47);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn0.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn0.Location = new System.Drawing.Point(12, 213);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 46);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn9.Location = new System.Drawing.Point(108, 74);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 46);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn8.Location = new System.Drawing.Point(60, 74);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 46);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn7.Location = new System.Drawing.Point(12, 74);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 46);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn6.Location = new System.Drawing.Point(108, 120);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 46);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn5.Location = new System.Drawing.Point(60, 120);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 46);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn4.Location = new System.Drawing.Point(12, 120);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 46);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn3.Location = new System.Drawing.Point(108, 166);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 47);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn2.Location = new System.Drawing.Point(60, 166);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 47);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Font = new System.Drawing.Font("Reem Kufi", 7.8F);
            this.btn1.Location = new System.Drawing.Point(12, 166);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 47);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseMenuStrip,
            this.standartFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 28);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseMenuStrip
            // 
            this.baseMenuStrip.Name = "baseMenuStrip";
            this.baseMenuStrip.Size = new System.Drawing.Size(115, 24);
            this.baseMenuStrip.Text = "EngineerForm";
            this.baseMenuStrip.Click += new System.EventHandler(this.engineerFormToolStripMenuItem_Click);
            // 
            // standartFormToolStripMenuItem
            // 
            this.standartFormToolStripMenuItem.Name = "standartFormToolStripMenuItem";
            this.standartFormToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.standartFormToolStripMenuItem.Text = "Standart Form";
            this.standartFormToolStripMenuItem.Visible = false;
            this.standartFormToolStripMenuItem.Click += new System.EventHandler(this.standartFormToolStripMenuItem_Click);
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(278, 274);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор 1.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Calc());

        }
        /// <summary>
        /// Обработчики для кнопок  обращаются к методу chislonaEkrane класса mehanizmcalkulyatora
        /// и передают ему одну из постоянных (odin, dva, tri  и т.д.). Результат, возвращаемый методом,
        /// присваивается  свойству Text текстового поля txtOutput.
        /// </summary>

        private void btn1_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (odin);
			}

			private void btn2_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (dva);
			}

			private void btn3_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (tri);
			}

			private void btn4_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (chetire);
			}

			private void btn5_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (pyat);
			}

			private void btn6_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (shest);
			}

			private void btn7_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (sem);
			}

			private void btn8_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (vosem);
			}

			private void btn9_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (devyat);
			}

			private void btn0_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (nul);
			}

			private void btnChangesign_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
			}

			private void btnpoint_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
			}
			/// <summary>
			/// Обработчики кнопок действия калькулятора передают 
			/// методу DeystvieCalculatora класса mehanizmcalkulyatora переменную перечисления Deystvie.
			/// </summary>
		
			private void btn_delenie_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Delenie);
			}

			private void btn_umnojenie_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Umnojenie);
			}

			private void btn_minus_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Vichitanie);
			}

			private void btn_plus_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Slojenie);
			}

			private void btn_ravno_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
				mehanizmcalkulyatora.Sbros();
			}

			private void btn_sbros_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.Sbros();
				txtOutput.Text = "0";
				
			}

        private void Calc_Load(object sender, EventArgs e)
        {
            
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {

			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Поле может содержать только цифры");
			}
		}

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void engineerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {                   
            var th = new Thread(() => Application.Run(new Form2()));
            th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
            th.Start();

            this.Close();
        }

        private void standartFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new Calc()));
            th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
            th.Start();

            this.Close();
        }
    }
    class mehanizmcalkulyatora
	{
	/// <summary>
	///Создаем перечисление Deystvie, для определения одного из четырех действия калькулятора.
	/// </summary>
		public enum Deystvie:int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
            Square =5,
            Pow = 6,
            Sqrt=7,
            X2 = 8,
            Recnum = 9
		}

	/// <summary>
	/// Объявляем и инициализируем переменную, 
	/// которая будет использоваться для смены знака при нажатии клавиши (+/-)
	/// </summary>

		private static double peremennayaMinus = -1;

		/// <summary>
		/// Объвляем переменные, для работы калькулятора:
		/// resultatVichisleniy - переменная для хранения
		///  промежуточного результата в механизме калькулятора
		///  resultatOutput - переменная, значение которой будет сниматься с экрана и  выводиться на него.
		///  tekusheeDeystvieCalculatora - хранение одного из действия калькулятора.
		///  pervoeChislo - переменная, в которую будет записываться число на экране
		///   до нажатия на одну из четырех кнопок с действием.
		///  vtoroeChislo - второе число на экране.
		///  dobavlenierazryada при добавлении следующего  разряда эта переменная примет значение true;
		///  ChislosTochkoy при добавлении десятичного разряда (знака точки) эта переменная примет значение true
		/// </summary>
	
		private static double resultatVichisleniy;
		private static string resultatOutput;
		private static Deystvie tekusheeDeystvieCalculatora;
		private static double pervoeChislo;
		private static double vtoroeChislo;
		private static bool dobavlenierazryada;
		private static bool ChislosTochkoy;
 
		/// <summary>
		/// В конструкторе класса mehanizmcalkulyatora инициализируем переменные 
		/// ChislosTochkoy и dobavlenierazryada - при запуске калькулятора на экране 
		/// нет ни разрядности, ни десятичной части.
		/// </summary>

		public mehanizmcalkulyatora ()
		{
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}

			
		/// <summary>
		/// В этом методе переменная resultatOutput изменяется - при вводе числа ее значение перезаписывается.
		/// </summary>
		

		public static string chislonaEkrane (string najatayaKlavisha)
		{
			resultatOutput = resultatOutput + najatayaKlavisha;
			return (resultatOutput);
		}
		/// <summary>
		/// Метод, в котором определяется peremenDeystviya - одно значение перечисления Deystvie,
		///в зависимости от выбора  клавиши +, -, *,  или /
		/// </summary>
	
		public static void DeystvieCalculatora (Deystvie peremenDeystviya)
		{
			try
			{
				if (resultatOutput != "" && !dobavlenierazryada)
				{
					pervoeChislo = System.Convert.ToDouble (resultatOutput);
					tekusheeDeystvieCalculatora = peremenDeystviya;
					resultatOutput = "";
					ChislosTochkoy = false;

				}			
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
			
			}
		}



	/// <summary>
	/// При нажатии  кнопки +/- число на экране - tekusheeChislo умножается на -1,
	///  а затем результат снова присваивается переменной resultatOutput.
	/// </summary>
	

		public static string ZnakChisla ()
		{
			double tekusheeChislo;

			if (resultatOutput != "")
			{
				tekusheeChislo = System.Convert.ToDouble (resultatOutput);
				resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
			}
		
			return (resultatOutput);
		}

		/// <summary>
		/// При нажатии кнопки ( , ) переменная resultatOutput приобретает дробную часть.
		/// </summary>
	

		public static string ZnakTochki ()
		{
			if (!ChislosTochkoy && !dobavlenierazryada)
			{
				if (resultatOutput != "")
					resultatOutput = resultatOutput + ",";
				else
					resultatOutput = "0,";

				ChislosTochkoy = true;
			}

			return (resultatOutput);
		}

	/// <summary>
	/// При нажатии кнопки ZnakRavno обрабатываются значения 
	/// переменнных pervoeChislo и vtoroeChislo, результат присваивается переменной resultatVichisleniy 
	/// которая  затем преобразуется в resultatOutput.
	/// </summary>


		public static string ZnakRavno ()
		{
			bool proverkaOshibok = false;

			if (resultatOutput != "")
			{
				vtoroeChislo = System.Convert.ToDouble (resultatOutput);
				dobavlenierazryada = true;

				switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
						resultatVichisleniy = pervoeChislo + vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						resultatVichisleniy = pervoeChislo - vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
						resultatVichisleniy = pervoeChislo * vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
						resultatVichisleniy = pervoeChislo / vtoroeChislo;
						proverkaOshibok = true;
						break;
                    case Deystvie.Pow:
                        resultatVichisleniy = Math.Pow(pervoeChislo, vtoroeChislo);
                        proverkaOshibok = true;
                        break;

                    case Deystvie.Sqrt:
                        resultatVichisleniy = Math.Sqrt(pervoeChislo);
                        proverkaOshibok = true;
                        break;

					default:
						proverkaOshibok = false;
						break;
				}

				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString (resultatVichisleniy);
			}
            else if (resultatOutput == "")
                {
                   
                    switch (tekusheeDeystvieCalculatora)
                    {
                        case Deystvie.Sqrt:
                            resultatVichisleniy = Math.Sqrt(pervoeChislo);
                            proverkaOshibok = true;
                            break;

                    case Deystvie.X2:
                        resultatVichisleniy = pervoeChislo*pervoeChislo;
                        proverkaOshibok = true;
                        break;
                    case Deystvie.Recnum:
                        resultatVichisleniy = 1/pervoeChislo;
                        proverkaOshibok = true;
                        break;

                    default:
                            proverkaOshibok = false;
                            break;
                    }

                    if (proverkaOshibok)
                        resultatOutput = System.Convert.ToString(resultatVichisleniy);
                }


            return resultatOutput;
		}

	/// <summary>
	/// При нажатии кнопки  С (сброс) значения переменных обнуляются.
	/// </summary>

		public static void Sbros ()
		{
			resultatVichisleniy = 0;
			pervoeChislo = 0;
			vtoroeChislo = 0;
			resultatOutput = "";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			ChislosTochkoy = false;
			dobavlenierazryada = false;			
		}
	}
}
