using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form1 : Form
    {
        int type;
        PersonRegister pr;
        bool alive;
        public Form1()
        {
            InitializeComponent();
            pr = new PersonRegister();
            type = 0;
            alive = false;
        }

        private void btnAddObserver_Click(object sender, EventArgs e)
        {
            IObserverPush o;
            switch (type)
            {
                case 0:
                    o = new DayObserver(pr);
                    break;
                case 1:
                    o = new MonthObserver(pr);
                    break;
                case 2:
                    o = new YearObserver(pr);
                    break;
                case 3:
                    o = new HeightObserver(pr);
                    break;
            }
            UpdateUI();
        }

        private void btnBornKill_Click(object sender, EventArgs e)
        {
            alive = !alive;
            TimerAge.Enabled = !TimerAge.Enabled;
            pr.CreateKillPerson(alive);
            if (alive)
                btnBornKill.Text = "Kill Person";
            else
                btnBornKill.Text = "Create Person";
            UpdateUI();
        }

        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            type = 0;
        }
        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
        }
        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            type = 2;
        }
        private void rbHeight_CheckedChanged(object sender, EventArgs e)
        {
            type = 3;
        }


        private void TimerAge_Tick(object sender, EventArgs e)
        {
            pr.p.GrowUp();
            UpdateUI();
        }
        private void lbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pr.Detach(pr.observers[lbType.SelectedIndex]);
            }
            catch (Exception) { }
            finally
            {
                UpdateUI();
            }
        }

        private void lbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pr.Detach(pr.observers[lbValue.SelectedIndex]);
            }
            catch (Exception) { }
            finally
            {
                UpdateUI();
            }
        }

        private void lbExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pr.Detach(pr.observers[lbExtension.SelectedIndex]);
            }
            catch (Exception) { }
            finally
            {
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            pr.Notify();
            lbExtension.Items.Clear();
            lbType.Items.Clear();
            lbValue.Items.Clear();
            foreach (IObserverPush o in pr.observers)
            {
                if (o is DayObserver)
                {
                    lbType.Items.Add(o.GetType().Name);
                    lbValue.Items.Add(o.ToForm());
                    lbExtension.Items.Add("days");
                }
                if (o is MonthObserver)
                {
                    lbType.Items.Add(o.GetType().Name);
                    lbValue.Items.Add(o.ToForm());
                    lbExtension.Items.Add("months");
                }
                if (o is YearObserver)
                {
                    lbType.Items.Add(o.GetType().Name);
                    lbValue.Items.Add(o.ToForm());
                    lbExtension.Items.Add("years");
                }
                if (o is HeightObserver)
                {
                    lbType.Items.Add(o.GetType().Name);
                    lbValue.Items.Add(o.ToForm());
                    lbExtension.Items.Add("cm");
                }
            }
        }
    }
}
