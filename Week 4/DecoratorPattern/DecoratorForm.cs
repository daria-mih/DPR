using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class DecoratorForm : Form
    {
        IWattCalculator decorator;
        List<string> itemList;
        int switcher;

        public DecoratorForm(IWattCalculator d)
        {
            InitializeComponent();            
            switcher = 0;
            decorator = d;
            lblWatts.Text = d.Measure().ToString();
            FillForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (switcher)
            {
                case 0:
                    decorator = new Buzzer(decorator);
                    break;
                case 1:
                    decorator = new LED(decorator);
                    break;
                case 2:
                    decorator = new Resistor(decorator);
                    break;
                case 3:
                    decorator = new RGBLED(decorator);
                    break;
            }
            lblWatts.Text = decorator.Measure().ToString();
            lbItems.Items.Add(lbOptions.SelectedItem);
        }

        //FORM stuff      
        private void FillForm()
        {
            itemList = new List<string>();

            itemList.Add("Buzzer");
            itemList.Add("LED");
            itemList.Add("Resistor");
            itemList.Add("RGBLED");

            lbOptions.DataSource = itemList;
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switcher = lbOptions.SelectedIndex;
        }
    }
}
