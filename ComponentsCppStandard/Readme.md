
To build Sample.cpp:

    C:\sb_csharp\ComponentsCppStandard>cl Sample.cpp /W4 /LD

So, it is just a traditional Windows DLL. It creates the .dll and .obj  files:

    C:\src\workspace\projects\sb_csharp\ComponentsCppStandard>dir
    Exports.def
    implements.h
    Sample.cpp
    Sample.dll
    Sample.obj


Module definition file:

    EXPORTS
    DllCanUnloadNow PRIVATE
    DllGetActivationFactory PRIVATE

We can compile, specifying more parameters and providing .def file:

    C:\sb_csharp\ComponentsCppStandard>cl Sample.cpp /W4 /FeSample.dll /link /dll /def:Exports.def
    Microsoft (R) C/C++ Optimizing Compiler Version 19.28.29912 for x86
    Copyright (C) Microsoft Corporation.  All rights reserved.
    .
    Sample.cpp
    Microsoft (R) Incremental Linker Version 14.28.29912.0
    Copyright (C) Microsoft Corporation.  All rights reserved.
    .
    /out:Sample.dll
    /dll
    /def:Exports.def
    Sample.obj
       Creating library Sample.lib and object Sample.exp

It also creates .lib and .exp

You can look inside of the dll using Dependency Walker tool, depends.exe:

    C:\sb_csharp\ComponentsCppStandard>depends.exe Sample.cpp

depends.exe did not work for me on Win 10, neither 32 or 64, just hangs.

The App is also not working with the DLL I built. Complains about `Sample` namespace, could not add
reference to the .dll, says it is not a COM object
