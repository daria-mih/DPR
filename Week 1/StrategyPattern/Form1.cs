using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        int min = 0;
        int max = 250;
        private ProcessHandler th;
        private Random rnd;
        public int myNumber;
        public BindingList<int> processList;

        private int prevProcess;
        bool GoUp;
        bool stopped = true;
        public Form1()
        {
            processList = new BindingList<int>();
            rnd = new Random();
            th = new ProcessHandler(new FCFS());
            GoUp = true;

            InitializeComponent();
            prevProcess = (tbRun.Maximum - tbRun.Value);
            tbRun.Minimum = min;
            tbRun.Maximum = max;
            tbRun.Value = max;

            FillList();

            lbProcess.DataSource = processList;
        }
        private void rbFirstCome_CheckedChanged(object sender, EventArgs e)
        {
            th = new ProcessHandler(new FCFS());
        }
        private void rbSeekTime_CheckedChanged(object sender, EventArgs e)
        {
            prevProcess = (tbRun.Maximum - tbRun.Value);
            th = new ProcessHandler(new SSTF());
        }
        private void rbScan_CheckedChanged(object sender, EventArgs e)
        {
            th = new ProcessHandler(new SCAN(GoUp));
        }
        /// <summary>
        /// Ticks every set interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tNextProcess_Tick(object sender, EventArgs e)
        {
            if ((tbRun.Maximum - tbRun.Value) == th.PerformRun(prevProcess, processList))
            {
                processList.Remove(th.PerformRun(prevProcess, processList));
                prevProcess = (tbRun.Maximum - tbRun.Value);
                AddUniqueNumber();
            }
            else if ((tbRun.Maximum - tbRun.Value) < th.PerformRun(prevProcess, processList))
            {
                tbRun.Value--;
            }
            else if ((tbRun.Maximum - tbRun.Value) > th.PerformRun(prevProcess, processList))
            {
                tbRun.Value++;
            }
            lblNextProcess.Text = (th.PerformRun(prevProcess, processList)).ToString();
        }
    


    /// <summary>
    /// Adds a unique number to the list
    /// </summary>
    public void AddUniqueNumber()
    {
        do
        {
            myNumber = rnd.Next(min, max);
        }
        while (processList.Contains(myNumber) || myNumber == prevProcess);
        processList.Add(myNumber);
    }


    /// <summary>
    /// Fill the processnr list
    /// </summary>
    public void FillList()
    {
        processList.Clear();
        for (int i = 0; i < 18; i++)
        {
            AddUniqueNumber();
        }
    }

    private void btnStartStop_Click(object sender, EventArgs e)
    {
        if (!stopped)
        {
            stopped = !stopped;
            timNextProcess.Stop();
            btnStartStop.Text = "Start";
        }
        else
        {
            stopped = !stopped;
            timNextProcess.Start();
            btnStartStop.Text = "Stop";
        }
    }
}
}
