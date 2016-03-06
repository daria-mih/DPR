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
    public partial class FormPhablet : Form
    {
        IPhablet phablet;
        public FormPhablet(IPhablet ph)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            phablet = ph;
            pictureBox1.Image = ph.ShowPictureSD();
            Show();
        }

        public FormPhablet()
        {

        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            phablet.Call().Play();
        }
    }
}
