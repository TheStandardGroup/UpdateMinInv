'File: frmMain.vb
'Purpose: User Interface for Minimum Inventory Updater
'Author: Matt Bachman, May 2013 for The Standard Group

Public Class frmMain
    Private ReadOnly updateAllDefault As Integer = 250
    'Dim dbName As String = "SGproving_dosrun"
    Private sConn As String
    Dim debtor As database
    Dim papsize As database
    Dim acNum As Int32

    'Constructs new frmMain
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        setSconnect()
        debtor = New database(sConn, "Debtor")
        papsize = New database(sConn, "PAPSIZE")
        Me.BackColor = Color.FromArgb(28, 63, 119)
        btnLoad.BackColor = Color.FromArgb(231, 185, 1)
        btnUpdate.BackColor = Color.FromArgb(231, 185, 1)
        cbUpdateAll.ForeColor = Color.White
        chbUpdateSelected.ForeColor = Color.White
        lblACNum.ForeColor = Color.White
        lblInformation.ForeColor = Color.White
        MenuStrip1.BackColor = Color.FromArgb(28, 63, 200)
    End Sub

    'Sets the connection string for the database
    Public Sub setSconnect()
        sConn = "Server=SGMISSQL;DataBase=" & dbName & "; Integrated Security=SSPI"
        
    End Sub

    'Updates the Information Label
    Private Sub updateLblInfo(ByVal val As String)
        lblInformation.Text = val

        lblInformation.Location = New Point((Me.Size.Width / 2) - (lblInformation.Size.Width / 2), lblInformation.Location.Y)
        Me.Update()
    End Sub

    'Updates the database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim res As DialogResult = MessageBox.Show("Are you sure you wish to update?", _
                                                  "Update", MessageBoxButtons.YesNo)
        If res = Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            updateLblInfo("Updating the PAPSIZE table")
            Dim mynum As Integer = -1
            If (chbUpdateSelected.Checked Or cbUpdateAll.Checked) Then
                Try
                    mynum = Convert.ToInt32(tbUpdateAll.Text)
                Catch ex As Exception
                    MessageBox.Show("Error! Enter a valid numeric number", "Error")
                End Try
            End If
            If cbUpdateAll.Checked Then
                papsize.updateAll(mynum)
                dgvTable.Update()
            ElseIf chbUpdateSelected.Checked Then
                Dim idxs() As Integer
                Dim i As Integer = 0
                Dim count As Integer = 0
                For Each dr As DataGridViewRow In dgvTable.Rows
                    If (dr.Selected) Then
                        If (count = 0) Then
                            ReDim Preserve idxs(1)
                            idxs(0) = i
                        Else
                            ReDim Preserve idxs(UBound(idxs) + 1)
                            idxs(count) = i
                        End If
                        count += 1
                    End If
                    i += 1
                Next
                If count > 0 Then
                    papsize.updateSome(mynum, idxs)

                    papsize.updateTable(acNum, "[CREDITOR RECNUM]")
                    updateLblInfo("PAPSIZE table updated")
                Else
                    MessageBox.Show("You must select the rows you wish to updated", "Error")
                    updateLblInfo("ERROR updateing PAPSIZE table")
                End If
            End If
                Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Loads information from the database based on the account number
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim worked As Boolean = True
        'Dim acNum As Int32
        Try
            acNum = Convert.ToInt32(tbAccNum.Text)
        Catch ex As Exception
            MessageBox.Show("Error! Enter a numeric Account Number", "Error")
            worked = False
        End Try
        If worked Then
            updateLblInfo("Loading Information From Database")
            Me.Cursor = Cursors.WaitCursor
            Dim myQuery As String = "SELECT [DATAFLEX RECNUM ONE] FROM [SGLive_dosrun].[dbo].[DEBTOR] WHERE [AC NO]= '" _
                                    & acNum & "'"
            If debtor.retrieveData(myQuery) Then
                acNum = debtor.getCode()
                myQuery = "SELECT * FROM " & papsize.Name & " " _
                                        & "WHERE [CREDITOR RECNUM] = '" & acNum & "' ORDER BY CODE"
                papsize.retrieveData(myQuery)
                dgvTable.DataSource = papsize.getDataTable()

                setVisibleFields()
                btnUpdate.Enabled = True
                maLoad.Enabled = False
                maUpdate.Enabled = True
                btnLoad.Enabled = False
                updateLblInfo("Table Loaded")
                'papsize.MessageBoxRow()
            Else
                updateLblInfo("Error Loading Information from the Database")
            End If
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Sets only the columns we want to visible
    Private Sub setVisibleFields()
        Dim i As Integer = 0
        While (i < dgvTable.Columns.Count)
            If (Not dgvTable.Columns(i).Name = "CODE") Then
                If (Not dgvTable.Columns(i).Name = "INVENTORY CODE") Then
                    If (Not dgvTable.Columns(i).Name = "MIN LEVEL") Then
                        dgvTable.Columns(i).Visible = False
                    End If
                Else
                    dgvTable.Columns(i).ReadOnly = True
                End If
            Else
                dgvTable.Columns(i).ReadOnly = True
            End If
            i += 1
        End While
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUpdate.Enabled = False
    End Sub

    'resets the form
    Private Sub mfReset_Click(sender As Object, e As EventArgs) Handles mfReset.Click
        btnUpdate.Enabled = False
        btnLoad.Enabled = True
        maLoad.Enabled = True
        maUpdate.Enabled = True
        tbAccNum.Text = ""
        updateLblInfo("")
    End Sub

    'Exits
    Private Sub mExit_Click(sender As Object, e As EventArgs) Handles mExit.Click
        Me.Dispose()
    End Sub

    'Exits
    Private Sub mfQuit_Click(sender As Object, e As EventArgs) Handles mfQuit.Click
        Me.Dispose()
    End Sub

    'When cbUpdateAll is checked or unchecked updates the form accordingly
    Private Sub cbUpdateAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbUpdateAll.CheckedChanged
        'If cbUpdateAll.Checked Then
        '    tbUpdateAll.Text = updateAllDefault
        '    tbUpdateAll.Enabled = True
        '    chbUpdateSelected.Checked = False
        'ElseIf Not chbUpdateSelected.Checked Then
        '    tbUpdateAll.Text = ""
        '    tbUpdateAll.Enabled = False
        'End If
        updateCheckBoxes(cbUpdateAll, chbUpdateSelected)
    End Sub

    Private Sub updateCheckBoxes(ByRef box1 As CheckBox, ByRef box2 As CheckBox)
        If box1.Checked Then
            tbUpdateAll.Text = updateAllDefault
            tbUpdateAll.Enabled = True
            box2.Checked = False
        ElseIf Not box2.Checked Then
            tbUpdateAll.Text = ""
            tbUpdateAll.Enabled = False
        End If
    End Sub

    'Loads data from the database
    Private Sub maLoad_Click(sender As Object, e As EventArgs) Handles maLoad.Click
        btnLoad_Click(sender, e)
    End Sub

    'Updates the table
    Private Sub maUpdate_Click(sender As Object, e As EventArgs) Handles maUpdate.Click
        btnUpdate_Click(sender, e)
    End Sub

    'Changes db name
    Private Sub maChangeDB_Click(sender As Object, e As EventArgs) Handles maChangeDB.Click
        mfReset_Click(sender, e)
        Dim newForm As New frmDBname(Me)
        newForm.ShowDialog()
        setSconnect()
        'DEBUGMessageBox.Show(sConn)

        debtor.setSconn = sConn
        papsize.setSconn = sConn
    End Sub


    Private Sub tbAccNum_KeyDown(sender As Object, e As KeyEventArgs) Handles tbAccNum.KeyDown
        If (e.KeyCode = Keys.Enter And btnLoad.Enabled = True) Then
            btnLoad_Click(sender, e)
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim frm As New frmHelp
        frm.ShowDialog()
    End Sub

    Private Sub chbUpdateSelected_CheckedChanged(sender As Object, e As EventArgs) Handles chbUpdateSelected.CheckedChanged
        updateCheckBoxes(chbUpdateSelected, cbUpdateAll)
    End Sub
End Class
