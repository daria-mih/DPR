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
    public partial class DeviceForm : Form
    {
        //Device the deviceform is connected to
        Device device;
        //Remoteform the deviceform is connected to
        RemoteForm rform;
        public DeviceForm(Device d, RemoteForm rform)
        {
            //connections
            this.rform = rform;
            device = d;
            //Formstuff for readability
            InitializeComponent();
            Text = device.GetType().Name;
            //More formstuff but device related
            UpdateForm();
        }
        /// <summary>
        /// Sets the form to the device's fields
        /// </summary>
        public void UpdateForm()
        {
            lblStatus.Text = "Status: " + device.status;
            lblVolume.Text = "Volume: " + device.volume;
        }
        /// <summary>
        /// Form close handler to dispose objects/forms it is connected to
        /// </summary>
        private void DeviceForm_ClosingHandler(object sender, FormClosingEventArgs e)
        {
            rform.Hide();
            rform.Dispose();
        }
    }
}
