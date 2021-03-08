#pragma once

// CDialogForCSharpUserControl dialog

class CDialogForCSharpUserControl : public CDialogEx
{
	DECLARE_DYNAMIC(CDialogForCSharpUserControl)

public:
	CDialogForCSharpUserControl(CWnd* pParent = nullptr);   // standard constructor
	virtual ~CDialogForCSharpUserControl();

	CWinFormsControl<WindowsFormsControlLibrary1::UserControl1> m_UserControl1;
	CString m_StrText;

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG_CSHARP_USERCONTROL1 };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedOk();
	virtual BOOL OnInitDialog();
};
