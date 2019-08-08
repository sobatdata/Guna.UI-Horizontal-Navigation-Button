Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnBody, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
    End Sub

    Private Sub nav_history_CheckedChanged(sender As Object, e As EventArgs) Handles nav_history.CheckedChanged
        If nav_history.Checked Then
            pn_history.BringToFront()
        End If
    End Sub

    Private Sub nav_home_CheckedChanged(sender As Object, e As EventArgs) Handles nav_home.CheckedChanged
        If nav_home.Checked Then
            pn_home.BringToFront()
        End If
    End Sub

    Private Sub nav_profile_CheckedChanged(sender As Object, e As EventArgs) Handles nav_profile.CheckedChanged
        If nav_profile.Checked Then
            pn_profile.BringToFront()
        End If
    End Sub

    Private Sub nav_settings_CheckedChanged(sender As Object, e As EventArgs) Handles nav_settings.CheckedChanged
        If nav_settings.Checked Then
            pn_settings.BringToFront()
        End If
    End Sub
End Class
