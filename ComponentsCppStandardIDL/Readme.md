

To produce .winmd:

    "C:\Program Files (x86)\Windows Kits\10\bin\10.0.19041.0\x64\midl.exe" Sample.idl /winrt /nomidl /metadata_dir "C:\Program Files (x86)\Windows Kits\10\References\10.0.19041.0\Windows.Foundation.FoundationContract\4.0.0.0"


But it does not create a .dll ??!!. I tried this, it did not help:

	cl Sample.cpp /W4 /FeSample.dll /link /dll /def:Exports.def


    C:\src\workspace\projects\sb_csharp\ComponentsCppStandardIDL>ls
    App  Exports.def  Readme.md  Sample.cpp  Sample.h  Sample.idl  Sample.winmd  implements.h

    C:\src\workspace\projects\sb_csharp\ComponentsCppStandardIDL>cl Sample.cpp /W4 /FeSample.dll /link /dll /def:Exports.def
    Microsoft (R) C/C++ Optimizing Compiler Version 19.28.29912 for x86
    Copyright (C) Microsoft Corporation.  All rights reserved.

    Sample.cpp
    C:\Program Files (x86)\Windows Kits\10\include\10.0.19041.0\winrt\windows.ui.core.h(79): warning C4005: 'CHECK_NS_PREFIX_STATE': macro redefinition
    C:\src\workspace\projects\sb_csharp\ComponentsCppStandardIDL\Sample.h(41): note: see previous definition of 'CHECK_NS_PREFIX_STATE'
	C:\src\workspace\projects\sb_csharp\ComponentsCppStandardIDL\Sample.h(249): error C2653: 'Windows': is not a class or namespace name
    C:\src\workspace\projects\sb_csharp\ComponentsCppStandardIDL\Sample.h(249): error C2061: syntax error: identifier 'ICoreWindow'
    Sample.cpp(29): error C2039: 'Sample': is not a member of 'ABI'
    C:\Program Files (x86)\Windows Kits\10\include\10.0.19041.0\winrt\windows.ui.core.h(5110): note: see declaration of 'ABI'
    Sample.cpp(29): error C3083: 'Sample': the symbol to the left of a '::' must be a type
    Sample.cpp(29): error C2039: 'IHen': is not a member of 'ABI'
    C:\Program Files (x86)\Windows Kits\10\include\10.0.19041.0\winrt\windows.ui.core.h(5110): note: see declaration of 'ABI'
    Sample.cpp(29): error C2065: 'IHen': undeclared identifier
    Sample.cpp(29): error C3544: 'Interfaces': parameter pack expects a type template argument
    Sample.cpp(30): error C3544: 'Interfaces': parameter pack expects a type template argument
    Sample.cpp(30): error C2955: 'Implements': use of class template requires template argument list
    C:\src\workspace\projects\sb_csharp\ComponentsCppStandardIDL\implements.h(12): note: see declaration of 'Implements'
    Sample.cpp(33): error C3668: 'Hen::Cluck': method with override specifier 'override' did not override any base class methods
    Sample.cpp(46): error C2440: '=': cannot convert from 'Hen *' to 'IInspectable *'
    Sample.cpp(46): note: Types pointed to are unrelated; conversion requires reinterpret_cast, C-style cast or function-style cast


Running it without /nomidl produces more files, no .dll though:

	"C:\Program Files (x86)\Windows Kits\10\bin\10.0.19041.0\x64\midl.exe" Sample.idl /winrt /metadata_dir "C:\Program Files (x86)\Windows Kits\10\References\10.0.19041.0\Windows.Foundation.FoundationContract\4.0.0.0"

    C:\src\workspace\projects\sb_csharp\ComponentsCppStandardIDL>ls -1
    App
    Exports.def
    Readme.md
    Sample.cpp
    Sample.h
    Sample.idl
    Sample.winmd
    Sample_i.c
    Sample_p.c
    Sample_p.h
    dlldata.c
    implements.h
