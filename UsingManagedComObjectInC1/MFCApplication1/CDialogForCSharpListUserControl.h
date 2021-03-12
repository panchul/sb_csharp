#pragma once


// CDialogForCSharpListUserControl dialog

class CDialogForCSharpListUserControl : public CDialogEx
{
	DECLARE_DYNAMIC(CDialogForCSharpListUserControl)

public:
	CDialogForCSharpListUserControl(CWnd* pParent = nullptr);   // standard constructor
	virtual ~CDialogForCSharpListUserControl();

	// C# dialog user controls
	CWinFormsControl<WindowsFormsControlLibrary1::UserControl2> m_UserControl2;

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG_CSHARP_LIST };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButtonPopulateFromCpp();
};
