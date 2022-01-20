<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.UserPassword = New System.Windows.Forms.TextBox()
        Me.Repassword = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.UserFullname = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Save_B = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserPassword
        '
        Me.UserPassword.Location = New System.Drawing.Point(97, 74)
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.Size = New System.Drawing.Size(260, 20)
        Me.UserPassword.TabIndex = 2
        Me.UserPassword.UseSystemPasswordChar = True
        '
        'Repassword
        '
        Me.Repassword.Location = New System.Drawing.Point(97, 100)
        Me.Repassword.Name = "Repassword"
        Me.Repassword.Size = New System.Drawing.Size(260, 20)
        Me.Repassword.TabIndex = 3
        Me.Repassword.UseSystemPasswordChar = True
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(97, 48)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(261, 20)
        Me.Username.TabIndex = 1
        '
        'UserFullname
        '
        Me.UserFullname.Location = New System.Drawing.Point(97, 22)
        Me.UserFullname.Name = "UserFullname"
        Me.UserFullname.Size = New System.Drawing.Size(261, 20)
        Me.UserFullname.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 132)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(346, 220)
        Me.DGV.TabIndex = 4
        '
        'Save_B
        '
        Me.Save_B.Location = New System.Drawing.Point(377, 306)
        Me.Save_B.Name = "Save_B"
        Me.Save_B.Size = New System.Drawing.Size(88, 46)
        Me.Save_B.TabIndex = 5
        Me.Save_B.Text = "บันทึกข้อมูล"
        Me.Save_B.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RePassword :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "UserName :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ชื่อผู้ใช้งาน :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 364)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Save_B)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.UserFullname)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Repassword)
        Me.Controls.Add(Me.UserPassword)
        Me.Name = "Form1"
        Me.Text = "เพิ่มข้อมูลผู้ใช้งาน"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserPassword As TextBox
    Friend WithEvents Repassword As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents UserFullname As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Save_B As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
