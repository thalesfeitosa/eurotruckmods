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


namespace EutrotruckModsInstaller
{
    public partial class Mapas : Form
    {
        public Mapas()
        {
            InitializeComponent();
        }

          OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                textBox2.Text = ofd.SafeFileName;
            }

            

            if (!Directory.Exists(@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod"))
            {
                Directory.CreateDirectory(@"C:\Users\thale\Documents\Euro Truck Simulator 2\mod");

                string[] mod = 

                foreach (string item in mod)
                {
                    File.Copy(item, @"C:\Users\thale\Documents\Euro Truck Simulator 2\mod");
                }

            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
