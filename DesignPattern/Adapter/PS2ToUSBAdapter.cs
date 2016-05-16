using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PS2ToUSBAdapter : USBInterface
    {
        private readonly PS2Interface _interface=new PS2Interface();
        public void ReadMsg()
        {
            _interface.ReadMsg();
        }
    }
}