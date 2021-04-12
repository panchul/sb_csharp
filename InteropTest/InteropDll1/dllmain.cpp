// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
//#define PINVOKELIB_EXPORTS


// From here:
//
// https://docs.microsoft.com/en-us/dotnet/framework/interop/marshaling-data-with-platform-invoke#pinvokelibdll
//
//

#include "framework.h"

#include <strsafe.h>
#include <objbase.h>
#include <stdio.h>

#include <iostream>

#pragma comment(lib,"ole32.lib")
BOOL APIENTRY DllMain( HMODULE hModule,
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

static int MyState = 0;
static FPTR MyFuncPtrState = nullptr;

PINVOKELIB_API int TestInt(int myint)
{
    ++MyState;
    //OutputDebugStringA("**********************\nTestInt\n");
    //std::cout << "myint is " << myint << "\n";
    if(MyFuncPtrState != nullptr)
    {
        MyFuncPtrState(myint);
    }
    return MyState *100 + myint;
}

PINVOKELIB_API bool RegisterFPtr(FPTR MyFunc)
{
    MyFuncPtrState = MyFunc;
    return true;
}

PINVOKELIB_API void RegisterAndInvokeFPtr(FPTR MyFunc, int myint)
{
    if (MyFunc != nullptr)
    {
        MyFunc(myint);
    }
}

//******************************************************************
// This is the constructor of a class that has been exported.
CTestClass::CTestClass()
{
    m_member = 1;
}

int CTestClass::DoSomething(int i)
{
    return i * i + m_member;
}

PINVOKELIB_API CTestClass* CreateTestClass()
{
    return new CTestClass();
}

PINVOKELIB_API void DoSomethingOnTestClass(CTestClass* instance)
{
    if (instance != nullptr) {
        instance->m_public_int = instance->DoSomething(0);
        MyState = instance->m_public_int;
    }
}

PINVOKELIB_API void DeleteTestClass(CTestClass* instance)
{
    if (instance != nullptr) {
        delete instance;
        instance = nullptr;
    }
}
