#include "implements.h"
#include <activation.h>
#include <memory>
#include <winstring.h>

#pragma comment(lib, "runtimeobject")

static long s_lock;

struct ComponentLock
{
    ComponentLock() noexcept
    {
        InterlockedIncrement(&s_lock);
    }
    
    ~ComponentLock() noexcept
    {
        InterlockedDecrement(&s_lock);
    }
};

HRESULT __stdcall DllCanUnloadNow()
{
    return s_lock ? S_FALSE : S_OK;
}

struct __declspec(uuid("fdc4cf7c-608a-4eed-a095-531042f0acc8")) __declspec(novtable)
IHen : IInspectable
{
    virtual HRESULT __stdcall Cluck() = 0;
};

struct Hen : Implements<IHen>
{
    ComponentLock m_lock;
    
    virtual HRESULT __stdcall Cluck() noexcept override
    {
        OutputDebugStringW(L"Clucking with Standard C++!\n");
        return S_OK;
    }
};

struct HenFactory : Implements<IActivationFactory>
{
    ComponentLock m_lock;
    
    virtual HRESULT __stdcall ActivateInstance(IInspectable ** instance) noexcept override
    {
        *instance = new (std::nothrow) Hen;
        return *instance ? S_OK : E_OUTOFMEMORY;
    }
};

HRESULT __stdcall DllGetActivationFactory(HSTRING classId,
                                          IActivationFactory ** factory)
{
    *factory = nullptr;
    wchar_t const * const expected = WindowsGetStringRawBuffer(classId, nullptr);
    
    if (0 == wcscmp(expected, L"Sample.Hen"))
    {
        *factory = new (std::nothrow) HenFactory;
        return *factory ? S_OK : E_OUTOFMEMORY;
    }
    
    return CLASS_E_CLASSNOTAVAILABLE;
}

