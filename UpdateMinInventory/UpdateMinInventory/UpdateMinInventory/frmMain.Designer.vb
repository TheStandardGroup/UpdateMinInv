<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblACNum = New System.Windows.Forms.Label()
        Me.tbAccNum = New System.Windows.Forms.TextBox()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mfReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mfQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.maChangeDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.maLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.maUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbUpdateAll = New System.Windows.Forms.TextBox()
        Me.cbUpdateAll = New System.Windows.Forms.CheckBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.chbUpdateSelected = New System.Windows.Forms.CheckBox()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblACNum
        '
        Me.lblACNum.AutoSize = True
        Me.lblACNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACNum.Location = New System.Drawing.Point(24, 38)
        Me.lblACNum.Name = "lblACNum"
        Me.lblACNum.Size = New System.Drawing.Size(113, 17)
        Me.lblACNum.TabIndex = 0
        Me.lblACNum.Text = "Account Number"
        '
        'tbAccNum
        '
        Me.tbAccNum.Location = New System.Drawing.Point(143, 35)
        Me.tbAccNum.Name = "tbAccNum"
        Me.tbAccNum.Size = New System.Drawing.Size(100, 20)
        Me.tbAccNum.TabIndex = 1
        '
        'dgvTable
        '
        Me.dgvTable.AllowUserToAddRows = False
        Me.dgvTable.AllowUserToDeleteRows = False
        Me.dgvTable.AllowUserToResizeColumns = False
        Me.dgvTable.AllowUserToResizeRows = False
        Me.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTable.Location = New System.Drawing.Point(27, 75)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(444, 339)
        Me.dgvTable.TabIndex = 2
        '
        'btnLoad
        '
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Location = New System.Drawing.Point(373, 35)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Location = New System.Drawing.Point(373, 437)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mFile, Me.ActionToolStripMenuItem, Me.HelpToolStripMenuItem, Me.mExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(501, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mFile
        '
        Me.mFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mfReset, Me.mfQuit})
        Me.mFile.Name = "mFile"
        Me.mFile.Size = New System.Drawing.Size(37, 20)
        Me.mFile.Text = "&File"
        '
        'mfReset
        '
        Me.mfReset.Name = "mfReset"
        Me.mfReset.Size = New System.Drawing.Size(102, 22)
        Me.mfReset.Text = "&Reset"
        '
        'mfQuit
        '
        Me.mfQuit.Name = "mfQuit"
        Me.mfQuit.Size = New System.Drawing.Size(102, 22)
        Me.mfQuit.Text = "&Quit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.maChangeDB, Me.maLoad, Me.maUpdate})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "&Action"
        '
        'maChangeDB
        '
        Me.maChangeDB.Name = "maChangeDB"
        Me.maChangeDB.Size = New System.Drawing.Size(166, 22)
        Me.maChangeDB.Text = "Change Database"
        '
        'maLoad
        '
        Me.maLoad.Name = "maLoad"
        Me.maLoad.Size = New System.Drawing.Size(166, 22)
        Me.maLoad.Text = "&Load"
        '
        'maUpdate
        '
        Me.maUpdate.Enabled = False
        Me.maUpdate.Name = "maUpdate"
        Me.maUpdate.Size = New System.Drawing.Size(166, 22)
        Me.maUpdate.Text = "&Update"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mExit
        '
        Me.mExit.Name = "mExit"
        Me.mExit.Size = New System.Drawing.Size(37, 20)
        Me.mExit.Text = "&Exit"
        '
        'tbUpdateAll
        '
        Me.tbUpdateAll.Enabled = False
        Me.tbUpdateAll.Location = New System.Drawing.Point(27, 439)
        Me.tbUpdateAll.Name = "tbUpdateAll"
        Me.tbUpdateAll.Size = New System.Drawing.Size(53, 20)
        Me.tbUpdateAll.TabIndex = 6
        '
        'cbUpdateAll
        '
        Me.cbUpdateAll.AutoSize = True
        Me.cbUpdateAll.Location = New System.Drawing.Point(86, 420)
        Me.cbUpdateAll.Name = "cbUpdateAll"
        Me.cbUpdateAll.Size = New System.Drawing.Size(75, 17)
        Me.cbUpdateAll.TabIndex = 7
        Me.cbUpdateAll.Text = "Update All"
        Me.cbUpdateAll.UseVisualStyleBackColor = True
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Location = New System.Drawing.Point(215, 467)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(0, 13)
        Me.lblInformation.TabIndex = 8
        '
        'chbUpdateSelected
        '
        Me.chbUpdateSelected.AutoSize = True
        Me.chbUpdateSelected.Location = New System.Drawing.Point(86, 441)
        Me.chbUpdateSelected.Name = "chbUpdateSelected"
        Me.chbUpdateSelected.Size = New System.Drawing.Size(106, 17)
        Me.chbUpdateSelected.TabIndex = 9
        Me.chbUpdateSelected.Text = "Update Selected"
        Me.chbUpdateSelected.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 489)
        Me.Controls.Add(Me.chbUpdateSelected)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.cbUpdateAll)
        Me.Controls.Add(Me.tbUpdateAll)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.tbAccNum)
        Me.Controls.Add(Me.lblACNum)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Update Inventory"
        CType(Me.dgvTable,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblACNum As System.Windows.Forms.Label
    Friend WithEvents tbAccNum As System.Windows.Forms.TextBox
    Friend WithEvents dgvTable As System.Windows.Forms.DataGridView
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mfReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mfQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbUpdateAll As System.Windows.Forms.TextBox
    Friend WithEvents cbUpdateAll As System.Windows.Forms.CheckBox
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents maChangeDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents maLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents maUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chbUpdateSelected As System.Windows.Forms.CheckBox

End Class
