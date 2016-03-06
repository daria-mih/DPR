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
    public partial class FormPhone : Form
    {
        IPhone phone;
        public FormPhone(IPhone p)
        {
            StartPosition = FormStartPosition.CenterScreen;            
            InitializeComponent();
            phone = p;
            pictureBox1.Image = p.ShowPictureLD();
            Show();
        }
        //empty constructor for initialisation of program
        public FormPhone()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
           phone.Call().Play();
            
        }
    }
}
