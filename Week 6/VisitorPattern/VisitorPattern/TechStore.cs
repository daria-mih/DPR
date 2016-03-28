using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPattern
{
    public partial class TechStore : Form
    {
        double currentprice;
        Laptop laptop;
        Phone phone;
        Camera camera;
        IVisitor v;
        public TechStore()
        {
            InitializeComponent();
            currentprice = 0;
            //create objects with a certain price
            laptop = new Laptop(499.99);
            phone = new Phone(239.99);
            camera = new Camera(180.21);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (currentprice > 0)
            {
                //show price and reset form
                MessageBox.Show(
                    ("You have purchased:\n" +
                    nudLaptop.Value.ToString() + " Laptop(s)\n" +
                    nudPhone.Value.ToString() + " Phone(s)\n" +
                    nudCamera.Value.ToString() + " Camera(s)\n" +
                    "Total price: " + Math.Round(currentprice, 2).ToString()));
                rbStore.Checked = true;
                nudLaptop.Value = 0;
                nudPhone.Value = 0;
                nudCamera.Value = 0;
            }
        }
        /// <summary>
        /// Method that happens on all events (numeric change or radiobutton change)
        /// and then calculates the price by using some price logic
        /// </summary>
        private void SetVisitor(object sender, EventArgs e)
        {
            //set the visitor to local or online
            if (rbStore.Checked)
            {
                v = new LocalPurchase();
            }
            else
            {
                v = new OnlinePurchase();
            }
            //calculate the current price without discount rules
            currentprice = CalculatePrice();
            //check if custom discountrules apply, if not price is set
            //else price is calculated with discount
            if (currentprice >= 3000)
            {
                if (rbStore.Checked)
                    v = new LocalSalePurchase();
                else
                    v = new OnlineSalePurchase();
                currentprice =  CalculatePrice();
            }

            lblPrice.Text = Math.Round(currentprice, 2).ToString();
        }
        /// <summary>
        /// calculates the current price by using the current v
        /// </summary>
        private double CalculatePrice()
        {
            double  returnprice = 0;
            returnprice += (laptop.accept(v) * Convert.ToDouble(nudLaptop.Value));
            returnprice += (phone.accept(v) * Convert.ToDouble(nudPhone.Value));
            returnprice += (camera.accept(v) * Convert.ToDouble(nudCamera.Value));
            return returnprice;
        }
    }
}
