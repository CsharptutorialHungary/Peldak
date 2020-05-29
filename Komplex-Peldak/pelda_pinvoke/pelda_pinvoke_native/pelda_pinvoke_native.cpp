#define WIN32_LEAN_AND_MEAN // Exclude rarely-used stuff from Windows headers
// Windows Header Files
#include <windows.h>
#include <SDKDDKVer.h>
#include <string>

BOOL APIENTRY DllMain(HMODULE hModule,
	DWORD  ul_reason_for_call,
	LPVOID lpReserved
)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}

int64_t __stdcall GetString(wchar_t str[], int64_t size)
{
	std::wstring string = L"Hello from native dll";
	return wcscpy_s(str, size, string.c_str());
}

int64_t *szamok;
uint32_t allocated;

uint32_t __stdcall InitFibonacci(uint32_t limit)
{
	szamok = new int64_t[limit +2];
	allocated = limit;
	szamok[0] = 0;
	szamok[1] = 1;
	for (uint32_t i = 2; i <= limit; i++)
	{
		szamok[i] = szamok[i - 1] + szamok[i - 2];
	}
	return limit;
}

void __stdcall DeleteFibonacci()
{
	delete[]szamok;
}

uint64_t __stdcall GetFibonacci(uint32_t limit)
{
	if (limit < 0 || limit > allocated)
		return -1;
	else
		return szamok[limit];
}

typedef struct Pont
{
	float X;
	float Y;
};

void __stdcall GetStruct(Pont* output)
{
	output->X = 3.14;
	output->Y = 1.41;
}