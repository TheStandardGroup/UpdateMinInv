Public Class frmHelp

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = Color.FromArgb(28, 63, 119)
        lblInfo1.ForeColor = Color.White
        lblInfo2.ForeColor = Color.White
        lblInfo3.ForeColor = Color.White
        lblInfo4.ForeColor = Color.White
        btnOkay.BackColor = Color.FromArgb(231, 185, 1)
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Dispose()
    End Sub
End Class