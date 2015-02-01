using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
class ManagedInject
{

    #region Storage
    static Process[] P;
    static IntPtr Han = IntPtr.Zero;
    static List<int> Caves = new List<int>();
    public static string ProcessName = string.Empty, _Class = "Class1", _DllMain = "DllMain";
    public static int _Wait = 2000;
    #endregion

    #region API

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool CloseHandle(IntPtr hObject);
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern int VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, uint flAllocationType, uint flProtect);
    [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
    static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, byte dwSize, uint dwFreeType);
    [DllImport("kernel32.dll")]
    static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, int lpStartAddress, int lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern int GetProcAddress(IntPtr hModule, string lpProcName);
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetModuleHandle(string lpModuleName);
    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);
    [DllImport("kernel32.dll")]
    static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);
    #endregion

    #region Functions

    static string CoreePath
    {
        get
        {
            foreach (ProcessModule M in Process.GetCurrentProcess().Modules)
                if (M.ModuleName.ToLower() == "mscoree.dll")
                    return M.FileName;
            return string.Empty;
        }
    }

    static bool LoadLibrary(out int Addy)
    {
        return (Addy = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA")) != 0;
    }

    static int Allocate()
    {
        int C = VirtualAllocEx(Han, IntPtr.Zero, 512, 0x1000, 0x40);
        if (C == 0)
        {
            CloseHandle(Han);
            throw new Exception("Unable to allocate some memory!.");
        }
        Caves.Add(C);
        return C;
    }

    static bool WriteBytes(int Addy, byte[] byts)
    {
        bool B = WriteProcessMemory(Han, Addy, byts, byts.Length, 0);
        if (!B)
        {
            Deallocate();
            CloseHandle(Han);
            throw new Exception("Write memory failed for some reason!.");
        }
        return B;
    }

    static IntPtr OpenProc()
    {
        return OpenProcess(0x2 | 0x8 | 0x10 | 0x20 | 0x400, false, P[0].Id);
    }

    static void RemoteThread(int Adr, int Cave, int _Wait)
    {
        IntPtr _Thread;
        if ((_Thread = CreateRemoteThread(Han, IntPtr.Zero, IntPtr.Zero, Adr, Cave, 0, IntPtr.Zero)) == IntPtr.Zero)
        {
            Deallocate();
            CloseHandle(Han);
            throw new Exception("Unable to create thread!.");
        }
        try
        {
            if (WaitForSingleObject(_Thread, _Wait) == -1)
            {
                Deallocate();
                CloseHandle(Han);
                throw new Exception("Unable to wait for object!.");
            }
        }
        finally
        {
            CloseHandle(_Thread);
        }
    }

    static bool IsManaged(string _Path)
    {
        try
        {
            Assembly asm = Assembly.LoadFrom(_Path);
            return true;
        }
        catch { return false; }
    }

    static string GetNamespace(string _Path)
    {
        try
        {
            Assembly asm = Assembly.LoadFrom(_Path);
            foreach (Type T in asm.GetTypes())
                if (T.IsClass & !T.ToString().StartsWith("<"))
                {
                    int i = -1;
                    if ((i = T.ToString().IndexOf(".")) != -1)
                        return T.ToString().Substring(0, i + 1) + _Class;
                    return string.Empty;
                }
        }
        catch
        {
            MessageBox.Show("Not a managed dll");
        }
        return string.Empty;
    }

    static int GetRuntime()
    {
        return GetProcAddress(GetModuleHandle("mscoree.dll"), "CorBindToRuntimeEx");
    }

    static void Deallocate()
    {
        foreach (IntPtr C in Caves)
            VirtualFreeEx(Han, C, 0, 0x8000);
    }

    static byte[] HX2Bts(string HXS)
    {
        if (HXS.Length % 2 != 0) HXS = HXS.Substring(0, HXS.Length - 1);
        byte[] buf = new byte[HXS.Length / 2];
        for (int i = 0; i < buf.Length; i++)
            buf[i] = byte.Parse(HXS.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
        return buf;
    }

    static string GetIns(int Addy)
    {
        byte[] BTS = BitConverter.GetBytes(Addy);
        string tmp = string.Empty;
        for (int i = 0; i < BTS.Length; i++)
            tmp += String.Format("{0:x2}", (uint)Convert.ToUInt32(BTS[i]));
        return tmp;
    }

    #endregion

    #region Mscoree

    static bool InjectMscoree(string _Path)
    {
        bool B = IsManaged(_Path);
        if ((_Path = B ? CoreePath : _Path) == string.Empty & B)
        {
            MessageBox.Show("mscoree.dll wasn't found, injection wont work", "Nothing Done...");
            return false;
        }
        P = Process.GetProcessesByName(ProcessName);
        if (P.Length == 0) return false;
        if (Han == IntPtr.Zero) Han = OpenProc();
        if (B)
        {
            foreach (ProcessModule M in P[0].Modules)
                if (M.ModuleName.ToLower() == "mscoree.dll")
                    return true;
        }
        if (Han != IntPtr.Zero)
        {
            int Adr;
            if (LoadLibrary(out Adr))
            {
                int Cave;
                if ((Cave = Allocate()) != 0)
                {
                    if (WriteBytes(Cave, Encoding.ASCII.GetBytes(_Path)))
                    {
                        RemoteThread(Adr, Cave, -1);
                        return B;
                    }
                }
            }
        }
        return false;
    }

    #endregion

    #region Inject

    public static void InjectCLR(string Dllpath, string DllMainName)
    {
        InjectCLR(Dllpath, DllMainName, "arg");
    }

    public static void InjectCLR(string Dllpath)
    {
        InjectCLR(Dllpath, _DllMain, "arg");
    }

    public static void InjectCLR(string Dllpath, string DllMainName, string arg)
    {
        if (ProcessName == string.Empty)
        {
            throw new Exception("Process name can't be blank.");
        }
        if (Dllpath == string.Empty)
        {
            throw new Exception("Dll path can't be blank.");
        }
        if (DllMainName == string.Empty)
        {
            throw new Exception("Dllmain field can't be blank.");
        }
        if (arg == string.Empty)
        {
            throw new Exception("Argument field can't be blank.");
        }
        if (InjectMscoree(Dllpath))
        {
            if (Han == IntPtr.Zero) return;
            int _Main;
            if ((_Main = Allocate()) == 0) return;
            int _wks = _Main + 0x54, _Path = _wks + 0xA;
            int _NSpace = _Path + (Dllpath.Length * 2) + 4;
            int _Method = _NSpace + (GetNamespace(Dllpath).Length * 2) + 4;
            int _Arg = _Method + (DllMainName.Length * 2) + 4;
            int _CLR = _Arg + (arg.Length * 2) + 4;
            int _CLR_ = _CLR + 0x12, _Host = _CLR_ + 0x12;
            int _Ret = _Host + 4;

            WriteBytes(_CLR, HX2Bts("6EA0F1901277624786B57A5EBA6BDB02"));
            WriteBytes(_CLR_, HX2Bts("6CA0F1901277624786B57A5EBA6BDB02"));
            WriteBytes(_wks, HX2Bts("77006B007300"));
            WriteBytes(_Path, Encoding.Unicode.GetBytes(Dllpath));
            WriteBytes(_NSpace, Encoding.Unicode.GetBytes(GetNamespace(Dllpath)));
            WriteBytes(_Method, Encoding.Unicode.GetBytes(DllMainName));
            WriteBytes(_Arg, Encoding.Unicode.GetBytes(arg));

            string Opcode = string.Empty;
            Opcode += "68" + GetIns(_Host) + "68" + GetIns(_CLR_);
            Opcode += "68" + GetIns(_CLR) + "6a00";
            Opcode += "68" + GetIns(_wks) + "6a00";
            Opcode += "E8" + GetIns(GetRuntime() - (_Main + 24) - 5);
            Opcode += "a1" + GetIns(_Host) + "8b088b510c50ffd2";
            Opcode += "68" + GetIns(_Ret) + "68" + GetIns(_Arg);
            Opcode += "68" + GetIns(_Method) + "68" + GetIns(_NSpace);
            Opcode += "68" + GetIns(_Path) + "a1" + GetIns(_Host);
            Opcode += "8b08508b412cffd0c3";

            WriteBytes(_Main, HX2Bts(Opcode));
            RemoteThread(_Main, 0, _Wait);
        }
        if (Han != IntPtr.Zero)
        {
            Deallocate();
            CloseHandle(Han);
            Han = IntPtr.Zero;
        }
    }

    #endregion

    #region Process Watcher

    public static List<string> Proc2Watch = new List<string>();

    public static Timer _Timer = new Timer();

    public static void StartWatcher()
    {
        MakeTimer(ProcWatcher, 3000);
    }

    static void MakeTimer(EventHandler timed, int Intervals)
    {
        _Timer.Interval = Intervals;
        _Timer.Start();
        _Timer.Tick += new EventHandler(timed);
    }

    static void ProcWatcher(object sender, EventArgs e)
    {
        CheckOnLoad();
    }

    public static void CheckOnLoad()
    {
        if (Proc2Watch.Count == 0) return;
        foreach (Process P in Process.GetProcesses())
        {
            if (Proc2Watch.FindAll(s => s.IndexOf(P.ProcessName, StringComparison.OrdinalIgnoreCase) >= 0).Count != 0)
            {
                Application.Exit();
            }
        }
        GC.Collect();
    }

    #endregion
}
