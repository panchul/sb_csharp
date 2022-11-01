// This MFC Samples source code demonstrates using MFC Microsoft Office Fluent User Interface 
// (the "Fluent UI") and is provided only as referential material to supplement the 
// Microsoft Foundation Classes Reference and related electronic documentation 
// included with the MFC C++ library software.  
// License terms to copy, use or distribute the Fluent UI are available separately.  
// To learn more about our Fluent UI licensing program, please visit 
// http://go.microsoft.com/fwlink/?LinkId=238214.
//
// Copyright (C) Microsoft Corporation
// All rights reserved.

// MFCClientApplicationView.cpp : implementation of the CMFCClientApplicationView class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "MFCClientApplication.h"
#endif

#include "MFCClientApplicationDoc.h"
#include "MFCClientApplicationView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMFCClientApplicationView

IMPLEMENT_DYNCREATE(CMFCClientApplicationView, CFormView)

BEGIN_MESSAGE_MAP(CMFCClientApplicationView, CFormView)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// CMFCClientApplicationView construction/destruction

CMFCClientApplicationView::CMFCClientApplicationView()
	 : CFormView(IDD_MFCCLIENTAPPLICATION_FORM)
	 // : CFormView(IDD_DIALOG_WF_NAME)
{
	// ??? attach 
	// TODO: add construction code here

}

CMFCClientApplicationView::~CMFCClientApplicationView()
{
}

void CMFCClientApplicationView::DoDataExchange(CDataExchange* pDX)
{
	CFormView::DoDataExchange(pDX);

	
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

BOOL CMFCClientApplicationView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs
	this->m_StrName = L"this is in formview";
	
	return CFormView::PreCreateWindow(cs);
}

void CMFCClientApplicationView::OnInitialUpdate()
{
	this->m_StrName = L"this is in formview";

	CFormView::OnInitialUpdate();
	ResizeParentToFit();

}

void CMFCClientApplicationView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CMFCClientApplicationView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CMFCClientApplicationView diagnostics

#ifdef _DEBUG
void CMFCClientApplicationView::AssertValid() const
{
	CFormView::AssertValid();
}

void CMFCClientApplicationView::Dump(CDumpContext& dc) const
{
	CFormView::Dump(dc);
}

CMFCClientApplicationDoc* CMFCClientApplicationView::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMFCClientApplicationDoc)));
	return (CMFCClientApplicationDoc*)m_pDocument;
}
#endif //_DEBUG


// CMFCClientApplicationView message handlers
