using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sims_13
{
    public class Manager
    {
        private Queue<Customer> customers = new Queue<Customer>();
        private Label queueLabel, workersLabel, nextEventLabel;
        private int workersCount = 5, currentTime = 0;
        private List<Worker> workers = new List<Worker>();
        private double lambda = 1;
        private double a = 1, b = 4;
        private double timeArrival;
        private Random rnd = new Random();
        private bool flag = false;
        public Manager(Label queue, Label workers, Label nextEvent, FlowLayoutPanel panel)
        {
            queueLabel = queue;
            workersLabel = workers;
            nextEventLabel = nextEvent;

            for (int i = 0; i < workersCount; i++)
            {
                var w = new Worker(lambda,panel, i);
                this.workers.Add(w);
            }
            timeArrival = GetPPPDistribution();
        }

        public void Update(int date)
        {
            int busyWorkers = 0;
            currentTime++;
            if (flag)
            {
                timeArrival = currentTime + GetPPPDistribution();
                flag = false;
            }
            if (currentTime > timeArrival)
            {
                var customer = new Customer(currentTime);
                customers.Enqueue(customer);
                flag = true;
            }
            foreach (var worker in workers)
            {
                worker.Update(ref customers, ref busyWorkers);
            }

            queueLabel.Text = "Queue: " + customers.Count;
            workersLabel.Text = "Busy operators: " + busyWorkers;
            nextEventLabel.Text = "Next event: " + timeArrival/10;
        }



        private double GetPPPDistribution()
        {
            double t_tmp = currentTime;
            double local_lambda = a + b;
            double u;

            do
            {
                t_tmp += GetDistribution(local_lambda);
                u = rnd.NextDouble() * local_lambda;
            }
            while (Math.Abs(a * Math.Sin(t_tmp) + b) < u);

            return Math.Round(t_tmp - currentTime, 0);
        }
        private double GetDistribution(double lambda_current)
        {
            return -(Math.Log(rnd.NextDouble()) / lambda_current);
        }

    }
}
