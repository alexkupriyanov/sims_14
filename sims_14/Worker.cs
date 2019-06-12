using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sims_13
{
    public class Worker
    {
        private bool isWork;
        private Random rnd = new Random();
        private int currentTime, timeDuration = 0;
        private double lambda;
        private Label label;
        private int num;
        public Worker(double l, FlowLayoutPanel panel, int num)
        {
            this.num = num;
            this.label = new Label
            {
                Text = $"Worker {this.num + 1} is free",
                Width = 70,
                Height = 70,
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(label);
            this.isWork = false;
            this.currentTime = 0;
            this.timeDuration = 0;
            this.lambda = l * 1.3;
        }

        public void StartWork()
        {
            this.isWork = true;
            this.currentTime = 0;
            this.timeDuration = (int) (GetDistribution(lambda) * 10);
        }

        public void Update(ref Queue<Customer> customers, ref int busyWorkers)
        {
            if (this.isWork)
            {
                this.currentTime++;
                if (this.currentTime - this.timeDuration > 0)
                {
                    this.isWork = false;
                    label.Text = $"Worker {this.num + 1} is free";
                }
                else
                {
                    label.Text = $"Worker {this.num + 1} is busy for {Math.Abs((double)(this.currentTime - this.timeDuration) / 10)} second";
                }

                busyWorkers++;
            }
            else
            {
                if (customers.Count > 0)
                {
                    customers.Dequeue();
                    StartWork();
                }
            }
        }

        private double GetDistribution(double lambda)
        {
            return -(Math.Log(rnd.NextDouble()) / lambda);
        }

    }
}
