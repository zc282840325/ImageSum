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

namespace ImageSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Bitmap> list = new List<Bitmap>() { (Bitmap)pictureBox1.Image, (Bitmap)pictureBox2.Image };
            string desk = AppDomain.CurrentDomain.BaseDirectory;
            string filename = desk+ DateTime.Now.ToString("yyyyMMddHHmmss")+".jpg";
            PictureStitching pic = new PictureStitching(list, filename);
            pictureBox4.Image = pic.SavePic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
