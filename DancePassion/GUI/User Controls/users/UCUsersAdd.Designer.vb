﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcUsersAdd
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UCBase
    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUserPass = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUserFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUserLastName = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUserEmail = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtUserName)
        Me.LayoutControl1.Controls.Add(Me.TxtUserPass)
        Me.LayoutControl1.Controls.Add(Me.TxtUserFirstName)
        Me.LayoutControl1.Controls.Add(Me.TxtUserLastName)
        Me.LayoutControl1.Controls.Add(Me.TxtUserEmail)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(624, 42, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(592, 219)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(108, 12)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(455, 40)
        Me.TxtUserName.StyleController = Me.LayoutControl1
        Me.TxtUserName.TabIndex = 4
        '
        'TxtUserPass
        '
        Me.TxtUserPass.Location = New System.Drawing.Point(108, 56)
        Me.TxtUserPass.Name = "TxtUserPass"
        Me.TxtUserPass.Properties.UseSystemPasswordChar = True
        Me.TxtUserPass.Size = New System.Drawing.Size(455, 40)
        Me.TxtUserPass.StyleController = Me.LayoutControl1
        Me.TxtUserPass.TabIndex = 5
        '
        'TxtUserFirstName
        '
        Me.TxtUserFirstName.Location = New System.Drawing.Point(108, 100)
        Me.TxtUserFirstName.Name = "TxtUserFirstName"
        Me.TxtUserFirstName.Size = New System.Drawing.Size(455, 40)
        Me.TxtUserFirstName.StyleController = Me.LayoutControl1
        Me.TxtUserFirstName.TabIndex = 6
        '
        'TxtUserLastName
        '
        Me.TxtUserLastName.Location = New System.Drawing.Point(108, 144)
        Me.TxtUserLastName.Name = "TxtUserLastName"
        Me.TxtUserLastName.Size = New System.Drawing.Size(455, 40)
        Me.TxtUserLastName.StyleController = Me.LayoutControl1
        Me.TxtUserLastName.TabIndex = 7
        '
        'TxtUserEmail
        '
        Me.TxtUserEmail.Location = New System.Drawing.Point(108, 188)
        Me.TxtUserEmail.Name = "TxtUserEmail"
        Me.TxtUserEmail.Size = New System.Drawing.Size(455, 40)
        Me.TxtUserEmail.StyleController = Me.LayoutControl1
        Me.TxtUserEmail.TabIndex = 8
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(575, 250)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtUserName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem1.Text = "Tên đăng nhập"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(93, 17)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 220)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(555, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtUserPass
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem2.Text = "Mật khẩu"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 17)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtUserFirstName
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 88)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem3.Text = "Họ"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 17)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtUserLastName
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 132)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem4.Text = "Tên"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(93, 17)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtUserEmail
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 176)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem5.Text = "Email"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(93, 17)
        '
        'UCUsersAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcUsersAdd"
        Me.Size = New System.Drawing.Size(592, 458)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUserPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUserFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUserLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUserEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
