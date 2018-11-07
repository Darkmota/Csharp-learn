using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HC5
{
    class SystemInfo
    {
        public OperatingSystem OSVersion;
        public bool Is64Bit;
        public SystemInfo()
        {
            OSVersion = Environment.OSVersion;
            Is64Bit = Environment.Is64BitOperatingSystem;
            // 以此类推
        }
    }
}
