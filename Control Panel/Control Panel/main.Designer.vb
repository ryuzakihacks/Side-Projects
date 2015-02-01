<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.qwe1 = New MetroFramework.Controls.MetroTabPage()
        Me.btnSAVE = New MetroFramework.Controls.MetroButton()
        Me.btnGENERATE = New MetroFramework.Controls.MetroButton()
        Me.txtboxNUMKEYS = New System.Windows.Forms.TextBox()
        Me.lblNUMCODES = New MetroFramework.Controls.MetroLabel()
        Me.txtboxRESULT = New System.Windows.Forms.TextBox()
        Me.qwe2 = New MetroFramework.Controls.MetroTabPage()
        Me.btnRESET = New MetroFramework.Controls.MetroButton()
        Me.lvusers = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NAMEfuck = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CODE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HWID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JOINED = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qwe3 = New MetroFramework.Controls.MetroTabPage()
        Me.cmbboxLOADERSTATUS = New MetroFramework.Controls.MetroComboBox()
        Me.lvLOADERINFO = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menustripLOADERINFO = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsUD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsDELETE = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnADDINFO = New MetroFramework.Controls.MetroButton()
        Me.lblSTATUS = New MetroFramework.Controls.MetroLabel()
        Me.txtboxVERSION = New System.Windows.Forms.TextBox()
        Me.lblVERSION = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1.SuspendLayout()
        Me.qwe1.SuspendLayout()
        Me.qwe2.SuspendLayout()
        Me.qwe3.SuspendLayout()
        Me.menustripLOADERINFO.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.qwe1)
        Me.MetroTabControl1.Controls.Add(Me.qwe3)
        Me.MetroTabControl1.Controls.Add(Me.qwe2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(6, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 2
        Me.MetroTabControl1.Size = New System.Drawing.Size(539, 248)
        Me.MetroTabControl1.TabIndex = 0
        '
        'qwe1
        '
        Me.qwe1.Controls.Add(Me.btnSAVE)
        Me.qwe1.Controls.Add(Me.btnGENERATE)
        Me.qwe1.Controls.Add(Me.txtboxNUMKEYS)
        Me.qwe1.Controls.Add(Me.lblNUMCODES)
        Me.qwe1.Controls.Add(Me.txtboxRESULT)
        Me.qwe1.HorizontalScrollbarBarColor = True
        Me.qwe1.Location = New System.Drawing.Point(4, 35)
        Me.qwe1.Name = "qwe1"
        Me.qwe1.Size = New System.Drawing.Size(531, 209)
        Me.qwe1.TabIndex = 1
        Me.qwe1.Text = "Code Manager"
        Me.qwe1.VerticalScrollbarBarColor = True
        '
        'btnSAVE
        '
        Me.btnSAVE.Location = New System.Drawing.Point(13, 131)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(268, 25)
        Me.btnSAVE.TabIndex = 6
        Me.btnSAVE.Text = "SAVE CODES TO THE DATABASE"
        '
        'btnGENERATE
        '
        Me.btnGENERATE.Location = New System.Drawing.Point(13, 96)
        Me.btnGENERATE.Name = "btnGENERATE"
        Me.btnGENERATE.Size = New System.Drawing.Size(268, 29)
        Me.btnGENERATE.TabIndex = 5
        Me.btnGENERATE.Text = "GENERATE CODES"
        '
        'txtboxNUMKEYS
        '
        Me.txtboxNUMKEYS.BackColor = System.Drawing.Color.Silver
        Me.txtboxNUMKEYS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxNUMKEYS.Location = New System.Drawing.Point(137, 66)
        Me.txtboxNUMKEYS.Name = "txtboxNUMKEYS"
        Me.txtboxNUMKEYS.Size = New System.Drawing.Size(144, 20)
        Me.txtboxNUMKEYS.TabIndex = 4
        Me.txtboxNUMKEYS.Text = "10"
        '
        'lblNUMCODES
        '
        Me.lblNUMCODES.AutoSize = True
        Me.lblNUMCODES.Location = New System.Drawing.Point(13, 66)
        Me.lblNUMCODES.Name = "lblNUMCODES"
        Me.lblNUMCODES.Size = New System.Drawing.Size(118, 19)
        Me.lblNUMCODES.TabIndex = 3
        Me.lblNUMCODES.Text = "Number of Codes:"
        '
        'txtboxRESULT
        '
        Me.txtboxRESULT.BackColor = System.Drawing.Color.Silver
        Me.txtboxRESULT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxRESULT.Enabled = False
        Me.txtboxRESULT.Location = New System.Drawing.Point(287, 8)
        Me.txtboxRESULT.Multiline = True
        Me.txtboxRESULT.Name = "txtboxRESULT"
        Me.txtboxRESULT.Size = New System.Drawing.Size(233, 198)
        Me.txtboxRESULT.TabIndex = 2
        '
        'qwe2
        '
        Me.qwe2.Controls.Add(Me.btnRESET)
        Me.qwe2.Controls.Add(Me.lvusers)
        Me.qwe2.HorizontalScrollbarBarColor = True
        Me.qwe2.Location = New System.Drawing.Point(4, 35)
        Me.qwe2.Name = "qwe2"
        Me.qwe2.Size = New System.Drawing.Size(531, 209)
        Me.qwe2.TabIndex = 0
        Me.qwe2.Text = "Code Users"
        Me.qwe2.VerticalScrollbarBarColor = True
        '
        'btnRESET
        '
        Me.btnRESET.Location = New System.Drawing.Point(188, 183)
        Me.btnRESET.Name = "btnRESET"
        Me.btnRESET.Size = New System.Drawing.Size(154, 23)
        Me.btnRESET.TabIndex = 8
        Me.btnRESET.Text = "RESET CODES AND USERS"
        '
        'lvusers
        '
        Me.lvusers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.NAMEfuck, Me.CODE, Me.HWID, Me.IP, Me.JOINED})
        Me.lvusers.FullRowSelect = True
        Me.lvusers.GridLines = True
        Me.lvusers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvusers.Location = New System.Drawing.Point(0, 4)
        Me.lvusers.Name = "lvusers"
        Me.lvusers.Size = New System.Drawing.Size(531, 173)
        Me.lvusers.TabIndex = 3
        Me.lvusers.UseCompatibleStateImageBehavior = False
        Me.lvusers.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 48
        '
        'NAMEfuck
        '
        Me.NAMEfuck.Text = "NAME"
        Me.NAMEfuck.Width = 96
        '
        'CODE
        '
        Me.CODE.Text = "CODE"
        Me.CODE.Width = 96
        '
        'HWID
        '
        Me.HWID.Text = "HWID"
        Me.HWID.Width = 96
        '
        'IP
        '
        Me.IP.Text = "IP"
        Me.IP.Width = 96
        '
        'JOINED
        '
        Me.JOINED.Text = "JOINED"
        Me.JOINED.Width = 96
        '
        'qwe3
        '
        Me.qwe3.Controls.Add(Me.cmbboxLOADERSTATUS)
        Me.qwe3.Controls.Add(Me.lvLOADERINFO)
        Me.qwe3.Controls.Add(Me.btnADDINFO)
        Me.qwe3.Controls.Add(Me.lblSTATUS)
        Me.qwe3.Controls.Add(Me.txtboxVERSION)
        Me.qwe3.Controls.Add(Me.lblVERSION)
        Me.qwe3.HorizontalScrollbarBarColor = True
        Me.qwe3.Location = New System.Drawing.Point(4, 35)
        Me.qwe3.Name = "qwe3"
        Me.qwe3.Size = New System.Drawing.Size(531, 209)
        Me.qwe3.TabIndex = 2
        Me.qwe3.Text = "Loader Info"
        Me.qwe3.VerticalScrollbarBarColor = True
        '
        'cmbboxLOADERSTATUS
        '
        Me.cmbboxLOADERSTATUS.FormattingEnabled = True
        Me.cmbboxLOADERSTATUS.ItemHeight = 23
        Me.cmbboxLOADERSTATUS.Items.AddRange(New Object() {"UNDETECTED", "DETECTED", "PATCHED"})
        Me.cmbboxLOADERSTATUS.Location = New System.Drawing.Point(244, 40)
        Me.cmbboxLOADERSTATUS.Name = "cmbboxLOADERSTATUS"
        Me.cmbboxLOADERSTATUS.Size = New System.Drawing.Size(146, 29)
        Me.cmbboxLOADERSTATUS.TabIndex = 11
        '
        'lvLOADERINFO
        '
        Me.lvLOADERINFO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvLOADERINFO.ContextMenuStrip = Me.menustripLOADERINFO
        Me.lvLOADERINFO.FullRowSelect = True
        Me.lvLOADERINFO.GridLines = True
        Me.lvLOADERINFO.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLOADERINFO.Location = New System.Drawing.Point(0, 103)
        Me.lvLOADERINFO.Name = "lvLOADERINFO"
        Me.lvLOADERINFO.Size = New System.Drawing.Size(528, 103)
        Me.lvLOADERINFO.TabIndex = 10
        Me.lvLOADERINFO.UseCompatibleStateImageBehavior = False
        Me.lvLOADERINFO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "LOADER VERSION"
        Me.ColumnHeader5.Width = 259
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "STATUS"
        Me.ColumnHeader6.Width = 252
        '
        'menustripLOADERINFO
        '
        Me.menustripLOADERINFO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsUD, Me.tsD, Me.tsP, Me.tsDELETE})
        Me.menustripLOADERINFO.Name = "menustripLOADERINFO"
        Me.menustripLOADERINFO.Size = New System.Drawing.Size(148, 92)
        '
        'tsUD
        '
        Me.tsUD.Name = "tsUD"
        Me.tsUD.Size = New System.Drawing.Size(147, 22)
        Me.tsUD.Text = "UNDETECTED"
        '
        'tsD
        '
        Me.tsD.Name = "tsD"
        Me.tsD.Size = New System.Drawing.Size(147, 22)
        Me.tsD.Text = "DETECTED"
        '
        'tsP
        '
        Me.tsP.Name = "tsP"
        Me.tsP.Size = New System.Drawing.Size(147, 22)
        Me.tsP.Text = "PATCHED"
        '
        'tsDELETE
        '
        Me.tsDELETE.Name = "tsDELETE"
        Me.tsDELETE.Size = New System.Drawing.Size(147, 22)
        Me.tsDELETE.Text = "DELETE"
        '
        'btnADDINFO
        '
        Me.btnADDINFO.Location = New System.Drawing.Point(188, 74)
        Me.btnADDINFO.Name = "btnADDINFO"
        Me.btnADDINFO.Size = New System.Drawing.Size(154, 23)
        Me.btnADDINFO.TabIndex = 9
        Me.btnADDINFO.Text = "ADD INFO"
        '
        'lblSTATUS
        '
        Me.lblSTATUS.AutoSize = True
        Me.lblSTATUS.Location = New System.Drawing.Point(147, 43)
        Me.lblSTATUS.Name = "lblSTATUS"
        Me.lblSTATUS.Size = New System.Drawing.Size(91, 19)
        Me.lblSTATUS.TabIndex = 7
        Me.lblSTATUS.Text = "Loader Status:"
        '
        'txtboxVERSION
        '
        Me.txtboxVERSION.BackColor = System.Drawing.Color.Silver
        Me.txtboxVERSION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxVERSION.Location = New System.Drawing.Point(246, 17)
        Me.txtboxVERSION.Name = "txtboxVERSION"
        Me.txtboxVERSION.Size = New System.Drawing.Size(144, 20)
        Me.txtboxVERSION.TabIndex = 6
        '
        'lblVERSION
        '
        Me.lblVERSION.AutoSize = True
        Me.lblVERSION.Location = New System.Drawing.Point(140, 18)
        Me.lblVERSION.Name = "lblVERSION"
        Me.lblVERSION.Size = New System.Drawing.Size(100, 19)
        Me.lblVERSION.TabIndex = 5
        Me.lblVERSION.Text = "Loader Version:"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(553, 322)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Resizable = False
        Me.Text = "CONTROL PANEL"
        Me.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center
        Me.MetroTabControl1.ResumeLayout(False)
        Me.qwe1.ResumeLayout(False)
        Me.qwe1.PerformLayout()
        Me.qwe2.ResumeLayout(False)
        Me.qwe3.ResumeLayout(False)
        Me.qwe3.PerformLayout()
        Me.menustripLOADERINFO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents qwe2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents qwe1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents lvusers As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents NAMEfuck As System.Windows.Forms.ColumnHeader
    Friend WithEvents CODE As System.Windows.Forms.ColumnHeader
    Friend WithEvents HWID As System.Windows.Forms.ColumnHeader
    Friend WithEvents IP As System.Windows.Forms.ColumnHeader
    Friend WithEvents JOINED As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblNUMCODES As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtboxRESULT As System.Windows.Forms.TextBox
    Friend WithEvents btnGENERATE As MetroFramework.Controls.MetroButton
    Friend WithEvents txtboxNUMKEYS As System.Windows.Forms.TextBox
    Friend WithEvents btnSAVE As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRESET As MetroFramework.Controls.MetroButton
    Friend WithEvents qwe3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnADDINFO As MetroFramework.Controls.MetroButton
    Friend WithEvents lblSTATUS As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtboxVERSION As System.Windows.Forms.TextBox
    Friend WithEvents lblVERSION As MetroFramework.Controls.MetroLabel
    Friend WithEvents lvLOADERINFO As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menustripLOADERINFO As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsUD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbboxLOADERSTATUS As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tsD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDELETE As System.Windows.Forms.ToolStripMenuItem
End Class
