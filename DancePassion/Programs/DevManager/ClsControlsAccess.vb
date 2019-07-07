﻿Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

#Region " DTO Controls Access of form"
'table controlsAccess
Public Class ControlsAccessDTO
    Private _controls_name As String
    Private _access_name As String

    Public Property Controls_name As String
        Get
            Return _controls_name
        End Get
        Set(value As String)
            _controls_name = value
        End Set
    End Property

    Public Property Access_name As String
        Get
            Return _access_name
        End Get
        Set(value As String)
            _access_name = value
        End Set
    End Property
End Class

#End Region

#Region " Controls Access Collection"
''' <summary>
''' Return The list acction for each controls, ex : {(ctr1,edit),(ctr1,create),(ctr2,delete)}
''' </summary>
Public Class ControlsAccessCollection
    Inherits List(Of ControlsAccessDTO)
End Class
#End Region

#Region " Controls Access Status"
Public Enum ControlsAccess_status
    C_TRUE = 1
    C_FALSE = 0
End Enum
#End Region

#Region " Data Access for controls Access"
Public Class ClsControlsAccess
    Private Shared Singleton As ClsControlsAccess
    Public Shared Function GetInstance() As ClsControlsAccess
        If Singleton Is Nothing Then
            Singleton = New ClsControlsAccess()
        End If
        Return Singleton
    End Function
    Public Function GetDataTable() As DataTable
        Dim dtControlsAccess As DataTable = DBHelper.GetInstance.GetDataTable("procGetAllControlsAccess", CommandType.StoredProcedure)
        Return dtControlsAccess
    End Function

    Public Function GetList() As ControlsAccessCollection
        Dim ControlsAccessList As New ControlsAccessCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procGetAllControlsAccess", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objControlsAccess As New ControlsAccessDTO With {
                .Controls_name = Reader(0).ToString(),
                .Access_name = Reader(1).ToString()
            }
            ControlsAccessList.Add(objControlsAccess)
        End While
        Reader.Close()

        Return ControlsAccessList

    End Function
    ''' <summary>
    ''' Return acction for each controls, ex : UCUsers{View, Create, Edit, Delele, Print,...on so}
    ''' </summary>
    Public Function GetAccessByControls(Controls_name As String, ControlsAccessList As ControlsAccessCollection) As List(Of String)

        Dim ObjAccess As New List(Of String)

        For Each Control In ControlsAccessList
            If Control.Controls_name.ToString = Controls_name Then
                ObjAccess.Add(Control.Access_name.ToString)
            End If
        Next

        Return ObjAccess

    End Function

    '''' <summary>
    '''' Return acction for each controls with desc , ex : UCUsers{(View,"Truy cập") , (Create,"Tạo mới"), (Edit,"Sửa")} 
    '''' </summary>
    Public Function GetAccessByControlsWithDesc(Controls_name As String, ControlsAccessList As ControlsAccessCollection, ObjAccess As AccessCollection)
        Dim ObjRS = (From ca In ControlsAccessList
                     Join a In ObjAccess On ca.Access_name Equals a.Access_name
                     Where ca.Controls_name = Controls_name
                     Select New With
                      {
                      ca.Access_name,
                      a.Access_desc
                      }).ToList()
        Return ObjRS
    End Function


    Public Function Insert(ControlsAccess As ControlsAccessDTO) As Boolean
        Dim strSQL = "procInsertControlsAccess"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_controls_name", ControlsAccess.Controls_name),
            New MySqlParameter("@p_access_name", ControlsAccess.Access_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
    Public Function Update(ControlsAccess As ControlsAccessDTO) As Boolean
        Dim strSQL = "procUpdateControlsAccess"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_controls_name", ControlsAccess.Controls_name),
            New MySqlParameter("@p_access_name", ControlsAccess.Access_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

End Class
#End Region