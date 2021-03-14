#include <windows.h>

namespace Sample
{
    public ref class Hen sealed
    {
    public:
    
        void Cluck()
        {
            OutputDebugStringW(L"Clucking with C++/CX!\n");
        }
    };
}
