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
    public partial class RemoteForm : Form
    {
        Device device;
        DeviceForm deviceForm;
        Command lastcommand = null;
        public RemoteForm(Device d)
        {
            //connect to device d
            device = d;
            //form stuff       
            (deviceForm = new DeviceForm(device, this)).Show();
            InitializeComponent();
        }

        //When button is pressed a new devicebutton is created
        //This device button has a Command assigned to it and is immediatly 'pressed'
        //lastcommand is assigned in the same line for the undo button

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (lastcommand != null)
            {
                new DeviceButton(lastcommand).pressUndo();
                deviceForm.UpdateForm();
            }
        }
        private void btnOff_Click(object sender, EventArgs e)
        {
            new DeviceButton((lastcommand = new Off(device))).press();
            deviceForm.UpdateForm();
        }
        private void btnOn_Click(object sender, EventArgs e)
        {
            new DeviceButton((lastcommand = new On(device))).press();
            deviceForm.UpdateForm();
        }
        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            new DeviceButton((lastcommand = new VolumeUp(device))).press();
            deviceForm.UpdateForm();
        }
        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            new DeviceButton((lastcommand = new VolumeDown(device))).press();
            deviceForm.UpdateForm();
        }
        /// <summary>
        /// Form close handler to dispose objects/forms it is connected to
        /// </summary>
        private void RemoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            deviceForm.Hide();
            deviceForm.Dispose();
        }
    }
}
