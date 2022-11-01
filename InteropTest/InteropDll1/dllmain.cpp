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



PINVOKELIB_API int TestStructInStruct(MYPERSON2* pPerson2)
{
    size_t len = 0;

    StringCchLengthA(pPerson2->person->last, STRSAFE_MAX_CCH, &len);
    len = sizeof(char) * (len + 2) + 1;

    STRSAFE_LPSTR temp = (STRSAFE_LPSTR)CoTaskMemAlloc(len);
    StringCchCopyA(temp, len, (STRSAFE_LPSTR)"Mc");
    StringCbCatA(temp, len, (STRSAFE_LPSTR)pPerson2->person->last);

    CoTaskMemFree(pPerson2->person->last);
    pPerson2->person->last = (char*)temp;

    return pPerson2->age;
}

PINVOKELIB_API void TestStructInStruct3(MYPERSON3 person3)
{
    printf("\n\nperson passed by value:\n");
    printf("first = %s last = %s age = %i\n\n",
        person3.person.first,
        person3.person.last,
        person3.age);
}

PINVOKELIB_API void TestArrayInStruct(MYARRAYSTRUCT* pStruct)
{
    pStruct->flag = true;
    pStruct->vals[0] += 100;
    pStruct->vals[1] += 100;
    pStruct->vals[2] += 100;
}

PINVOKELIB_API int TestRefArrayOfInts(int** ppArray, int* pSize)
{
    int result = 0;

    // CoTaskMemAlloc must be used instead of the new operator
    // because code on the managed side will call Marshal.FreeCoTaskMem
    // to free this memory.

    int* newArray = (int*)CoTaskMemAlloc(sizeof(int) * 5);

    for (int i = 0; i < *pSize; i++)
    {
        result += (*ppArray)[i];
    }

    for (int j = 0; j < 5; j++)
    {
        newArray[j] = (*ppArray)[j] + 100;
    }

    CoTaskMemFree(*ppArray);
    *ppArray = newArray;
    *pSize = 5;

    return result;
}

PINVOKELIB_API void TestOutArrayOfStructs(int* pSize, MYSTRSTRUCT2** ppStruct)
{
    const int cArraySize = 5;
    *pSize = 0;
    *ppStruct = (MYSTRSTRUCT2*)CoTaskMemAlloc(cArraySize * sizeof(MYSTRSTRUCT2));

    if (ppStruct != NULL)
    {
        MYSTRSTRUCT2* pCurStruct = *ppStruct;
        LPSTR buffer;
        *pSize = cArraySize;

        STRSAFE_LPCSTR teststr = "***";
        size_t len = 0;
        StringCchLengthA(teststr, STRSAFE_MAX_CCH, &len);
        len++;

        for (int i = 0; i < cArraySize; i++, pCurStruct++)
        {
            pCurStruct->size = len;
            buffer = (LPSTR)CoTaskMemAlloc(len);
            StringCchCopyA(buffer, len, teststr);
            pCurStruct->buffer = (char*)buffer;
        }
    }
}