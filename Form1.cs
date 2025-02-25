using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace Crypter
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Icon = new Icon("download.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            using (var OpenFileDialog = new OpenFileDialog())
            {
                OpenFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = OpenFileDialog.FileName;
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Crypter.Properties.Resources.music);
            audio.PlayLooping();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] keys = "1q@w2e$r4ty3uiop5a#sd6f7ghj8klz9xc0vbnm".ToCharArray();
            Random rnd = new Random();
            string randomString = "";
            for (int i = 0; i < 25; i++)
            {
                randomString += keys[rnd.Next(0, 35)].ToString();
            }
            textBox2.Text = randomString;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Crypter.Properties.Resources.music);
            audio.Stop();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Crypter.Properties.Resources.music);
            audio.PlayLooping();
        }
    }
}
