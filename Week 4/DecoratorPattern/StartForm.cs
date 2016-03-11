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
    public partial class StartForm : Form
    {
        DecoratorForm form;
        public StartForm()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnArduino_Click(object sender, EventArgs e)
        {
            form = new DecoratorForm(new ArduinoUno());
            form.Text = "Arduino Uno";
            form.Show();
        }

        private void btnBreadboard_Click(object sender, EventArgs e)
        {
            form = new DecoratorForm(new Breadboard());
            form.Text = "Breadboard";
            form.Show();
        }
    }
}
