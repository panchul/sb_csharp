# sb_csharp

Misc snippets and templates for C#

**Content**

- [Using Managed COM Object in C++](#using-managed-com-object-in-c)
- [Pre-requisites](#pre-requisites)
- [Demos](#demos)
 - [ComponentsCppCX](#componentscppcx)
 - [ComponentsCppStandard](#componentscppstandard)
 - [ComponentsCppStandardIDL](#componentscppstandardidl)
 - [CoreAppCppCX_UniversalWindows](#coreappcppcx-universalwindows)
 - [CoreAppStandardCpp](#coreappstandardcpp)
 - [CoreAppUniversalWindows](#coreappuniversalwindows)
 - [UsingManagedComObjectInC](#usingmanagedcomobjectInc)
 - [UsingManagedComObjectInC1](#usingmanagedcomobjectinc1)
- [Links](#links)

---

# Pre-requisites

To run samples from this repository, install free Visual Studio 2019 from Microsoft website.

Some projects work with Mono on Linux or Mac, but it is not guaranteed.

## Config considerations

Some needed libraries or packages might be in different place on your system, for example,
I am using vcpackages from here, it is for Visual Studio 2019:
`C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\VC\vcpackages`

`metadata_dir`:

"C:\Program Files (x86)\Windows Kits\10\References\10.0.19041.0\Windows.Foundation.FoundationContract\4.0.0.0"

You may also need to explicitly install some non-default packages in Visual Studio Installer.

You may have to turn Windows 10's Developer Mode, or run some of the samples in Administrative
mode to let it register DLLs, etc.

---

# Demos

---

## ComponentsCppCX

---

[ComponentsCppCX](ComponentsCppCX/)

---

## ComponentsCppStandard

---

[ComponentsCppStandard](ComponentsCppStandard/)

---

## ComponentsCppStandardIDL

---

[ComponentsCppStandardIDL](ComponentsCppStandardIDL/)

---

## CoreAppCppCX_UniversalWindows

---

[CoreAppCppCX_UniversalWindows](CoreAppCppCX_UniversalWindows/)

---

## CoreAppStandardCpp

---

[CoreAppStandardCpp](CoreAppStandardCpp/)

---

## CoreAppUniversalWindows

---

[CoreAppUniversalWindows](CoreAppUniversalWindows/)

---

## UsingManagedComObjectInC

---

[UsingManagedComObjectInC](UsingManagedComObjectInC/)

---

## UsingManagedComObjectInC1

---

[UsingManagedComObjectInC1](UsingManagedComObjectInC1/)

---

# Links

- uuidgen
- ildasm
- midl.exe
- midlrt.exe
- mdmerge.exe, to merge the definitions
- depends.exe https://www.dependencywalker.com/  Dependency Walker

