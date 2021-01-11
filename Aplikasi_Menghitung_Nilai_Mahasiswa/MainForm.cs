/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 03/05/2020
 * Time: 3:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aplikasi_Menghitung_Nilai_Mahasiswa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String matkul,nama,npm,nilaiHuruf,rerata;
		int tugas,uts,uas,ratarata;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void disableRadioButton(){
			radioButtonJarkom.Enabled=false;
			radioButtonProlan.Enabled=false;
			radioButtonMulmed.Enabled=false;
			radioButtonPba.Enabled=false;
			radioButtonProbab.Enabled=false;
			radioButtonEval.Enabled=false;
			radioButtonSKJ.Enabled=false;
		}
		void ButtonProsesClick(object sender, EventArgs e)
		{
			// menampilkan nama mata kuliah ketika memilih radio button
			if(radioButtonSKJ.Checked) {
				matkul="Sistem Kemanan Sistem dan Jaringan";
				disableRadioButton();
				radioButtonSKJ.Enabled=true;
			}
			if(radioButtonJarkom.Checked){
				matkul="Jaringan Komputer Lanjut";
				disableRadioButton();
				radioButtonJarkom.Enabled=true;
			}
			if(radioButtonProlan.Checked){
				matkul="Pemrograman Lanjut";
				disableRadioButton();
				radioButtonProlan.Enabled=true;
			}
			if(radioButtonMulmed.Checked){
				matkul="Multimedia";
				disableRadioButton();
				radioButtonMulmed.Enabled=true;
			}
			if(radioButtonPba.Checked){
				matkul="Penngembangan Bahan Ajar";
				disableRadioButton();
				radioButtonPba.Enabled=true;
			}
			if(radioButtonProbab.Checked){
				matkul="Probabilitas dan Statistik";
				disableRadioButton();
				radioButtonProbab.Enabled=true;
			}
			if(radioButtonEval.Checked){
				matkul="Evaluasi Pembe;ajaran";
				disableRadioButton();
				radioButtonEval.Enabled=true;
			}
			
			// input npm,nama,nilai tugas,uts dan uas
			npm=textBoxNpm.Text;
			nama=textBoxNama.Text;
			tugas=int.Parse(textBoxTugas.Text);
			uts=int.Parse(textBoxUTS.Text);
			uas=int.Parse(textBoxUAS.Text);
			
			// rumus menghitung nilai ratarata
			ratarata=(tugas+uts+uas)/3;
			rerata=ratarata+"";
			
			// menampilkan nilai ratarata di texbox
			textBoxRatarata.Text=ratarata+"";
			
			// menentukan nilai huruf berdasarkan nilai ratarata
			if(ratarata<=39) nilaiHuruf="E";
			else if(ratarata>39 && ratarata<=54) nilaiHuruf="D";
			else if(ratarata>54 && ratarata<=69) nilaiHuruf="C";
			else if(ratarata>69 && ratarata<=84) nilaiHuruf="B";
			else if(ratarata>84) nilaiHuruf="A";
			
			// menampilkan nilai di textbox nilai
			textBoxNilai.Text=nilaiHuruf;
			
			// menambahkan matkul di labelmatkul
			labelMatkul.Text+=" "+matkul;
			String data="1";
			foreach(object obj in data){
				listBox1.Items.Add(npm+" "+nama+" Nilai Angka = "+ratarata+" Nilai Huruf = "+nilaiHuruf);
			}
		}
		
		// button refres di form nilai
		void ButtonResfreshClick(object sender, EventArgs e)
		{
			textBoxNpm.Clear();
			textBoxNama.Clear();
			textBoxUTS.Clear();
			textBoxTugas.Clear();
			textBoxUAS.Clear();
			textBoxRatarata.Clear();
			textBoxNilai.Clear();
		}
		
		// button hapus item yang dipilih di listbox
		void Button1Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Data yang anda pilih akan dihapus,lanjutkan?","Warning",MessageBoxButtons.YesNo);
			if(result==DialogResult.Yes) listBox1.Items.Remove(listBox1.SelectedItem);
		}
		
		// button exit dari aplikasi
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		// button hapus semua textbox dan listbox
		void ButtonClearClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tindakan ini akan menghapus semua data tetap lanjutkan?","Warning",MessageBoxButtons.YesNo);
			if(result==DialogResult.Yes)listBox1.Items.Clear();
			tugas=0;uts=0;uas=0;ratarata=0;
			radioButtonJarkom.Enabled=true;
			radioButtonProlan.Enabled=true;
			radioButtonMulmed.Enabled=true;
			radioButtonPba.Enabled=true;
			radioButtonProbab.Enabled=true;
			radioButtonEval.Enabled=true;
			radioButtonSKJ.Enabled=true;
			textBoxNpm.Clear();
			textBoxNama.Clear();
			textBoxUTS.Clear();
			textBoxTugas.Clear();
			textBoxUAS.Clear();
			textBoxRatarata.Clear();
			textBoxNilai.Clear();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void RadioButton6CheckedChanged(object sender, EventArgs e)
		{
		
		}
	}
}
