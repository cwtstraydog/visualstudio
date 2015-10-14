<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.gpbPolarity = New System.Windows.Forms.GroupBox()
        Me.rdobtnPolarityRev = New System.Windows.Forms.RadioButton()
        Me.rdoPolarityNormal = New System.Windows.Forms.RadioButton()
        Me.gpbDirect = New System.Windows.Forms.GroupBox()
        Me.lblBaudRate = New System.Windows.Forms.Label()
        Me.lblComPortNum = New System.Windows.Forms.Label()
        Me.rdoDirectConnect = New System.Windows.Forms.RadioButton()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.gpbAuto = New System.Windows.Forms.GroupBox()
        Me.txtbxAutoFanS10 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS9 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS8 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS7 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS6 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS5 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS4 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS3 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS2 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFanS1 = New System.Windows.Forms.TextBox()
        Me.btnAutoClear = New System.Windows.Forms.Button()
        Me.lblTimerCount = New System.Windows.Forms.Label()
        Me.btnUnpause = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAutoFromP = New System.Windows.Forms.Label()
        Me.lblAutoTimer = New System.Windows.Forms.Label()
        Me.lblAutoDutyCycle = New System.Windows.Forms.Label()
        Me.txtDutystop = New System.Windows.Forms.TextBox()
        Me.txtDutyStart = New System.Windows.Forms.TextBox()
        Me.lblAutoTo = New System.Windows.Forms.Label()
        Me.lblAutoFrom = New System.Windows.Forms.Label()
        Me.txtbxAutoDwell = New System.Windows.Forms.TextBox()
        Me.lblAutoDwell = New System.Windows.Forms.Label()
        Me.rdoSeconds = New System.Windows.Forms.RadioButton()
        Me.rdobtnAutoUpDown = New System.Windows.Forms.RadioButton()
        Me.btnResetAuto = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtbxAutoFan10 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan9 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan8 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan7 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan6 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan5 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan4 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan3 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan2 = New System.Windows.Forms.TextBox()
        Me.txtbxAutoFan1 = New System.Windows.Forms.TextBox()
        Me.chkbAutoAll = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan10 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan9 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan8 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan7 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan6 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan5 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan2 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan4 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan3 = New System.Windows.Forms.CheckBox()
        Me.chkbAutoFan1 = New System.Windows.Forms.CheckBox()
        Me.gpbAutoPercent = New System.Windows.Forms.GroupBox()
        Me.rdoAutoPercent1 = New System.Windows.Forms.RadioButton()
        Me.rdoAutoPercent5 = New System.Windows.Forms.RadioButton()
        Me.gpbManual = New System.Windows.Forms.GroupBox()
        Me.btnManClear = New System.Windows.Forms.Button()
        Me.btnManDown = New System.Windows.Forms.Button()
        Me.btnManUp = New System.Windows.Forms.Button()
        Me.rdobtnManBy1 = New System.Windows.Forms.RadioButton()
        Me.rdobtnManBy5 = New System.Windows.Forms.RadioButton()
        Me.txtbxManFan10 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan9 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan8 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan7 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan6 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan5 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan4 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan3 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan2 = New System.Windows.Forms.TextBox()
        Me.txtbxManFan1 = New System.Windows.Forms.TextBox()
        Me.txtbxManAll = New System.Windows.Forms.TextBox()
        Me.chkbManAll = New System.Windows.Forms.CheckBox()
        Me.chkbManFan10 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan9 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan8 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan7 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan6 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan5 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan2 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan4 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan3 = New System.Windows.Forms.CheckBox()
        Me.chkbManFan1 = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.rdoManualEnable = New System.Windows.Forms.RadioButton()
        Me.rdoAutoramp = New System.Windows.Forms.RadioButton()
        Me.lblMainPercentage = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableAutoRampToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableManualRampToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableCommunicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReversedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnpauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpyGlassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblReversed = New System.Windows.Forms.Label()
        Me.lblManualTrue = New System.Windows.Forms.Label()
        Me.lblmanualup = New System.Windows.Forms.Label()
        Me.lblCycleCount = New System.Windows.Forms.Label()
        Me.lblUpDown = New System.Windows.Forms.Label()
        Me.lblFanPWMp1 = New System.Windows.Forms.Label()
        Me.lblFanPWM1 = New System.Windows.Forms.Label()
        Me.lblFanPWM2 = New System.Windows.Forms.Label()
        Me.lblFanPWMp2 = New System.Windows.Forms.Label()
        Me.lblFanPWM3 = New System.Windows.Forms.Label()
        Me.lblFanPWMp3 = New System.Windows.Forms.Label()
        Me.lblFanPWM4 = New System.Windows.Forms.Label()
        Me.lblFanPWMp4 = New System.Windows.Forms.Label()
        Me.lblFanPWM5 = New System.Windows.Forms.Label()
        Me.lblFanPWMp5 = New System.Windows.Forms.Label()
        Me.lblFanPWM10 = New System.Windows.Forms.Label()
        Me.lblFanPWMp10 = New System.Windows.Forms.Label()
        Me.lblFanPWM9 = New System.Windows.Forms.Label()
        Me.lblFanPWMp9 = New System.Windows.Forms.Label()
        Me.lblFanPWM8 = New System.Windows.Forms.Label()
        Me.lblFanPWMp8 = New System.Windows.Forms.Label()
        Me.lblFanPWM7 = New System.Windows.Forms.Label()
        Me.lblFanPWMp7 = New System.Windows.Forms.Label()
        Me.lblFanPWM6 = New System.Windows.Forms.Label()
        Me.lblFanPWMp6 = New System.Windows.Forms.Label()
        Me.lblPWNSpeed = New System.Windows.Forms.Label()
        Me.gpbPolarity.SuspendLayout()
        Me.gpbDirect.SuspendLayout()
        Me.gpbAuto.SuspendLayout()
        Me.gpbAutoPercent.SuspendLayout()
        Me.gpbManual.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbPolarity
        '
        Me.gpbPolarity.Controls.Add(Me.rdobtnPolarityRev)
        Me.gpbPolarity.Controls.Add(Me.rdoPolarityNormal)
        Me.gpbPolarity.Location = New System.Drawing.Point(162, 22)
        Me.gpbPolarity.Name = "gpbPolarity"
        Me.gpbPolarity.Size = New System.Drawing.Size(268, 39)
        Me.gpbPolarity.TabIndex = 0
        Me.gpbPolarity.TabStop = False
        Me.gpbPolarity.Text = "Polarity"
        '
        'rdobtnPolarityRev
        '
        Me.rdobtnPolarityRev.AutoSize = True
        Me.rdobtnPolarityRev.Location = New System.Drawing.Point(154, 16)
        Me.rdobtnPolarityRev.Name = "rdobtnPolarityRev"
        Me.rdobtnPolarityRev.Size = New System.Drawing.Size(71, 17)
        Me.rdobtnPolarityRev.TabIndex = 1
        Me.rdobtnPolarityRev.TabStop = True
        Me.rdobtnPolarityRev.Text = "Reversed"
        Me.rdobtnPolarityRev.UseVisualStyleBackColor = True
        '
        'rdoPolarityNormal
        '
        Me.rdoPolarityNormal.AutoSize = True
        Me.rdoPolarityNormal.Location = New System.Drawing.Point(52, 16)
        Me.rdoPolarityNormal.Name = "rdoPolarityNormal"
        Me.rdoPolarityNormal.Size = New System.Drawing.Size(58, 17)
        Me.rdoPolarityNormal.TabIndex = 0
        Me.rdoPolarityNormal.TabStop = True
        Me.rdoPolarityNormal.Text = "Normal"
        Me.rdoPolarityNormal.UseVisualStyleBackColor = True
        '
        'gpbDirect
        '
        Me.gpbDirect.Controls.Add(Me.lblBaudRate)
        Me.gpbDirect.Controls.Add(Me.lblComPortNum)
        Me.gpbDirect.Controls.Add(Me.rdoDirectConnect)
        Me.gpbDirect.Controls.Add(Me.txtTransmit)
        Me.gpbDirect.Controls.Add(Me.cmbBaud)
        Me.gpbDirect.Controls.Add(Me.cmbPort)
        Me.gpbDirect.Controls.Add(Me.rtbReceived)
        Me.gpbDirect.Controls.Add(Me.btnSend)
        Me.gpbDirect.Controls.Add(Me.btnDisconnect)
        Me.gpbDirect.Controls.Add(Me.btnConnect)
        Me.gpbDirect.Location = New System.Drawing.Point(29, 67)
        Me.gpbDirect.Name = "gpbDirect"
        Me.gpbDirect.Size = New System.Drawing.Size(600, 181)
        Me.gpbDirect.TabIndex = 1
        Me.gpbDirect.TabStop = False
        Me.gpbDirect.Text = "Direct communication to fans"
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.Location = New System.Drawing.Point(6, 52)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(58, 13)
        Me.lblBaudRate.TabIndex = 9
        Me.lblBaudRate.Text = "Baud Rate"
        '
        'lblComPortNum
        '
        Me.lblComPortNum.AutoSize = True
        Me.lblComPortNum.Location = New System.Drawing.Point(6, 24)
        Me.lblComPortNum.Name = "lblComPortNum"
        Me.lblComPortNum.Size = New System.Drawing.Size(60, 13)
        Me.lblComPortNum.TabIndex = 8
        Me.lblComPortNum.Text = "Com Port #"
        '
        'rdoDirectConnect
        '
        Me.rdoDirectConnect.AutoSize = True
        Me.rdoDirectConnect.Location = New System.Drawing.Point(287, 20)
        Me.rdoDirectConnect.Name = "rdoDirectConnect"
        Me.rdoDirectConnect.Size = New System.Drawing.Size(125, 17)
        Me.rdoDirectConnect.TabIndex = 7
        Me.rdoDirectConnect.TabStop = True
        Me.rdoDirectConnect.Text = "Direct Com to Control"
        Me.rdoDirectConnect.UseVisualStyleBackColor = True
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(287, 49)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(221, 20)
        Me.txtTransmit.TabIndex = 6
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(74, 47)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(121, 21)
        Me.cmbBaud.TabIndex = 5
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(74, 21)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPort.TabIndex = 4
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(9, 74)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(580, 101)
        Me.rtbReceived.TabIndex = 3
        Me.rtbReceived.Text = ""
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(514, 48)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(201, 47)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 1
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(201, 18)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'gpbAuto
        '
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS10)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS9)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS8)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS7)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS6)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS5)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS4)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS3)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS2)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFanS1)
        Me.gpbAuto.Controls.Add(Me.btnAutoClear)
        Me.gpbAuto.Controls.Add(Me.lblTimerCount)
        Me.gpbAuto.Controls.Add(Me.btnUnpause)
        Me.gpbAuto.Controls.Add(Me.Label2)
        Me.gpbAuto.Controls.Add(Me.lblAutoFromP)
        Me.gpbAuto.Controls.Add(Me.lblAutoTimer)
        Me.gpbAuto.Controls.Add(Me.lblAutoDutyCycle)
        Me.gpbAuto.Controls.Add(Me.txtDutystop)
        Me.gpbAuto.Controls.Add(Me.txtDutyStart)
        Me.gpbAuto.Controls.Add(Me.lblAutoTo)
        Me.gpbAuto.Controls.Add(Me.lblAutoFrom)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoDwell)
        Me.gpbAuto.Controls.Add(Me.lblAutoDwell)
        Me.gpbAuto.Controls.Add(Me.rdoSeconds)
        Me.gpbAuto.Controls.Add(Me.rdobtnAutoUpDown)
        Me.gpbAuto.Controls.Add(Me.btnResetAuto)
        Me.gpbAuto.Controls.Add(Me.btnPause)
        Me.gpbAuto.Controls.Add(Me.btnStop)
        Me.gpbAuto.Controls.Add(Me.btnGo)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan10)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan9)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan8)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan7)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan6)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan5)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan4)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan3)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan2)
        Me.gpbAuto.Controls.Add(Me.txtbxAutoFan1)
        Me.gpbAuto.Controls.Add(Me.chkbAutoAll)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan10)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan9)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan8)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan7)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan6)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan5)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan2)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan4)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan3)
        Me.gpbAuto.Controls.Add(Me.chkbAutoFan1)
        Me.gpbAuto.Controls.Add(Me.gpbAutoPercent)
        Me.gpbAuto.Location = New System.Drawing.Point(31, 273)
        Me.gpbAuto.Name = "gpbAuto"
        Me.gpbAuto.Size = New System.Drawing.Size(587, 190)
        Me.gpbAuto.TabIndex = 2
        Me.gpbAuto.TabStop = False
        Me.gpbAuto.Text = "Auto Fan Ramp Control"
        '
        'txtbxAutoFanS10
        '
        Me.txtbxAutoFanS10.Location = New System.Drawing.Point(234, 146)
        Me.txtbxAutoFanS10.Name = "txtbxAutoFanS10"
        Me.txtbxAutoFanS10.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS10.TabIndex = 71
        Me.txtbxAutoFanS10.Visible = False
        '
        'txtbxAutoFanS9
        '
        Me.txtbxAutoFanS9.Location = New System.Drawing.Point(234, 120)
        Me.txtbxAutoFanS9.Name = "txtbxAutoFanS9"
        Me.txtbxAutoFanS9.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS9.TabIndex = 68
        Me.txtbxAutoFanS9.Visible = False
        '
        'txtbxAutoFanS8
        '
        Me.txtbxAutoFanS8.Location = New System.Drawing.Point(234, 94)
        Me.txtbxAutoFanS8.Name = "txtbxAutoFanS8"
        Me.txtbxAutoFanS8.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS8.TabIndex = 65
        Me.txtbxAutoFanS8.Visible = False
        '
        'txtbxAutoFanS7
        '
        Me.txtbxAutoFanS7.Location = New System.Drawing.Point(234, 68)
        Me.txtbxAutoFanS7.Name = "txtbxAutoFanS7"
        Me.txtbxAutoFanS7.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS7.TabIndex = 62
        Me.txtbxAutoFanS7.Visible = False
        '
        'txtbxAutoFanS6
        '
        Me.txtbxAutoFanS6.Location = New System.Drawing.Point(234, 42)
        Me.txtbxAutoFanS6.Name = "txtbxAutoFanS6"
        Me.txtbxAutoFanS6.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS6.TabIndex = 59
        Me.txtbxAutoFanS6.Visible = False
        '
        'txtbxAutoFanS5
        '
        Me.txtbxAutoFanS5.Location = New System.Drawing.Point(110, 147)
        Me.txtbxAutoFanS5.Name = "txtbxAutoFanS5"
        Me.txtbxAutoFanS5.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS5.TabIndex = 56
        Me.txtbxAutoFanS5.Visible = False
        '
        'txtbxAutoFanS4
        '
        Me.txtbxAutoFanS4.Location = New System.Drawing.Point(110, 121)
        Me.txtbxAutoFanS4.Name = "txtbxAutoFanS4"
        Me.txtbxAutoFanS4.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS4.TabIndex = 53
        Me.txtbxAutoFanS4.Visible = False
        '
        'txtbxAutoFanS3
        '
        Me.txtbxAutoFanS3.Location = New System.Drawing.Point(110, 95)
        Me.txtbxAutoFanS3.Name = "txtbxAutoFanS3"
        Me.txtbxAutoFanS3.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS3.TabIndex = 50
        Me.txtbxAutoFanS3.Visible = False
        '
        'txtbxAutoFanS2
        '
        Me.txtbxAutoFanS2.Location = New System.Drawing.Point(110, 69)
        Me.txtbxAutoFanS2.Name = "txtbxAutoFanS2"
        Me.txtbxAutoFanS2.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS2.TabIndex = 47
        Me.txtbxAutoFanS2.Visible = False
        '
        'txtbxAutoFanS1
        '
        Me.txtbxAutoFanS1.Location = New System.Drawing.Point(110, 43)
        Me.txtbxAutoFanS1.Name = "txtbxAutoFanS1"
        Me.txtbxAutoFanS1.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFanS1.TabIndex = 44
        Me.txtbxAutoFanS1.Visible = False
        '
        'btnAutoClear
        '
        Me.btnAutoClear.Location = New System.Drawing.Point(132, 15)
        Me.btnAutoClear.Name = "btnAutoClear"
        Me.btnAutoClear.Size = New System.Drawing.Size(75, 23)
        Me.btnAutoClear.TabIndex = 71
        Me.btnAutoClear.Text = "Clear"
        Me.btnAutoClear.UseVisualStyleBackColor = True
        '
        'lblTimerCount
        '
        Me.lblTimerCount.AutoSize = True
        Me.lblTimerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerCount.Location = New System.Drawing.Point(335, 126)
        Me.lblTimerCount.Name = "lblTimerCount"
        Me.lblTimerCount.Size = New System.Drawing.Size(93, 20)
        Me.lblTimerCount.TabIndex = 70
        Me.lblTimerCount.Text = "##Timer##"
        '
        'btnUnpause
        '
        Me.btnUnpause.Location = New System.Drawing.Point(425, 161)
        Me.btnUnpause.Name = "btnUnpause"
        Me.btnUnpause.Size = New System.Drawing.Size(75, 23)
        Me.btnUnpause.TabIndex = 69
        Me.btnUnpause.Text = "Unpause ►"
        Me.btnUnpause.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(548, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAutoFromP
        '
        Me.lblAutoFromP.AutoSize = True
        Me.lblAutoFromP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoFromP.Location = New System.Drawing.Point(548, 81)
        Me.lblAutoFromP.Name = "lblAutoFromP"
        Me.lblAutoFromP.Size = New System.Drawing.Size(21, 17)
        Me.lblAutoFromP.TabIndex = 67
        Me.lblAutoFromP.Text = "%"
        Me.lblAutoFromP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAutoTimer
        '
        Me.lblAutoTimer.AutoSize = True
        Me.lblAutoTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoTimer.Location = New System.Drawing.Point(276, 126)
        Me.lblAutoTimer.Name = "lblAutoTimer"
        Me.lblAutoTimer.Size = New System.Drawing.Size(53, 20)
        Me.lblAutoTimer.TabIndex = 66
        Me.lblAutoTimer.Text = "Timer"
        '
        'lblAutoDutyCycle
        '
        Me.lblAutoDutyCycle.AutoSize = True
        Me.lblAutoDutyCycle.Location = New System.Drawing.Point(484, 64)
        Me.lblAutoDutyCycle.Name = "lblAutoDutyCycle"
        Me.lblAutoDutyCycle.Size = New System.Drawing.Size(58, 13)
        Me.lblAutoDutyCycle.TabIndex = 65
        Me.lblAutoDutyCycle.Text = "Duty Cycle"
        '
        'txtDutystop
        '
        Me.txtDutystop.Location = New System.Drawing.Point(485, 106)
        Me.txtDutystop.Name = "txtDutystop"
        Me.txtDutystop.Size = New System.Drawing.Size(57, 20)
        Me.txtDutystop.TabIndex = 164
        '
        'txtDutyStart
        '
        Me.txtDutyStart.Location = New System.Drawing.Point(485, 80)
        Me.txtDutyStart.Name = "txtDutyStart"
        Me.txtDutyStart.Size = New System.Drawing.Size(57, 20)
        Me.txtDutyStart.TabIndex = 163
        '
        'lblAutoTo
        '
        Me.lblAutoTo.AutoSize = True
        Me.lblAutoTo.Location = New System.Drawing.Point(459, 103)
        Me.lblAutoTo.Name = "lblAutoTo"
        Me.lblAutoTo.Size = New System.Drawing.Size(20, 13)
        Me.lblAutoTo.TabIndex = 62
        Me.lblAutoTo.Text = "To"
        '
        'lblAutoFrom
        '
        Me.lblAutoFrom.AutoSize = True
        Me.lblAutoFrom.Location = New System.Drawing.Point(449, 82)
        Me.lblAutoFrom.Name = "lblAutoFrom"
        Me.lblAutoFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblAutoFrom.TabIndex = 61
        Me.lblAutoFrom.Text = "From"
        '
        'txtbxAutoDwell
        '
        Me.txtbxAutoDwell.Location = New System.Drawing.Point(275, 103)
        Me.txtbxAutoDwell.Name = "txtbxAutoDwell"
        Me.txtbxAutoDwell.Size = New System.Drawing.Size(55, 20)
        Me.txtbxAutoDwell.TabIndex = 160
        '
        'lblAutoDwell
        '
        Me.lblAutoDwell.AutoSize = True
        Me.lblAutoDwell.Location = New System.Drawing.Point(272, 83)
        Me.lblAutoDwell.Name = "lblAutoDwell"
        Me.lblAutoDwell.Size = New System.Drawing.Size(59, 13)
        Me.lblAutoDwell.TabIndex = 59
        Me.lblAutoDwell.Text = "Dwell Time"
        '
        'rdoSeconds
        '
        Me.rdoSeconds.AutoSize = True
        Me.rdoSeconds.Location = New System.Drawing.Point(337, 106)
        Me.rdoSeconds.Name = "rdoSeconds"
        Me.rdoSeconds.Size = New System.Drawing.Size(99, 17)
        Me.rdoSeconds.TabIndex = 158
        Me.rdoSeconds.TabStop = True
        Me.rdoSeconds.Text = "Ramp Up Once"
        Me.rdoSeconds.UseVisualStyleBackColor = True
        '
        'rdobtnAutoUpDown
        '
        Me.rdobtnAutoUpDown.AutoSize = True
        Me.rdobtnAutoUpDown.Location = New System.Drawing.Point(337, 83)
        Me.rdobtnAutoUpDown.Name = "rdobtnAutoUpDown"
        Me.rdobtnAutoUpDown.Size = New System.Drawing.Size(91, 17)
        Me.rdobtnAutoUpDown.TabIndex = 157
        Me.rdobtnAutoUpDown.TabStop = True
        Me.rdobtnAutoUpDown.Text = "Up and Down"
        Me.rdobtnAutoUpDown.UseVisualStyleBackColor = True
        '
        'btnResetAuto
        '
        Me.btnResetAuto.Location = New System.Drawing.Point(506, 161)
        Me.btnResetAuto.Name = "btnResetAuto"
        Me.btnResetAuto.Size = New System.Drawing.Size(75, 23)
        Me.btnResetAuto.TabIndex = 56
        Me.btnResetAuto.Text = "Reset"
        Me.btnResetAuto.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(425, 161)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 55
        Me.btnPause.Text = "Pause ║"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(344, 161)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 54
        Me.btnStop.Text = "Stop ■"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(263, 161)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 72
        Me.btnGo.Text = "Go ►"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtbxAutoFan10
        '
        Me.txtbxAutoFan10.Location = New System.Drawing.Point(204, 146)
        Me.txtbxAutoFan10.Name = "txtbxAutoFan10"
        Me.txtbxAutoFan10.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan10.TabIndex = 70
        Me.txtbxAutoFan10.Visible = False
        '
        'txtbxAutoFan9
        '
        Me.txtbxAutoFan9.Location = New System.Drawing.Point(204, 120)
        Me.txtbxAutoFan9.Name = "txtbxAutoFan9"
        Me.txtbxAutoFan9.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan9.TabIndex = 67
        Me.txtbxAutoFan9.Visible = False
        '
        'txtbxAutoFan8
        '
        Me.txtbxAutoFan8.Location = New System.Drawing.Point(204, 94)
        Me.txtbxAutoFan8.Name = "txtbxAutoFan8"
        Me.txtbxAutoFan8.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan8.TabIndex = 64
        Me.txtbxAutoFan8.Visible = False
        '
        'txtbxAutoFan7
        '
        Me.txtbxAutoFan7.Location = New System.Drawing.Point(204, 68)
        Me.txtbxAutoFan7.Name = "txtbxAutoFan7"
        Me.txtbxAutoFan7.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan7.TabIndex = 61
        Me.txtbxAutoFan7.Visible = False
        '
        'txtbxAutoFan6
        '
        Me.txtbxAutoFan6.Location = New System.Drawing.Point(204, 42)
        Me.txtbxAutoFan6.Name = "txtbxAutoFan6"
        Me.txtbxAutoFan6.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan6.TabIndex = 58
        Me.txtbxAutoFan6.Visible = False
        '
        'txtbxAutoFan5
        '
        Me.txtbxAutoFan5.Location = New System.Drawing.Point(81, 147)
        Me.txtbxAutoFan5.Name = "txtbxAutoFan5"
        Me.txtbxAutoFan5.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan5.TabIndex = 55
        Me.txtbxAutoFan5.Visible = False
        '
        'txtbxAutoFan4
        '
        Me.txtbxAutoFan4.Location = New System.Drawing.Point(81, 121)
        Me.txtbxAutoFan4.Name = "txtbxAutoFan4"
        Me.txtbxAutoFan4.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan4.TabIndex = 52
        Me.txtbxAutoFan4.Visible = False
        '
        'txtbxAutoFan3
        '
        Me.txtbxAutoFan3.Location = New System.Drawing.Point(81, 95)
        Me.txtbxAutoFan3.Name = "txtbxAutoFan3"
        Me.txtbxAutoFan3.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan3.TabIndex = 49
        Me.txtbxAutoFan3.Visible = False
        '
        'txtbxAutoFan2
        '
        Me.txtbxAutoFan2.Location = New System.Drawing.Point(81, 69)
        Me.txtbxAutoFan2.Name = "txtbxAutoFan2"
        Me.txtbxAutoFan2.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan2.TabIndex = 46
        Me.txtbxAutoFan2.Visible = False
        '
        'txtbxAutoFan1
        '
        Me.txtbxAutoFan1.Location = New System.Drawing.Point(81, 43)
        Me.txtbxAutoFan1.Name = "txtbxAutoFan1"
        Me.txtbxAutoFan1.Size = New System.Drawing.Size(23, 20)
        Me.txtbxAutoFan1.TabIndex = 43
        Me.txtbxAutoFan1.Visible = False
        '
        'chkbAutoAll
        '
        Me.chkbAutoAll.AutoSize = True
        Me.chkbAutoAll.Location = New System.Drawing.Point(22, 19)
        Me.chkbAutoAll.Name = "chkbAutoAll"
        Me.chkbAutoAll.Size = New System.Drawing.Size(37, 17)
        Me.chkbAutoAll.TabIndex = 41
        Me.chkbAutoAll.Text = "All"
        Me.chkbAutoAll.UseVisualStyleBackColor = True
        '
        'chkbAutoFan10
        '
        Me.chkbAutoFan10.AutoSize = True
        Me.chkbAutoFan10.Location = New System.Drawing.Point(145, 149)
        Me.chkbAutoFan10.Name = "chkbAutoFan10"
        Me.chkbAutoFan10.Size = New System.Drawing.Size(59, 17)
        Me.chkbAutoFan10.TabIndex = 69
        Me.chkbAutoFan10.Text = "Fan 10"
        Me.chkbAutoFan10.UseVisualStyleBackColor = True
        Me.chkbAutoFan10.Visible = False
        '
        'chkbAutoFan9
        '
        Me.chkbAutoFan9.AutoSize = True
        Me.chkbAutoFan9.Location = New System.Drawing.Point(145, 123)
        Me.chkbAutoFan9.Name = "chkbAutoFan9"
        Me.chkbAutoFan9.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan9.TabIndex = 66
        Me.chkbAutoFan9.Text = "Fan 9"
        Me.chkbAutoFan9.UseVisualStyleBackColor = True
        Me.chkbAutoFan9.Visible = False
        '
        'chkbAutoFan8
        '
        Me.chkbAutoFan8.AutoSize = True
        Me.chkbAutoFan8.Location = New System.Drawing.Point(145, 97)
        Me.chkbAutoFan8.Name = "chkbAutoFan8"
        Me.chkbAutoFan8.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan8.TabIndex = 63
        Me.chkbAutoFan8.Text = "Fan 8"
        Me.chkbAutoFan8.UseVisualStyleBackColor = True
        Me.chkbAutoFan8.Visible = False
        '
        'chkbAutoFan7
        '
        Me.chkbAutoFan7.AutoSize = True
        Me.chkbAutoFan7.Location = New System.Drawing.Point(145, 71)
        Me.chkbAutoFan7.Name = "chkbAutoFan7"
        Me.chkbAutoFan7.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan7.TabIndex = 60
        Me.chkbAutoFan7.Text = "Fan 7"
        Me.chkbAutoFan7.UseVisualStyleBackColor = True
        Me.chkbAutoFan7.Visible = False
        '
        'chkbAutoFan6
        '
        Me.chkbAutoFan6.AutoSize = True
        Me.chkbAutoFan6.Location = New System.Drawing.Point(145, 45)
        Me.chkbAutoFan6.Name = "chkbAutoFan6"
        Me.chkbAutoFan6.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan6.TabIndex = 57
        Me.chkbAutoFan6.Text = "Fan 6"
        Me.chkbAutoFan6.UseVisualStyleBackColor = True
        Me.chkbAutoFan6.Visible = False
        '
        'chkbAutoFan5
        '
        Me.chkbAutoFan5.AutoSize = True
        Me.chkbAutoFan5.Location = New System.Drawing.Point(22, 149)
        Me.chkbAutoFan5.Name = "chkbAutoFan5"
        Me.chkbAutoFan5.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan5.TabIndex = 54
        Me.chkbAutoFan5.Text = "Fan 5"
        Me.chkbAutoFan5.UseVisualStyleBackColor = True
        Me.chkbAutoFan5.Visible = False
        '
        'chkbAutoFan2
        '
        Me.chkbAutoFan2.AutoSize = True
        Me.chkbAutoFan2.Location = New System.Drawing.Point(22, 71)
        Me.chkbAutoFan2.Name = "chkbAutoFan2"
        Me.chkbAutoFan2.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan2.TabIndex = 45
        Me.chkbAutoFan2.Text = "Fan 2"
        Me.chkbAutoFan2.UseVisualStyleBackColor = True
        Me.chkbAutoFan2.Visible = False
        '
        'chkbAutoFan4
        '
        Me.chkbAutoFan4.AutoSize = True
        Me.chkbAutoFan4.Location = New System.Drawing.Point(22, 123)
        Me.chkbAutoFan4.Name = "chkbAutoFan4"
        Me.chkbAutoFan4.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan4.TabIndex = 51
        Me.chkbAutoFan4.Text = "Fan 4"
        Me.chkbAutoFan4.UseVisualStyleBackColor = True
        Me.chkbAutoFan4.Visible = False
        '
        'chkbAutoFan3
        '
        Me.chkbAutoFan3.AutoSize = True
        Me.chkbAutoFan3.Location = New System.Drawing.Point(22, 97)
        Me.chkbAutoFan3.Name = "chkbAutoFan3"
        Me.chkbAutoFan3.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan3.TabIndex = 48
        Me.chkbAutoFan3.Text = "Fan 3"
        Me.chkbAutoFan3.UseVisualStyleBackColor = True
        Me.chkbAutoFan3.Visible = False
        '
        'chkbAutoFan1
        '
        Me.chkbAutoFan1.AutoSize = True
        Me.chkbAutoFan1.Location = New System.Drawing.Point(22, 45)
        Me.chkbAutoFan1.Name = "chkbAutoFan1"
        Me.chkbAutoFan1.Size = New System.Drawing.Size(53, 17)
        Me.chkbAutoFan1.TabIndex = 31
        Me.chkbAutoFan1.Text = "Fan 1"
        Me.chkbAutoFan1.UseVisualStyleBackColor = True
        Me.chkbAutoFan1.Visible = False
        '
        'gpbAutoPercent
        '
        Me.gpbAutoPercent.Controls.Add(Me.rdoAutoPercent1)
        Me.gpbAutoPercent.Controls.Add(Me.rdoAutoPercent5)
        Me.gpbAutoPercent.Location = New System.Drawing.Point(263, 14)
        Me.gpbAutoPercent.Name = "gpbAutoPercent"
        Me.gpbAutoPercent.Size = New System.Drawing.Size(136, 48)
        Me.gpbAutoPercent.TabIndex = 0
        Me.gpbAutoPercent.TabStop = False
        '
        'rdoAutoPercent1
        '
        Me.rdoAutoPercent1.AutoSize = True
        Me.rdoAutoPercent1.Location = New System.Drawing.Point(72, 19)
        Me.rdoAutoPercent1.Name = "rdoAutoPercent1"
        Me.rdoAutoPercent1.Size = New System.Drawing.Size(57, 17)
        Me.rdoAutoPercent1.TabIndex = 135
        Me.rdoAutoPercent1.TabStop = True
        Me.rdoAutoPercent1.Text = "By 1 %"
        Me.rdoAutoPercent1.UseVisualStyleBackColor = True
        '
        'rdoAutoPercent5
        '
        Me.rdoAutoPercent5.AutoSize = True
        Me.rdoAutoPercent5.Location = New System.Drawing.Point(6, 19)
        Me.rdoAutoPercent5.Name = "rdoAutoPercent5"
        Me.rdoAutoPercent5.Size = New System.Drawing.Size(60, 17)
        Me.rdoAutoPercent5.TabIndex = 134
        Me.rdoAutoPercent5.TabStop = True
        Me.rdoAutoPercent5.Text = "By 5 %."
        Me.rdoAutoPercent5.UseVisualStyleBackColor = True
        '
        'gpbManual
        '
        Me.gpbManual.Controls.Add(Me.btnManClear)
        Me.gpbManual.Controls.Add(Me.btnManDown)
        Me.gpbManual.Controls.Add(Me.btnManUp)
        Me.gpbManual.Controls.Add(Me.rdobtnManBy1)
        Me.gpbManual.Controls.Add(Me.rdobtnManBy5)
        Me.gpbManual.Controls.Add(Me.txtbxManFan10)
        Me.gpbManual.Controls.Add(Me.txtbxManFan9)
        Me.gpbManual.Controls.Add(Me.txtbxManFan8)
        Me.gpbManual.Controls.Add(Me.txtbxManFan7)
        Me.gpbManual.Controls.Add(Me.txtbxManFan6)
        Me.gpbManual.Controls.Add(Me.txtbxManFan5)
        Me.gpbManual.Controls.Add(Me.txtbxManFan4)
        Me.gpbManual.Controls.Add(Me.txtbxManFan3)
        Me.gpbManual.Controls.Add(Me.txtbxManFan2)
        Me.gpbManual.Controls.Add(Me.txtbxManFan1)
        Me.gpbManual.Controls.Add(Me.txtbxManAll)
        Me.gpbManual.Controls.Add(Me.chkbManAll)
        Me.gpbManual.Controls.Add(Me.chkbManFan10)
        Me.gpbManual.Controls.Add(Me.chkbManFan9)
        Me.gpbManual.Controls.Add(Me.chkbManFan8)
        Me.gpbManual.Controls.Add(Me.chkbManFan7)
        Me.gpbManual.Controls.Add(Me.chkbManFan6)
        Me.gpbManual.Controls.Add(Me.chkbManFan5)
        Me.gpbManual.Controls.Add(Me.chkbManFan2)
        Me.gpbManual.Controls.Add(Me.chkbManFan4)
        Me.gpbManual.Controls.Add(Me.chkbManFan3)
        Me.gpbManual.Controls.Add(Me.chkbManFan1)
        Me.gpbManual.Location = New System.Drawing.Point(30, 501)
        Me.gpbManual.Name = "gpbManual"
        Me.gpbManual.Size = New System.Drawing.Size(388, 180)
        Me.gpbManual.TabIndex = 3
        Me.gpbManual.TabStop = False
        Me.gpbManual.Text = "Manual Fan Control"
        '
        'btnManClear
        '
        Me.btnManClear.Location = New System.Drawing.Point(133, 12)
        Me.btnManClear.Name = "btnManClear"
        Me.btnManClear.Size = New System.Drawing.Size(75, 23)
        Me.btnManClear.TabIndex = 36
        Me.btnManClear.Text = "Clear"
        Me.btnManClear.UseVisualStyleBackColor = True
        '
        'btnManDown
        '
        Me.btnManDown.Location = New System.Drawing.Point(298, 91)
        Me.btnManDown.Name = "btnManDown"
        Me.btnManDown.Size = New System.Drawing.Size(75, 23)
        Me.btnManDown.TabIndex = 35
        Me.btnManDown.Text = "Down"
        Me.btnManDown.UseVisualStyleBackColor = True
        '
        'btnManUp
        '
        Me.btnManUp.Location = New System.Drawing.Point(298, 62)
        Me.btnManUp.Name = "btnManUp"
        Me.btnManUp.Size = New System.Drawing.Size(75, 23)
        Me.btnManUp.TabIndex = 34
        Me.btnManUp.Text = "Up"
        Me.btnManUp.UseVisualStyleBackColor = True
        '
        'rdobtnManBy1
        '
        Me.rdobtnManBy1.AutoSize = True
        Me.rdobtnManBy1.Location = New System.Drawing.Point(316, 18)
        Me.rdobtnManBy1.Name = "rdobtnManBy1"
        Me.rdobtnManBy1.Size = New System.Drawing.Size(57, 17)
        Me.rdobtnManBy1.TabIndex = 32
        Me.rdobtnManBy1.TabStop = True
        Me.rdobtnManBy1.Text = "By 1 %"
        Me.rdobtnManBy1.UseVisualStyleBackColor = True
        '
        'rdobtnManBy5
        '
        Me.rdobtnManBy5.AutoSize = True
        Me.rdobtnManBy5.Location = New System.Drawing.Point(250, 18)
        Me.rdobtnManBy5.Name = "rdobtnManBy5"
        Me.rdobtnManBy5.Size = New System.Drawing.Size(60, 17)
        Me.rdobtnManBy5.TabIndex = 31
        Me.rdobtnManBy5.TabStop = True
        Me.rdobtnManBy5.Text = "By 5 %."
        Me.rdobtnManBy5.UseVisualStyleBackColor = True
        '
        'txtbxManFan10
        '
        Me.txtbxManFan10.Location = New System.Drawing.Point(205, 146)
        Me.txtbxManFan10.Name = "txtbxManFan10"
        Me.txtbxManFan10.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan10.TabIndex = 30
        '
        'txtbxManFan9
        '
        Me.txtbxManFan9.Location = New System.Drawing.Point(205, 120)
        Me.txtbxManFan9.Name = "txtbxManFan9"
        Me.txtbxManFan9.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan9.TabIndex = 29
        '
        'txtbxManFan8
        '
        Me.txtbxManFan8.Location = New System.Drawing.Point(205, 94)
        Me.txtbxManFan8.Name = "txtbxManFan8"
        Me.txtbxManFan8.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan8.TabIndex = 28
        '
        'txtbxManFan7
        '
        Me.txtbxManFan7.Location = New System.Drawing.Point(205, 68)
        Me.txtbxManFan7.Name = "txtbxManFan7"
        Me.txtbxManFan7.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan7.TabIndex = 27
        '
        'txtbxManFan6
        '
        Me.txtbxManFan6.Location = New System.Drawing.Point(205, 42)
        Me.txtbxManFan6.Name = "txtbxManFan6"
        Me.txtbxManFan6.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan6.TabIndex = 26
        '
        'txtbxManFan5
        '
        Me.txtbxManFan5.Location = New System.Drawing.Point(82, 147)
        Me.txtbxManFan5.Name = "txtbxManFan5"
        Me.txtbxManFan5.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan5.TabIndex = 25
        '
        'txtbxManFan4
        '
        Me.txtbxManFan4.Location = New System.Drawing.Point(82, 121)
        Me.txtbxManFan4.Name = "txtbxManFan4"
        Me.txtbxManFan4.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan4.TabIndex = 24
        '
        'txtbxManFan3
        '
        Me.txtbxManFan3.Location = New System.Drawing.Point(82, 95)
        Me.txtbxManFan3.Name = "txtbxManFan3"
        Me.txtbxManFan3.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan3.TabIndex = 23
        '
        'txtbxManFan2
        '
        Me.txtbxManFan2.Location = New System.Drawing.Point(82, 69)
        Me.txtbxManFan2.Name = "txtbxManFan2"
        Me.txtbxManFan2.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan2.TabIndex = 22
        '
        'txtbxManFan1
        '
        Me.txtbxManFan1.Location = New System.Drawing.Point(82, 43)
        Me.txtbxManFan1.Name = "txtbxManFan1"
        Me.txtbxManFan1.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManFan1.TabIndex = 21
        '
        'txtbxManAll
        '
        Me.txtbxManAll.Location = New System.Drawing.Point(66, 19)
        Me.txtbxManAll.Name = "txtbxManAll"
        Me.txtbxManAll.Size = New System.Drawing.Size(39, 20)
        Me.txtbxManAll.TabIndex = 20
        '
        'chkbManAll
        '
        Me.chkbManAll.AutoSize = True
        Me.chkbManAll.Location = New System.Drawing.Point(23, 19)
        Me.chkbManAll.Name = "chkbManAll"
        Me.chkbManAll.Size = New System.Drawing.Size(37, 17)
        Me.chkbManAll.TabIndex = 19
        Me.chkbManAll.Text = "All"
        Me.chkbManAll.UseVisualStyleBackColor = True
        '
        'chkbManFan10
        '
        Me.chkbManFan10.AutoSize = True
        Me.chkbManFan10.Location = New System.Drawing.Point(146, 149)
        Me.chkbManFan10.Name = "chkbManFan10"
        Me.chkbManFan10.Size = New System.Drawing.Size(59, 17)
        Me.chkbManFan10.TabIndex = 18
        Me.chkbManFan10.Text = "Fan 10"
        Me.chkbManFan10.UseVisualStyleBackColor = True
        '
        'chkbManFan9
        '
        Me.chkbManFan9.AutoSize = True
        Me.chkbManFan9.Location = New System.Drawing.Point(146, 123)
        Me.chkbManFan9.Name = "chkbManFan9"
        Me.chkbManFan9.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan9.TabIndex = 17
        Me.chkbManFan9.Text = "Fan 9"
        Me.chkbManFan9.UseVisualStyleBackColor = True
        '
        'chkbManFan8
        '
        Me.chkbManFan8.AutoSize = True
        Me.chkbManFan8.Location = New System.Drawing.Point(146, 97)
        Me.chkbManFan8.Name = "chkbManFan8"
        Me.chkbManFan8.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan8.TabIndex = 16
        Me.chkbManFan8.Text = "Fan 8"
        Me.chkbManFan8.UseVisualStyleBackColor = True
        '
        'chkbManFan7
        '
        Me.chkbManFan7.AutoSize = True
        Me.chkbManFan7.Location = New System.Drawing.Point(146, 71)
        Me.chkbManFan7.Name = "chkbManFan7"
        Me.chkbManFan7.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan7.TabIndex = 15
        Me.chkbManFan7.Text = "Fan 7"
        Me.chkbManFan7.UseVisualStyleBackColor = True
        '
        'chkbManFan6
        '
        Me.chkbManFan6.AutoSize = True
        Me.chkbManFan6.Location = New System.Drawing.Point(146, 45)
        Me.chkbManFan6.Name = "chkbManFan6"
        Me.chkbManFan6.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan6.TabIndex = 14
        Me.chkbManFan6.Text = "Fan 6"
        Me.chkbManFan6.UseVisualStyleBackColor = True
        '
        'chkbManFan5
        '
        Me.chkbManFan5.AutoSize = True
        Me.chkbManFan5.Location = New System.Drawing.Point(23, 149)
        Me.chkbManFan5.Name = "chkbManFan5"
        Me.chkbManFan5.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan5.TabIndex = 13
        Me.chkbManFan5.Text = "Fan 5"
        Me.chkbManFan5.UseVisualStyleBackColor = True
        '
        'chkbManFan2
        '
        Me.chkbManFan2.AutoSize = True
        Me.chkbManFan2.Location = New System.Drawing.Point(23, 71)
        Me.chkbManFan2.Name = "chkbManFan2"
        Me.chkbManFan2.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan2.TabIndex = 12
        Me.chkbManFan2.Text = "Fan 2"
        Me.chkbManFan2.UseVisualStyleBackColor = True
        '
        'chkbManFan4
        '
        Me.chkbManFan4.AutoSize = True
        Me.chkbManFan4.Location = New System.Drawing.Point(23, 123)
        Me.chkbManFan4.Name = "chkbManFan4"
        Me.chkbManFan4.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan4.TabIndex = 11
        Me.chkbManFan4.Text = "Fan 4"
        Me.chkbManFan4.UseVisualStyleBackColor = True
        '
        'chkbManFan3
        '
        Me.chkbManFan3.AutoSize = True
        Me.chkbManFan3.Location = New System.Drawing.Point(23, 97)
        Me.chkbManFan3.Name = "chkbManFan3"
        Me.chkbManFan3.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan3.TabIndex = 10
        Me.chkbManFan3.Text = "Fan 3"
        Me.chkbManFan3.UseVisualStyleBackColor = True
        '
        'chkbManFan1
        '
        Me.chkbManFan1.AutoSize = True
        Me.chkbManFan1.Location = New System.Drawing.Point(23, 45)
        Me.chkbManFan1.Name = "chkbManFan1"
        Me.chkbManFan1.Size = New System.Drawing.Size(53, 17)
        Me.chkbManFan1.TabIndex = 0
        Me.chkbManFan1.Text = "Fan 1"
        Me.chkbManFan1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(543, 677)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'rdoManualEnable
        '
        Me.rdoManualEnable.AutoSize = True
        Me.rdoManualEnable.Location = New System.Drawing.Point(53, 480)
        Me.rdoManualEnable.Name = "rdoManualEnable"
        Me.rdoManualEnable.Size = New System.Drawing.Size(153, 17)
        Me.rdoManualEnable.TabIndex = 5
        Me.rdoManualEnable.TabStop = True
        Me.rdoManualEnable.Text = "Manual Fan Control Enable"
        Me.rdoManualEnable.UseVisualStyleBackColor = True
        '
        'rdoAutoramp
        '
        Me.rdoAutoramp.AutoSize = True
        Me.rdoAutoramp.Location = New System.Drawing.Point(53, 250)
        Me.rdoAutoramp.Name = "rdoAutoramp"
        Me.rdoAutoramp.Size = New System.Drawing.Size(165, 17)
        Me.rdoAutoramp.TabIndex = 6
        Me.rdoAutoramp.TabStop = True
        Me.rdoAutoramp.Text = "Automatic Fan Control Enable"
        Me.rdoAutoramp.UseVisualStyleBackColor = True
        '
        'lblMainPercentage
        '
        Me.lblMainPercentage.AutoSize = True
        Me.lblMainPercentage.Location = New System.Drawing.Point(480, 501)
        Me.lblMainPercentage.Name = "lblMainPercentage"
        Me.lblMainPercentage.Size = New System.Drawing.Size(117, 13)
        Me.lblMainPercentage.TabIndex = 7
        Me.lblMainPercentage.Text = "Fan Speed Percentage"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OperateToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "Menu1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableAutoRampToolStripMenuItem, Me.EnableManualRampToolStripMenuItem, Me.EnableCommunicationToolStripMenuItem, Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem, Me.NormalToolStripMenuItem, Me.ReversedToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EnableAutoRampToolStripMenuItem
        '
        Me.EnableAutoRampToolStripMenuItem.Name = "EnableAutoRampToolStripMenuItem"
        Me.EnableAutoRampToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EnableAutoRampToolStripMenuItem.Text = "Enable Auto Ramp"
        '
        'EnableManualRampToolStripMenuItem
        '
        Me.EnableManualRampToolStripMenuItem.Name = "EnableManualRampToolStripMenuItem"
        Me.EnableManualRampToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EnableManualRampToolStripMenuItem.Text = "Enable Manual Ramp"
        '
        'EnableCommunicationToolStripMenuItem
        '
        Me.EnableCommunicationToolStripMenuItem.Name = "EnableCommunicationToolStripMenuItem"
        Me.EnableCommunicationToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EnableCommunicationToolStripMenuItem.Text = "Enable Communication"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'ReversedToolStripMenuItem
        '
        Me.ReversedToolStripMenuItem.Name = "ReversedToolStripMenuItem"
        Me.ReversedToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ReversedToolStripMenuItem.Text = "Reversed"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OperateToolStripMenuItem
        '
        Me.OperateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToolStripMenuItem, Me.StopToolStripMenuItem, Me.PauseToolStripMenuItem, Me.UnpauseToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.OperateToolStripMenuItem.Name = "OperateToolStripMenuItem"
        Me.OperateToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OperateToolStripMenuItem.Text = "Action"
        '
        'GoToolStripMenuItem
        '
        Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
        Me.GoToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.GoToolStripMenuItem.Text = "Go"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'UnpauseToolStripMenuItem
        '
        Me.UnpauseToolStripMenuItem.Name = "UnpauseToolStripMenuItem"
        Me.UnpauseToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.UnpauseToolStripMenuItem.Text = "Unpause"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.SpyGlassToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'SpyGlassToolStripMenuItem
        '
        Me.SpyGlassToolStripMenuItem.Name = "SpyGlassToolStripMenuItem"
        Me.SpyGlassToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SpyGlassToolStripMenuItem.Text = "Spy Glass"
        '
        'Timer1
        '
        '
        'lblReversed
        '
        Me.lblReversed.AutoSize = True
        Me.lblReversed.Location = New System.Drawing.Point(38, 38)
        Me.lblReversed.Name = "lblReversed"
        Me.lblReversed.Size = New System.Drawing.Size(39, 13)
        Me.lblReversed.TabIndex = 10
        Me.lblReversed.Text = "Label3"
        '
        'lblManualTrue
        '
        Me.lblManualTrue.AutoSize = True
        Me.lblManualTrue.Location = New System.Drawing.Point(160, 690)
        Me.lblManualTrue.Name = "lblManualTrue"
        Me.lblManualTrue.Size = New System.Drawing.Size(64, 13)
        Me.lblManualTrue.TabIndex = 11
        Me.lblManualTrue.Text = "ManualTrue"
        '
        'lblmanualup
        '
        Me.lblmanualup.AutoSize = True
        Me.lblmanualup.Location = New System.Drawing.Point(67, 690)
        Me.lblmanualup.Name = "lblmanualup"
        Me.lblmanualup.Size = New System.Drawing.Size(57, 13)
        Me.lblmanualup.TabIndex = 12
        Me.lblmanualup.Text = "ManualUP"
        '
        'lblCycleCount
        '
        Me.lblCycleCount.AutoSize = True
        Me.lblCycleCount.Location = New System.Drawing.Point(259, 690)
        Me.lblCycleCount.Name = "lblCycleCount"
        Me.lblCycleCount.Size = New System.Drawing.Size(64, 13)
        Me.lblCycleCount.TabIndex = 13
        Me.lblCycleCount.Text = "Cycle Count"
        '
        'lblUpDown
        '
        Me.lblUpDown.AutoSize = True
        Me.lblUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpDown.ForeColor = System.Drawing.Color.Crimson
        Me.lblUpDown.Location = New System.Drawing.Point(303, 477)
        Me.lblUpDown.Name = "lblUpDown"
        Me.lblUpDown.Size = New System.Drawing.Size(59, 20)
        Me.lblUpDown.TabIndex = 14
        Me.lblUpDown.Text = "Down!"
        '
        'lblFanPWMp1
        '
        Me.lblFanPWMp1.AutoSize = True
        Me.lblFanPWMp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp1.Location = New System.Drawing.Point(486, 526)
        Me.lblFanPWMp1.Name = "lblFanPWMp1"
        Me.lblFanPWMp1.Size = New System.Drawing.Size(54, 20)
        Me.lblFanPWMp1.TabIndex = 15
        Me.lblFanPWMp1.Text = "100%"
        '
        'lblFanPWM1
        '
        Me.lblFanPWM1.AutoSize = True
        Me.lblFanPWM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM1.Location = New System.Drawing.Point(424, 526)
        Me.lblFanPWM1.Name = "lblFanPWM1"
        Me.lblFanPWM1.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM1.TabIndex = 16
        Me.lblFanPWM1.Text = "Fan 01"
        '
        'lblFanPWM2
        '
        Me.lblFanPWM2.AutoSize = True
        Me.lblFanPWM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM2.Location = New System.Drawing.Point(424, 546)
        Me.lblFanPWM2.Name = "lblFanPWM2"
        Me.lblFanPWM2.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM2.TabIndex = 18
        Me.lblFanPWM2.Text = "Fan 02"
        '
        'lblFanPWMp2
        '
        Me.lblFanPWMp2.AutoSize = True
        Me.lblFanPWMp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp2.Location = New System.Drawing.Point(486, 546)
        Me.lblFanPWMp2.Name = "lblFanPWMp2"
        Me.lblFanPWMp2.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp2.TabIndex = 17
        Me.lblFanPWMp2.Text = "000"
        '
        'lblFanPWM3
        '
        Me.lblFanPWM3.AutoSize = True
        Me.lblFanPWM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM3.Location = New System.Drawing.Point(424, 566)
        Me.lblFanPWM3.Name = "lblFanPWM3"
        Me.lblFanPWM3.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM3.TabIndex = 20
        Me.lblFanPWM3.Text = "Fan 03"
        '
        'lblFanPWMp3
        '
        Me.lblFanPWMp3.AutoSize = True
        Me.lblFanPWMp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp3.Location = New System.Drawing.Point(486, 566)
        Me.lblFanPWMp3.Name = "lblFanPWMp3"
        Me.lblFanPWMp3.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp3.TabIndex = 19
        Me.lblFanPWMp3.Text = "000"
        '
        'lblFanPWM4
        '
        Me.lblFanPWM4.AutoSize = True
        Me.lblFanPWM4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM4.Location = New System.Drawing.Point(424, 586)
        Me.lblFanPWM4.Name = "lblFanPWM4"
        Me.lblFanPWM4.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM4.TabIndex = 22
        Me.lblFanPWM4.Text = "Fan 04"
        '
        'lblFanPWMp4
        '
        Me.lblFanPWMp4.AutoSize = True
        Me.lblFanPWMp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp4.Location = New System.Drawing.Point(486, 586)
        Me.lblFanPWMp4.Name = "lblFanPWMp4"
        Me.lblFanPWMp4.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp4.TabIndex = 21
        Me.lblFanPWMp4.Text = "000"
        '
        'lblFanPWM5
        '
        Me.lblFanPWM5.AutoSize = True
        Me.lblFanPWM5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM5.Location = New System.Drawing.Point(424, 606)
        Me.lblFanPWM5.Name = "lblFanPWM5"
        Me.lblFanPWM5.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM5.TabIndex = 24
        Me.lblFanPWM5.Text = "Fan 05"
        '
        'lblFanPWMp5
        '
        Me.lblFanPWMp5.AutoSize = True
        Me.lblFanPWMp5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp5.Location = New System.Drawing.Point(486, 606)
        Me.lblFanPWMp5.Name = "lblFanPWMp5"
        Me.lblFanPWMp5.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp5.TabIndex = 23
        Me.lblFanPWMp5.Text = "000"
        '
        'lblFanPWM10
        '
        Me.lblFanPWM10.AutoSize = True
        Me.lblFanPWM10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM10.Location = New System.Drawing.Point(535, 606)
        Me.lblFanPWM10.Name = "lblFanPWM10"
        Me.lblFanPWM10.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM10.TabIndex = 34
        Me.lblFanPWM10.Text = "Fan 10"
        '
        'lblFanPWMp10
        '
        Me.lblFanPWMp10.AutoSize = True
        Me.lblFanPWMp10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp10.Location = New System.Drawing.Point(598, 606)
        Me.lblFanPWMp10.Name = "lblFanPWMp10"
        Me.lblFanPWMp10.Size = New System.Drawing.Size(54, 20)
        Me.lblFanPWMp10.TabIndex = 33
        Me.lblFanPWMp10.Text = "100%"
        '
        'lblFanPWM9
        '
        Me.lblFanPWM9.AutoSize = True
        Me.lblFanPWM9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM9.Location = New System.Drawing.Point(535, 586)
        Me.lblFanPWM9.Name = "lblFanPWM9"
        Me.lblFanPWM9.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM9.TabIndex = 32
        Me.lblFanPWM9.Text = "Fan 09"
        '
        'lblFanPWMp9
        '
        Me.lblFanPWMp9.AutoSize = True
        Me.lblFanPWMp9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp9.Location = New System.Drawing.Point(598, 586)
        Me.lblFanPWMp9.Name = "lblFanPWMp9"
        Me.lblFanPWMp9.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp9.TabIndex = 31
        Me.lblFanPWMp9.Text = "000"
        '
        'lblFanPWM8
        '
        Me.lblFanPWM8.AutoSize = True
        Me.lblFanPWM8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM8.Location = New System.Drawing.Point(535, 566)
        Me.lblFanPWM8.Name = "lblFanPWM8"
        Me.lblFanPWM8.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM8.TabIndex = 30
        Me.lblFanPWM8.Text = "Fan 08"
        '
        'lblFanPWMp8
        '
        Me.lblFanPWMp8.AutoSize = True
        Me.lblFanPWMp8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp8.Location = New System.Drawing.Point(598, 566)
        Me.lblFanPWMp8.Name = "lblFanPWMp8"
        Me.lblFanPWMp8.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp8.TabIndex = 29
        Me.lblFanPWMp8.Text = "000"
        '
        'lblFanPWM7
        '
        Me.lblFanPWM7.AutoSize = True
        Me.lblFanPWM7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM7.Location = New System.Drawing.Point(535, 546)
        Me.lblFanPWM7.Name = "lblFanPWM7"
        Me.lblFanPWM7.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM7.TabIndex = 28
        Me.lblFanPWM7.Text = "Fan 07"
        '
        'lblFanPWMp7
        '
        Me.lblFanPWMp7.AutoSize = True
        Me.lblFanPWMp7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp7.Location = New System.Drawing.Point(598, 546)
        Me.lblFanPWMp7.Name = "lblFanPWMp7"
        Me.lblFanPWMp7.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp7.TabIndex = 27
        Me.lblFanPWMp7.Text = "000"
        '
        'lblFanPWM6
        '
        Me.lblFanPWM6.AutoSize = True
        Me.lblFanPWM6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWM6.Location = New System.Drawing.Point(535, 526)
        Me.lblFanPWM6.Name = "lblFanPWM6"
        Me.lblFanPWM6.Size = New System.Drawing.Size(65, 20)
        Me.lblFanPWM6.TabIndex = 26
        Me.lblFanPWM6.Text = "Fan 06"
        '
        'lblFanPWMp6
        '
        Me.lblFanPWMp6.AutoSize = True
        Me.lblFanPWMp6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanPWMp6.Location = New System.Drawing.Point(598, 526)
        Me.lblFanPWMp6.Name = "lblFanPWMp6"
        Me.lblFanPWMp6.Size = New System.Drawing.Size(39, 20)
        Me.lblFanPWMp6.TabIndex = 25
        Me.lblFanPWMp6.Text = "000"
        '
        'lblPWNSpeed
        '
        Me.lblPWNSpeed.AutoSize = True
        Me.lblPWNSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWNSpeed.Location = New System.Drawing.Point(443, 524)
        Me.lblPWNSpeed.Name = "lblPWNSpeed"
        Me.lblPWNSpeed.Size = New System.Drawing.Size(201, 73)
        Me.lblPWNSpeed.TabIndex = 8
        Me.lblPWNSpeed.Text = "100%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 712)
        Me.Controls.Add(Me.lblFanPWM10)
        Me.Controls.Add(Me.lblFanPWMp10)
        Me.Controls.Add(Me.lblFanPWM9)
        Me.Controls.Add(Me.lblFanPWMp9)
        Me.Controls.Add(Me.lblFanPWM8)
        Me.Controls.Add(Me.lblFanPWMp8)
        Me.Controls.Add(Me.lblFanPWM7)
        Me.Controls.Add(Me.lblFanPWMp7)
        Me.Controls.Add(Me.lblFanPWM6)
        Me.Controls.Add(Me.lblFanPWMp6)
        Me.Controls.Add(Me.lblFanPWM5)
        Me.Controls.Add(Me.lblFanPWMp5)
        Me.Controls.Add(Me.lblFanPWM4)
        Me.Controls.Add(Me.lblFanPWMp4)
        Me.Controls.Add(Me.lblFanPWM3)
        Me.Controls.Add(Me.lblFanPWMp3)
        Me.Controls.Add(Me.lblFanPWM2)
        Me.Controls.Add(Me.lblFanPWMp2)
        Me.Controls.Add(Me.lblFanPWM1)
        Me.Controls.Add(Me.lblFanPWMp1)
        Me.Controls.Add(Me.lblUpDown)
        Me.Controls.Add(Me.lblCycleCount)
        Me.Controls.Add(Me.lblmanualup)
        Me.Controls.Add(Me.lblManualTrue)
        Me.Controls.Add(Me.lblReversed)
        Me.Controls.Add(Me.lblPWNSpeed)
        Me.Controls.Add(Me.lblMainPercentage)
        Me.Controls.Add(Me.rdoAutoramp)
        Me.Controls.Add(Me.rdoManualEnable)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gpbManual)
        Me.Controls.Add(Me.gpbAuto)
        Me.Controls.Add(Me.gpbDirect)
        Me.Controls.Add(Me.gpbPolarity)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "10 Fan PWM"
        Me.gpbPolarity.ResumeLayout(False)
        Me.gpbPolarity.PerformLayout()
        Me.gpbDirect.ResumeLayout(False)
        Me.gpbDirect.PerformLayout()
        Me.gpbAuto.ResumeLayout(False)
        Me.gpbAuto.PerformLayout()
        Me.gpbAutoPercent.ResumeLayout(False)
        Me.gpbAutoPercent.PerformLayout()
        Me.gpbManual.ResumeLayout(False)
        Me.gpbManual.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbPolarity As System.Windows.Forms.GroupBox
    Friend WithEvents gpbDirect As System.Windows.Forms.GroupBox
    Friend WithEvents gpbAuto As System.Windows.Forms.GroupBox
    Friend WithEvents gpbManual As System.Windows.Forms.GroupBox
    Friend WithEvents chkbManAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbManFan1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAutoFromP As System.Windows.Forms.Label
    Friend WithEvents lblAutoTimer As System.Windows.Forms.Label
    Friend WithEvents lblAutoDutyCycle As System.Windows.Forms.Label
    Friend WithEvents txtDutystop As System.Windows.Forms.TextBox
    Friend WithEvents txtDutyStart As System.Windows.Forms.TextBox
    Friend WithEvents lblAutoTo As System.Windows.Forms.Label
    Friend WithEvents lblAutoFrom As System.Windows.Forms.Label
    Friend WithEvents txtbxAutoDwell As System.Windows.Forms.TextBox
    Friend WithEvents lblAutoDwell As System.Windows.Forms.Label
    Friend WithEvents rdoSeconds As System.Windows.Forms.RadioButton
    Friend WithEvents rdobtnAutoUpDown As System.Windows.Forms.RadioButton
    Friend WithEvents btnResetAuto As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtbxAutoFan10 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan9 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan8 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan7 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan6 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan5 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan4 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan3 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFan1 As System.Windows.Forms.TextBox
    Friend WithEvents chkbAutoAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAutoFan1 As System.Windows.Forms.CheckBox
    Friend WithEvents gpbAutoPercent As System.Windows.Forms.GroupBox
    Friend WithEvents rdoAutoPercent1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAutoPercent5 As System.Windows.Forms.RadioButton
    Friend WithEvents btnManDown As System.Windows.Forms.Button
    Friend WithEvents btnManUp As System.Windows.Forms.Button
    Friend WithEvents rdobtnManBy1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdobtnManBy5 As System.Windows.Forms.RadioButton
    Friend WithEvents txtbxManFan10 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan9 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan8 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan7 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan6 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan5 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan4 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan3 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManFan1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManAll As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoManualEnable As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAutoramp As System.Windows.Forms.RadioButton
    Friend WithEvents btnUnpause As System.Windows.Forms.Button
    Friend WithEvents lblTimerCount As System.Windows.Forms.Label
    Friend WithEvents lblMainPercentage As System.Windows.Forms.Label
    Friend WithEvents rdobtnPolarityRev As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPolarityNormal As System.Windows.Forms.RadioButton
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtbReceived As System.Windows.Forms.RichTextBox
    Friend WithEvents lblBaudRate As System.Windows.Forms.Label
    Friend WithEvents lblComPortNum As System.Windows.Forms.Label
    Friend WithEvents rdoDirectConnect As System.Windows.Forms.RadioButton
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EnableAutoRampToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableManualRampToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableCommunicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReversedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnpauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpyGlassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblReversed As System.Windows.Forms.Label
    Friend WithEvents lblManualTrue As System.Windows.Forms.Label
    Friend WithEvents lblmanualup As System.Windows.Forms.Label
    Friend WithEvents lblCycleCount As System.Windows.Forms.Label
    Friend WithEvents lblUpDown As System.Windows.Forms.Label
    Friend WithEvents btnAutoClear As System.Windows.Forms.Button
    Friend WithEvents btnManClear As System.Windows.Forms.Button
    Friend WithEvents lblFanPWMp1 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM1 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM2 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp2 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM3 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp3 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM4 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp4 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM5 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp5 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM10 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp10 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM9 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp9 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM8 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp8 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM7 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp7 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWM6 As System.Windows.Forms.Label
    Friend WithEvents lblFanPWMp6 As System.Windows.Forms.Label
    Friend WithEvents txtbxAutoFanS10 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS9 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS8 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS7 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS6 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS5 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS4 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS3 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAutoFanS1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPWNSpeed As System.Windows.Forms.Label

End Class
