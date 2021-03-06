// mydll.cpp: 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include"mydll.h"

using namespace std;

extern "C" HANDLE _declspec(dllexport) __stdcall OpenSerialPort(wstring strPort, ULONG ulBaudrate) {
	HANDLE hSerial;
	hSerial = CreateFile(strPort.c_str(),
		GENERIC_READ | GENERIC_WRITE,
		NULL,
		NULL,
		OPEN_EXISTING,
		NULL,
		NULL);

	if (hSerial == INVALID_HANDLE_VALUE)//Open serial port failed.
	{
		return hSerial;
	}

	//Config serial port
	DCB PortDCB;
	PortDCB.DCBlength = sizeof(DCB);

	// Get the default serial parameter.
	GetCommState(hSerial, &PortDCB);
	PortDCB.BaudRate = ulBaudrate;      // baudrate
	PortDCB.ByteSize = 8;               // Number of bits/byte, 4-8 
	PortDCB.Parity = NOPARITY;
	PortDCB.StopBits = ONESTOPBIT;

	if (!SetCommState(hSerial, &PortDCB))
	{
		//config the serial port failed.
		CloseHandle(hSerial);
		return (INVALID_HANDLE_VALUE);
	}

	//Config the serial port timeout property.
	COMMTIMEOUTS CommTimeouts;
	GetCommTimeouts(hSerial, &CommTimeouts);        //Get the serial port default timeout.
	CommTimeouts.ReadIntervalTimeout = MAXDWORD;
	CommTimeouts.ReadTotalTimeoutMultiplier = 10;
	CommTimeouts.ReadTotalTimeoutConstant = 10;
	CommTimeouts.WriteTotalTimeoutMultiplier = 50;
	CommTimeouts.WriteTotalTimeoutConstant = 100;

	if (!SetCommTimeouts(hSerial, &CommTimeouts))
	{
		//config the serial port timeout failed;
		CloseHandle(hSerial);
		return (INVALID_HANDLE_VALUE);
	}
	return (hSerial);
}
extern "C" void _declspec(dllexport) __stdcall CloseSerialPort(HANDLE hSerial) {
	CloseHandle(hSerial);
}
extern "C" bool _declspec(dllexport) __stdcall WriteSerial(char* btData, ULONG ulSize, HANDLE hSerial) {
	DWORD dwNumBytes, dwRet;
	dwRet = WriteFile(hSerial, //Handle
		btData, //Data buffer
		ulSize, //Buffer size
		&dwNumBytes, //written bytes
		NULL); //don't support

	return (dwRet != 0);
}
extern "C" bool _declspec(dllexport) __stdcall ReadSerial(BYTE *btData, ULONG *ulSize, HANDLE hSerial) {
	//SetCommMask (hSerial, EV_RXCHAR);
	ULONG ulRdSize = 0;
	BYTE Byte;
	DWORD dwBytes;
	bool blRd = false;
	DWORD dwMask = EV_RXCHAR;
	//WaitCommEvent(hSerial,&dwMask,NULL);
	SetCommMask(hSerial, EV_RXCHAR);
	while (ReadFile(hSerial, &Byte, 1, &dwBytes, 0) != 0)
	{
		if (dwBytes>0)
		{
			btData[ulRdSize++] = Byte;

			if (ulRdSize == *ulSize)
			{
				blRd = true;
				break;
			}
		}

		else
		{
			blRd = true;
			break;
		}
	}

	*ulSize = ulRdSize;
	return (blRd);
}
extern "C" int _declspec(dllexport) __stdcall COM_Send(char *inportname, unsigned int rate, char *buff) {
	USES_CONVERSION;
	static HANDLE hSerialPort;
	static int n, m = 1, cache_rate;//数据长度
	wchar_t* portname = A2W(inportname);
	static char c[100];
	char p = (char)portname;
	static char p1;
	strcpy_s(c, buff);
	wstring wstr = portname;
	if (m == 1)
	{
		m = 0;
		p1 = p;
		//printf(p);
		//printf(p1);
		cache_rate = rate;
		wstr += ':';
		n = strlen(buff);//数据长度
						  //char c[sizeof(buff)];//给出要发送的数组的长度缓冲区 		
		hSerialPort = OpenSerialPort(wstr, rate);//Open serial port com4 串口波特率
	}
	if ((p1 != p) || (cache_rate != rate))
	{
		m = 1;
	}
	if (hSerialPort != INVALID_HANDLE_VALUE)//句柄无效则关闭它，比如说打不开串口了
	{
		if (!WriteSerial(c, n, hSerialPort))//C是要发的数据后面那个是这个数组的长度
			return 8;					//MessageBox(0, "ERROR", "ERROR", MB_ICONWARNING);//show error message
			//printf("ERROR!!");
		//CloseSerialPort(hSerialPort);
	}
	else
	{
		//printf("打开串口失败");
		return 7;
	}

	return 0;

	/*string portname = "COM4:";
	int n;//数据长度
	string buff = "  ";
	n=buff.length();//数据长度
	//printf("%d",sizeof(buff));
	char c[sizeof(buff)];//给出要发送的数组的长度缓冲区
	strcpy_s(c, buff.c_str());
	hSerialPort = OpenSerialPort( portname, 115200);//Open serial port com4 串口波特率*/
	/*if (hSerialPort != INVALID_HANDLE_VALUE)//句柄无效则关闭它，比如说打不开串口了
	{
	if (!WriteSerial(c, n, hSerialPort))//C是要发的数据后面那个是这个数组的长度

	//MessageBox(0, "ERROR", "ERROR", MB_ICONWARNING);//show error message
	printf("ERROR!!");
	//CloseSerialPort(hSerialPort);
	}*/
}



