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
    public partial class RemoteConsole : Form
    {
        public RemoteConsole()
        {
            InitializeComponent();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            new RemoteForm(new Television()).Show();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            new RemoteForm(new Radio()).Show();
        }


    }
}

