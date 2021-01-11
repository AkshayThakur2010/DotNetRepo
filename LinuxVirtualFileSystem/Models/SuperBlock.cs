using System;
using System.Collections.Generic;
using System.Text;

namespace LinuxVirtualFileSystem.Models
{
    public class SuperBlock
    {
        public int FreeINode { get; set; }
        public int TotalINode { get; set; }
    }
}
