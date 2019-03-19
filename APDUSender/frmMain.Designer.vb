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
        Me.btnByteToThaiASCII = New System.Windows.Forms.Button()
        Me.txtASCII = New System.Windows.Forms.TextBox()
        Me.btnByteToASCII = New System.Windows.Forms.Button()
        Me.lblFunction = New System.Windows.Forms.Label()
        Me.txtSW1SW2 = New System.Windows.Forms.TextBox()
        Me.txtRecievedAPDU = New System.Windows.Forms.TextBox()
        Me.lblRecievedAPDU = New System.Windows.Forms.Label()
        Me.lblSendAPDU = New System.Windows.Forms.Label()
        Me.btnSendAPDU = New System.Windows.Forms.Button()
        Me.txtSendAPDU = New System.Windows.Forms.TextBox()
        Me.lblReaderName = New System.Windows.Forms.Label()
        Me.txtATRValue = New System.Windows.Forms.TextBox()
        Me.lblATR = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnGetATR = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnRefesh = New System.Windows.Forms.Button()
        Me.cbxReader = New System.Windows.Forms.ComboBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnByteToThaiASCII
        '
        Me.btnByteToThaiASCII.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByteToThaiASCII.Location = New System.Drawing.Point(25, 460)
        Me.btnByteToThaiASCII.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnByteToThaiASCII.Name = "btnByteToThaiASCII"
        Me.btnByteToThaiASCII.Size = New System.Drawing.Size(418, 30)
        Me.btnByteToThaiASCII.TabIndex = 6
        Me.btnByteToThaiASCII.Text = "Response Byte to Thai"
        Me.btnByteToThaiASCII.UseVisualStyleBackColor = True
        '
        'txtASCII
        '
        Me.txtASCII.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtASCII.Location = New System.Drawing.Point(25, 373)
        Me.txtASCII.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtASCII.Multiline = True
        Me.txtASCII.Name = "txtASCII"
        Me.txtASCII.ReadOnly = True
        Me.txtASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtASCII.Size = New System.Drawing.Size(418, 52)
        Me.txtASCII.TabIndex = 10
        '
        'btnByteToASCII
        '
        Me.btnByteToASCII.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByteToASCII.Location = New System.Drawing.Point(25, 428)
        Me.btnByteToASCII.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnByteToASCII.Name = "btnByteToASCII"
        Me.btnByteToASCII.Size = New System.Drawing.Size(418, 30)
        Me.btnByteToASCII.TabIndex = 5
        Me.btnByteToASCII.Text = "Response Byte to Text"
        Me.btnByteToASCII.UseVisualStyleBackColor = True
        '
        'lblFunction
        '
        Me.lblFunction.AutoSize = True
        Me.lblFunction.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunction.Location = New System.Drawing.Point(21, 350)
        Me.lblFunction.Name = "lblFunction"
        Me.lblFunction.Size = New System.Drawing.Size(77, 19)
        Me.lblFunction.TabIndex = 15
        Me.lblFunction.Text = "Function"
        '
        'txtSW1SW2
        '
        Me.txtSW1SW2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSW1SW2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSW1SW2.Location = New System.Drawing.Point(25, 279)
        Me.txtSW1SW2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSW1SW2.Multiline = True
        Me.txtSW1SW2.Name = "txtSW1SW2"
        Me.txtSW1SW2.ReadOnly = True
        Me.txtSW1SW2.Size = New System.Drawing.Size(418, 30)
        Me.txtSW1SW2.TabIndex = 9
        '
        'txtRecievedAPDU
        '
        Me.txtRecievedAPDU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecievedAPDU.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecievedAPDU.Location = New System.Drawing.Point(25, 207)
        Me.txtRecievedAPDU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRecievedAPDU.Multiline = True
        Me.txtRecievedAPDU.Name = "txtRecievedAPDU"
        Me.txtRecievedAPDU.ReadOnly = True
        Me.txtRecievedAPDU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecievedAPDU.Size = New System.Drawing.Size(418, 68)
        Me.txtRecievedAPDU.TabIndex = 8
        '
        'lblRecievedAPDU
        '
        Me.lblRecievedAPDU.AutoSize = True
        Me.lblRecievedAPDU.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecievedAPDU.Location = New System.Drawing.Point(21, 181)
        Me.lblRecievedAPDU.Name = "lblRecievedAPDU"
        Me.lblRecievedAPDU.Size = New System.Drawing.Size(129, 19)
        Me.lblRecievedAPDU.TabIndex = 7
        Me.lblRecievedAPDU.Text = "Received APDU"
        '
        'lblSendAPDU
        '
        Me.lblSendAPDU.AutoSize = True
        Me.lblSendAPDU.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSendAPDU.Location = New System.Drawing.Point(21, 19)
        Me.lblSendAPDU.Name = "lblSendAPDU"
        Me.lblSendAPDU.Size = New System.Drawing.Size(137, 19)
        Me.lblSendAPDU.TabIndex = 6
        Me.lblSendAPDU.Text = "Command APDU"
        '
        'btnSendAPDU
        '
        Me.btnSendAPDU.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendAPDU.Location = New System.Drawing.Point(135, 122)
        Me.btnSendAPDU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSendAPDU.Name = "btnSendAPDU"
        Me.btnSendAPDU.Size = New System.Drawing.Size(308, 30)
        Me.btnSendAPDU.TabIndex = 4
        Me.btnSendAPDU.Text = "Send"
        Me.btnSendAPDU.UseVisualStyleBackColor = True
        '
        'txtSendAPDU
        '
        Me.txtSendAPDU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSendAPDU.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendAPDU.Location = New System.Drawing.Point(25, 44)
        Me.txtSendAPDU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSendAPDU.Multiline = True
        Me.txtSendAPDU.Name = "txtSendAPDU"
        Me.txtSendAPDU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSendAPDU.Size = New System.Drawing.Size(418, 74)
        Me.txtSendAPDU.TabIndex = 3
        '
        'lblReaderName
        '
        Me.lblReaderName.AutoSize = True
        Me.lblReaderName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReaderName.Location = New System.Drawing.Point(25, 59)
        Me.lblReaderName.Name = "lblReaderName"
        Me.lblReaderName.Size = New System.Drawing.Size(70, 19)
        Me.lblReaderName.TabIndex = 14
        Me.lblReaderName.Text = "Reader:"
        '
        'txtATRValue
        '
        Me.txtATRValue.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATRValue.Location = New System.Drawing.Point(74, 509)
        Me.txtATRValue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtATRValue.Multiline = True
        Me.txtATRValue.Name = "txtATRValue"
        Me.txtATRValue.ReadOnly = True
        Me.txtATRValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtATRValue.Size = New System.Drawing.Size(369, 54)
        Me.txtATRValue.TabIndex = 11
        '
        'lblATR
        '
        Me.lblATR.AutoSize = True
        Me.lblATR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATR.Location = New System.Drawing.Point(21, 509)
        Me.lblATR.Name = "lblATR"
        Me.lblATR.Size = New System.Drawing.Size(47, 19)
        Me.lblATR.TabIndex = 3
        Me.lblATR.Text = "ATR:"
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(24, 20)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(168, 29)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "APDU Sender"
        '
        'btnGetATR
        '
        Me.btnGetATR.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetATR.Location = New System.Drawing.Point(74, 568)
        Me.btnGetATR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGetATR.Name = "btnGetATR"
        Me.btnGetATR.Size = New System.Drawing.Size(369, 27)
        Me.btnGetATR.TabIndex = 7
        Me.btnGetATR.Text = "Get ATR"
        Me.btnGetATR.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlHeader.Controls.Add(Me.btnRefesh)
        Me.pnlHeader.Controls.Add(Me.cbxReader)
        Me.pnlHeader.Controls.Add(Me.lblReaderName)
        Me.pnlHeader.Controls.Add(Me.lblFormTitle)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(984, 101)
        Me.pnlHeader.TabIndex = 6
        '
        'btnRefesh
        '
        Me.btnRefesh.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefesh.Location = New System.Drawing.Point(368, 56)
        Me.btnRefesh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefesh.Name = "btnRefesh"
        Me.btnRefesh.Size = New System.Drawing.Size(108, 27)
        Me.btnRefesh.TabIndex = 2
        Me.btnRefesh.Text = "Refresh"
        Me.btnRefesh.UseVisualStyleBackColor = True
        '
        'cbxReader
        '
        Me.cbxReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReader.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReader.FormattingEnabled = True
        Me.cbxReader.Location = New System.Drawing.Point(101, 57)
        Me.cbxReader.Name = "cbxReader"
        Me.cbxReader.Size = New System.Drawing.Size(262, 25)
        Me.cbxReader.TabIndex = 1
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(464, 24)
        Me.txtLog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(495, 612)
        Me.txtLog.TabIndex = 12
        Me.txtLog.Text = "++APDUSender : Begin++"
        '
        'pnlBody
        '
        Me.pnlBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBody.Controls.Add(Me.btnByteToThaiASCII)
        Me.pnlBody.Controls.Add(Me.txtASCII)
        Me.pnlBody.Controls.Add(Me.txtATRValue)
        Me.pnlBody.Controls.Add(Me.btnByteToASCII)
        Me.pnlBody.Controls.Add(Me.lblATR)
        Me.pnlBody.Controls.Add(Me.lblFunction)
        Me.pnlBody.Controls.Add(Me.txtSW1SW2)
        Me.pnlBody.Controls.Add(Me.btnGetATR)
        Me.pnlBody.Controls.Add(Me.txtRecievedAPDU)
        Me.pnlBody.Controls.Add(Me.lblRecievedAPDU)
        Me.pnlBody.Controls.Add(Me.lblSendAPDU)
        Me.pnlBody.Controls.Add(Me.btnSendAPDU)
        Me.pnlBody.Controls.Add(Me.txtSendAPDU)
        Me.pnlBody.Controls.Add(Me.txtLog)
        Me.pnlBody.Location = New System.Drawing.Point(0, 98)
        Me.pnlBody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(984, 663)
        Me.pnlBody.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)
        Me.Name = "frmMain"
        Me.Text = "APDUSender"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnByteToThaiASCII As Button
    Friend WithEvents txtASCII As TextBox
    Friend WithEvents btnByteToASCII As Button
    Friend WithEvents lblFunction As Label
    Friend WithEvents txtSW1SW2 As TextBox
    Friend WithEvents txtRecievedAPDU As TextBox
    Friend WithEvents lblRecievedAPDU As Label
    Friend WithEvents lblSendAPDU As Label
    Friend WithEvents btnSendAPDU As Button
    Friend WithEvents txtSendAPDU As TextBox
    Friend WithEvents lblReaderName As Label
    Friend WithEvents txtATRValue As TextBox
    Friend WithEvents lblATR As Label
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnGetATR As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents txtLog As TextBox
    Friend WithEvents pnlBody As Panel
    Friend WithEvents btnRefesh As Button
    Friend WithEvents cbxReader As ComboBox
End Class
