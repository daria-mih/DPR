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
        private ThreadHandler th;
        private Random rnd;
        public int myNumber;
        public BindingList<int> threadList;
        public Form1()
        {
            threadList = new BindingList<int>();
            rnd = new Random();
            th = new ThreadHandler(new FCFS());

            InitializeComponent();

            FillList();

            lbThreads.DataSource = threadList;
        }

        private void rbScan_CheckedChanged(object sender, EventArgs e)
        {
            th = new ThreadHandler(new SCAN());
        }

        private void rbSeekTime_CheckedChanged(object sender, EventArgs e)
        {
            th = new ThreadHandler(new SSTF());
        }

        private void rbFirstCome_CheckedChanged(object sender, EventArgs e)
        {
            th = new ThreadHandler(new FCFS());
        }

        private void tNextProcess_Tick(object sender, EventArgs e)
        {
            if ((tbRun.Maximum - tbRun.Value) == th.PerformRun(threadList))
            {
                threadList.Remove(th.PerformRun(threadList));
                AddUniqueNumber();
            }
            else if ((tbRun.Maximum - tbRun.Value) < th.PerformRun(threadList))
            {
                tbRun.Value--;
            }
            else if ((tbRun.Maximum - tbRun.Value) > th.PerformRun(threadList))
            {
                tbRun.Value++;
            }
        }

        /// <summary>
        /// Adds a unique number to the list
        /// </summary>
        public void AddUniqueNumber()
        {
            do
            {
                myNumber = rnd.Next(1, 30);
            }
            while (threadList.Contains(myNumber));
            threadList.Add(myNumber);
        }


        /// <summary>
        /// Fill the processnr list
        /// </summary>
        public void FillList()
        {
            threadList.Clear();
            for (int i = 0; i < 18; i++)
            {
                AddUniqueNumber();
            }
        }

        private void tbRun_Scroll(object sender, EventArgs e)
        {

        }
    }
}
