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
            UserFullname.Focus()
            Exit Sub
        End If

        executesql("INSERT INTO Tbl_UserLogin(User_Fullname,User_Username,User_Password)VALUES('" & UserFullname.Text & "','" & Username.Text & "','" & UserPassword.Text & "')")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
