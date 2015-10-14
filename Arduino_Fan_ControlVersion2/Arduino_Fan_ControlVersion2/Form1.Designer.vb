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
        Me.components = New System.ComponentModel.Container()
        Me.rdoPercent5 = New System.Windows.Forms.RadioButton()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.lblPWNSpeed = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableAutoRampControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableManualRampControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rdoPercent1 = New System.Windows.Forms.RadioButton()
        Me.lblPercentsign2 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblAutoDuty = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPercentSign1 = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.rdoPolarityNormal = New System.Windows.Forms.RadioButton()
        Me.grbPolarity = New System.Windows.Forms.GroupBox()
        Me.rdoPolarityReversed = New System.Windows.Forms.RadioButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rdoSeconds = New System.Windows.Forms.RadioButton()
        Me.rdoMinutes = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblDwellTime = New System.Windows.Forms.Label()
        Me.btnResetAuto = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.grpbByPercentAuto = New System.Windows.Forms.GroupBox()
        Me.rdoAutoPercent1 = New System.Windows.Forms.RadioButton()
        Me.rdoAutoPercent5 = New System.Windows.Forms.RadioButton()
        Me.txtDutyStart = New System.Windows.Forms.TextBox()
        Me.grbCom = New System.Windows.Forms.GroupBox()
        Me.lblBaud = New System.Windows.Forms.Label()
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.rdoDirect = New System.Windows.Forms.RadioButton()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDutyMan = New System.Windows.Forms.TextBox()
        Me.grbAuto = New System.Windows.Forms.GroupBox()
        Me.btnUnpause = New System.Windows.Forms.Button()
        Me.txtDutystop = New System.Windows.Forms.TextBox()
        Me.txtDwell = New System.Windows.Forms.TextBox()
        Me.grbMan = New System.Windows.Forms.GroupBox()
        Me.lblManDutyCycle = New System.Windows.Forms.Label()
        Me.rdoManualramp = New System.Windows.Forms.RadioButton()
        Me.rdoAutoramp = New System.Windows.Forms.RadioButton()
        Me.lblUpDown = New System.Windows.Forms.Label()
        Me.lblManualTrue = New System.Windows.Forms.Label()
        Me.lblmanualup = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCycleCount = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grbPolarity.SuspendLayout()
        Me.grpbByPercentAuto.SuspendLayout()
        Me.grbCom.SuspendLayout()
        Me.grbAuto.SuspendLayout()
        Me.grbMan.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoPercent5
        '
        Me.rdoPercent5.AutoSize = True
        Me.rdoPercent5.Location = New System.Drawing.Point(32, 19)
        Me.rdoPercent5.Name = "rdoPercent5"
        Me.rdoPercent5.Size = New System.Drawing.Size(57, 17)
        Me.rdoPercent5.TabIndex = 3
        Me.rdoPercent5.TabStop = True
        Me.rdoPercent5.Text = "By 5 %"
        Me.rdoPercent5.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(160, 81)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 23)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(160, 52)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 0
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'lblPWNSpeed
        '
        Me.lblPWNSpeed.AutoSize = True
        Me.lblPWNSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWNSpeed.Location = New System.Drawing.Point(332, 532)
        Me.lblPWNSpeed.Name = "lblPWNSpeed"
        Me.lblPWNSpeed.Size = New System.Drawing.Size(169, 63)
        Me.lblPWNSpeed.TabIndex = 20
        Me.lblPWNSpeed.Text = "100%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(359, 518)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Fan Speed Percentage"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(521, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableAutoRampControlToolStripMenuItem, Me.EnableManualRampControlToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EnableAutoRampControlToolStripMenuItem
        '
        Me.EnableAutoRampControlToolStripMenuItem.Name = "EnableAutoRampControlToolStripMenuItem"
        Me.EnableAutoRampControlToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.EnableAutoRampControlToolStripMenuItem.Text = "Enable Auto Ramp Control"
        '
        'EnableManualRampControlToolStripMenuItem
        '
        Me.EnableManualRampControlToolStripMenuItem.Name = "EnableManualRampControlToolStripMenuItem"
        Me.EnableManualRampControlToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.EnableManualRampControlToolStripMenuItem.Text = "Enable Manual Ramp Control"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToolStripMenuItem, Me.StopToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'GoToolStripMenuItem
        '
        Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
        Me.GoToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.GoToolStripMenuItem.Text = "Go"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionToolStripMenuItem, Me.AboutToolStripMenuItem, Me.DebugToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InstructionToolStripMenuItem
        '
        Me.InstructionToolStripMenuItem.Name = "InstructionToolStripMenuItem"
        Me.InstructionToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.InstructionToolStripMenuItem.Text = "Instruction"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DebugToolStripMenuItem1
        '
        Me.DebugToolStripMenuItem1.Name = "DebugToolStripMenuItem1"
        Me.DebugToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.DebugToolStripMenuItem1.Text = "Spy Glass"
        '
        'rdoPercent1
        '
        Me.rdoPercent1.AutoSize = True
        Me.rdoPercent1.Location = New System.Drawing.Point(118, 19)
        Me.rdoPercent1.Name = "rdoPercent1"
        Me.rdoPercent1.Size = New System.Drawing.Size(57, 17)
        Me.rdoPercent1.TabIndex = 2
        Me.rdoPercent1.TabStop = True
        Me.rdoPercent1.Text = "By 1 %"
        Me.rdoPercent1.UseVisualStyleBackColor = True
        '
        'lblPercentsign2
        '
        Me.lblPercentsign2.AutoSize = True
        Me.lblPercentsign2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentsign2.Location = New System.Drawing.Point(420, 38)
        Me.lblPercentsign2.Name = "lblPercentsign2"
        Me.lblPercentsign2.Size = New System.Drawing.Size(22, 18)
        Me.lblPercentsign2.TabIndex = 18
        Me.lblPercentsign2.Text = "%"
        Me.lblPercentsign2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(16, 80)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(33, 13)
        Me.lblTimer.TabIndex = 17
        Me.lblTimer.Text = "Timer"
        '
        'lblAutoDuty
        '
        Me.lblAutoDuty.AutoSize = True
        Me.lblAutoDuty.Location = New System.Drawing.Point(305, 16)
        Me.lblAutoDuty.Name = "lblAutoDuty"
        Me.lblAutoDuty.Size = New System.Drawing.Size(58, 13)
        Me.lblAutoDuty.TabIndex = 16
        Me.lblAutoDuty.Text = "Duty Cycle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Timer"
        '
        'lblPercentSign1
        '
        Me.lblPercentSign1.AutoSize = True
        Me.lblPercentSign1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentSign1.Location = New System.Drawing.Point(304, 37)
        Me.lblPercentSign1.Name = "lblPercentSign1"
        Me.lblPercentSign1.Size = New System.Drawing.Size(22, 18)
        Me.lblPercentSign1.TabIndex = 14
        Me.lblPercentSign1.Text = "%"
        Me.lblPercentSign1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(210, 39)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 13
        Me.lblFrom.Text = "From"
        '
        'rdoPolarityNormal
        '
        Me.rdoPolarityNormal.AutoSize = True
        Me.rdoPolarityNormal.Checked = True
        Me.rdoPolarityNormal.Location = New System.Drawing.Point(33, 19)
        Me.rdoPolarityNormal.Name = "rdoPolarityNormal"
        Me.rdoPolarityNormal.Size = New System.Drawing.Size(58, 17)
        Me.rdoPolarityNormal.TabIndex = 0
        Me.rdoPolarityNormal.TabStop = True
        Me.rdoPolarityNormal.Text = "Normal"
        Me.rdoPolarityNormal.UseVisualStyleBackColor = True
        '
        'grbPolarity
        '
        Me.grbPolarity.Controls.Add(Me.rdoPolarityReversed)
        Me.grbPolarity.Controls.Add(Me.rdoPolarityNormal)
        Me.grbPolarity.Location = New System.Drawing.Point(123, 39)
        Me.grbPolarity.Name = "grbPolarity"
        Me.grbPolarity.Size = New System.Drawing.Size(248, 45)
        Me.grbPolarity.TabIndex = 22
        Me.grbPolarity.TabStop = False
        Me.grbPolarity.Text = "Polarity"
        '
        'rdoPolarityReversed
        '
        Me.rdoPolarityReversed.AutoSize = True
        Me.rdoPolarityReversed.Location = New System.Drawing.Point(166, 19)
        Me.rdoPolarityReversed.Name = "rdoPolarityReversed"
        Me.rdoPolarityReversed.Size = New System.Drawing.Size(71, 17)
        Me.rdoPolarityReversed.TabIndex = 1
        Me.rdoPolarityReversed.TabStop = True
        Me.rdoPolarityReversed.Text = "Reversed"
        Me.rdoPolarityReversed.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'rdoSeconds
        '
        Me.rdoSeconds.AutoSize = True
        Me.rdoSeconds.Location = New System.Drawing.Point(108, 55)
        Me.rdoSeconds.Name = "rdoSeconds"
        Me.rdoSeconds.Size = New System.Drawing.Size(99, 17)
        Me.rdoSeconds.TabIndex = 4
        Me.rdoSeconds.TabStop = True
        Me.rdoSeconds.Text = "Ramp Up Once"
        Me.rdoSeconds.UseVisualStyleBackColor = True
        '
        'rdoMinutes
        '
        Me.rdoMinutes.AutoSize = True
        Me.rdoMinutes.Location = New System.Drawing.Point(108, 32)
        Me.rdoMinutes.Name = "rdoMinutes"
        Me.rdoMinutes.Size = New System.Drawing.Size(91, 17)
        Me.rdoMinutes.TabIndex = 3
        Me.rdoMinutes.TabStop = True
        Me.rdoMinutes.Text = "Up and Down"
        Me.rdoMinutes.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(333, 39)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 12
        Me.lblTo.Text = "To"
        '
        'lblDwellTime
        '
        Me.lblDwellTime.AutoSize = True
        Me.lblDwellTime.Location = New System.Drawing.Point(30, 16)
        Me.lblDwellTime.Name = "lblDwellTime"
        Me.lblDwellTime.Size = New System.Drawing.Size(59, 13)
        Me.lblDwellTime.TabIndex = 10
        Me.lblDwellTime.Text = "Dwell Time"
        '
        'btnResetAuto
        '
        Me.btnResetAuto.Location = New System.Drawing.Point(367, 111)
        Me.btnResetAuto.Name = "btnResetAuto"
        Me.btnResetAuto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResetAuto.Size = New System.Drawing.Size(75, 23)
        Me.btnResetAuto.TabIndex = 9
        Me.btnResetAuto.Text = "Reset"
        Me.btnResetAuto.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(256, 111)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 8
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(134, 111)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 7
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(19, 111)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'grpbByPercentAuto
        '
        Me.grpbByPercentAuto.Controls.Add(Me.rdoAutoPercent1)
        Me.grpbByPercentAuto.Controls.Add(Me.rdoAutoPercent5)
        Me.grpbByPercentAuto.Location = New System.Drawing.Point(235, 62)
        Me.grpbByPercentAuto.Name = "grpbByPercentAuto"
        Me.grpbByPercentAuto.Size = New System.Drawing.Size(193, 41)
        Me.grpbByPercentAuto.TabIndex = 5
        Me.grpbByPercentAuto.TabStop = False
        '
        'rdoAutoPercent1
        '
        Me.rdoAutoPercent1.AutoSize = True
        Me.rdoAutoPercent1.Location = New System.Drawing.Point(110, 16)
        Me.rdoAutoPercent1.Name = "rdoAutoPercent1"
        Me.rdoAutoPercent1.Size = New System.Drawing.Size(57, 17)
        Me.rdoAutoPercent1.TabIndex = 1
        Me.rdoAutoPercent1.TabStop = True
        Me.rdoAutoPercent1.Text = "By 1 %"
        Me.rdoAutoPercent1.UseVisualStyleBackColor = True
        '
        'rdoAutoPercent5
        '
        Me.rdoAutoPercent5.AutoSize = True
        Me.rdoAutoPercent5.Location = New System.Drawing.Point(34, 16)
        Me.rdoAutoPercent5.Name = "rdoAutoPercent5"
        Me.rdoAutoPercent5.Size = New System.Drawing.Size(57, 17)
        Me.rdoAutoPercent5.TabIndex = 0
        Me.rdoAutoPercent5.TabStop = True
        Me.rdoAutoPercent5.Text = "By 5 %"
        Me.rdoAutoPercent5.UseVisualStyleBackColor = True
        '
        'txtDutyStart
        '
        Me.txtDutyStart.Location = New System.Drawing.Point(246, 35)
        Me.txtDutyStart.Name = "txtDutyStart"
        Me.txtDutyStart.Size = New System.Drawing.Size(52, 20)
        Me.txtDutyStart.TabIndex = 2
        '
        'grbCom
        '
        Me.grbCom.Controls.Add(Me.lblBaud)
        Me.grbCom.Controls.Add(Me.lblComPort)
        Me.grbCom.Controls.Add(Me.btnSend)
        Me.grbCom.Controls.Add(Me.btnConnect)
        Me.grbCom.Controls.Add(Me.btnDisconnect)
        Me.grbCom.Controls.Add(Me.rtbReceived)
        Me.grbCom.Controls.Add(Me.rdoDirect)
        Me.grbCom.Controls.Add(Me.txtTransmit)
        Me.grbCom.Controls.Add(Me.cmbBaud)
        Me.grbCom.Controls.Add(Me.cmbPort)
        Me.grbCom.Location = New System.Drawing.Point(12, 103)
        Me.grbCom.Name = "grbCom"
        Me.grbCom.Size = New System.Drawing.Size(477, 206)
        Me.grbCom.TabIndex = 14
        Me.grbCom.TabStop = False
        Me.grbCom.Text = "Communication Settings"
        '
        'lblBaud
        '
        Me.lblBaud.AutoSize = True
        Me.lblBaud.Location = New System.Drawing.Point(27, 61)
        Me.lblBaud.Name = "lblBaud"
        Me.lblBaud.Size = New System.Drawing.Size(58, 13)
        Me.lblBaud.TabIndex = 10
        Me.lblBaud.Text = "Baud Rate"
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Location = New System.Drawing.Point(25, 24)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(60, 13)
        Me.lblComPort.TabIndex = 9
        Me.lblComPort.Text = "Com Port #"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(389, 51)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(236, 19)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(236, 54)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(6, 85)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(465, 115)
        Me.rtbReceived.TabIndex = 4
        Me.rtbReceived.Text = ""
        '
        'rdoDirect
        '
        Me.rdoDirect.AutoSize = True
        Me.rdoDirect.Location = New System.Drawing.Point(331, 16)
        Me.rdoDirect.Name = "rdoDirect"
        Me.rdoDirect.Size = New System.Drawing.Size(129, 17)
        Me.rdoDirect.TabIndex = 3
        Me.rdoDirect.TabStop = True
        Me.rdoDirect.Text = "Direct Com To Control"
        Me.rdoDirect.UseVisualStyleBackColor = True
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(331, 54)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(49, 20)
        Me.txtTransmit.TabIndex = 2
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(91, 56)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(121, 21)
        Me.cmbBaud.TabIndex = 1
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(91, 21)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPort.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(401, 601)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtDutyMan
        '
        Me.txtDutyMan.Location = New System.Drawing.Point(19, 68)
        Me.txtDutyMan.Name = "txtDutyMan"
        Me.txtDutyMan.Size = New System.Drawing.Size(100, 20)
        Me.txtDutyMan.TabIndex = 4
        '
        'grbAuto
        '
        Me.grbAuto.Controls.Add(Me.btnUnpause)
        Me.grbAuto.Controls.Add(Me.lblPercentsign2)
        Me.grbAuto.Controls.Add(Me.lblTimer)
        Me.grbAuto.Controls.Add(Me.lblAutoDuty)
        Me.grbAuto.Controls.Add(Me.Label8)
        Me.grbAuto.Controls.Add(Me.lblPercentSign1)
        Me.grbAuto.Controls.Add(Me.lblFrom)
        Me.grbAuto.Controls.Add(Me.lblTo)
        Me.grbAuto.Controls.Add(Me.lblDwellTime)
        Me.grbAuto.Controls.Add(Me.btnResetAuto)
        Me.grbAuto.Controls.Add(Me.btnPause)
        Me.grbAuto.Controls.Add(Me.btnStop)
        Me.grbAuto.Controls.Add(Me.btnGo)
        Me.grbAuto.Controls.Add(Me.grpbByPercentAuto)
        Me.grbAuto.Controls.Add(Me.rdoSeconds)
        Me.grbAuto.Controls.Add(Me.rdoMinutes)
        Me.grbAuto.Controls.Add(Me.txtDutyStart)
        Me.grbAuto.Controls.Add(Me.txtDutystop)
        Me.grbAuto.Controls.Add(Me.txtDwell)
        Me.grbAuto.Location = New System.Drawing.Point(15, 347)
        Me.grbAuto.Name = "grbAuto"
        Me.grbAuto.Size = New System.Drawing.Size(461, 142)
        Me.grbAuto.TabIndex = 15
        Me.grbAuto.TabStop = False
        Me.grbAuto.Text = "Auto Fan Ramp"
        '
        'btnUnpause
        '
        Me.btnUnpause.Location = New System.Drawing.Point(256, 109)
        Me.btnUnpause.Name = "btnUnpause"
        Me.btnUnpause.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUnpause.Size = New System.Drawing.Size(75, 23)
        Me.btnUnpause.TabIndex = 19
        Me.btnUnpause.Text = "Unpause"
        Me.btnUnpause.UseVisualStyleBackColor = True
        '
        'txtDutystop
        '
        Me.txtDutystop.Location = New System.Drawing.Point(359, 36)
        Me.txtDutystop.Name = "txtDutystop"
        Me.txtDutystop.Size = New System.Drawing.Size(55, 20)
        Me.txtDutystop.TabIndex = 1
        '
        'txtDwell
        '
        Me.txtDwell.Location = New System.Drawing.Point(25, 36)
        Me.txtDwell.Name = "txtDwell"
        Me.txtDwell.Size = New System.Drawing.Size(63, 20)
        Me.txtDwell.TabIndex = 0
        '
        'grbMan
        '
        Me.grbMan.Controls.Add(Me.lblManDutyCycle)
        Me.grbMan.Controls.Add(Me.txtDutyMan)
        Me.grbMan.Controls.Add(Me.rdoPercent5)
        Me.grbMan.Controls.Add(Me.rdoPercent1)
        Me.grbMan.Controls.Add(Me.btnDown)
        Me.grbMan.Controls.Add(Me.btnUp)
        Me.grbMan.Location = New System.Drawing.Point(18, 518)
        Me.grbMan.Name = "grbMan"
        Me.grbMan.Size = New System.Drawing.Size(308, 110)
        Me.grbMan.TabIndex = 18
        Me.grbMan.TabStop = False
        Me.grbMan.Text = "Manual Fan Control"
        '
        'lblManDutyCycle
        '
        Me.lblManDutyCycle.AutoSize = True
        Me.lblManDutyCycle.Location = New System.Drawing.Point(36, 52)
        Me.lblManDutyCycle.Name = "lblManDutyCycle"
        Me.lblManDutyCycle.Size = New System.Drawing.Size(58, 13)
        Me.lblManDutyCycle.TabIndex = 5
        Me.lblManDutyCycle.Text = "Duty Cycle"
        '
        'rdoManualramp
        '
        Me.rdoManualramp.AutoSize = True
        Me.rdoManualramp.Location = New System.Drawing.Point(15, 495)
        Me.rdoManualramp.Name = "rdoManualramp"
        Me.rdoManualramp.Size = New System.Drawing.Size(132, 17)
        Me.rdoManualramp.TabIndex = 17
        Me.rdoManualramp.TabStop = True
        Me.rdoManualramp.Text = "Manual Control Enable"
        Me.rdoManualramp.UseVisualStyleBackColor = True
        '
        'rdoAutoramp
        '
        Me.rdoAutoramp.AutoSize = True
        Me.rdoAutoramp.Location = New System.Drawing.Point(15, 324)
        Me.rdoAutoramp.Name = "rdoAutoramp"
        Me.rdoAutoramp.Size = New System.Drawing.Size(139, 17)
        Me.rdoAutoramp.TabIndex = 16
        Me.rdoAutoramp.TabStop = True
        Me.rdoAutoramp.Text = "Automatic Ramp Enable"
        Me.rdoAutoramp.UseVisualStyleBackColor = True
        '
        'lblUpDown
        '
        Me.lblUpDown.AutoSize = True
        Me.lblUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpDown.Location = New System.Drawing.Point(244, 495)
        Me.lblUpDown.Name = "lblUpDown"
        Me.lblUpDown.Size = New System.Drawing.Size(0, 20)
        Me.lblUpDown.TabIndex = 23
        '
        'lblManualTrue
        '
        Me.lblManualTrue.AutoSize = True
        Me.lblManualTrue.Location = New System.Drawing.Point(133, 638)
        Me.lblManualTrue.Name = "lblManualTrue"
        Me.lblManualTrue.Size = New System.Drawing.Size(49, 13)
        Me.lblManualTrue.TabIndex = 6
        Me.lblManualTrue.Text = "Trueduty"
        '
        'lblmanualup
        '
        Me.lblmanualup.AutoSize = True
        Me.lblmanualup.Location = New System.Drawing.Point(247, 638)
        Me.lblmanualup.Name = "lblmanualup"
        Me.lblmanualup.Size = New System.Drawing.Size(56, 13)
        Me.lblmanualup.TabIndex = 7
        Me.lblmanualup.Text = "manualUP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        '
        'lblCycleCount
        '
        Me.lblCycleCount.AutoSize = True
        Me.lblCycleCount.Location = New System.Drawing.Point(34, 638)
        Me.lblCycleCount.Name = "lblCycleCount"
        Me.lblCycleCount.Size = New System.Drawing.Size(64, 13)
        Me.lblCycleCount.TabIndex = 25
        Me.lblCycleCount.Text = "Cycle Count"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 660)
        Me.Controls.Add(Me.lblCycleCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblManualTrue)
        Me.Controls.Add(Me.lblmanualup)
        Me.Controls.Add(Me.lblUpDown)
        Me.Controls.Add(Me.lblPWNSpeed)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grbPolarity)
        Me.Controls.Add(Me.grbCom)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grbAuto)
        Me.Controls.Add(Me.grbMan)
        Me.Controls.Add(Me.rdoManualramp)
        Me.Controls.Add(Me.rdoAutoramp)
        Me.Name = "frmMain"
        Me.Text = "Windows PWM Controler"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbPolarity.ResumeLayout(False)
        Me.grbPolarity.PerformLayout()
        Me.grpbByPercentAuto.ResumeLayout(False)
        Me.grpbByPercentAuto.PerformLayout()
        Me.grbCom.ResumeLayout(False)
        Me.grbCom.PerformLayout()
        Me.grbAuto.ResumeLayout(False)
        Me.grbAuto.PerformLayout()
        Me.grbMan.ResumeLayout(False)
        Me.grbMan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoPercent5 As System.Windows.Forms.RadioButton
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents lblPWNSpeed As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableAutoRampControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableManualRampControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rdoPercent1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPercentsign2 As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblAutoDuty As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPercentSign1 As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents rdoPolarityNormal As System.Windows.Forms.RadioButton
    Friend WithEvents grbPolarity As System.Windows.Forms.GroupBox
    Friend WithEvents rdoPolarityReversed As System.Windows.Forms.RadioButton
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents rdoSeconds As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMinutes As System.Windows.Forms.RadioButton
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblDwellTime As System.Windows.Forms.Label
    Friend WithEvents btnResetAuto As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents grpbByPercentAuto As System.Windows.Forms.GroupBox
    Friend WithEvents rdoAutoPercent1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAutoPercent5 As System.Windows.Forms.RadioButton
    Friend WithEvents txtDutyStart As System.Windows.Forms.TextBox
    Friend WithEvents grbCom As System.Windows.Forms.GroupBox
    Friend WithEvents lblBaud As System.Windows.Forms.Label
    Friend WithEvents lblComPort As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents rtbReceived As System.Windows.Forms.RichTextBox
    Friend WithEvents rdoDirect As System.Windows.Forms.RadioButton
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtDutyMan As System.Windows.Forms.TextBox
    Friend WithEvents grbAuto As System.Windows.Forms.GroupBox
    Friend WithEvents txtDutystop As System.Windows.Forms.TextBox
    Friend WithEvents txtDwell As System.Windows.Forms.TextBox
    Friend WithEvents grbMan As System.Windows.Forms.GroupBox
    Friend WithEvents lblManDutyCycle As System.Windows.Forms.Label
    Friend WithEvents rdoManualramp As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAutoramp As System.Windows.Forms.RadioButton
    Friend WithEvents lblUpDown As System.Windows.Forms.Label
    Friend WithEvents btnUnpause As System.Windows.Forms.Button
    Friend WithEvents lblManualTrue As System.Windows.Forms.Label
    Friend WithEvents lblmanualup As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DebugToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCycleCount As System.Windows.Forms.Label

End Class
