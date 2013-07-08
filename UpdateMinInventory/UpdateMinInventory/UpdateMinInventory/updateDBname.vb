Public Class frmDBname
    Dim myPar As frmMain
    Public Sub New(ByRef parent As frmMain)
        InitializeComponent()
        myPar = parent
        lblName.Text = dbName
        Me.BackColor = Color.FromArgb(28, 63, 119)
        lblCurrDb.ForeColor = Color.White
        lblName.ForeColor = Color.White
        lblNew.ForeColor = Color.White
        btnOk.BackColor = Color.FromArgb(231, 185, 1)

    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If tbNew.Text = "" Then
            MessageBox.Show("You must enter a new Database name")
        Else
            dbName = tbNew.Text
            Me.Dispose()
        End If
    End Sub
End Class