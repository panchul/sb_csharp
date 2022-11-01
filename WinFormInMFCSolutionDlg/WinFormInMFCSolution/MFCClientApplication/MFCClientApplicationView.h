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

// MFCClientApplicationView.h : interface of the CMFCClientApplicationView class
//

#pragma once


class CMFCClientApplicationView : public CFormView
{
protected: // create from serialization only
	CMFCClientApplicationView();
	DECLARE_DYNCREATE(CMFCClientApplicationView)

public:
#ifdef AFX_DESIGN_TIME
	enum{ IDD = IDD_MFCCLIENTAPPLICATION_FORM };
#endif

// Attributes
public:
	CMFCClientApplicationDoc* GetDocument() const;

// Operations
public:

// Overrides
public:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual void OnInitialUpdate(); // called first time after construct

// Implementation
public:
	virtual ~CMFCClientApplicationView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in MFCClientApplicationView.cpp
inline CMFCClientApplicationDoc* CMFCClientApplicationView::GetDocument() const
   { return reinterpret_cast<CMFCClientApplicationDoc*>(m_pDocument); }
#endif

