Public Class BusinessCenter

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams

        Get

            Dim cp As CreateParams = MyBase.CreateParams

            cp.ExStyle = cp.ExStyle Or 33554432

            Return cp

        End Get

    End Property

    Private Sub BusinessCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginShow()
    End Sub

    Sub LoginShow()
        FormLogin.TopLevel = False
        Panel1.Controls.Add(FormLogin)
        FormLogin.Show()
    End Sub

    Sub HomeShow()
        FormHome.TopLevel = False
        Panel1.Controls.Add(FormHome)
        FormHome.Show()
    End Sub

    Sub RegisterShow()
        FormRegister.TopLevel = False
        Panel1.Controls.Add(FormRegister)
        FormRegister.Show()
    End Sub

    Sub ClearPanel(frm As Form)
        Panel1.Controls.Clear()
        frm.Close()
    End Sub

End Class