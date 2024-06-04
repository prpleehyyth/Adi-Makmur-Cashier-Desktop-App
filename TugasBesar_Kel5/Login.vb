Imports MySql.Data.MySqlClient
Public Class Login
    Dim id_user As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        Me.AcceptButton = ButtonLogin
    End Sub


    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If tbxUsername IsNot Nothing And tbxPassword IsNot Nothing Then
            ds.Clear()
            da = New MySqlDataAdapter("select * from tbl_user where username='" & tbxUsername.Text & "' AND password='" & tbxPassword.Text & "';", conn)
            da.Fill(ds, "user")
            If ds.Tables("user").Rows.Count > 0 Then
                Me.Hide()
                ShowSelectedForm()
                Logout()
            Else
                MessageBox.Show("Invalid Username or Password")
            End If
        End If
    End Sub

    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSignUp.LinkClicked
        Transisi.HideSync(PanelSignIn)
        Transisi.ShowSync(PanelSignUP)
    End Sub

    Private Sub linkSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignIn.LinkClicked
        Transisi.HideSync(PanelSignUP)
        Transisi.ShowSync(PanelSignIn)
    End Sub

    Private Sub buttonSignUp_Click(sender As Object, e As EventArgs) Handles buttonSignUp.Click
        If tbxUsernameSU IsNot Nothing And tbxPassword2 IsNot Nothing And cbxRoleSU IsNot Nothing Then
            Dim kode As String
            Dim role As String = cbxRoleSU.Text
            If role = "Admin" Then
                kode = "ADM"
            ElseIf role = "Cashier" Then
                kode = "CSR"
            ElseIf role = "Owner" Then
                kode = "OWN"
            End If
            ds.Clear()
            da = New MySqlDataAdapter("Select CASE WHEN MAX(CAST(SUBSTRING(id_user, 4, 3) AS UNSIGNED)) IS NULL THEN '" & kode & "001'
                                       ELSE CONCAT('" & kode & "',LPAD(MAX(CAST(SUBSTRING(id_user, 4, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor
                                       FROM tbl_user
                                       WHERE id_user LIKE '" & kode & "%';", conn)
            da.Fill(ds, "user")
            id_user = ds.Tables("user").Rows(0).Item(0).ToString

            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_user Values(?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_user", id_user)
            da.SelectCommand.Parameters.AddWithValue("username", tbxUsernameSU.Text)
            da.SelectCommand.Parameters.AddWithValue("password", tbxPassword2.Text)
            da.SelectCommand.Parameters.AddWithValue("role", cbxRoleSU.Text)
            da.Fill(ds, "xxx")

            Transisi.HideSync(PanelSignUP)
            Transisi.ShowSync(PanelSignIn)
        End If
    End Sub
    Private Sub ShowSelectedForm()
        Dim selectedForm As String = ds.Tables("user").Rows(0).Item(3).ToString()
        If selectedForm = "Cashier" Then
            Dim formA As New HomepageCashier()
            formA.tbxUser.Text = tbxUsername.Text
            formA.Show()
            Me.Hide()
        ElseIf selectedForm = "Admin" Then
            Dim formB As New HomepageAdmin()
            formB.tbxUser.Text = tbxUsername.Text
            formB.Show()
            Me.Hide()
        ElseIf selectedForm = "Owner" Then
            Dim formC As New HomepageOwner()
            formC.tbxUser.Text = tbxUsername.Text
            formC.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Logout()
        ' Reset the login state
        tbxUsername.Text = String.Empty
        tbxPassword.Text = String.Empty



    End Sub


End Class