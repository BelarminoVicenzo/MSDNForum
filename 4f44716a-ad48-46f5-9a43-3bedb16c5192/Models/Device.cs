using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Models
{
    class Device
    {
        public string Kind { get; internal set; }
        public string Name { get; internal set; }
        public bool PasswordIsSupported { get; internal set; }
        public string Password { get; internal set; }
    }
}
