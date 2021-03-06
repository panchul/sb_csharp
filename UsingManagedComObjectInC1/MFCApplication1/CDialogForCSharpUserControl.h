#pragma once


// CDialogForCSharpUserControl dialog

class CDialogForCSharpUserControl : public CDialogEx
{
	DECLARE_DYNAMIC(CDialogForCSharpUserControl)

public:
	CDialogForCSharpUserControl(CWnd* pParent = nullptr);   // standard constructor
	virtual ~CDialogForCSharpUserControl();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG_CSHARP_USERCONTROL1 };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
};
