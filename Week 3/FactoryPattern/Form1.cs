using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class FormFactory : Form
    {
        int phone;
        int tablet;
        int phablet;
        FormPhone formphone = new FormPhone();
        public FormFactory()
        {
            InitializeComponent();
            phone = 0;
            tablet = 0;
            phablet = 0;
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            AbstractFactory phonefactory;
            formphone.Dispose();
            switch (phone)
            {
                case 0:
                    phonefactory = new NokiaFactory();
                    formphone = new FormPhone(phonefactory.createPhone());
                    break;
                case 1:
                    phonefactory = new AppleFactory();
                    formphone = new FormPhone(phonefactory.createPhone());
                    break;
                case 2:
                    phonefactory = new SamsungFactory();
                    formphone = new FormPhone(phonefactory.createPhone());
                    break;
            }
        }

        private void btnTablet_Click(object sender, EventArgs e)
        {

        }

        private void btnPhablet_Click(object sender, EventArgs e)
        {

        }

        private void rbNokiaPhone_CheckedChanged(object sender, EventArgs e)
        {
            phone = 0;
        }

        private void rbApplePhone_CheckedChanged(object sender, EventArgs e)
        {
            phone = 1;
        }

        private void rbSamsungPhone_CheckedChanged(object sender, EventArgs e)
        {
            phone = 2;
        }
    }
}
