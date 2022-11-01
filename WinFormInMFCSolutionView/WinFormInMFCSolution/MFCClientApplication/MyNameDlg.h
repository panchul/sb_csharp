#pragma once


// CMyNameDlg dialog

class CMyNameDlg : public CDialogEx
{
	DECLARE_DYNAMIC(CMyNameDlg)

public:
	CMyNameDlg(CWnd* pParent = NULL);   // standard constructor
	virtual ~CMyNameDlg();

	CWinFormsControl<csharp_tpf::CSharpMyNameCtrl> m_MyNameCtrl;
	CString m_StrName;


// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG_WF_NAME };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	virtual BOOL OnInitDialog();
};
