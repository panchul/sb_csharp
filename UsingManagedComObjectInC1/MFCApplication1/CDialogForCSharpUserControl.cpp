// CDialogForCSharpUserControl.cpp : implementation file
//

#include "pch.h"
#include "MFCApplication1.h"
#include "CDialogForCSharpUserControl.h"
#include "afxdialogex.h"


// CDialogForCSharpUserControl dialog

IMPLEMENT_DYNAMIC(CDialogForCSharpUserControl, CDialogEx)

CDialogForCSharpUserControl::CDialogForCSharpUserControl(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DIALOG_CSHARP_USERCONTROL1, pParent)
{

}

CDialogForCSharpUserControl::~CDialogForCSharpUserControl()
{
}

void CDialogForCSharpUserControl::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);

	DDX_ManagedControl(pDX, IDC_CSHARP_USER_CONTROL_PLACEHOLDER1, this->m_UserControl1);
}


BEGIN_MESSAGE_MAP(CDialogForCSharpUserControl, CDialogEx)
	ON_BN_CLICKED(IDOK, &CDialogForCSharpUserControl::OnBnClickedOk)
END_MESSAGE_MAP()


// CDialogForCSharpUserControl message handlers


void CDialogForCSharpUserControl::OnBnClickedOk()
{
	// TODO: Add your control notification handler code here
	CDialogEx::OnOK();
}
