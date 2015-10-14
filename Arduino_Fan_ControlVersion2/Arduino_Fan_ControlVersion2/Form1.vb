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
    Dim multiplex As Decimal
    Dim dutycycleM As Decimal           '
    Dim manualup As Integer             'Flag bit to signal the first time through the manual process
    Dim manualdown As Integer           'To flag the first time through the manual down function
    Dim resetStart As Integer
    Dim resetStop As Integer
    Dim resetDwell As Integer
    Dim resetTrueDutyCycle As Decimal           '
    Dim multipleCheat As Integer                'because we are dealling with 2.56 and 12.8  instead of 1 and 5
    Dim reversePol As Integer
    Dim resetCyclenumber As Integer      ' for up down option
    Dim updown As Integer                   'Flag bit for up down 0 is down 1 is up
    Dim labelEnable As Integer              'Flag bit for debug will enable hidden labels

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
    '   Version 2.00.01 started on 08/08/2014
    '       To Do List :
    '       Add continous ramp up and down                                                                                                      Completed 08/09/2014
    '       ad reveresed polarity code so the radio buttons work                                                                                Completed 08/09/2014
    '       better user experience with "autoramp" buttons ie; disable buttons that can not or should not be used during certian operations     Completed 08/11/2014
    '       Labeling indicators                                                                                                                 Completed 08/11/2014
    '       work on menu bar information                                                                                                        Completed 08/12/2014
    '       Change "About" information before publishing                                                                                        Completed 08/12/2014
    '       Manual up stops at 98% (?) WTF?                                                                                                     Completed 08/12/2014  
    '       Manual has bad increment and decrement code there is something in the if/then statements                                            Completed 08/12/2014
    '       Added A Debug Spy into code to view some vairbles during operation                                                                  Completed 08/12/2014

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        On Error Resume Next
        End
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        multiplex = 0
        rdoAutoPercent5.Checked = True
        rdoAutoPercent1.Checked = False
        reversePol = 1
        dutycycleM = 0
        operationTrue = 0
        close_on_error = 0
        manualdown = 0
        manualup = 0

        '==========VVV These are used for debug and should be visible during normal use VVV==================
        Label1.Text = "reversePol = " & reversePol    'xcxc
        Label1.Visible = False
        lblManualTrue.Visible = False
        lblmanualup.Visible = False
        lblCycleCount.Visible = False
        '==========^^^ These are used for debug and should be visible during normal use ^^^==================


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
        rdoAutoramp.Checked = True
        btnUnpause.Visible = False
        btnPause.Enabled = False
        btnResetAuto.Enabled = False
        btnStop.Enabled = False
        lblPWNSpeed.Text = "Ready"
        Label1.Text = reversePol
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        On Error Resume Next
        SerialPort1.PortName = cmbPort.Text         'Set SerialPort1 to the selected COM port at startup
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on

        SerialPort1.Open()                          'Open our serial port

        SerialPort1.Write("230" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
        SerialPort1.Write("230" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii

        dutycyclestart = 25
        dutycycleM = dutycyclestart
        cheater(sender, e)   'Loads PWM into Varible trueDutycycle
        set_Fanspeed(sender, e)


        rtbReceived.ResetText()
        rtbReceived.Text = "Fan is on and running at " & dutycycleM & "%" & vbLf & "Connected!"
        btnConnect.Enabled = False          'Disable Connect button
        btnDisconnect.Enabled = True        'and Enable Disconnect button
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        On Error Resume Next

        dutycycleM = 25
        dutycyclestart = 25
        cheater(sender, e)   'Loads PWM into Varible trueDutycycle
        set_Fanspeed(sender, e)

        rtbReceived.ResetText()
        rtbReceived.Text = "Fan is on and running at " & dutycycleM & "%" & vbLf & "Disconnected"

        btnConnect.Enabled = True
        btnDisconnect.Enabled = False

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        On Error Resume Next

        dutycyclestart = txtTransmit.Text
        cheater(sender, e)   'Loads PWM into Varible trueDutycycle
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
        On Error Resume Next
        'To increase one unit per second
        'Label8.Text = txtDwell.Text

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        On Error Resume Next
        If operationTrue = 1 Then
            btnPause.Enabled = False
            btnPause.Visible = True
            btnUnpause.Enabled = False
            btnUnpause.Visible = False
            btnResetAuto.Enabled = True
            'To stop the Timer

            If btnUnpause.Enabled = True Then
                btnUnpause.Enabled = False
                btnUnpause.Visible = False
                btnPause.Enabled = True
            End If

            Timer1.Enabled = False
            btnGo.Enabled = True

            dutycyclestart = txtDutyStart.Text
            dutycycleM = dutycyclestart
            cheater(sender, e)   'Loads PWM into Varible trueDutycycle
            set_Fanspeed(sender, e)

            rtbReceived.ResetText()
            rtbReceived.Text = "Fan is on and running at " & dutycycleM & "%" & vbLf

        End If
        btnStop.Enabled = False
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        On Error Resume Next
        'get variables for interations, dwell, and dutycycle start 
        'multpex is the multiplier for auto bump of duty cycle

        If rdoAutoPercent5.Checked = True Then
            multiplex = 5
        Else : multiplex = 1

        End If

        operationTrue = 1
        btnPause.Enabled = True
        btnResetAuto.Enabled = False
        btnPause.Visible = True
        btnUnpause.Visible = False


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
            cheater(sender, e)   'Loads PWM into Varible trueDutycycle
            resetTrueDutyCycle = trueDutycycle

        End If

        Label8.Text = txtDwell.Text

        dutycyclestart = txtDutyStart.Text  'start point
        dutycyclestart = dutycyclestart - multiplex
        dutycyclestop = txtDutystop.Text 'stop point
        cyclenumber = (dutycyclestop - dutycyclestart) \ multiplex  'figure number of loops

        If rdoMinutes.Checked = True Then
            cyclenumber = cyclenumber
        Else : cyclenumber = cyclenumber + 1
        End If


        resetCyclenumber = cyclenumber - 1

        cheater(sender, e)   'Loads PWM into Varible trueDutycycle 'this was a second call for some reason 
        dutycycleM = dutycyclestart
        Timer1.Enabled = True
        btnGo.Enabled = False
        btnStop.Enabled = True

    End Sub
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        On Error Resume Next
        btnPause.Enabled = False
        btnPause.Visible = False
        btnUnpause.Enabled = True
        btnUnpause.Visible = True


        Timer1.Stop()

    End Sub


    Private Sub btnUnpause_Click(sender As Object, e As EventArgs) Handles btnUnpause.Click
        On Error Resume Next
        btnUnpause.Enabled = False
        btnUnpause.Visible = False
        btnPause.Enabled = True
        btnPause.Visible = True

        Timer1.Start()

    End Sub
    Private Sub btnResetAuto_Click(sender As Object, e As EventArgs) Handles btnResetAuto.Click
        On Error Resume Next
        'reset was punched rebuild enviroment from beginiing
        operationTrue = 0
        updown = 0
        txtDutyStart.Text = resetStart
        txtDutystop.Text = resetStop
        txtDwell.Text = resetDwell

        Label8.Text = txtDwell.Text


        dutycyclestart = txtDutyStart.Text
        cheater(sender, e)   'Loads PWM into Varible trueDutycycle
        dutycycleM = dutycyclestart
        set_Fanspeed(sender, e)

        btnGo.Enabled = True
        btnPause.Enabled = False
        btnUnpause.Visible = True
        btnUnpause.Enabled = False
        btnUnpause.Visible = False
        btnStop.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        'CheckState to ensure that we have another cyckle to run
        Label8.Text = Val(Label8.Text) - 1

        '================VVV Doing up and down until button "stop" is pressed VVV==============
        ' 1 is down 0 is up

        If rdoMinutes.Checked = True And Label8.Text <= 0 Then
            If cyclenumber <= 0 Then
                cyclenumber = resetCyclenumber

                If updown = 0 Then
                    updown = 1
                Else : updown = 0
                End If
            End If

            If updown = 0 Then      'we are going up wich is more than normal
                lblUpDown.Text = "UP!"

                dutycyclestart = dutycyclestart + multiplex
                cheater(sender, e)   'Loads PWM into Varible trueDutycycle
                cyclenumber = cyclenumber - 1
                dutycycleM = dutycycleM + multiplex
                set_Fanspeed(sender, e)
                Label8.Text = txtDwell.Text

            End If

            If updown = 1 Then      'we are going down is is opposite of normal
                lblUpDown.Text = "DOWN!"
                dutycyclestart = dutycyclestart - multiplex
                cheater(sender, e)   'Loads PWM into Varible trueDutycycle
                cyclenumber = cyclenumber - 1
                dutycycleM = dutycycleM - multiplex
                set_Fanspeed(sender, e)
                Label8.Text = txtDwell.Text

            End If
        End If


        '================^^^ Doing up and down until button "stop" is pressed ^^^==============

        If rdoMinutes.Checked = False And Label8.Text <= 0 Then

            dutycyclestart = dutycyclestart + multiplex
            cheater(sender, e)   'Loads PWM into Varible trueDutycycle

            cyclenumber = cyclenumber - 1
            dutycycleM = dutycycleM + multiplex
            set_Fanspeed(sender, e)
            Label8.Text = txtDwell.Text
        End If


        If rdoMinutes.Checked = False And cyclenumber <= 0 Then
            cyclenumber = 0

            trueDutycycle = resetTrueDutyCycle
            dutycycleM = resetStart
            set_Fanspeed(sender, e)

            lblPWNSpeed.Text = "DONE!"
            Timer1.Enabled = False
            btnGo.Enabled = True
            btnStop_Click(sender, e)
            btnResetAuto_Click(sender, e)
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
            txtDutyMan.Text = ""
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
            Label8.Text = "Timer"
            txtDwell.Text = ""
            txtDutyStart.Text = ""
            txtDutystop.Text = ""
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

        If SerialPort1.IsOpen = True Then
            SerialPort1.Write(trueDutycycle & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
            rtbReceived.Text = "Setting fan speed to " & dutycycleM & "%" & vbLf & "trueDutycycle =" & trueDutycycle & vbLf
            lblPWNSpeed.Text = dutycycleM & "%"
        Else
            rtbReceived.Text = "Serial Port Is Closed!!" & vbLf & "Setfan Speed " & "Serial Port Closed " & vbCrLf & "Setting fan speed to " & dutycycleM & "%" & vbLf & "trueDutycycle =" & trueDutycycle & vbLf
            lblPWNSpeed.Text = dutycycleM & "%"
        End If

        'plus the Line feed (New Line) as arduino is in need of that to know when the message is over.


        rtbReceived.Text = "Fan is on and running at " & dutycycleM & "%" & vbLf
        lblManualTrue.Text = "truedutycycle = " & trueDutycycle 'xcxc
        lblCycleCount.Text = "Cycle Count = " & cyclenumber
    End Sub

    Private Sub rdoAutoPercent5_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAutoPercent5.CheckedChanged
        On Error Resume Next
    End Sub



    'Manual controls VVV
    'the following is for the up button in manual mode VVV

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        On Error Resume Next

        '===========checking varibles and set up increment values
        If rdoPercent5.Checked = True Then
            multiplex = 5
        Else : multiplex = 1
        End If

        If txtDutyMan.Text < 5 Then txtDutyMan.Text = 5
        If txtDutyMan.Text > 100 Then txtDutyMan.Text = 100

        If manualup <> 0 Or manualdown <> 0 Then   ' this is not the first time through and we check if this is the users intention (maybe take out the rdomanualramp check
            dutycyclestart = dutycyclestart + multiplex
            cheater(sender, e)   'Loads PWM into Varible trueDutycycle
            dutycycleM = dutycyclestart
            lblmanualup.Text = "(up) one is not zero " & "up " & manualup & " " & "Down " & manualdown
        End If

        If manualdown = 0 And manualup = 0 Then    'checkng manual flag bit  for 1st time through if this is not the first time through we skip this operation
            dutycyclestart = txtDutyMan.Text  'start point
            cheater(sender, e)   'Loads PWM into Varible trueDutycycle 
            dutycycleM = dutycyclestart
            lblmanualup.Text = "(up) both are zero " & "up " & manualup & " " & "Down " & manualdown

            If manualup = 0 Then
                manualup = manualup + 1
            End If
            
        End If

        lblUpDown.Text = "UP!"  'Tell the user the direction that was just used

        'SEND THE FAN CONTROLER THE DESIRE FAN SPEED
        set_Fanspeed(sender, e)

        If dutycyclestart = 100 Then btnUp.Enabled = False 'highest level disable the "up" button
        If dutycyclestart < 100 Then btnUp.Enabled = True 'not highest level enable up button 'we can go higher!
        If dutycyclestart <= 5 Then btnDown.Enabled = False 'we are as slow as we can go turn off the "down" button
        If dutycyclestart > 5 Then btnDown.Enabled = True 'we can go slower so turn on the "down" button



    End Sub
    'the following is for the down button in manual mode VVV

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        On Error Resume Next



        If rdoPercent5.Checked = True Then
            multiplex = 5
        Else : multiplex = 1
        End If

        If manualup <> 0 Or manualdown <> 0 Then
            dutycyclestart = dutycyclestart - multiplex
            cheater(sender, e)   'Loads PWM into Varible trueDutycycle
            dutycycleM = dutycyclestart
            lblmanualup.Text = "(down) one is not zero " & "up " & manualup & " " & "Down " & manualdown
        End If

        If manualdown = 0 And manualup = 0 Then
            dutycyclestart = txtDutyMan.Text  'start point a fresh start cause the manualup varible is equal to zero
            cheater(sender, e)   'Loads PWM into Varible trueDutycycle
            dutycycleM = dutycyclestart
            lblmanualup.Text = "(down) both are zero " & "up " & manualup & " " & "Down " & manualdown

            If manualdown = 0 Then
                manualdown = manualdown + 1
            End If

        End If

        ' Not being incremented and decremanreted preoperly beciuse of the code in the two if/thens
        lblUpDown.Text = "DOWN!" 'Tell the user the direction that was just used

        'go change the fan speed
        set_Fanspeed(sender, e)

        If dutycyclestart = 100 Then btnUp.Enabled = False 'highest level disable the "up" button
        If dutycyclestart < 100 Then btnUp.Enabled = True 'not highest level enable up button 'we can go higher!
        If dutycyclestart <= 5 Then btnDown.Enabled = False 'we are as slow as we can go turn off the "down" button
        If dutycyclestart > 5 Then btnDown.Enabled = True 'we can go slower so turn on the "down" button



    End Sub

    Private Sub txtDutyMan_TextChanged(sender As Object, e As EventArgs) Handles txtDutyMan.TextChanged
        On Error Resume Next
        'the text box changed which means the user wants to start some pllace else lets reset the button conditions
        manualup = 0
        manualdown = 0
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

        eAboutMessage = "Windows Control For Arduino Fan Control Device" & vbLf & "Written For EMESC By EmigJ" & vbLf & "Version 2.00.01 08-12-2014" & vbLf & "Now With Continous Ramp & " & vbLf & "Black Hole/Time Travel Control"
        MsgBox(eAboutMessage, MsgBoxStyle.OkOnly)


    End Sub

    Private Sub InstructionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionToolStripMenuItem.Click
        On Error Resume Next
        eAboutMessage = "Nothing To See Here" & vbLf & "Move Along" & vbLf & "This Will Be Written When The Program Is Finalized (Ver 2.00.10)"
        MsgBox(eAboutMessage, MsgBoxStyle.OkOnly)

    End Sub

  

    Private Sub cheater(sender As Object, e As EventArgs)
        On Error Resume Next



        If dutycyclestart <= 5 Then dutycyclestart = 5
        If dutycyclestart >= 100 Then dutycyclestart = 100

        If dutycyclestart = 5 And reversePol = 1 Then trueDutycycle = 242 Else If reversePol = 0 And dutycyclestart = 5 Then trueDutycycle = 15
        If dutycyclestart = 6 And reversePol = 1 Then trueDutycycle = 240 Else If reversePol = 0 And dutycyclestart = 6 Then trueDutycycle = 17
        If dutycyclestart = 7 And reversePol = 1 Then trueDutycycle = 237 Else If reversePol = 0 And dutycyclestart = 7 Then trueDutycycle = 20
        If dutycyclestart = 8 And reversePol = 1 Then trueDutycycle = 235 Else If reversePol = 0 And dutycyclestart = 8 Then trueDutycycle = 22
        If dutycyclestart = 9 And reversePol = 1 Then trueDutycycle = 232 Else If reversePol = 0 And dutycyclestart = 9 Then trueDutycycle = 25
        If dutycyclestart = 10 And reversePol = 1 Then trueDutycycle = 230 Else If reversePol = 0 And dutycyclestart = 10 Then trueDutycycle = 27
        If dutycyclestart = 11 And reversePol = 1 Then trueDutycycle = 227 Else If reversePol = 0 And dutycyclestart = 11 Then trueDutycycle = 30
        If dutycyclestart = 12 And reversePol = 1 Then trueDutycycle = 225 Else If reversePol = 0 And dutycyclestart = 12 Then trueDutycycle = 33
        If dutycyclestart = 13 And reversePol = 1 Then trueDutycycle = 222 Else If reversePol = 0 And dutycyclestart = 13 Then trueDutycycle = 35
        If dutycyclestart = 14 And reversePol = 1 Then trueDutycycle = 219 Else If reversePol = 0 And dutycyclestart = 14 Then trueDutycycle = 38
        If dutycyclestart = 15 And reversePol = 1 Then trueDutycycle = 217 Else If reversePol = 0 And dutycyclestart = 15 Then trueDutycycle = 40
        If dutycyclestart = 16 And reversePol = 1 Then trueDutycycle = 214 Else If reversePol = 0 And dutycyclestart = 16 Then trueDutycycle = 43
        If dutycyclestart = 17 And reversePol = 1 Then trueDutycycle = 212 Else If reversePol = 0 And dutycyclestart = 17 Then trueDutycycle = 45
        If dutycyclestart = 18 And reversePol = 1 Then trueDutycycle = 209 Else If reversePol = 0 And dutycyclestart = 18 Then trueDutycycle = 48
        If dutycyclestart = 19 And reversePol = 1 Then trueDutycycle = 207 Else If reversePol = 0 And dutycyclestart = 19 Then trueDutycycle = 50
        If dutycyclestart = 20 And reversePol = 1 Then trueDutycycle = 204 Else If reversePol = 0 And dutycyclestart = 20 Then trueDutycycle = 53
        If dutycyclestart = 21 And reversePol = 1 Then trueDutycycle = 201 Else If reversePol = 0 And dutycyclestart = 21 Then trueDutycycle = 56
        If dutycyclestart = 22 And reversePol = 1 Then trueDutycycle = 199 Else If reversePol = 0 And dutycyclestart = 22 Then trueDutycycle = 58
        If dutycyclestart = 23 And reversePol = 1 Then trueDutycycle = 196 Else If reversePol = 0 And dutycyclestart = 23 Then trueDutycycle = 61
        If dutycyclestart = 24 And reversePol = 1 Then trueDutycycle = 194 Else If reversePol = 0 And dutycyclestart = 24 Then trueDutycycle = 63
        If dutycyclestart = 25 And reversePol = 1 Then trueDutycycle = 191 Else If reversePol = 0 And dutycyclestart = 25 Then trueDutycycle = 66
        If dutycyclestart = 26 And reversePol = 1 Then trueDutycycle = 189 Else If reversePol = 0 And dutycyclestart = 26 Then trueDutycycle = 68
        If dutycyclestart = 27 And reversePol = 1 Then trueDutycycle = 186 Else If reversePol = 0 And dutycyclestart = 27 Then trueDutycycle = 71
        If dutycyclestart = 28 And reversePol = 1 Then trueDutycycle = 184 Else If reversePol = 0 And dutycyclestart = 28 Then trueDutycycle = 73
        If dutycyclestart = 29 And reversePol = 1 Then trueDutycycle = 181 Else If reversePol = 0 And dutycyclestart = 29 Then trueDutycycle = 76
        If dutycyclestart = 30 And reversePol = 1 Then trueDutycycle = 178 Else If reversePol = 0 And dutycyclestart = 30 Then trueDutycycle = 79
        If dutycyclestart = 31 And reversePol = 1 Then trueDutycycle = 176 Else If reversePol = 0 And dutycyclestart = 31 Then trueDutycycle = 81
        If dutycyclestart = 32 And reversePol = 1 Then trueDutycycle = 173 Else If reversePol = 0 And dutycyclestart = 32 Then trueDutycycle = 84
        If dutycyclestart = 33 And reversePol = 1 Then trueDutycycle = 171 Else If reversePol = 0 And dutycyclestart = 33 Then trueDutycycle = 86
        If dutycyclestart = 34 And reversePol = 1 Then trueDutycycle = 168 Else If reversePol = 0 And dutycyclestart = 34 Then trueDutycycle = 89
        If dutycyclestart = 35 And reversePol = 1 Then trueDutycycle = 166 Else If reversePol = 0 And dutycyclestart = 35 Then trueDutycycle = 91
        If dutycyclestart = 36 And reversePol = 1 Then trueDutycycle = 163 Else If reversePol = 0 And dutycyclestart = 36 Then trueDutycycle = 94
        If dutycyclestart = 37 And reversePol = 1 Then trueDutycycle = 161 Else If reversePol = 0 And dutycyclestart = 37 Then trueDutycycle = 97
        If dutycyclestart = 38 And reversePol = 1 Then trueDutycycle = 158 Else If reversePol = 0 And dutycyclestart = 38 Then trueDutycycle = 99
        If dutycyclestart = 39 And reversePol = 1 Then trueDutycycle = 155 Else If reversePol = 0 And dutycyclestart = 39 Then trueDutycycle = 102
        If dutycyclestart = 40 And reversePol = 1 Then trueDutycycle = 153 Else If reversePol = 0 And dutycyclestart = 40 Then trueDutycycle = 104
        If dutycyclestart = 41 And reversePol = 1 Then trueDutycycle = 150 Else If reversePol = 0 And dutycyclestart = 41 Then trueDutycycle = 107
        If dutycyclestart = 42 And reversePol = 1 Then trueDutycycle = 148 Else If reversePol = 0 And dutycyclestart = 42 Then trueDutycycle = 109
        If dutycyclestart = 43 And reversePol = 1 Then trueDutycycle = 145 Else If reversePol = 0 And dutycyclestart = 43 Then trueDutycycle = 112
        If dutycyclestart = 44 And reversePol = 1 Then trueDutycycle = 143 Else If reversePol = 0 And dutycyclestart = 44 Then trueDutycycle = 114
        If dutycyclestart = 45 And reversePol = 1 Then trueDutycycle = 140 Else If reversePol = 0 And dutycyclestart = 45 Then trueDutycycle = 117
        If dutycyclestart = 46 And reversePol = 1 Then trueDutycycle = 137 Else If reversePol = 0 And dutycyclestart = 46 Then trueDutycycle = 120
        If dutycyclestart = 47 And reversePol = 1 Then trueDutycycle = 135 Else If reversePol = 0 And dutycyclestart = 47 Then trueDutycycle = 122
        If dutycyclestart = 48 And reversePol = 1 Then trueDutycycle = 132 Else If reversePol = 0 And dutycyclestart = 48 Then trueDutycycle = 125
        If dutycyclestart = 49 And reversePol = 1 Then trueDutycycle = 130 Else If reversePol = 0 And dutycyclestart = 49 Then trueDutycycle = 127
        If dutycyclestart = 50 And reversePol = 1 Then trueDutycycle = 127 Else If reversePol = 0 And dutycyclestart = 50 Then trueDutycycle = 130
        If dutycyclestart = 51 And reversePol = 1 Then trueDutycycle = 125 Else If reversePol = 0 And dutycyclestart = 51 Then trueDutycycle = 132
        If dutycyclestart = 52 And reversePol = 1 Then trueDutycycle = 122 Else If reversePol = 0 And dutycyclestart = 52 Then trueDutycycle = 135
        If dutycyclestart = 53 And reversePol = 1 Then trueDutycycle = 120 Else If reversePol = 0 And dutycyclestart = 53 Then trueDutycycle = 137
        If dutycyclestart = 54 And reversePol = 1 Then trueDutycycle = 117 Else If reversePol = 0 And dutycyclestart = 54 Then trueDutycycle = 140
        If dutycyclestart = 55 And reversePol = 1 Then trueDutycycle = 114 Else If reversePol = 0 And dutycyclestart = 55 Then trueDutycycle = 143
        If dutycyclestart = 56 And reversePol = 1 Then trueDutycycle = 112 Else If reversePol = 0 And dutycyclestart = 56 Then trueDutycycle = 145
        If dutycyclestart = 57 And reversePol = 1 Then trueDutycycle = 109 Else If reversePol = 0 And dutycyclestart = 57 Then trueDutycycle = 148
        If dutycyclestart = 58 And reversePol = 1 Then trueDutycycle = 107 Else If reversePol = 0 And dutycyclestart = 58 Then trueDutycycle = 150
        If dutycyclestart = 59 And reversePol = 1 Then trueDutycycle = 104 Else If reversePol = 0 And dutycyclestart = 59 Then trueDutycycle = 153
        If dutycyclestart = 60 And reversePol = 1 Then trueDutycycle = 102 Else If reversePol = 0 And dutycyclestart = 60 Then trueDutycycle = 155
        If dutycyclestart = 61 And reversePol = 1 Then trueDutycycle = 99 Else If reversePol = 0 And dutycyclestart = 61 Then trueDutycycle = 158
        If dutycyclestart = 62 And reversePol = 1 Then trueDutycycle = 97 Else If reversePol = 0 And dutycyclestart = 62 Then trueDutycycle = 161
        If dutycyclestart = 63 And reversePol = 1 Then trueDutycycle = 94 Else If reversePol = 0 And dutycyclestart = 63 Then trueDutycycle = 163
        If dutycyclestart = 64 And reversePol = 1 Then trueDutycycle = 91 Else If reversePol = 0 And dutycyclestart = 64 Then trueDutycycle = 166
        If dutycyclestart = 65 And reversePol = 1 Then trueDutycycle = 89 Else If reversePol = 0 And dutycyclestart = 65 Then trueDutycycle = 168
        If dutycyclestart = 66 And reversePol = 1 Then trueDutycycle = 86 Else If reversePol = 0 And dutycyclestart = 66 Then trueDutycycle = 171
        If dutycyclestart = 67 And reversePol = 1 Then trueDutycycle = 84 Else If reversePol = 0 And dutycyclestart = 67 Then trueDutycycle = 173
        If dutycyclestart = 68 And reversePol = 1 Then trueDutycycle = 81 Else If reversePol = 0 And dutycyclestart = 68 Then trueDutycycle = 176
        If dutycyclestart = 69 And reversePol = 1 Then trueDutycycle = 79 Else If reversePol = 0 And dutycyclestart = 69 Then trueDutycycle = 178
        If dutycyclestart = 70 And reversePol = 1 Then trueDutycycle = 76 Else If reversePol = 0 And dutycyclestart = 70 Then trueDutycycle = 181
        If dutycyclestart = 71 And reversePol = 1 Then trueDutycycle = 73 Else If reversePol = 0 And dutycyclestart = 71 Then trueDutycycle = 184
        If dutycyclestart = 72 And reversePol = 1 Then trueDutycycle = 71 Else If reversePol = 0 And dutycyclestart = 72 Then trueDutycycle = 186
        If dutycyclestart = 73 And reversePol = 1 Then trueDutycycle = 68 Else If reversePol = 0 And dutycyclestart = 73 Then trueDutycycle = 189
        If dutycyclestart = 74 And reversePol = 1 Then trueDutycycle = 66 Else If reversePol = 0 And dutycyclestart = 74 Then trueDutycycle = 191
        If dutycyclestart = 75 And reversePol = 1 Then trueDutycycle = 63 Else If reversePol = 0 And dutycyclestart = 75 Then trueDutycycle = 194
        If dutycyclestart = 76 And reversePol = 1 Then trueDutycycle = 61 Else If reversePol = 0 And dutycyclestart = 76 Then trueDutycycle = 196
        If dutycyclestart = 77 And reversePol = 1 Then trueDutycycle = 58 Else If reversePol = 0 And dutycyclestart = 77 Then trueDutycycle = 199
        If dutycyclestart = 78 And reversePol = 1 Then trueDutycycle = 56 Else If reversePol = 0 And dutycyclestart = 78 Then trueDutycycle = 201
        If dutycyclestart = 79 And reversePol = 1 Then trueDutycycle = 53 Else If reversePol = 0 And dutycyclestart = 79 Then trueDutycycle = 204
        If dutycyclestart = 80 And reversePol = 1 Then trueDutycycle = 50 Else If reversePol = 0 And dutycyclestart = 80 Then trueDutycycle = 207
        If dutycyclestart = 81 And reversePol = 1 Then trueDutycycle = 48 Else If reversePol = 0 And dutycyclestart = 81 Then trueDutycycle = 209
        If dutycyclestart = 82 And reversePol = 1 Then trueDutycycle = 45 Else If reversePol = 0 And dutycyclestart = 82 Then trueDutycycle = 212
        If dutycyclestart = 83 And reversePol = 1 Then trueDutycycle = 43 Else If reversePol = 0 And dutycyclestart = 83 Then trueDutycycle = 214
        If dutycyclestart = 84 And reversePol = 1 Then trueDutycycle = 40 Else If reversePol = 0 And dutycyclestart = 84 Then trueDutycycle = 217
        If dutycyclestart = 85 And reversePol = 1 Then trueDutycycle = 38 Else If reversePol = 0 And dutycyclestart = 85 Then trueDutycycle = 219
        If dutycyclestart = 86 And reversePol = 1 Then trueDutycycle = 35 Else If reversePol = 0 And dutycyclestart = 86 Then trueDutycycle = 222
        If dutycyclestart = 87 And reversePol = 1 Then trueDutycycle = 33 Else If reversePol = 0 And dutycyclestart = 87 Then trueDutycycle = 225
        If dutycyclestart = 88 And reversePol = 1 Then trueDutycycle = 30 Else If reversePol = 0 And dutycyclestart = 88 Then trueDutycycle = 227
        If dutycyclestart = 89 And reversePol = 1 Then trueDutycycle = 27 Else If reversePol = 0 And dutycyclestart = 89 Then trueDutycycle = 230
        If dutycyclestart = 90 And reversePol = 1 Then trueDutycycle = 25 Else If reversePol = 0 And dutycyclestart = 90 Then trueDutycycle = 232
        If dutycyclestart = 91 And reversePol = 1 Then trueDutycycle = 22 Else If reversePol = 0 And dutycyclestart = 91 Then trueDutycycle = 235
        If dutycyclestart = 92 And reversePol = 1 Then trueDutycycle = 20 Else If reversePol = 0 And dutycyclestart = 92 Then trueDutycycle = 237
        If dutycyclestart = 93 And reversePol = 1 Then trueDutycycle = 17 Else If reversePol = 0 And dutycyclestart = 93 Then trueDutycycle = 240
        If dutycyclestart = 94 And reversePol = 1 Then trueDutycycle = 15 Else If reversePol = 0 And dutycyclestart = 94 Then trueDutycycle = 242
        If dutycyclestart = 95 And reversePol = 1 Then trueDutycycle = 12 Else If reversePol = 0 And dutycyclestart = 95 Then trueDutycycle = 245
        If dutycyclestart = 96 And reversePol = 1 Then trueDutycycle = 9 Else If reversePol = 0 And dutycyclestart = 96 Then trueDutycycle = 248
        If dutycyclestart = 97 And reversePol = 1 Then trueDutycycle = 7 Else If reversePol = 0 And dutycyclestart = 97 Then trueDutycycle = 250
        If dutycyclestart = 98 And reversePol = 1 Then trueDutycycle = 4 Else If reversePol = 0 And dutycyclestart = 98 Then trueDutycycle = 253
        If dutycyclestart = 99 And reversePol = 1 Then trueDutycycle = 2 Else If reversePol = 0 And dutycyclestart = 99 Then trueDutycycle = 255
        If dutycyclestart = 100 And reversePol = 1 Then trueDutycycle = 0 Else If reversePol = 0 And dutycyclestart = 100 Then trueDutycycle = 256



    End Sub

    Private Sub rdoPolarityNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPolarityNormal.CheckedChanged
        On Error Resume Next

        If rdoPolarityNormal.Checked = True Then reversePol = 1
        Label1.Text = "reversePol = " & reversePol    'xcxc
    End Sub

    Private Sub rdoPolarityReversed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPolarityReversed.CheckedChanged
        On Error Resume Next

        If rdoPolarityReversed.Checked = True Then reversePol = 0
        Label1.Text = "reversePol = " & reversePol    'xcxc
    End Sub
    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        If labelEnable <> 0 Then
            '==========VVV These are used for debug and should be visible during normal use VVV==================
            Label1.Visible = False
            lblManualTrue.Visible = False
            lblmanualup.Visible = False
            lblCycleCount.Visible = False
            '==========^^^ These are used for debug and should be visible during normal use ^^^==================
        End If

        If labelEnable = 0 Then
            '==========VVV These are used for debug and should be visible during normal use VVV==================
            Label1.Visible = True
            lblManualTrue.Visible = True
            lblmanualup.Visible = True
            lblCycleCount.Visible = True
            '==========^^^ These are used for debug and should be visible during normal use ^^^==================
        End If

    End Sub

    Private Sub DebugToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem1.Click
        On Error Resume Next

        If labelEnable = 0 Then DebugToolStripMenuItem_Click(sender, e) : labelEnable = 1 Else DebugToolStripMenuItem_Click(sender, e) : labelEnable = 0


    End Sub
End Class
