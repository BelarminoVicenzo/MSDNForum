using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Views;

namespace WindowsFormsApp3.Presenters
{
    class AddDevicePresenter
    {
        private readonly IAddDeviceView view;
        private Models.Device model = new Models.Device();
        public AddDevicePresenter(Views.IAddDeviceView view)
        {
            this.view = view;
        }
        public void LoadDevices()
        {
            ModelRepositories.DeviceRepository repository = new ModelRepositories.DeviceRepository();
            view.SetDevices(repository.GetDevices());
        }

        public void LoadDevice(string deviceName)
        {
            ModelRepositories.DeviceRepository repository = new ModelRepositories.DeviceRepository();
            model = repository.GetDevice(deviceName);
            view.DeviceName = model.Name;
            view.Password = model.Password;
            view.PasswordIsSupported = model.PasswordIsSupported;
        }
    }
}
