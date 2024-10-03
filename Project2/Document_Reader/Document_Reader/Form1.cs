using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_Reader
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				string satir = sr.ReadLine();
				while (satir != null)// satir değeri null değerden farklı olduğu müddetçe
				{
					listBox1.Items.Add(satir);
					satir = sr.ReadLine();

				}

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

			saveFileDialog1.Filter = "Yeni Metin Belgesi|*.txt";
			saveFileDialog1.Title = "Metin Belgesi Kayıt";
			saveFileDialog1.ShowDialog();
			StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
			sw.WriteLine(richTextBox1.Text);
			sw.Close();
			MessageBox.Show("Kayıt Oluşturuldu");
		}
	}
}
