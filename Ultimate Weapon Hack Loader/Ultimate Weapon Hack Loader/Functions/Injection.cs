using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace Ultimate_Weapon_Hack_Loader
{
    class Injection
    {
        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

        [DllImport("kernel32", EntryPoint = "LoadLibraryA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int LoadLibrary(string lpLibFileName);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int WriteProcessMemory(System.IntPtr hProcess, int lpBaseAddress, string lpBuffer, int nSize, int lpNumberOfBytesWritten);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int VirtualAllocEx(System.IntPtr hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetProcAddress(int hModule, string lpProcName);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int CreateRemoteThread(System.IntPtr hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, int lpThreadId);

        [DllImport("Kernel32", EntryPoint = "GetModuleHandleA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32", EntryPoint = "CloseHandle")]
        private static extern int CloseHandle(System.IntPtr hObject);

        [DllImport("user32", EntryPoint = "FindWindowA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        public void Inject(string process,string dllname)
        {
            System.IntPtr TargetProcessHandle;
            int TargetBufferSize;
            String pszLibFileRemote;
            int pfnStartAddr;
            Process[] TargetProcess = Process.GetProcessesByName(process);
            TargetProcessHandle = OpenProcess(0x1F0FFF, false, TargetProcess[0].Id);
            pszLibFileRemote = dllname;
            pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32.dll"), "LoadLibraryA");
            TargetBufferSize = 1 + pszLibFileRemote.Length;
            int Rtn;
            int LoadLibParamAdr;
            LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, 4096, 4);
            Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0);
            CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, 0);
            CloseHandle(TargetProcessHandle);
        } 
    }
}
