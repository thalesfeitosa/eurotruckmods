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

            //MessageBox.Show("Mod Mapas Instalado!!");
                        

        }

                  
                          
        

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Hide();
        }

        private void Mapas_Load(object sender, EventArgs e)
        {

        }
    }
}
