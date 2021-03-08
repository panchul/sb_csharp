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

	if (pDX->m_bSaveAndValidate)
	{
		// dialog -> member variables
		WindowsFormsControlLibrary1::UserControl1^ hUserControl =
			this->m_UserControl1.GetControl();

		this->m_StrText = hUserControl->GetTextBox1()->Text;
	}
	else
	{
		// member variables -> dialog
		WindowsFormsControlLibrary1::UserControl1^ hUserControl =
			this->m_UserControl1.GetControl();

		hUserControl->GetTextBox1()->Text = gcnew System::String(this->m_StrText);
	}
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


BOOL CDialogForCSharpUserControl::OnInitDialog()
{
	// Initialize before CDialogEx::OnInitDialog()
	this->m_StrText = L"something";
	//this->m_UserControl1;

	CDialogEx::OnInitDialog();

	// TODO:  Add extra initialization here

	return TRUE;  // return TRUE unless you set the focus to a control
				  // EXCEPTION: OCX Property Pages should return FALSE
}
