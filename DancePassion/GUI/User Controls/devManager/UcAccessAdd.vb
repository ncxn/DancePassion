﻿Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model

Public Class UcAccessAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Form action"
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub

    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub UpdateDB()
        Dim data As New Access With {
            .Access_name = TxtAccess_name.Text.ToString,
            .Access_desc = TxtAccess_desc.Text.ToString
        }
        If ClsAccess.GetInstance.Insert(data) Then

        End If
    End Sub
#End Region
End Class
