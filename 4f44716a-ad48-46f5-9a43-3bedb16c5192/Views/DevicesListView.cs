using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Views
{
    interface IDevicesListView
    {
        void ShowMessage(string message);
    }
    public partial class DevicesListView : Form, IDevicesListView
    {
        private readonly Presenters.DeviceListPresenter presenter;
        public DevicesListView()
        {
            this.presenter = new Presenters.DeviceListPresenter(this);
            InitializeComponent();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.AddDevice();
        }
    }
}
