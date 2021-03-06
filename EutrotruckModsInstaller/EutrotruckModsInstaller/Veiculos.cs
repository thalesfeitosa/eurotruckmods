﻿using System;
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
    public partial class Veiculos : Form
    {

        WebClient wc = new WebClient();

        public Veiculos()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Text = ofd.FileName;
                textBox2.Text = ofd.SafeFileName;

                if (!Directory.Exists(@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod"))
                {
                    Directory.CreateDirectory(@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod");

                    string veiculo = Path.GetFileName(ofd.FileName);

                    FileInfo vei = new FileInfo(veiculo);

                    vei.CopyTo(@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod" + veiculo);

                    MessageBox.Show(" Mod Veiculo Instalado com Sucesso!! ");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedDownloadComplete);
            Uri modveiculos = new Uri(linkbox.Text);
            string fileName = Path.GetFileName(modveiculos.AbsolutePath);
            //wc.DownloadFileAsync(modveiculos, Application.StartupPath + "/" + fileName);
            wc.DownloadFileAsync(modveiculos, @"C:\Users\thale\Documents\Euro Truck Simulator 2\mod\Modveiculos.rar", true);
        }

            private void filedDownloadComplete(object sender, AsyncCompletedEventArgs e)
            {
                MessageBox.Show("Download Completo! Mod Veiculos Instalado! :)");
            }


        }
}
