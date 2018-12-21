using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3.Views
{
    interface IAddDeviceView
    {
        void SetDevices(IEnumerable<string> devices);
        string DeviceName { get; set; }
        bool PasswordIsSupported { get; set; }
        string Password { get; set; }
    }
    public partial class AddDeviceView : Form, IAddDeviceView
    {
        private readonly Presenters.AddDevicePresenter presenter;
        public AddDeviceView()
        {
            presenter = new Presenters.AddDevicePresenter(this);
            InitializeComponent();
            presenter.LoadDevices();
        }

        public bool PasswordIsSupported
        {
            get { return checkBox1.Checked; }
            set
            {
                textBox2.Enabled = value;
                checkBox1.Checked = value;
            }
        }
        public string Password
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string DeviceName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public void SetDevices(IEnumerable<string> devices)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(devices.ToArray());
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            presenter.LoadDevice(comboBox1.Text);
        }
    }
}
