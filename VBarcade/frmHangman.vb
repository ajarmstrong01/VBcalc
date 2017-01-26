Public Class frmHangman
    Private Sub exitGame(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub startGame(sender As Object, e As EventArgs) Handles btnStart.Click
        btnClose.Hide()
        btnStart.Hide()
        lblTitle.Hide()
    End Sub
End Class