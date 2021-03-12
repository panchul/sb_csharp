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
	, cpp_string_var(_T(""))
	, csharp_string_var(_T(""))
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
	DDX_Text(pDX, IDC_EDIT1, cpp_string_var);
	DDX_Text(pDX, IDC_EDIT2, csharp_string_var);
}


BEGIN_MESSAGE_MAP(CDialogForCSharpUserControl, CDialogEx)
	ON_BN_CLICKED(IDOK, &CDialogForCSharpUserControl::OnBnClickedOk)
	ON_BN_CLICKED(IDC_BUTTON1, &CDialogForCSharpUserControl::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CDialogForCSharpUserControl::OnBnClickedButton2)
END_MESSAGE_MAP()


// CDialogForCSharpUserControl message handlers

BOOL CDialogForCSharpUserControl::OnInitDialog()
{
	// Initialize before CDialogEx::OnInitDialog()
	this->m_StrText = L"value in c# control";
	//this->m_UserControl1;
	this->cpp_string_var = L"value in cpp control";

	CDialogEx::OnInitDialog();

	return TRUE;  // return TRUE unless you set the focus to a control
				  // EXCEPTION: OCX Property Pages should return FALSE
}

void CDialogForCSharpUserControl::OnBnClickedOk()
{
	CDialogEx::OnOK();
}

// C++ to C#
void CDialogForCSharpUserControl::OnBnClickedButton1()
{
	// we are typing into the edit box, which is this->cpp_string_var
	// and then want to see it in the C# controls (and in C# class)
		
	AfxMessageBox(L"Under Construction");
	// dialog -> member variables
	//WindowsFormsControlLibrary1::UserControl1^ hUserControl =
    //	this->m_UserControl1.GetControl();
	//
	//this->m_StrText = hUserControl->GetTextBox1()->Text;
}

// C# to C++
void CDialogForCSharpUserControl::OnBnClickedButton2()
{
	// we have it in the C# class,
	// we want to get it into this->csharp_string_var
		
	AfxMessageBox(L"Under Construction");
	// member variables -> dialog
	//WindowsFormsControlLibrary1::UserControl1^ hUserControl =
	//	this->m_UserControl1.GetControl();
	//
	//hUserControl->GetTextBox1()->Text = gcnew System::String(this->m_StrText);
}
