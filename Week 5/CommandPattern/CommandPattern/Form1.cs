using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class Form1 : Form
    {
        Cook cook;
        Waiter waiter;
        DeclineOrder decline;
        CookOrder cookorder;
        List<int> ingredients;
           

        public Form1()
        {
            InitializeComponent();

            cook = new Cook();
            waiter = new Waiter();
            decline = new DeclineOrder(cook);
            cookorder = new CookOrder(cook);
            ingredients = new List<int>(15);
            for (int i = 0; i < 15; i++) ingredients.Add(i);

        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< nudAppetizer.Value; i++)
            {  if (ingredients.Count > 0)
                {
                    
                    waiter.PlaceOrder(cookorder);
                    ingredients.RemoveAt(ingredients.Count - 1);
                    MessageBox.Show("Your order is placed");

                }
                else
                {
                    waiter.PlaceOrder(decline);
                    MessageBox.Show("Sorry, the order cannot be placed due to insufficient ingredients");
                    break;

                   
                } 
            }
            for (int i = 0; i < nudMain.Value; i++)
            {
                if (ingredients.Count > 0)
                {

                    waiter.PlaceOrder(cookorder);
                    ingredients.RemoveAt(ingredients.Count - 1);
                    MessageBox.Show("Your order is placed");

                }
                else
                {
                    waiter.PlaceOrder(decline);
                    MessageBox.Show("Sorry, the order cannot be placed due to insufficient ingredients");
                    break;


                }
            }
            for (int i = 0; i < nudDessert.Value; i++)
            {
                if (ingredients.Count > 0)
                {

                    waiter.PlaceOrder(cookorder);
                    ingredients.RemoveAt(ingredients.Count - 1);
                    MessageBox.Show("Your order is placed");

                }
                else
                {
                    waiter.PlaceOrder(decline);
                    MessageBox.Show("Sorry, the order cannot be placed due to insufficient ingredients");
                    break;


                }
            }

           
        }
    }
}
