/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 03/05/2020
 * Time: 3:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Aplikasi_Menghitung_Nilai_Mahasiswa
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelMatkul;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNpm;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonProbab;
		private System.Windows.Forms.RadioButton radioButtonPba;
		private System.Windows.Forms.RadioButton radioButtonMulmed;
		private System.Windows.Forms.RadioButton radioButtonProlan;
		private System.Windows.Forms.RadioButton radioButtonJarkom;
		private System.Windows.Forms.RadioButton radioButtonSKJ;
		private System.Windows.Forms.RadioButton radioButtonEval;
		private System.Windows.Forms.TextBox textBoxTugas;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxUTS;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxUAS;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonProses;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TextBox textBoxRatarata;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxNilai;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button buttonResfresh;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNpm = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonEval = new System.Windows.Forms.RadioButton();
			this.radioButtonProbab = new System.Windows.Forms.RadioButton();
			this.radioButtonPba = new System.Windows.Forms.RadioButton();
			this.radioButtonMulmed = new System.Windows.Forms.RadioButton();
			this.radioButtonProlan = new System.Windows.Forms.RadioButton();
			this.radioButtonJarkom = new System.Windows.Forms.RadioButton();
			this.radioButtonSKJ = new System.Windows.Forms.RadioButton();
			this.textBoxTugas = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxUTS = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxUAS = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonProses = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.textBoxRatarata = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxNilai = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonResfresh = new System.Windows.Forms.Button();
			this.labelMatkul = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NAMA";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "NPM";
			// 
			// textBoxNpm
			// 
			this.textBoxNpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNpm.Location = new System.Drawing.Point(74, 29);
			this.textBoxNpm.Name = "textBoxNpm";
			this.textBoxNpm.Size = new System.Drawing.Size(172, 20);
			this.textBoxNpm.TabIndex = 3;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNama.Location = new System.Drawing.Point(74, 55);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(172, 20);
			this.textBoxNama.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonEval);
			this.groupBox1.Controls.Add(this.radioButtonProbab);
			this.groupBox1.Controls.Add(this.radioButtonPba);
			this.groupBox1.Controls.Add(this.radioButtonMulmed);
			this.groupBox1.Controls.Add(this.radioButtonProlan);
			this.groupBox1.Controls.Add(this.radioButtonJarkom);
			this.groupBox1.Controls.Add(this.radioButtonSKJ);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(275, 269);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MATA KULIAH";
			// 
			// radioButtonEval
			// 
			this.radioButtonEval.Location = new System.Drawing.Point(7, 212);
			this.radioButtonEval.Name = "radioButtonEval";
			this.radioButtonEval.Size = new System.Drawing.Size(262, 24);
			this.radioButtonEval.TabIndex = 6;
			this.radioButtonEval.TabStop = true;
			this.radioButtonEval.Text = "Evaluasi Pembelajaran";
			this.radioButtonEval.UseVisualStyleBackColor = true;
			// 
			// radioButtonProbab
			// 
			this.radioButtonProbab.Location = new System.Drawing.Point(7, 181);
			this.radioButtonProbab.Name = "radioButtonProbab";
			this.radioButtonProbab.Size = new System.Drawing.Size(262, 24);
			this.radioButtonProbab.TabIndex = 5;
			this.radioButtonProbab.TabStop = true;
			this.radioButtonProbab.Text = "Probabilitas dan Statistik";
			this.radioButtonProbab.UseVisualStyleBackColor = true;
			this.radioButtonProbab.CheckedChanged += new System.EventHandler(this.RadioButton6CheckedChanged);
			// 
			// radioButtonPba
			// 
			this.radioButtonPba.Location = new System.Drawing.Point(7, 150);
			this.radioButtonPba.Name = "radioButtonPba";
			this.radioButtonPba.Size = new System.Drawing.Size(262, 24);
			this.radioButtonPba.TabIndex = 4;
			this.radioButtonPba.TabStop = true;
			this.radioButtonPba.Text = "Pengembangan Bahan Ajar";
			this.radioButtonPba.UseVisualStyleBackColor = true;
			// 
			// radioButtonMulmed
			// 
			this.radioButtonMulmed.Location = new System.Drawing.Point(6, 120);
			this.radioButtonMulmed.Name = "radioButtonMulmed";
			this.radioButtonMulmed.Size = new System.Drawing.Size(262, 24);
			this.radioButtonMulmed.TabIndex = 3;
			this.radioButtonMulmed.TabStop = true;
			this.radioButtonMulmed.Text = "Multimedia";
			this.radioButtonMulmed.UseVisualStyleBackColor = true;
			// 
			// radioButtonProlan
			// 
			this.radioButtonProlan.Location = new System.Drawing.Point(7, 90);
			this.radioButtonProlan.Name = "radioButtonProlan";
			this.radioButtonProlan.Size = new System.Drawing.Size(262, 24);
			this.radioButtonProlan.TabIndex = 2;
			this.radioButtonProlan.TabStop = true;
			this.radioButtonProlan.Text = "Pemrograman Lanjut";
			this.radioButtonProlan.UseVisualStyleBackColor = true;
			// 
			// radioButtonJarkom
			// 
			this.radioButtonJarkom.Location = new System.Drawing.Point(6, 60);
			this.radioButtonJarkom.Name = "radioButtonJarkom";
			this.radioButtonJarkom.Size = new System.Drawing.Size(262, 24);
			this.radioButtonJarkom.TabIndex = 1;
			this.radioButtonJarkom.TabStop = true;
			this.radioButtonJarkom.Text = "Jaringan Komputer Lanjut";
			this.radioButtonJarkom.UseVisualStyleBackColor = true;
			// 
			// radioButtonSKJ
			// 
			this.radioButtonSKJ.Location = new System.Drawing.Point(6, 30);
			this.radioButtonSKJ.Name = "radioButtonSKJ";
			this.radioButtonSKJ.Size = new System.Drawing.Size(262, 24);
			this.radioButtonSKJ.TabIndex = 0;
			this.radioButtonSKJ.TabStop = true;
			this.radioButtonSKJ.Text = "Keamanan Sitem dan Jaringan Komputer";
			this.radioButtonSKJ.UseVisualStyleBackColor = true;
			// 
			// textBoxTugas
			// 
			this.textBoxTugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTugas.Location = new System.Drawing.Point(74, 82);
			this.textBoxTugas.Name = "textBoxTugas";
			this.textBoxTugas.Size = new System.Drawing.Size(41, 20);
			this.textBoxTugas.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(5, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "TUGAS";
			// 
			// textBoxUTS
			// 
			this.textBoxUTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUTS.Location = new System.Drawing.Point(74, 111);
			this.textBoxUTS.Name = "textBoxUTS";
			this.textBoxUTS.Size = new System.Drawing.Size(41, 20);
			this.textBoxUTS.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "UTS";
			// 
			// textBoxUAS
			// 
			this.textBoxUAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUAS.Location = new System.Drawing.Point(74, 137);
			this.textBoxUAS.Name = "textBoxUAS";
			this.textBoxUAS.Size = new System.Drawing.Size(41, 20);
			this.textBoxUAS.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(10, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "UAS";
			// 
			// buttonProses
			// 
			this.buttonProses.BackColor = System.Drawing.Color.GreenYellow;
			this.buttonProses.Location = new System.Drawing.Point(136, 86);
			this.buttonProses.Name = "buttonProses";
			this.buttonProses.Size = new System.Drawing.Size(75, 32);
			this.buttonProses.TabIndex = 12;
			this.buttonProses.Text = "PROSES";
			this.buttonProses.UseVisualStyleBackColor = false;
			this.buttonProses.Click += new System.EventHandler(this.ButtonProsesClick);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(633, 49);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(367, 199);
			this.listBox1.TabIndex = 13;
			// 
			// buttonClear
			// 
			this.buttonClear.BackColor = System.Drawing.Color.OrangeRed;
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClear.Location = new System.Drawing.Point(767, 257);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(98, 35);
			this.buttonClear.TabIndex = 14;
			this.buttonClear.Text = "CLEAR ALL";
			this.buttonClear.UseVisualStyleBackColor = false;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// textBoxRatarata
			// 
			this.textBoxRatarata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRatarata.Location = new System.Drawing.Point(18, 231);
			this.textBoxRatarata.Name = "textBoxRatarata";
			this.textBoxRatarata.Size = new System.Drawing.Size(41, 20);
			this.textBoxRatarata.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(10, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Nilai Angka";
			// 
			// textBoxNilai
			// 
			this.textBoxNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNilai.Location = new System.Drawing.Point(136, 234);
			this.textBoxNilai.Name = "textBoxNilai";
			this.textBoxNilai.Size = new System.Drawing.Size(41, 20);
			this.textBoxNilai.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(119, 205);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "Nilai Huruf";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.buttonResfresh);
			this.groupBox2.Controls.Add(this.textBoxNilai);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.buttonProses);
			this.groupBox2.Controls.Add(this.textBoxUAS);
			this.groupBox2.Controls.Add(this.textBoxNama);
			this.groupBox2.Controls.Add(this.textBoxRatarata);
			this.groupBox2.Controls.Add(this.textBoxNpm);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBoxUTS);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxTugas);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(335, 21);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(271, 269);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "FORM NILAI";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(13, 175);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "HASIL";
			// 
			// buttonResfresh
			// 
			this.buttonResfresh.BackColor = System.Drawing.Color.Gold;
			this.buttonResfresh.Location = new System.Drawing.Point(136, 127);
			this.buttonResfresh.Name = "buttonResfresh";
			this.buttonResfresh.Size = new System.Drawing.Size(75, 34);
			this.buttonResfresh.TabIndex = 13;
			this.buttonResfresh.Text = "REFRESH";
			this.buttonResfresh.UseVisualStyleBackColor = false;
			this.buttonResfresh.Click += new System.EventHandler(this.ButtonResfreshClick);
			// 
			// labelMatkul
			// 
			this.labelMatkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMatkul.Location = new System.Drawing.Point(633, 21);
			this.labelMatkul.Name = "labelMatkul";
			this.labelMatkul.Size = new System.Drawing.Size(367, 23);
			this.labelMatkul.TabIndex = 20;
			this.labelMatkul.Text = "Daftar Nilai";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkOrange;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(633, 257);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 33);
			this.button1.TabIndex = 21;
			this.button1.Text = "DELETE ITEM";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(902, 259);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 33);
			this.button2.TabIndex = 22;
			this.button2.Text = "EXIT";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1030, 316);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelMatkul);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "APLIKASI REKAP NILAI";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
