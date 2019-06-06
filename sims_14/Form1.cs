using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sims_13
{
    public partial class Form1 : Form
    {

        private int date = 0;

        private double currentTime = 0;

        private Manager manager;
        bool enable = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (enable)
            {
                StartButton.Text = "Start";
                timer1.Stop();
                enable = false;
            }
            else
            {
                StartButton.Text = "Stop";
                date = 0;
                currentTime = 0;
                this.manager = new Manager(Queue, Busy, Arrive, flowLayoutPanel1);
                timer1.Start();
                enable = true;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            manager.Update(date);
            date++;
            currentTime = (double)date / 10;
            Time.Text = "Time: " + currentTime;
           
        }

    }
}
