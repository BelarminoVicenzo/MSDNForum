using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Presenters
{
    class DeviceListPresenter
    {
        private readonly Views.IDevicesListView view;
        public DeviceListPresenter(Views.IDevicesListView view)
        {
            this.view = view;
        }
        public void AddDevice()
        {
            Views.AddDeviceView addDeviceForm = new Views.AddDeviceView();
            if(addDeviceForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                view.ShowMessage("Add device complete");
            }
        }
    }
}
