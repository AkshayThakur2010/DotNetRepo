using System;
using System.Collections.Generic;
using System.Text;

namespace LinuxVirtualFileSystem.Models
{
    public class FileTable
    {
        public int ReadOffset { get; set; }
        public int WriteOffset { get; set; }
        public int Count { get; set; }

        public int Mode { get; set; }
        public INode ptrInode { get; set; }

    }
}
