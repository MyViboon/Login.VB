Public Class Form1
    Private Sub Save_B_Click(sender As Object, e As EventArgs) Handles Save_B.Click
        If UserFullname.Text = "" Then
            MsgBox("กรูณากรอกชื่อของท่าน", MsgBoxStyle.Critical)
            UserFullname.Focus()
            Exit Sub
        End If
        If Username.Text = "" Then
            MsgBox("กรูณากรอก User ของท่าน", MsgBoxStyle.Critical)
            Username.Focus()
            Exit Sub
        End If
        If UserPassword.Text = "" Then
            MsgBox("กรูณากรอกรหัสของท่าน", MsgBoxStyle.Critical)
            UserFullname.Focus()
            Exit Sub
        End If
        If Repassword.Text <> UserPassword.Text Then
            MsgBox("ยืนยันรหัสไม่ถูกต้อง", MsgBoxStyle.Critical)
            Repassword.Focus()
            Repassword.SelectAll()
            Exit Sub
        End If

        Dim checkuser As DataTable = executesql("SELECT User_Username FROM Tbl_UserLogin WHERE User_Username='" & Username.Text & "'")
        If checkuser.Rows.Count > 0 Then
            MsgBox("ชื่อ UserName นี้มีผู้ใช้งานแล้ว", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim Uconfirm As MsgBoxResult
        Uconfirm = MessageBox.Show("คุณต้องการบันทึกใช่หรือไม่", "CONFIRM ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Uconfirm = MsgBoxResult.Yes Then
            executesql("INSERT INTO Tbl_UserLogin(User_Fullname,User_Username,User_Password)VALUES('" & UserFullname.Text & "','" & Username.Text & "','" & UserPassword.Text & "')")
            MsgBox("คุณได้ทำการบันทึกแล้ว", MsgBoxStyle.Information)
            UserFullname.Clear()
            Username.Clear()
            UserPassword.Clear()
            Repassword.Clear()
        End If

        loaduserdata()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaduserdata()
    End Sub

    Private Sub loaduserdata()
        Dim LOADATA As DataTable = executesql("SELECT User_Fullname,User_Username FROM Tbl_UserLogin")
        DGV.DataSource = LOADATA
        DGV.Columns(0).HeaderText = "ชื่อผู้ใช้งาน"
        DGV.Columns(1).HeaderText = "ชื่อ UserName"
        DGV.Columns(0).Width = 120
        DGV.Columns(1).Width = 200
    End Sub

End Class
