﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcEvents_Add
    'Inherits System.Windows.Forms.UserControl
    Inherits UcBase
    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TxtEvent_Name = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TxtEvent_Participant_Max = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TxtEvent_End_Date = New DevExpress.XtraEditors.DateEdit()
        Me.TxtEvent_Start_Date = New DevExpress.XtraEditors.DateEdit()
        Me.TxtEvent_Type_Id = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEvent_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEvent_Participant_Max.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEvent_End_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEvent_End_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEvent_Start_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEvent_Start_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEvent_Type_Id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 450)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtEvent_Name)
        Me.LayoutControl1.Controls.Add(Me.TxtEvent_Participant_Max)
        Me.LayoutControl1.Controls.Add(Me.TxtEvent_End_Date)
        Me.LayoutControl1.Controls.Add(Me.TxtEvent_Start_Date)
        Me.LayoutControl1.Controls.Add(Me.TxtEvent_Type_Id)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(724, 211)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(707, 240)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtEvent_Type_Id
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem1.Text = "Loại sự kiện"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 17)
        '
        'TxtEvent_Name
        '
        Me.TxtEvent_Name.Location = New System.Drawing.Point(106, 27)
        Me.TxtEvent_Name.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtEvent_Name.Name = "TxtEvent_Name"
        Me.TxtEvent_Name.Size = New System.Drawing.Size(589, 40)
        Me.TxtEvent_Name.StyleController = Me.LayoutControl1
        Me.TxtEvent_Name.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtEvent_Name
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem2.Text = "Tên sự kiện"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(82, 17)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtEvent_Start_Date
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 88)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem3.Text = "Ngày bắt đầu"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(82, 17)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtEvent_End_Date
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 132)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem4.Text = "Ngày kết thúc"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(82, 17)
        '
        'TxtEvent_Participant_Max
        '
        Me.TxtEvent_Participant_Max.Location = New System.Drawing.Point(106, 159)
        Me.TxtEvent_Participant_Max.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtEvent_Participant_Max.Name = "TxtEvent_Participant_Max"
        Me.TxtEvent_Participant_Max.Size = New System.Drawing.Size(589, 40)
        Me.TxtEvent_Participant_Max.StyleController = Me.LayoutControl1
        Me.TxtEvent_Participant_Max.TabIndex = 8
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtEvent_Participant_Max
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 176)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem5.Text = "Khách dự kiến"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(82, 17)
        '
        'TxtEvent_End_Date
        '
        Me.TxtEvent_End_Date.EditValue = Nothing
        Me.TxtEvent_End_Date.Location = New System.Drawing.Point(106, 115)
        Me.TxtEvent_End_Date.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtEvent_End_Date.Name = "TxtEvent_End_Date"
        Me.TxtEvent_End_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEvent_End_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEvent_End_Date.Properties.DisplayFormat.FormatString = ""
        Me.TxtEvent_End_Date.Properties.EditFormat.FormatString = ""
        Me.TxtEvent_End_Date.Properties.Mask.EditMask = ""
        Me.TxtEvent_End_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtEvent_End_Date.Size = New System.Drawing.Size(589, 40)
        Me.TxtEvent_End_Date.StyleController = Me.LayoutControl1
        Me.TxtEvent_End_Date.TabIndex = 7
        '
        'TxtEvent_Start_Date
        '
        Me.TxtEvent_Start_Date.EditValue = Nothing
        Me.TxtEvent_Start_Date.Location = New System.Drawing.Point(106, 71)
        Me.TxtEvent_Start_Date.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtEvent_Start_Date.Name = "TxtEvent_Start_Date"
        Me.TxtEvent_Start_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEvent_Start_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEvent_Start_Date.Properties.DisplayFormat.FormatString = ""
        Me.TxtEvent_Start_Date.Properties.EditFormat.FormatString = ""
        Me.TxtEvent_Start_Date.Properties.Mask.EditMask = ""
        Me.TxtEvent_Start_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtEvent_Start_Date.Size = New System.Drawing.Size(589, 40)
        Me.TxtEvent_Start_Date.StyleController = Me.LayoutControl1
        Me.TxtEvent_Start_Date.TabIndex = 6
        '
        'TxtEvent_Type_Id
        '
        Me.TxtEvent_Type_Id.Location = New System.Drawing.Point(106, -17)
        Me.TxtEvent_Type_Id.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtEvent_Type_Id.Name = "TxtEvent_Type_Id"
        Me.TxtEvent_Type_Id.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEvent_Type_Id.Properties.NullText = ""
        Me.TxtEvent_Type_Id.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.TxtEvent_Type_Id.Size = New System.Drawing.Size(589, 40)
        Me.TxtEvent_Type_Id.StyleController = Me.LayoutControl1
        Me.TxtEvent_Type_Id.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'UcEvents_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcEvents_Add"
        Me.Size = New System.Drawing.Size(724, 490)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEvent_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEvent_Participant_Max.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEvent_End_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEvent_End_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEvent_Start_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEvent_Start_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEvent_Type_Id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtEvent_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEvent_Participant_Max As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEvent_End_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtEvent_Start_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtEvent_Type_Id As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
