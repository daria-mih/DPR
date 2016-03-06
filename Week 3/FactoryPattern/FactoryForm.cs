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
    public partial class FactoryForm : Form
    {
        int phone;
        int tablet;
        int phablet;
        FormPhone formphone;
        FormPhablet formphablet;
        FormTablet formtablet;
        AbstractFactory samsung, apple, nokia;
        public FactoryForm()
        {
            InitializeComponent();
            phone = 0;
            tablet = 0;
            phablet = 0;

            //create forms
            formphone = new FormPhone();
            formtablet = new FormTablet();
            formphablet = new FormPhablet();

            //create factories
            samsung = new SamsungFactory();
            apple = new AppleFactory();
            nokia = new NokiaFactory();
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            switch (phone)
            {
                case 0:
                    ProducePhone(nokia);
                    break;
                case 1:
                    ProducePhone(apple);
                    break;
                case 2:
                    ProducePhone(samsung);
                    break;
            }
        }

        private void btnTablet_Click(object sender, EventArgs e)
        {
            switch (tablet)
            {
                case 0:
                    ProduceTablet(nokia);
                    break;
                case 1:
                    ProduceTablet(apple);
                    break;
                case 2:
                    ProduceTablet(samsung);
                    break;
            }
        }

        private void btnPhablet_Click(object sender, EventArgs e)
        {
            switch (phablet)
            {
                case 0:
                    ProducePhablet(nokia);
                    break;
                case 1:
                    ProducePhablet(apple);
                    break;
                case 2:
                    ProducePhablet(samsung);
                    break;

            }
        }

        private void ProducePhone(AbstractFactory phonefactory)
        {
            formphone = new FormPhone(phonefactory.createPhone());
            formphone.Text = phonefactory.createPhone().GetType().Name;
        }

        private void ProduceTablet(AbstractFactory tabletfactory)
        {
            formtablet = new FormTablet(tabletfactory.createTablet());
            formtablet.Text = tabletfactory.createTablet().GetType().Name;
        }

        private void ProducePhablet(AbstractFactory phabletfactory)
        {
            formphablet = new FormPhablet(phabletfactory.createPhablet());
            formphablet.Text = phabletfactory.createPhablet().GetType().Name;
        }



        //radiobuttons
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
        private void rbNokiaTab_CheckedChanged(object sender, EventArgs e)
        {
            tablet = 0;
        }
        private void rbAppleTab_CheckedChanged(object sender, EventArgs e)
        {
            tablet = 1;
        }
        private void rbSamsungTab_CheckedChanged(object sender, EventArgs e)
        {
            tablet = 2;
        }
        private void rbNokiaPhab_CheckedChanged(object sender, EventArgs e)
        {
            phablet = 0;
        }
        private void rbApplePhab_CheckedChanged(object sender, EventArgs e)
        {
            phablet = 1;
        }
        private void rbSamsungPhab_CheckedChanged(object sender, EventArgs e)
        {
            phablet = 2;
        }
    }
}
