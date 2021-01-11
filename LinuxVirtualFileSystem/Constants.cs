using System;
using System.Collections.Generic;
using System.Text;

namespace LinuxVirtualFileSystem
{
    public static class Constants
    {
        public static int MAXINODE = 100;

        public const int READ = 1;
        public const int WRITE = 2;

        public const int MAXFILESIZE = 2048;

        public const int REGULAR = 1;
        public const int NoFileType = 0;

        public const int START = 0;
        public const int CURRENT = 1;
        public const int END = 2;

        public const int TOTALFILES = 50;
    }
}
