namespace LinuxVirtualFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualFileSystem vObj = new VirtualFileSystem();
            vObj.CreateVFS();
            vObj.GetUserInput();
        }
    }
}
