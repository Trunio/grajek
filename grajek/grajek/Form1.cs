using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer grajek = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grajek.URL = "plecak.mp3";
            grajek.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grajek.controls.pause();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            grajek.controls.stop();
        }
    }
}
