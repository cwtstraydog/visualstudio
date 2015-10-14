Imports System.Threading
Public Class frmMain
    Dim dwelltime As Integer
    Dim dutycyclestart As Integer
    Dim dutycyclestop As Integer
    Dim cyclenumber As Integer      'this is  a cycle checker to exit out when the user cycles are complete
    Dim operationTrue As Integer    'this is s checker to determine is the program is running to prevent user from making fatal mistake, "do not cross the beams"
    Dim trueDutycycle As Decimal     'this is the true number that is sent to the AFCD XCXC
    Dim NewDutyCycle As Decimal         'to handle decimal number BEFORE converting to truedutycycle and sending  Arduino xcxc
    Dim loopchecker As Integer      'for if then statements and loop checking !! much like the cyclenumber !!
    Dim close_on_error As Integer   'this is to close the progrma on a a fatal user error "i said not to cross the beams!"
    Dim eMessage As String
    Dim eAboutMessage As String
    Dim multiplex As Decimal            'xcxc
    Dim dutycycleM As Decimal           'xcxc
    Dim manualup As Integer
    Dim resetStart As Integer
    Dim resetStop As Integer
    Dim resetDwell As Integer
    Dim resetTrueDutyCycle As Decimal           'xcxc
    Dim multipleCheat As Integer                'because we are dealling with 2.56 and 12.8  instead of 1 and 5
    Dim reversePol As Integer
    Dim resetCyclenumber As Integer      ' for up down option

    Private Property myPort As String()
    ' Version 1.00.00 did not install on winXP and has to rewrite the program for .Net 3.5
    ' Version 1.01.01 ddid not see the the arduino
    ' Version 1.10.00 did not have the proper timer
    ' Ver. 1.20.11 Changed the math for duty cycle conversion from trueDutycycle = (99 - (dutycyclestart - 5)) to trueDutycycle = (99 - (dutycyclestart - 4))
    ' Version 1.30.10 Changed the Arduino program so this had to change. Arduino was kinda a dirty brute force through and did not exactly work as elegant as the project
    '   Deserved. Using the PWM timers in fast pwm, Better resolution better control and matches the PWM Module CT40042 much closer
    '   There are two ways to control the Arduino 0-244,  256-2.56 or 0-244 by 2. (244 is the lowest PWM that has consistant control on the fan, Expecting 12 to be 
    '   the lowest on positive polarity fans. -Man makes plans and god laughs. _unknown
    '

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        multiplex = 0
        rdoAutoPercent5.Checked = True
        rdoAutoPercent1.Checked = False
        'rdoAutoPercent10.Enabled = False
        dutycycleM = 0
        operationTrue = 0
        close_on_error = 0

        'When our form loads, auto detect all serial ports in the system and populate the cmbPort Combo box.
        myPort = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available

        'Populate the cmbBaud Combo box to common baud rates used
        cmbBaud.Items.Add(115200)
        'Other Serial Port Property
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8

        For i = 0 To UBound(myPort)             'indexing com ports
            cmbPort.Items.Add(myPort(i))
        Next

        cmbPort.Text = cmbPort.Items.Item(0)    'Set cmbPort text to the first COM port detected
        cmbBaud.Text = cmbBaud.Items.Item(0)    'Set cmbBaud text to the first Baud rate on the list

        btnDisconnect.Enabled = False           'Initially Disconnect Button is Disabled

        If cmbPort.Text <> cmbPort.Items.Item(0) Then   'check if FCD is attached
            eMessage = "Please plug fan control device into USB port. The Program will now exit."
            close_on_error = 1 'will force program to exit if the FCD is not attached
            trouble(sender, e)
        End If

        rdoSeconds.Checked = True
        rdoPolarityNormal.Checked = True



        ' SerialPort1.PortName = cmbPort.Text         'Set SerialPort1 to the selected COM port at startup
        ' SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on
        ' SerialPort1.Open()                          'Open our serial port
        ' SerialPort1.Write("94" & vbLf)
        ' SerialPort1.Close()             'Close our Serial Port
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text         'Set SerialPort1 to the selected COM port at startup
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on

        SerialPort1.Open()                          'Open our serial port


        'Add the following in a attempt to stop an open loop



        SerialPort1.Write("230" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
        SerialPort1.Write("230" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
        lblPWNSpeed.Text = "10%"


        rtbReceived.ResetText()
        rtbReceived.Text = "Fan is on and running at 10%" & vbLf
        btnConnect.Enabled = False          'Disable Connect button
        btnDisconnect.Enabled = True        'and Enable Disconnect button
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        On Error Resume Next

        SerialPort1.Write("230" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
        SerialPort1.Close()             'Close our Serial Port

        lblPWNSpeed.Text = "10%"

        rtbReceived.ResetText()
        rtbReceived.Text = "Fan is on and running at 10%" & vbLf

        btnConnect.Enabled = True
        btnDisconnect.Enabled = False

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        On Error Resume Next

        dutycyclestart = txtTransmit.Text
        cheater(sender, e)
        dutycycleM = dutycyclestart
        txtTransmit.Text = ""


        set_Fanspeed(sender, e)


    End Sub

    'some error handling subsVVV
    Private Sub cmbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPort.SelectedIndexChanged
        On Error Resume Next

        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text         'pop a message box to user if he is changing ports
        Else                                                                               'without disconnecting first.
            eMessage = "Valid only if port is Closed, Please Press the 'Disconnect Button'"
            trouble(sender, e)
        End If
    End Sub

    Private Sub cmbBaud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBaud.SelectedIndexChanged
        On Error Resume Next

        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text         'pop a message box to user if he is changing baud rate
        Else                                                                                'without disconnecting first.
            eMessage = "Valid only if port is Closed, Please Press the 'Disconnect Button'"
            trouble(sender, e)
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        'To increase one unit per second
        Label8.Text = txtDwell.Text
        'Label8.Text = Val(Label8.Text) + 1
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        On Error Resume Next

        'To stop the Timer
        'trueDutycycle = 230
        'set_Fanspeed(sender, e)
        Timer1.Enabled = False
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        On Error Resume Next
        'get variables for interations, dwell, and dutycycle start 
        'multpex is the multiplier for auto bump of duty cycle
        operationTrue = 1
        'txtDutyStart
        'txtDutystop
        'txtDwell
        If txtDwell.Text = "" Then
            eMessage = "You need a Dwell Time Value"
            trouble(sender, e)
            txtDutyStart.Text = 0
            txtDutystop.Text = 0
            txtDwell.Text = 0
        End If

        If txtDutyStart.Text = "" Then
            eMessage = "You need a Duty Start Value"
            trouble(sender, e)
            txtDutyStart.Text = 0
            txtDutystop.Text = 0
            txtDwell.Text = 0
        End If

        If txtDutystop.Text = "" Then
            eMessage = "You need a Duty Stop Value"
            trouble(sender, e)
            txtDutyStart.Text = 0
            txtDutystop.Text = 0
            txtDwell.Text = 0
        End If

        'saving window values for reset button
        If txtDutyStart.Text > 0 And txtDutystop.Text > 0 And txtDwell.Text > 0 Then
            resetStart = txtDutyStart.Text
            resetStop = txtDutystop.Text
            resetDwell = txtDwell.Text
            dutycyclestart = txtDutyStart.Text
            cheater(sender, e)
            resetTrueDutyCycle = trueDutycycle

        End If

        If rdoAutoPercent5.Checked = True Then
            multiplex = 5
        Else : multiplex = 1
        End If

       

        Label8.Text = txtDwell.Text


        dutycyclestart = txtDutyStart.Text  'start point
        dutycyclestart = dutycyclestart - multiplex
        dutycyclestop = txtDutystop.Text 'stop point
        cyclenumber = (dutycyclestop - dutycyclestart) \ multiplex  'figure number of loops
        cyclenumber = cyclenumber + 1
        resetCyclenumber = cyclenumber
        'trueDutycycle = (245 - (dutycyclestart - 2.56))
        cheater(sender, e) 'this was a second call for some reason 
        dutycycleM = dutycyclestart

      
        Timer1.Enabled = True

    End Sub

    Private Sub btnResetAuto_Click(sender As Object, e As EventArgs) Handles btnResetAuto.Click
        On Error Resume Next
        'reset was punched rebuild enviroment from beginiing
        operationTrue = 0

        txtDutyStart.Text = resetStart
        txtDutystop.Text = resetStop
        txtDwell.Text = resetDwell

        Label8.Text = txtDwell.Text

        dutycyclestart = txtDutyStart.Text  'start point
        'dutycyclestart = dutycyclestart - multiplex
        dutycyclestop = txtDutystop.Text 'stop point

        cyclenumber = (dutycyclestop - dutycyclestart) \ multiplex  'figure number of loops
        cyclenumber = cyclenumber + 1
        dutycycleM = resetStart
        trueDutycycle = resetTrueDutyCycle
        cheater(sender, e)
        set_Fanspeed(sender, e)




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        'CheckState to ensure that we have another cyckle to run
        Label8.Text = Val(Label8.Text) - 1

        '================VVV Doing up and down until button "stop" is pressed VVV==============
        'If rdoMinutes.Checked = True Then
        'cyclenumber = resetCyclenumber
        ' End If
        '================^^^ Doing up and down until button "stop" is pressed ^^^==============

        If Label8.Text <= 0 Then


            dutycyclestart = dutycyclestart + multiplex
            cheater(sender, e)
            'trueDutycycle = Val(trueDutycycle) - Val(multiplex)
            cyclenumber = cyclenumber - 1
            dutycycleM = dutycycleM + multiplex
            set_Fanspeed(sender, e)
            Label8.Text = txtDwell.Text
        End If


        If cyclenumber <= 0 Then
            cyclenumber = 0

            trueDutycycle = resetTrueDutyCycle
            dutycycleM = resetStart
            set_Fanspeed(sender, e)
            'trueDutycycle = 84
            'set_Fanspeed(sender, e)
            lblPWNSpeed.Text = "DONE!"
            Timer1.Enabled = False
        End If





    End Sub
    'the following is for error handling and user guidanceVVV
    Public Sub trouble(sender As Object, e As EventArgs)
        On Error Resume Next

        MsgBox(eMessage, vbCritical)
        eMessage = "this was cleared in the last call to trouble"
        If close_on_error = 1 Then End
        Refresh() ' FrmMain_Load(sender, e)

    End Sub

    Private Sub rdoAutoramp_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAutoramp.CheckedChanged
        On Error Resume Next

        If rdoAutoramp.Checked Then
            rtbReceived.ResetText()
            rdoDirect.Checked = False
            btnSend.Enabled = False
            txtTransmit.Enabled = False
            rdoManualramp.Checked = False
            grbAuto.Enabled = True
            grbMan.Enabled = False
        End If

    End Sub

    Private Sub rdoManualramp_CheckedChanged(sender As Object, e As EventArgs) Handles rdoManualramp.CheckedChanged
        On Error Resume Next

        If rdoManualramp.Checked Then
            rtbReceived.ResetText()
            rdoDirect.Checked = False
            btnSend.Enabled = False
            txtTransmit.Enabled = False
            rdoAutoramp.Checked = False
            grbAuto.Enabled = False
            grbMan.Enabled = True
            rdoPercent5.Checked = True
            txtDutyMan.Text = ""

        End If

    End Sub

    Private Sub rdoDirect_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDirect.CheckedChanged
        'enable direct communication to fan control device (FCD)
        On Error Resume Next

        If rdoDirect.Checked Then
            btnSend.Enabled = True
            txtTransmit.Enabled = True
            rdoManualramp.Checked = False
            rdoAutoramp.Checked = False
            grbAuto.Enabled = False
            grbMan.Enabled = False
        End If

    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        On Error Resume Next

        ReceivedText(SerialPort1.ReadExisting())    'Automatically called every time a data is received at the serialPort

    End Sub


    'Serial Data recieved routine VVV
    Private Sub ReceivedText(ByVal [text] As String)
        On Error Resume Next

        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New ContextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.rtbReceived.Text &= [text]
        End If

    End Sub

   
    'Fan control used by the entire program VVV
    Private Sub set_Fanspeed(sender As Object, e As EventArgs)
        On Error Resume Next
  

        If trueDutycycle >= 245 Or trueDutycycle > 243 Then '245 is the new 99 "245.76"
            trueDutycycle = 245
            dutycycleM = 5
            dutycyclestart = 5
        End If

        If trueDutycycle <= 0 Or trueDutycycle <= 1 Then  '0 is the new 100 ramp up and down by 2.56 1.80 last positive number and should be looked at as zero "0"
            trueDutycycle = 0
            dutycycleM = 100
            dutycyclestart = 100
        End If
        trueDutycycle = Math.Round(trueDutycycle, MidpointRounding.AwayFromZero)

        'dutycycleM = dutycyclestart

        If SerialPort1.IsOpen = True Then
            SerialPort1.Write(trueDutycycle & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
            rtbReceived.Text = "Setting fan speed to " & dutycycleM & "%" & vbLf & "trueDutycycle =" & trueDutycycle & vbLf
            lblPWNSpeed.Text = dutycycleM & "%"
        Else
            rtbReceived.Text = "Setfan Speed " & "Serial Port Closed " & vbCrLf & "Setting fan speed to " & dutycycleM & "%" & vbLf & "trueDutycycle =" & trueDutycycle & vbLf
            lblPWNSpeed.Text = dutycycleM & "%"
        End If

        'plus the Line feed (New Line) as arduino is in need of that to know when the message is over.
        'txtTransmit.Text = ""
    End Sub

    Private Sub rdoAutoPercent5_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAutoPercent5.CheckedChanged
        On Error Resume Next

        If rdoAutoPercent5.Checked = True Then
            multiplex = 5
            rdoAutoPercent1.Checked = False
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        'hide a button "visable enbale = no" that reads unpause
        'force program into a loop that while unpause butteon visble is enabled the progtram waits for it to be visiable disabled
        'btnResetAuto.Visible = True
        'btnPause.Visible = False
    End Sub

    'Manual controls VVV
    'the following is for the up button in manual mode VVV

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        On Error Resume Next

        If rdoPercent5.Checked = True Then
            multiplex = 5
        Else : multiplex = 1

        End If

        If trueDutycycle <= 245 Then
            'turn on the down button
            btnDown.Enabled = True
        End If


        If manualup = 0 Then
            dutycyclestart = txtDutyMan.Text  'start point
            'trueDutycycle = (245 - (dutycyclestart - 2.56))
            cheater(sender, e)
            dutycycleM = dutycyclestart

            'if the duty cycle is at its highest we want to stop the user from going any higher
            If trueDutycycle <= 0 Then
                btnUp.Enabled = False
            End If

        End If

        If rdoManualramp.Checked = True And manualup <> 0 Then
            dutycycleM = dutycycleM + multiplex
            dutycyclestart = dutycyclestart + multiplex
            cheater(sender, e)
            'trueDutycycle = trueDutycycle - multiplex

            'if the duty cycle is at its highest we want to stop the user from going any higher
            If trueDutycycle <= 5 Then
                btnUp.Enabled = False
            End If

        End If
        'SEND THE FAN CONTROLER THE DESIRE FAN SPEED
        set_Fanspeed(sender, e)

        If manualup = 0 Then
            manualup = manualup + 1
        End If

    End Sub
    'the following is for the down button in manual mode VVV

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        On Error Resume Next

        If rdoPercent5.Checked = True Then
            multiplex = 5
        Else : multiplex = 1
        End If

        If trueDutycycle >= 5 Then
            'we just want to turn on the up button
            btnUp.Enabled = True
        End If


        If manualup = 0 Then
            dutycyclestart = txtDutyMan.Text  'start point a fresh start cause the manualup varible is equal to zero
            cheater(sender, e)
            'trueDutycycle = (245 - (dutycyclestart - 2.56))
            dutycycleM = dutycyclestart

            'if the duty cycle is at its lowest we want to stop the user from going any lower
            If trueDutycycle >= 245 Then
                btnDown.Enabled = False
            End If

        End If

        If rdoManualramp.Checked = True And manualup <> 0 Then
            dutycycleM = dutycycleM - multiplex
            dutycyclestart = dutycyclestart - multiplex
            cheater(sender, e)
            'trueDutycycle = trueDutycycle + multiplex

            'if the duty cycle is at its lowest we want to stop the user from going any lower
            If trueDutycycle >= 245 Then
                btnDown.Enabled = False
            End If

        End If

        'go change the fan speed
        set_Fanspeed(sender, e)

        If manualup = 0 Then
            manualup = manualup + 1
        End If


    End Sub

    Private Sub txtDutyMan_TextChanged(sender As Object, e As EventArgs) Handles txtDutyMan.TextChanged
        On Error Resume Next
        'the text box changed which means the user wants to start some pllace else lets reset the button conditions

        manualup = 0
    End Sub

    Private Sub txtDwell_TextChanged(sender As Object, e As EventArgs) Handles txtDwell.TextChanged
        On Error Resume Next
        If operationTrue = 0 Then
            txtDwell.Refresh()
            resetDwell = txtDwell.Text
        End If

    End Sub

    Private Sub txtDutyStart_TextChanged(sender As Object, e As EventArgs) Handles txtDutyStart.TextChanged
        On Error Resume Next
        If operationTrue = 0 Then
            txtDutyStart.Refresh()
            resetStart = txtDutyStart.Text
        End If
    End Sub

    Private Sub txtDutystop_TextChanged(sender As Object, e As EventArgs) Handles txtDutystop.TextChanged
        On Error Resume Next
        If operationTrue = 0 Then
            txtDutystop.Refresh()
            resetStop = txtDutystop.Text
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grbMan.Enter
        On Error Resume Next

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles grbAuto.Enter
        On Error Resume Next

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles grbCom.Enter
        On Error Resume Next

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        On Error Resume Next
        btnExit_Click(sender, e)
    End Sub

    Private Sub EnableAutoRampControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableAutoRampControlToolStripMenuItem.Click
        On Error Resume Next
        rdoAutoramp.Checked = True
        rdoAutoramp_CheckedChanged(sender, e)
    End Sub

    Private Sub EnableManualRampControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableManualRampControlToolStripMenuItem.Click
        On Error Resume Next
        rdoManualramp.Checked = True
        rdoManualramp_CheckedChanged(sender, e)
    End Sub

    Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click
        On Error Resume Next
        btnGo_Click(sender, e)
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        On Error Resume Next
        btnStop_Click(sender, e)
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        On Error Resume Next
        btnPause_Click(sender, e)
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        On Error Resume Next
        btnResetAuto_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        On Error Resume Next
        eAboutMessage = "Windows Control For Arduino Fan Control Device" & vbLf & "Written For EMESC By EmigJ" & vbLf & "Version 1.10.11 07-26-2014"
        MsgBox(eAboutMessage, MsgBoxStyle.OkOnly)

        'MsgBoxStyle.OkOnly()
    End Sub

    Private Sub InstructionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionToolStripMenuItem.Click
        On Error Resume Next
        eAboutMessage = "Nothing To See Here" & vbLf & "Move Along" & vbLf & "This Will Be Written When The Program Is Finalized (Ver 1.25..8)"
        MsgBox(eAboutMessage, MsgBoxStyle.OkOnly)

    End Sub

    Private Sub lblPWNSpeed_Click(sender As Object, e As EventArgs) Handles lblPWNSpeed.Click

    End Sub

    Private Sub rdoPercent5_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPercent5.CheckedChanged

    End Sub

    Private Sub cheater(sender As Object, e As EventArgs)
        On Error Resume Next
        If dutycyclestart = 0 And reversePol = 1 Then trueDutycycle = 245.0 '      else truedutycycle = 	12.04
        If dutycyclestart = 1 And reversePol = 1 Then trueDutycycle = 245.0 '      else truedutycycle = 	12.04
        If dutycyclestart = 2 And reversePol = 1 Then trueDutycycle = 245.0 '      else truedutycycle = 	12.04
        If dutycyclestart = 3 And reversePol = 1 Then trueDutycycle = 245.0 '      else truedutycycle = 	12.04

        If dutycyclestart = 4 And reversePol = 1 Then trueDutycycle = 245.0 '      else truedutycycle = 	12.04
        If dutycyclestart = 5 And reversePol = 1 Then trueDutycycle = 242.44 '      else truedutycycle = 	14.6
        If dutycyclestart = 6 And reversePol = 1 Then trueDutycycle = 239.88 '      else truedutycycle = 	17.16
        If dutycyclestart = 7 And reversePol = 1 Then trueDutycycle = 237.32 '      else truedutycycle = 	19.72
        If dutycyclestart = 8 And reversePol = 1 Then trueDutycycle = 234.76 '      else truedutycycle = 	22.28
        If dutycyclestart = 9 And reversePol = 1 Then trueDutycycle = 232.2 '      else truedutycycle = 	24.84
        If dutycyclestart = 10 And reversePol = 1 Then trueDutycycle = 229.64 '      else truedutycycle = 	27.4
        If dutycyclestart = 11 And reversePol = 1 Then trueDutycycle = 227.08 '      else truedutycycle = 	29.96
        If dutycyclestart = 12 And reversePol = 1 Then trueDutycycle = 224.52 '      else truedutycycle = 	32.52
        If dutycyclestart = 13 And reversePol = 1 Then trueDutycycle = 221.96 '      else truedutycycle = 	35.08
        If dutycyclestart = 14 And reversePol = 1 Then trueDutycycle = 219.4 '      else truedutycycle = 	37.64
        If dutycyclestart = 15 And reversePol = 1 Then trueDutycycle = 216.84 '      else truedutycycle = 	40.2
        If dutycyclestart = 16 And reversePol = 1 Then trueDutycycle = 214.28 '      else truedutycycle = 	42.76
        If dutycyclestart = 17 And reversePol = 1 Then trueDutycycle = 211.72 '      else truedutycycle = 	45.32
        If dutycyclestart = 18 And reversePol = 1 Then trueDutycycle = 209.16 '      else truedutycycle = 	47.88
        If dutycyclestart = 19 And reversePol = 1 Then trueDutycycle = 206.6 '      else truedutycycle = 	50.44
        If dutycyclestart = 20 And reversePol = 1 Then trueDutycycle = 204.04 '      else truedutycycle = 	53
        If dutycyclestart = 21 And reversePol = 1 Then trueDutycycle = 201.48 '      else truedutycycle = 	55.56
        If dutycyclestart = 22 And reversePol = 1 Then trueDutycycle = 198.92 '      else truedutycycle = 	58.12
        If dutycyclestart = 23 And reversePol = 1 Then trueDutycycle = 196.36 '      else truedutycycle = 	60.68
        If dutycyclestart = 24 And reversePol = 1 Then trueDutycycle = 193.8 '      else truedutycycle = 	63.24
        If dutycyclestart = 25 And reversePol = 1 Then trueDutycycle = 191.24 '      else truedutycycle = 	65.8
        If dutycyclestart = 26 And reversePol = 1 Then trueDutycycle = 188.68 '      else truedutycycle = 	68.36
        If dutycyclestart = 27 And reversePol = 1 Then trueDutycycle = 186.12 '      else truedutycycle = 	70.92
        If dutycyclestart = 28 And reversePol = 1 Then trueDutycycle = 183.56 '      else truedutycycle = 	73.48
        If dutycyclestart = 29 And reversePol = 1 Then trueDutycycle = 181.0 '      else truedutycycle = 	76.04
        If dutycyclestart = 30 And reversePol = 1 Then trueDutycycle = 179.44 '      else truedutycycle = 	78.6
        If dutycyclestart = 31 And reversePol = 1 Then trueDutycycle = 175.88 '      else truedutycycle = 	81.16
        If dutycyclestart = 32 And reversePol = 1 Then trueDutycycle = 173.32 '      else truedutycycle = 	83.72
        If dutycyclestart = 33 And reversePol = 1 Then trueDutycycle = 170.76 '      else truedutycycle = 	86.28
        If dutycyclestart = 34 And reversePol = 1 Then trueDutycycle = 168.2 '      else truedutycycle = 	88.84
        If dutycyclestart = 35 And reversePol = 1 Then trueDutycycle = 165.64 '      else truedutycycle = 	91.4
        If dutycyclestart = 36 And reversePol = 1 Then trueDutycycle = 163.08 '      else truedutycycle = 	93.96
        If dutycyclestart = 37 And reversePol = 1 Then trueDutycycle = 160.52 '      else truedutycycle = 	96.52
        If dutycyclestart = 38 And reversePol = 1 Then trueDutycycle = 157.96 '      else truedutycycle = 	99.08
        If dutycyclestart = 39 And reversePol = 1 Then trueDutycycle = 155.4 '      else truedutycycle = 	101.64
        If dutycyclestart = 40 And reversePol = 1 Then trueDutycycle = 152.84 '      else truedutycycle = 	104.2
        If dutycyclestart = 41 And reversePol = 1 Then trueDutycycle = 150.28 '      else truedutycycle = 	106.76
        If dutycyclestart = 42 And reversePol = 1 Then trueDutycycle = 147.72 '      else truedutycycle = 	109.32
        If dutycyclestart = 43 And reversePol = 1 Then trueDutycycle = 145.16 '      else truedutycycle = 	111.88
        If dutycyclestart = 44 And reversePol = 1 Then trueDutycycle = 142.6 '      else truedutycycle = 	114.44
        If dutycyclestart = 45 And reversePol = 1 Then trueDutycycle = 140.04 '      else truedutycycle = 	117
        If dutycyclestart = 46 And reversePol = 1 Then trueDutycycle = 137.48 '      else truedutycycle = 	119.56
        If dutycyclestart = 47 And reversePol = 1 Then trueDutycycle = 134.92 '      else truedutycycle = 	122.12
        If dutycyclestart = 48 And reversePol = 1 Then trueDutycycle = 132.36 '      else truedutycycle = 	124.68
        If dutycyclestart = 49 And reversePol = 1 Then trueDutycycle = 129.8 '      else truedutycycle = 	127.24
        If dutycyclestart = 50 And reversePol = 1 Then trueDutycycle = 127.24 '      else truedutycycle = 	129.8
        If dutycyclestart = 51 And reversePol = 1 Then trueDutycycle = 124.68 '      else truedutycycle = 	132.36
        If dutycyclestart = 52 And reversePol = 1 Then trueDutycycle = 122.12 '      else truedutycycle = 	134.92
        If dutycyclestart = 53 And reversePol = 1 Then trueDutycycle = 119.56 '      else truedutycycle = 	137.48
        If dutycyclestart = 54 And reversePol = 1 Then trueDutycycle = 117.0 '      else truedutycycle = 	140.04
        If dutycyclestart = 55 And reversePol = 1 Then trueDutycycle = 114.44 '      else truedutycycle = 	142.6
        If dutycyclestart = 56 And reversePol = 1 Then trueDutycycle = 111.88 '      else truedutycycle = 	145.16
        If dutycyclestart = 57 And reversePol = 1 Then trueDutycycle = 109.32 '      else truedutycycle = 	147.72
        If dutycyclestart = 58 And reversePol = 1 Then trueDutycycle = 106.76 '      else truedutycycle = 	150.28
        If dutycyclestart = 59 And reversePol = 1 Then trueDutycycle = 104.2 '      else truedutycycle = 	152.84
        If dutycyclestart = 60 And reversePol = 1 Then trueDutycycle = 101.64 '      else truedutycycle = 	155.4
        If dutycyclestart = 61 And reversePol = 1 Then trueDutycycle = 99.08 '      else truedutycycle = 	157.96
        If dutycyclestart = 62 And reversePol = 1 Then trueDutycycle = 96.52 '      else truedutycycle = 	160.52
        If dutycyclestart = 63 And reversePol = 1 Then trueDutycycle = 93.96 '      else truedutycycle = 	163.08
        If dutycyclestart = 64 And reversePol = 1 Then trueDutycycle = 91.4 '      else truedutycycle = 	165.64
        If dutycyclestart = 65 And reversePol = 1 Then trueDutycycle = 88.84 '      else truedutycycle = 	168.2
        If dutycyclestart = 66 And reversePol = 1 Then trueDutycycle = 86.28 '      else truedutycycle = 	170.76
        If dutycyclestart = 67 And reversePol = 1 Then trueDutycycle = 83.72 '      else truedutycycle = 	173.32
        If dutycyclestart = 68 And reversePol = 1 Then trueDutycycle = 81.16 '      else truedutycycle = 	175.88
        If dutycyclestart = 69 And reversePol = 1 Then trueDutycycle = 78.6 '      else truedutycycle = 	178.44
        If dutycyclestart = 70 And reversePol = 1 Then trueDutycycle = 77 '      else truedutycycle = 	181
        If dutycyclestart = 71 And reversePol = 1 Then trueDutycycle = 73.48 '      else truedutycycle = 	183.56
        If dutycyclestart = 72 And reversePol = 1 Then trueDutycycle = 70.92 '      else truedutycycle = 	186.12
        If dutycyclestart = 73 And reversePol = 1 Then trueDutycycle = 68.36 '      else truedutycycle = 	188.68
        If dutycyclestart = 74 And reversePol = 1 Then trueDutycycle = 65.8 '      else truedutycycle = 	191.24
        If dutycyclestart = 75 And reversePol = 1 Then trueDutycycle = 63.24 '      else truedutycycle = 	193.8
        If dutycyclestart = 76 And reversePol = 1 Then trueDutycycle = 60.68 '      else truedutycycle = 	196.36
        If dutycyclestart = 77 And reversePol = 1 Then trueDutycycle = 58.12 '      else truedutycycle = 	198.92
        If dutycyclestart = 78 And reversePol = 1 Then trueDutycycle = 55.56 '      else truedutycycle = 	201.48
        If dutycyclestart = 79 And reversePol = 1 Then trueDutycycle = 53.0 '      else truedutycycle = 	204.04
        If dutycyclestart = 80 And reversePol = 1 Then trueDutycycle = 50.44 '      else truedutycycle = 	206.6
        If dutycyclestart = 81 And reversePol = 1 Then trueDutycycle = 47.88 '      else truedutycycle = 	209.16
        If dutycyclestart = 82 And reversePol = 1 Then trueDutycycle = 45.32 '      else truedutycycle = 	211.72
        If dutycyclestart = 83 And reversePol = 1 Then trueDutycycle = 42.76 '      else truedutycycle = 	214.28
        If dutycyclestart = 84 And reversePol = 1 Then trueDutycycle = 40.2 '      else truedutycycle = 	216.84
        If dutycyclestart = 85 And reversePol = 1 Then trueDutycycle = 37.64 '      else truedutycycle = 	219.4
        If dutycyclestart = 86 And reversePol = 1 Then trueDutycycle = 35.08 '      else truedutycycle = 	221.96
        If dutycyclestart = 87 And reversePol = 1 Then trueDutycycle = 32.52 '      else truedutycycle = 	224.52
        If dutycyclestart = 88 And reversePol = 1 Then trueDutycycle = 29.96 '      else truedutycycle = 	227.08
        If dutycyclestart = 89 And reversePol = 1 Then trueDutycycle = 27.4 '      else truedutycycle = 	229.64
        If dutycyclestart = 90 And reversePol = 1 Then trueDutycycle = 24.84 '      else truedutycycle = 	232.2
        If dutycyclestart = 91 And reversePol = 1 Then trueDutycycle = 23 '      else truedutycycle = 	234.76
        If dutycyclestart = 92 And reversePol = 1 Then trueDutycycle = 19.72 '      else truedutycycle = 	237.32
        If dutycyclestart = 93 And reversePol = 1 Then trueDutycycle = 17.16 '      else truedutycycle = 	239.88
        If dutycyclestart = 94 And reversePol = 1 Then trueDutycycle = 14.6 '      else truedutycycle = 	242.44
        If dutycyclestart = 95 And reversePol = 1 Then trueDutycycle = 13 '      else truedutycycle = 	245
        If dutycyclestart = 96 And reversePol = 1 Then trueDutycycle = 9.48 '      else truedutycycle = 	247.56
        If dutycyclestart = 97 And reversePol = 1 Then trueDutycycle = 6.92 '      else truedutycycle = 	250.12
        If dutycyclestart = 98 And reversePol = 1 Then trueDutycycle = 4.36 '      else truedutycycle = 	252.68
        If dutycyclestart = 99 And reversePol = 1 Then trueDutycycle = 1.8 '      else truedutycycle = 	255.24
        If dutycyclestart = 100 And reversePol = 1 Then trueDutycycle = 0.0 '      else truedutycycle = 	256



    End Sub

    Private Sub rdoPolarityNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPolarityNormal.CheckedChanged
        On Error Resume Next
        If rdoPolarityNormal.Checked = True Then reversePol = 1

    End Sub

    Private Sub rdoPolarityReversed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPolarityReversed.CheckedChanged
        On Error Resume Next
        If rdoPolarityReversed.Checked = True Then reversePol = 0

    End Sub

 
    Private Sub rdoSeconds_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSeconds.CheckedChanged

    End Sub

    Private Sub rdoMinutes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMinutes.CheckedChanged

    End Sub
End Class
