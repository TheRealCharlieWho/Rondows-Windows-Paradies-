Public Class AdminPassword

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = ("roblox") Then
            Desktop.show()
            Me.Hide()
        Else
            MsgBox("You Have Entered The Wrong Password")
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class