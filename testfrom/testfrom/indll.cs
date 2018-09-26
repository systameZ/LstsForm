using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace testfrom
{
    class indll
    {
        [DllImport("mydll.dll", CallingConvention = CallingConvention.Cdecl)]
        //extern "C" HANDLE _declspec(dllexport) __stdcall OpenSerialPort(std::wstring strPort, ULONG ulBaudrate);
        //extern "C" void _declspec(dllexport) __stdcall CloseSerialPort(HANDLE hSerial);
        //extern "C" bool _declspec(dllexport) __stdcall WriteSerial(char* btData, ULONG ulSize, HANDLE hSerial);
        //extern "C" bool _declspec(dllexport) __stdcall ReadSerial(BYTE* btData, ULONG* ulSize, HANDLE hSerial);
        //extern "C" int _declspec(dllexport) __stdcall COM_Send(std::wstring portname, unsigned int rate, std::string buff);
        public static extern IntPtr OpenSerialPort(IntPtr strPort, UInt32 ulBaudrate);
        [DllImport("mydll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CloseSerialPort(IntPtr hSerial);
        [DllImport("mydll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WriteSerial(String btData, UInt32 ulSize ,IntPtr hSerial);
        [DllImport("mydll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ReadSerial(Byte[] btData, UInt32 ulSize, IntPtr hSerial);
        [DllImport("mydll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int COM_Send(StringBuilder portname, uint rate, StringBuilder buff);

    }
}
