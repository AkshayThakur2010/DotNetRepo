using System;
using System.Collections.Generic;
using System.Text;

namespace LinuxVirtualFileSystem.Models
{
    public class INode
    {
        public string FileName { get; set; }
        public int FileActualSize { get; set; }
        public int FileSize { get; set; }
        public int INodeNumber { get; set; }
        public string[] Buffer { get; set; }
        public int FileType { get; set; }
        public int LinkCount { get; set; }
        public int ReferenceCount { get; set; }
        public int Permission { get; set; }
        public INode Next;
        public INode Prev;

        public INode()
        {
            Next = null;
            Prev = null;
        }
    }
}
