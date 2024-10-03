using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace File_Operations
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string dosyaadi, dosyayolu;
		StreamWriter sw;  /*Akış Yazıcı(belgede baştan sona kadar inme okuma vs
						  StreamWriter C# dilinde bir sınıftır ve metin tabanlı
						  verileri dosyalara veya akışlara (streams) yazmak için
						  kullanılır. StreamWriter kullanarak bir dosyaya metin
						  yazabilir, dosya üzerinde satır ekleyebilir ya da
						  düzenlemeler yapabilirsiniz.*/
		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			dosyaadi = textBox2.Text;
			sw = File.CreateText(dosyayolu + "//" + dosyaadi + ".doc");//File.CreateText(): Yeni bir metin dosyası oluşturur
		
			//(eğer dosya varsa üzerine yazar).
			sw.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
			{
				dosyayolu = folderBrowserDialog2.SelectedPath.ToString();
				textBox1.Text = dosyayolu;
			}
		}
	}
}
