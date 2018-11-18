Public Class Login

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = ("admin") Then
            AdminPassword.show()
            Me.Hide()
        End If
        If TextBox1.Text = ("guest") Then
            MsgBox("Hello Guest")
        End If
        If TextBox1.Text = ("Guest") Then
            MsgBox("Hello Guest")
        End If
    End Sub
End Class
