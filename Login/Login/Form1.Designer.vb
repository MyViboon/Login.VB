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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Save_B = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserPassword
        '
        Me.UserPassword.Location = New System.Drawing.Point(140, 83)
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.Size = New System.Drawing.Size(209, 20)
        Me.UserPassword.TabIndex = 2
        Me.UserPassword.UseSystemPasswordChar = True
        '
        'Repassword
        '
        Me.Repassword.Location = New System.Drawing.Point(140, 109)
        Me.Repassword.Name = "Repassword"
        Me.Repassword.Size = New System.Drawing.Size(209, 20)
        Me.Repassword.TabIndex = 3
        Me.Repassword.UseSystemPasswordChar = True
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(140, 57)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(210, 20)
        Me.Username.TabIndex = 1
        '
        'UserFullname
        '
        Me.UserFullname.Location = New System.Drawing.Point(140, 31)
        Me.UserFullname.Name = "UserFullname"
        Me.UserFullname.Size = New System.Drawing.Size(210, 20)
        Me.UserFullname.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(337, 195)
        Me.DataGridView1.TabIndex = 4
        '
        'Save_B
        '
        Me.Save_B.Location = New System.Drawing.Point(367, 306)
        Me.Save_B.Name = "Save_B"
        Me.Save_B.Size = New System.Drawing.Size(88, 46)
        Me.Save_B.TabIndex = 5
        Me.Save_B.Text = "บันทึกข้อมูล"
        Me.Save_B.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RePassword :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "UserName :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ชื่อผู้ใช้งาน :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 364)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Save_B)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UserFullname)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Repassword)
        Me.Controls.Add(Me.UserPassword)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserPassword As TextBox
    Friend WithEvents Repassword As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents UserFullname As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Save_B As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
