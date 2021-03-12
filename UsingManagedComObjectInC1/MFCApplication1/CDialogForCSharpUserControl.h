#pragma once

// CDialogForCSharpUserControl dialog

class CDialogForCSharpUserControl : public CDialogEx
{
	DECLARE_DYNAMIC(CDialogForCSharpUserControl)

public:
	CDialogForCSharpUserControl(CWnd* pParent = nullptr);   // standard constructor
	virtual ~CDialogForCSharpUserControl();

	// C# dialog user controls
	CWinFormsControl<WindowsFormsControlLibrary1::UserControl1> m_UserControl1;
	CString m_StrText;

	// C++ dialog user controls
	CString cpp_string_var;

	
	
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
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedButton2();
	
	CString csharp_string_var;
};
