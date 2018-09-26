#pragma once
#ifndef _COM_H
#endif _COM_H
#pragma once
#include <string>
#include "atlconv.h"

extern "C" HANDLE _declspec(dllexport) __stdcall  OpenSerialPort(std::wstring strPort, ULONG ulBaudrate);
extern "C" void _declspec(dllexport) __stdcall  CloseSerialPort(HANDLE hSerial);
extern "C" bool _declspec(dllexport) __stdcall  WriteSerial(char* btData, ULONG ulSize, HANDLE hSerial);
extern "C" bool _declspec(dllexport) __stdcall  ReadSerial(BYTE *btData, ULONG *ulSize, HANDLE hSerial);
extern "C" int _declspec(dllexport) __stdcall COM_Send(char *portname, unsigned int rate, char *buff);