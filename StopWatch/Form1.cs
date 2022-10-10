using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        private Stopwatch watch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            watch = new Stopwatch();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            watch.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = String.Format("{0:mm\\:ss\\:ff}", watch.Elapsed);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            watch?.Stop();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            watch.Restart();
            LapLabel.Text = "";
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            LapLabel.Text += LabelTime.Text.Substring(0,8) + "\n";
        }

        private void ClearLapsButton_Click(object sender, EventArgs e)
        {
            LapLabel.Text = "";
        }
    }
}