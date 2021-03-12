// CDialogForCSharpListUserControl.cpp : implementation file
//

#include "pch.h"
#include "MFCApplication1.h"
#include "CDialogForCSharpListUserControl.h"
#include "afxdialogex.h"


// CDialogForCSharpListUserControl dialog

IMPLEMENT_DYNAMIC(CDialogForCSharpListUserControl, CDialogEx)

CDialogForCSharpListUserControl::CDialogForCSharpListUserControl(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DIALOG_CSHARP_LIST, pParent)
{

}

CDialogForCSharpListUserControl::~CDialogForCSharpListUserControl()
{
}

void CDialogForCSharpListUserControl::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);

	DDX_ManagedControl(pDX, IDC_PLACEHOLDER_FOR_CSHARP_LIST, this->m_UserControl2);

}


BEGIN_MESSAGE_MAP(CDialogForCSharpListUserControl, CDialogEx)
	ON_BN_CLICKED(IDC_BUTTON_POPULATE_FROM_CPP, &CDialogForCSharpListUserControl::OnBnClickedButtonPopulateFromCpp)
END_MESSAGE_MAP()


// CDialogForCSharpListUserControl message handlers


void CDialogForCSharpListUserControl::OnBnClickedButtonPopulateFromCpp()
{
	WindowsFormsControlLibrary1::UserControl2^ hUserControl =
		this->m_UserControl2.GetControl();


	// TODO: fill it up
	
	hUserControl->GetListView1()->Text = gcnew System::String(L"something");

	
}
