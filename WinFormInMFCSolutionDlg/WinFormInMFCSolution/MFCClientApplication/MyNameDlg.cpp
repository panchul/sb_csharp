// MyNameDlg.cpp : implementation file
//

#include "stdafx.h"
#include "MFCClientApplication.h"
#include "MyNameDlg.h"
#include "afxdialogex.h"


// CMyNameDlg dialog

IMPLEMENT_DYNAMIC(CMyNameDlg, CDialogEx)

CMyNameDlg::CMyNameDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(IDD_DIALOG_WF_NAME, pParent)
{

}

CMyNameDlg::~CMyNameDlg()
{
}

void CMyNameDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_ManagedControl(pDX, IDC_STATIC_WF_NAME, this->m_MyNameCtrl);

	if (pDX->m_bSaveAndValidate)
	{
		// we are copying contents of Dialog controls
		// to our member variables
		csharp_tpf::CSharpMyNameCtrl^ hMyNameCtrl =
			this->m_MyNameCtrl.GetControl();

		this->m_StrName = hMyNameCtrl->GetNameTextBox()->Text;
	}
	else
	{
		// we are copying the contents of member data
		// to our Dialog controls
		csharp_tpf::CSharpMyNameCtrl^ hMyNameCtrl =
			this->m_MyNameCtrl.GetControl();

		hMyNameCtrl->GetNameTextBox()->Text
			= gcnew ClrString(this->m_StrName);
	}

}


BEGIN_MESSAGE_MAP(CMyNameDlg, CDialogEx)
END_MESSAGE_MAP()


// CMyNameDlg message handlers


BOOL CMyNameDlg::OnInitDialog()
{
	// initialize member fields
	// before CDialogEx::OnInitDialog();
	// because these members will be update in
	// DoDataExchange()
	this->m_StrName = L"Thomas Kim";

	CDialogEx::OnInitDialog();

	// TODO:  Add extra initialization here

	return TRUE;  // return TRUE unless you set the focus to a control
				  // EXCEPTION: OCX Property Pages should return FALSE
}
