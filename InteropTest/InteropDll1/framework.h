#pragma once

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers
// Windows Header Files
#include <windows.h>
// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the PINVOKELIB_EXPORTS
// symbol defined on the command line. this symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// PINVOKELIB_API functions as being imported from a DLL, wheras this DLL sees symbols
// defined with this macro as being exported.
#ifdef PINVOKELIB_EXPORTS
#define PINVOKELIB_API __declspec(dllexport)
#else
#define PINVOKELIB_API __declspec(dllimport)
#endif

typedef void (CALLBACK* FPTR)(int i);

// This is an exported class.
class PINVOKELIB_API CTestClass
{
public:
	CTestClass(void);
	int DoSomething(int i);

	int m_public_int;
	
private:
	int m_member;
};

#ifdef __cplusplus
extern "C"
{
#endif

	PINVOKELIB_API int TestInt(int myint);

	PINVOKELIB_API bool RegisterFPtr(FPTR MyFunc);

	PINVOKELIB_API void RegisterAndInvokeFPtr(FPTR MyFunc, int myint);

	PINVOKELIB_API CTestClass* CreateTestClass();
	PINVOKELIB_API void DoSomethingOnTestClass(CTestClass* instance);
	PINVOKELIB_API void DeleteTestClass(CTestClass* instance);

#ifdef __cplusplus
}
#endif
