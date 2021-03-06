﻿Imports VTNcoLtd.Model
Imports VTNcoLtd.BUS
Imports VTNcoLtd.DevExpressHelper

Public Class UcCustomer_Update

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Properties"
    Private _Cmodel As Customer
    Private _Customer_Group As CustomerGroupCollection

    Public Property Cmodel As Customer
        Get
            Return _Cmodel
        End Get
        Set(value As Customer)
            _Cmodel = value
        End Set
    End Property

    Public Property Customer_Group As CustomerGroupCollection
        Get
            Return _Customer_Group
        End Get
        Set(value As CustomerGroupCollection)
            _Customer_Group = value
        End Set
    End Property

#End Region

#Region " Form"

    Sub LoadData() Handles Me.Load
        TxtCustomer_Name.Text = Cmodel.Customer_Name
        TxtCustomer_Addresss.Text = Cmodel.Customer_Address
        TxtCustomer_Phone.Text = Cmodel.Customer_Phone
        TxtCustomer_Email.Text = Cmodel.Customer_Email
        TxtCustomer_Group_Id.EditValue = Cmodel.Customer_Group_Id

        'Add Search lookup
        SearchLookup()
    End Sub

    Sub OK() Handles BtnOK.ItemClick
        Dim handle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(Me)
        Try
            If ClsCustomers.GetInstance.Update(GetModel()) Then
                Cancel()
            End If
        Catch ex As Exception
            ShowMessage.GetInstance.ShowError(ex.Message)
        Finally
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseOverlayForm(handle)
        End Try
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Function ValidateInput() As Boolean
        Return Not String.IsNullOrEmpty(TxtCustomer_Name.Text)
    End Function

    Private Function GetModel() As Customer

        Dim Model As New Customer

        If ValidateInput() Then
            With Model
                .Customer_Id = Cmodel.Customer_Id
                .Customer_Name = TxtCustomer_Name.Text
                .Customer_Address = TxtCustomer_Addresss.Text
                .Customer_Phone = TxtCustomer_Phone.Text
                .Customer_Email = TxtCustomer_Email.Text
                .Customer_Group_Id = TxtCustomer_Group_Id.EditValue
                .Customer_Expand_Info_Id = Nothing
            End With
        End If

        Return Model
    End Function

    Sub SearchLookup()
        TxtCustomer_Group_Id.Properties.DataSource = Customer_Group
        TxtCustomer_Group_Id.Properties.ValueMember = "Customer_group_id"
        TxtCustomer_Group_Id.Properties.DisplayMember = "Customer_group_name"
        TxtCustomer_Group_Id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        TxtCustomer_Group_Id.Properties.PopulateViewColumns()
        TxtCustomer_Group_Id.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_id").Width = 50
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_parent").Visible = False
    End Sub

#End Region

End Class
