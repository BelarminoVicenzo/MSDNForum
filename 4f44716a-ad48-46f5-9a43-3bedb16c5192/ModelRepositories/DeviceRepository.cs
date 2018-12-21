using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.ModelRepositories
{
    class DeviceRepository
    {
        private Models.Device X3 => new Models.Device
        {
            Kind = "X3",
            Name = "Basic",
            PasswordIsSupported = false,
            Password = string.Empty,
        };
        private Models.Device X5 => new Models.Device
        {
            Kind = "X5",
            Name = "Classic",
            PasswordIsSupported = false,
            Password = string.Empty,
        };
        private Models.Device X7 => new Models.Device
        {
            Kind = "X7",
            Name = "Luxury",
            PasswordIsSupported = true,
            Password = string.Empty,
        };
        public IEnumerable<string> GetDevices()
        {
            return new List<string>
            {
                "X3", "X5", "X7"
            };
        }
        public Models.Device GetDevice(string name)
        {
            switch (name.ToLower())
            {
                case "x3": return X3;
                case "x5":return X5;
                case "x7": return X7;
            }
            throw new NotSupportedException();
        }
        
    }
}
