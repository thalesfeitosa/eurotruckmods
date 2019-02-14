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
using System.Net;



namespace EutrotruckModsInstaller
{
    public partial class Mapas : Form
    {

        WebClient wc = new WebClient();

        public Mapas()
        {
            InitializeComponent();
        }

          OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                textBox2.Text = ofd.SafeFileName;
            }

            if (!Directory.Exists (@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod"))
            {
                Directory.CreateDirectory(@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod");
              
            }
            string arquivo1 = Path.GetFileName(ofd.FileName);

            FileInfo fi = new FileInfo(arquivo1);

            fi.CopyTo(@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod" + arquivo1);

            MessageBox.Show("Mod Mapas Instalado!!");
                        

        }

                  
                          
        

        

        private void Mapas_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
                        
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedDownloadComplete);
            Uri modmapas = new Uri(linkbox.Text);
            wc.DownloadFileAsync(modmapas, @"C:\Users\thale\Documents\Euro Truck Simulator 2\mod\Modmapas.rar",true); 
        }

        private void filedDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completo! Mod Mapas Instalado! :)"); 
        }


        //private void textBox2_TextChanged(object sender, EventArgs e)
        

        
    }
}
