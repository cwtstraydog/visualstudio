Imports System.Threading
Public Class Form1
    '=== EMESC Lab fan control
    '=== Control program to send proper values to arduino that wil control 10 fans indepentantly 
    '=== John Emig 06/15/2015 

    '===    As of 07/15/2015 direct communication to arduino works
    '=== User can type in a string of comma seperated PWM values and the values will be converted
    '=== to values that the arduino can relate to and change the PWM clocks to control the fan speed
    '===    The auto control is nearly complete
    '=== The user can check the all box and the text box values are verified 
    '=== The user can check individual fans and present numbers into text box
    '=== The individual text box values are loaded into an array and verified
    Dim TroubleFlag As Integer
    Dim NotReady As Integer
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
    Dim dutycycleM As Decimal           'dutycycle used for manual mode lets see if we can get rid of this and only have one dutycycle variable
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
    Dim ArduinoCommand As String    'Arduino number to be sent to the arduino 
    Dim UserCommandArray(10) As String       'User number will be in precentages 0= fan 1,, 9= fan 10 blah blah blah
    Dim UserCommandArrayS(10) As String
    Dim FanUserInput(10) As Integer          ' needed for checking of erronious inputs
    Dim FanArduinoInput(10) As Integer      '
    Dim arrayindexer1 As Integer             'being used for indexing the array in for next loops
    Dim arrayindexer2 As Integer             'being used for indexing the array in for next loops
    'these are the dutycycle numbers that passed to the arduino like the "truedutycycle" of the old program

    Dim resetStartF1 As Integer
    Dim resetStopF1 As Integer
    Dim resetStartF2 As Integer
    Dim resetStopF2 As Integer
    Dim resetStartF3 As Integer
    Dim resetStopF3 As Integer
    Dim resetStartF4 As Integer
    Dim resetStopF4 As Integer
    Dim resetStartF5 As Integer
    Dim resetStopF5 As Integer
    Dim resetStartF6 As Integer
    Dim resetStopF6 As Integer
    Dim resetStartF7 As Integer
    Dim resetStopF7 As Integer
    Dim resetStartF8 As Integer
    Dim resetStopF8 As Integer
    Dim resetStartF9 As Integer
    Dim resetStopF9 As Integer
    Dim resetStartF10 As Integer
    Dim resetStopF10 As Integer


    Private Property myPort As String()
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        On Error Resume Next
        End
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        On Error Resume Next
        btnExit_Click(sender, e)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        lblPWNSpeed.Text = "reversePol = " & reversePol    'xcxc
        lblPWNSpeed.Visible = False
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
        lblReversed.Text = reversePol
    End Sub

    'the following is for error handling and user guidanceVVV
    Public Sub trouble(sender As Object, e As EventArgs)
        On Error Resume Next

        MsgBox(eMessage, vbCritical)
        TroubleFlag = 1
        eMessage = "this was cleared in the last call to trouble"
        If close_on_error = 1 Then End
        Refresh() ' FrmMain_Load(sender, e)

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        On Error Resume Next
        SerialPort1.PortName = cmbPort.Text         'Set SerialPort1 to the selected COM port at startup
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on

        SerialPort1.Open()                          'Open our serial port

        SerialPort1.Write("230" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii()
        SerialPort1.Write("230" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii()

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

        If txtTransmit.Text = "" Then
            eMessage = "Hey! I need info here for me to do anything."
            trouble(sender, e)
        End If

        UserCommandArray = Split(txtTransmit.Text, ",")   'take the user number from the text box

        For i = 1 To 10
            If UserCommandArray(arrayindexer1) = "" Then UserCommandArray(arrayindexer1) = "5"
            arrayindexer1 = arrayindexer1 + 1
        Next
        arrayindexer1 = 0

        txtTransmit.Text = ""

        For i = 1 To 10
            dutycyclestart = UserCommandArray(arrayindexer1)
            cheater(sender, e)                  'Loads PWM into Varible trueDutycycle converting user number to arduino number
            FanUserInput(arrayindexer1) = dutycyclestart
            FanArduinoInput(arrayindexer1) = trueDutycycle
            ' ArduinoCommand = this is the command to send to the arduino
            ArduinoCommand = ArduinoCommand & trueDutycycle & ","
            arrayindexer1 = arrayindexer1 + 1
        Next

        arrayindexer1 = 0
        set_Fanspeed(sender, e)

        '============ Notes ============VVV
        'leaving here 
        'usercommandarray(10) has user inputed PWMs (0-100%) as strings
        'fanuserinput(10) has user inputed PWMs (0-100) as integers
        'fanarduinoinput(10) has arduino PWM values (1-255)
        'ArduinoCommand is not an array but a long string of comma delimited arduino PWM values (187,187,187,128,128,90,95,...Etc)
        '               which when written to the serial port will control 10 seperate PWM timers on the Arduino
        '============ Notes ============^^^

    End Sub
    Private Sub set_Fanspeed(sender As Object, e As EventArgs)  ' only used for manual and direct mode
        On Error Resume Next


        '============ Notes ============VVV
        'Entering here 
        'entire program uses this routine to send fan speed commands after input is recieved.
        'usercommandarray(10) has user inputed PWMs (0-100%) as strings
        'fanuserinput(10) has user inputed PWMs (0-100) as integers
        'fanarduinoinput(10) has arduino PWM values (1-255)
        'ArduinoCommand is not an array but a long string of comma delimited arduino PWM values (187,187,187,128,128,90,95,...Etc)
        '               which when written to the serial port will control 10 seperate PWM timers on the Arduino
        '============ Notes ============^^^

        


        If SerialPort1.IsOpen = True Then
            SerialPort1.Write(ArduinoCommand & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
            rtbReceived.Text = "Setting fan speed to: " & vbCrLf & _
            " Fan 01 = " & dutycyclestart & "% " & _
            " Fan 06 = " & dutycyclestart & "% " & vbCrLf & _
            " Fan 02 = " & dutycyclestart & "% " & _
            " Fan 07 = " & dutycyclestart & "% " & vbCrLf & _
            " Fan 03 = " & dutycyclestart & "% " & _
            " Fan 08 = " & dutycyclestart & "% " & vbCrLf & _
            " Fan 04 = " & dutycyclestart & "% " & _
            " Fan 09 = " & dutycyclestart & "% " & vbCrLf & _
            " Fan 05 = " & dutycyclestart & "% " & _
            " Fan 10 = " & dutycyclestart & "% " & vbCrLf & _
            ArduinoCommand

            'FanPWMSpeedLabels(sender, e)    'subroutine to change feedback labels on form "fan01= 100%" etc etc
            ArduinoCommand = ""
        Else
            rtbReceived.Text = "Serial Port Is Closed!!" & vbLf & "Setfan Speed " & "Serial Port Closed " & vbCrLf & "Setting fan speed to " & dutycycleM & "%" & vbLf & "trueDutycycle =" & trueDutycycle & vbLf


        End If
        'FanPWMSpeedLabels(sender, e)    'subroutine to change feedback labels on form "fan01= 100%" etc etc
        'rtbReceived.Text = "Fan is on and running at " & dutycycleM & "%" & vbLf
        lblManualTrue.Text = "ArduinoCommand = " & ArduinoCommand
        lblCycleCount.Text = "Cycle Count = " & cyclenumber
    End Sub
    Private Sub cheater(sender As Object, e As EventArgs)
        On Error Resume Next
        '============ Notes ============VVV
        '
        '============ Notes ============^^^


        If dutycyclestart <= 5 Then dutycyclestart = 5
        If dutycyclestart >= 100 Then dutycyclestart = 100

        If dutycyclestart = 5 And reversePol = 1 Then trueDutycycle = 242 _
            Else If reversePol = 0 And dutycyclestart = 5 Then trueDutycycle = 15

        If dutycyclestart = 6 And reversePol = 1 Then trueDutycycle = 240 _
            Else If reversePol = 0 And dutycyclestart = 6 Then trueDutycycle = 17

        If dutycyclestart = 7 And reversePol = 1 Then trueDutycycle = 237 _
            Else If reversePol = 0 And dutycyclestart = 7 Then trueDutycycle = 20

        If dutycyclestart = 8 And reversePol = 1 Then trueDutycycle = 235 _
            Else If reversePol = 0 And dutycyclestart = 8 Then trueDutycycle = 22

        If dutycyclestart = 9 And reversePol = 1 Then trueDutycycle = 232 _
            Else If reversePol = 0 And dutycyclestart = 9 Then trueDutycycle = 25

        If dutycyclestart = 10 And reversePol = 1 Then trueDutycycle = 230 _
            Else If reversePol = 0 And dutycyclestart = 10 Then trueDutycycle = 27

        If dutycyclestart = 11 And reversePol = 1 Then trueDutycycle = 227 _
            Else If reversePol = 0 And dutycyclestart = 11 Then trueDutycycle = 30

        If dutycyclestart = 12 And reversePol = 1 Then trueDutycycle = 225 _
            Else If reversePol = 0 And dutycyclestart = 12 Then trueDutycycle = 33

        If dutycyclestart = 13 And reversePol = 1 Then trueDutycycle = 222 _
            Else If reversePol = 0 And dutycyclestart = 13 Then trueDutycycle = 35

        If dutycyclestart = 14 And reversePol = 1 Then trueDutycycle = 219 _
            Else If reversePol = 0 And dutycyclestart = 14 Then trueDutycycle = 38

        If dutycyclestart = 15 And reversePol = 1 Then trueDutycycle = 217 _
            Else If reversePol = 0 And dutycyclestart = 15 Then trueDutycycle = 40

        If dutycyclestart = 16 And reversePol = 1 Then trueDutycycle = 214 _
            Else If reversePol = 0 And dutycyclestart = 16 Then trueDutycycle = 43

        If dutycyclestart = 17 And reversePol = 1 Then trueDutycycle = 212 _
            Else If reversePol = 0 And dutycyclestart = 17 Then trueDutycycle = 45

        If dutycyclestart = 18 And reversePol = 1 Then trueDutycycle = 209 _
            Else If reversePol = 0 And dutycyclestart = 18 Then trueDutycycle = 48

        If dutycyclestart = 19 And reversePol = 1 Then trueDutycycle = 207 _
            Else If reversePol = 0 And dutycyclestart = 19 Then trueDutycycle = 50

        If dutycyclestart = 20 And reversePol = 1 Then trueDutycycle = 204 _
            Else If reversePol = 0 And dutycyclestart = 20 Then trueDutycycle = 53

        If dutycyclestart = 21 And reversePol = 1 Then trueDutycycle = 201 _
            Else If reversePol = 0 And dutycyclestart = 21 Then trueDutycycle = 56

        If dutycyclestart = 22 And reversePol = 1 Then trueDutycycle = 199 _
            Else If reversePol = 0 And dutycyclestart = 22 Then trueDutycycle = 58

        If dutycyclestart = 23 And reversePol = 1 Then trueDutycycle = 196 _
            Else If reversePol = 0 And dutycyclestart = 23 Then trueDutycycle = 61

        If dutycyclestart = 24 And reversePol = 1 Then trueDutycycle = 194 _
            Else If reversePol = 0 And dutycyclestart = 24 Then trueDutycycle = 63

        If dutycyclestart = 25 And reversePol = 1 Then trueDutycycle = 191 _
            Else If reversePol = 0 And dutycyclestart = 25 Then trueDutycycle = 66

        If dutycyclestart = 26 And reversePol = 1 Then trueDutycycle = 189 _
            Else If reversePol = 0 And dutycyclestart = 26 Then trueDutycycle = 68

        If dutycyclestart = 27 And reversePol = 1 Then trueDutycycle = 186 _
            Else If reversePol = 0 And dutycyclestart = 27 Then trueDutycycle = 71

        If dutycyclestart = 28 And reversePol = 1 Then trueDutycycle = 184 _
            Else If reversePol = 0 And dutycyclestart = 28 Then trueDutycycle = 73

        If dutycyclestart = 29 And reversePol = 1 Then trueDutycycle = 181 _
            Else If reversePol = 0 And dutycyclestart = 29 Then trueDutycycle = 76

        If dutycyclestart = 30 And reversePol = 1 Then trueDutycycle = 178 _
            Else If reversePol = 0 And dutycyclestart = 30 Then trueDutycycle = 79

        If dutycyclestart = 31 And reversePol = 1 Then trueDutycycle = 176 _
            Else If reversePol = 0 And dutycyclestart = 31 Then trueDutycycle = 81

        If dutycyclestart = 32 And reversePol = 1 Then trueDutycycle = 173 _
            Else If reversePol = 0 And dutycyclestart = 32 Then trueDutycycle = 84

        If dutycyclestart = 33 And reversePol = 1 Then trueDutycycle = 171 _
            Else If reversePol = 0 And dutycyclestart = 33 Then trueDutycycle = 86

        If dutycyclestart = 34 And reversePol = 1 Then trueDutycycle = 168 _
            Else If reversePol = 0 And dutycyclestart = 34 Then trueDutycycle = 89

        If dutycyclestart = 35 And reversePol = 1 Then trueDutycycle = 166 _
            Else If reversePol = 0 And dutycyclestart = 35 Then trueDutycycle = 91

        If dutycyclestart = 36 And reversePol = 1 Then trueDutycycle = 163 _
            Else If reversePol = 0 And dutycyclestart = 36 Then trueDutycycle = 94

        If dutycyclestart = 37 And reversePol = 1 Then trueDutycycle = 161 _
            Else If reversePol = 0 And dutycyclestart = 37 Then trueDutycycle = 97

        If dutycyclestart = 38 And reversePol = 1 Then trueDutycycle = 158 _
            Else If reversePol = 0 And dutycyclestart = 38 Then trueDutycycle = 99

        If dutycyclestart = 39 And reversePol = 1 Then trueDutycycle = 155 _
            Else If reversePol = 0 And dutycyclestart = 39 Then trueDutycycle = 102

        If dutycyclestart = 40 And reversePol = 1 Then trueDutycycle = 153 _
            Else If reversePol = 0 And dutycyclestart = 40 Then trueDutycycle = 104

        If dutycyclestart = 41 And reversePol = 1 Then trueDutycycle = 150 _
            Else If reversePol = 0 And dutycyclestart = 41 Then trueDutycycle = 107

        If dutycyclestart = 42 And reversePol = 1 Then trueDutycycle = 148 _
            Else If reversePol = 0 And dutycyclestart = 42 Then trueDutycycle = 109

        If dutycyclestart = 43 And reversePol = 1 Then trueDutycycle = 145 _
            Else If reversePol = 0 And dutycyclestart = 43 Then trueDutycycle = 112

        If dutycyclestart = 44 And reversePol = 1 Then trueDutycycle = 143 _
            Else If reversePol = 0 And dutycyclestart = 44 Then trueDutycycle = 114

        If dutycyclestart = 45 And reversePol = 1 Then trueDutycycle = 140 _
            Else If reversePol = 0 And dutycyclestart = 45 Then trueDutycycle = 117

        If dutycyclestart = 46 And reversePol = 1 Then trueDutycycle = 137 _
            Else If reversePol = 0 And dutycyclestart = 46 Then trueDutycycle = 120

        If dutycyclestart = 47 And reversePol = 1 Then trueDutycycle = 135 _
            Else If reversePol = 0 And dutycyclestart = 47 Then trueDutycycle = 122

        If dutycyclestart = 48 And reversePol = 1 Then trueDutycycle = 132 _
            Else If reversePol = 0 And dutycyclestart = 48 Then trueDutycycle = 125

        If dutycyclestart = 49 And reversePol = 1 Then trueDutycycle = 130 _
            Else If reversePol = 0 And dutycyclestart = 49 Then trueDutycycle = 127

        If dutycyclestart = 50 And reversePol = 1 Then trueDutycycle = 127 _
            Else If reversePol = 0 And dutycyclestart = 50 Then trueDutycycle = 130

        If dutycyclestart = 51 And reversePol = 1 Then trueDutycycle = 125 _
            Else If reversePol = 0 And dutycyclestart = 51 Then trueDutycycle = 132

        If dutycyclestart = 52 And reversePol = 1 Then trueDutycycle = 122 _
            Else If reversePol = 0 And dutycyclestart = 52 Then trueDutycycle = 135

        If dutycyclestart = 53 And reversePol = 1 Then trueDutycycle = 120 _
            Else If reversePol = 0 And dutycyclestart = 53 Then trueDutycycle = 137

        If dutycyclestart = 54 And reversePol = 1 Then trueDutycycle = 117 _
            Else If reversePol = 0 And dutycyclestart = 54 Then trueDutycycle = 140

        If dutycyclestart = 55 And reversePol = 1 Then trueDutycycle = 114 _
            Else If reversePol = 0 And dutycyclestart = 55 Then trueDutycycle = 143

        If dutycyclestart = 56 And reversePol = 1 Then trueDutycycle = 112 _
            Else If reversePol = 0 And dutycyclestart = 56 Then trueDutycycle = 145

        If dutycyclestart = 57 And reversePol = 1 Then trueDutycycle = 109 _
            Else If reversePol = 0 And dutycyclestart = 57 Then trueDutycycle = 148

        If dutycyclestart = 58 And reversePol = 1 Then trueDutycycle = 107 _
            Else If reversePol = 0 And dutycyclestart = 58 Then trueDutycycle = 150

        If dutycyclestart = 59 And reversePol = 1 Then trueDutycycle = 104 _
            Else If reversePol = 0 And dutycyclestart = 59 Then trueDutycycle = 153

        If dutycyclestart = 60 And reversePol = 1 Then trueDutycycle = 102 _
            Else If reversePol = 0 And dutycyclestart = 60 Then trueDutycycle = 155

        If dutycyclestart = 61 And reversePol = 1 Then trueDutycycle = 99 _
            Else If reversePol = 0 And dutycyclestart = 61 Then trueDutycycle = 158

        If dutycyclestart = 62 And reversePol = 1 Then trueDutycycle = 97 _
            Else If reversePol = 0 And dutycyclestart = 62 Then trueDutycycle = 161

        If dutycyclestart = 63 And reversePol = 1 Then trueDutycycle = 94 _
            Else If reversePol = 0 And dutycyclestart = 63 Then trueDutycycle = 163

        If dutycyclestart = 64 And reversePol = 1 Then trueDutycycle = 91 _
            Else If reversePol = 0 And dutycyclestart = 64 Then trueDutycycle = 166

        If dutycyclestart = 65 And reversePol = 1 Then trueDutycycle = 89 _
            Else If reversePol = 0 And dutycyclestart = 65 Then trueDutycycle = 168

        If dutycyclestart = 66 And reversePol = 1 Then trueDutycycle = 86 _
            Else If reversePol = 0 And dutycyclestart = 66 Then trueDutycycle = 171

        If dutycyclestart = 67 And reversePol = 1 Then trueDutycycle = 84 _
            Else If reversePol = 0 And dutycyclestart = 67 Then trueDutycycle = 173

        If dutycyclestart = 68 And reversePol = 1 Then trueDutycycle = 81 _
            Else If reversePol = 0 And dutycyclestart = 68 Then trueDutycycle = 176

        If dutycyclestart = 69 And reversePol = 1 Then trueDutycycle = 79 _
            Else If reversePol = 0 And dutycyclestart = 69 Then trueDutycycle = 178

        If dutycyclestart = 70 And reversePol = 1 Then trueDutycycle = 76 _
            Else If reversePol = 0 And dutycyclestart = 70 Then trueDutycycle = 181

        If dutycyclestart = 71 And reversePol = 1 Then trueDutycycle = 73 _
            Else If reversePol = 0 And dutycyclestart = 71 Then trueDutycycle = 184

        If dutycyclestart = 72 And reversePol = 1 Then trueDutycycle = 71 _
            Else If reversePol = 0 And dutycyclestart = 72 Then trueDutycycle = 186

        If dutycyclestart = 73 And reversePol = 1 Then trueDutycycle = 68 _
            Else If reversePol = 0 And dutycyclestart = 73 Then trueDutycycle = 189

        If dutycyclestart = 74 And reversePol = 1 Then trueDutycycle = 66 _
            Else If reversePol = 0 And dutycyclestart = 74 Then trueDutycycle = 191

        If dutycyclestart = 75 And reversePol = 1 Then trueDutycycle = 63 _
            Else If reversePol = 0 And dutycyclestart = 75 Then trueDutycycle = 194

        If dutycyclestart = 76 And reversePol = 1 Then trueDutycycle = 61 _
            Else If reversePol = 0 And dutycyclestart = 76 Then trueDutycycle = 196

        If dutycyclestart = 77 And reversePol = 1 Then trueDutycycle = 58 _
            Else If reversePol = 0 And dutycyclestart = 77 Then trueDutycycle = 199

        If dutycyclestart = 78 And reversePol = 1 Then trueDutycycle = 56 _
            Else If reversePol = 0 And dutycyclestart = 78 Then trueDutycycle = 201

        If dutycyclestart = 79 And reversePol = 1 Then trueDutycycle = 53 _
            Else If reversePol = 0 And dutycyclestart = 79 Then trueDutycycle = 204

        If dutycyclestart = 80 And reversePol = 1 Then trueDutycycle = 50 _
            Else If reversePol = 0 And dutycyclestart = 80 Then trueDutycycle = 207

        If dutycyclestart = 81 And reversePol = 1 Then trueDutycycle = 48 _
            Else If reversePol = 0 And dutycyclestart = 81 Then trueDutycycle = 209

        If dutycyclestart = 82 And reversePol = 1 Then trueDutycycle = 45 _
            Else If reversePol = 0 And dutycyclestart = 82 Then trueDutycycle = 212

        If dutycyclestart = 83 And reversePol = 1 Then trueDutycycle = 43 _
            Else If reversePol = 0 And dutycyclestart = 83 Then trueDutycycle = 214

        If dutycyclestart = 84 And reversePol = 1 Then trueDutycycle = 40 _
            Else If reversePol = 0 And dutycyclestart = 84 Then trueDutycycle = 217

        If dutycyclestart = 85 And reversePol = 1 Then trueDutycycle = 38 _
            Else If reversePol = 0 And dutycyclestart = 85 Then trueDutycycle = 219

        If dutycyclestart = 86 And reversePol = 1 Then trueDutycycle = 35 _
            Else If reversePol = 0 And dutycyclestart = 86 Then trueDutycycle = 222

        If dutycyclestart = 87 And reversePol = 1 Then trueDutycycle = 33 _
            Else If reversePol = 0 And dutycyclestart = 87 Then trueDutycycle = 225

        If dutycyclestart = 88 And reversePol = 1 Then trueDutycycle = 30 _
            Else If reversePol = 0 And dutycyclestart = 88 Then trueDutycycle = 227

        If dutycyclestart = 89 And reversePol = 1 Then trueDutycycle = 27 _
            Else If reversePol = 0 And dutycyclestart = 89 Then trueDutycycle = 230

        If dutycyclestart = 90 And reversePol = 1 Then trueDutycycle = 25 _
            Else If reversePol = 0 And dutycyclestart = 90 Then trueDutycycle = 232

        If dutycyclestart = 91 And reversePol = 1 Then trueDutycycle = 22 _
            Else If reversePol = 0 And dutycyclestart = 91 Then trueDutycycle = 235

        If dutycyclestart = 92 And reversePol = 1 Then trueDutycycle = 20 _
            Else If reversePol = 0 And dutycyclestart = 92 Then trueDutycycle = 237

        If dutycyclestart = 93 And reversePol = 1 Then trueDutycycle = 17 _
            Else If reversePol = 0 And dutycyclestart = 93 Then trueDutycycle = 240

        If dutycyclestart = 94 And reversePol = 1 Then trueDutycycle = 15 _
            Else If reversePol = 0 And dutycyclestart = 94 Then trueDutycycle = 242

        If dutycyclestart = 95 And reversePol = 1 Then trueDutycycle = 12 _
            Else If reversePol = 0 And dutycyclestart = 95 Then trueDutycycle = 245

        If dutycyclestart = 96 And reversePol = 1 Then trueDutycycle = 9 _
            Else If reversePol = 0 And dutycyclestart = 96 Then trueDutycycle = 248

        If dutycyclestart = 97 And reversePol = 1 Then trueDutycycle = 7 _
            Else If reversePol = 0 And dutycyclestart = 97 Then trueDutycycle = 250

        If dutycyclestart = 98 And reversePol = 1 Then trueDutycycle = 4 _
            Else If reversePol = 0 And dutycyclestart = 98 Then trueDutycycle = 253

        If dutycyclestart = 99 And reversePol = 1 Then trueDutycycle = 2 _
            Else If reversePol = 0 And dutycyclestart = 99 Then trueDutycycle = 255

        If dutycyclestart = 100 And reversePol = 1 Then trueDutycycle = 0 _
            Else If reversePol = 0 And dutycyclestart = 100 Then trueDutycycle = 256

    End Sub

    Private Sub chkbAutoAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoAll.CheckedChanged
        On Error Resume Next
        '============ Notes ============VVV
        '
        '============ Notes ============^^^

       


    End Sub

    Private Sub chkbManAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManAll.CheckedChanged
        On Error Resume Next

        '=== Notes ===VVV
        '
        '=== Notes ===^^^

        If chkbManAll.Checked Then
            chkbManFan1.Enabled = False
            chkbManFan1.Checked = False
            txtbxManFan1.Enabled = False

            chkbManFan2.Enabled = False
            chkbManFan2.Checked = False
            txtbxManFan2.Enabled = False

            chkbManFan3.Enabled = False
            chkbManFan3.Checked = False
            txtbxManFan3.Enabled = False

            chkbManFan4.Enabled = False
            chkbManFan4.Checked = False
            txtbxManFan4.Enabled = False

            chkbManFan5.Enabled = False
            chkbManFan5.Checked = False
            txtbxManFan5.Enabled = False

            chkbManFan6.Enabled = False
            chkbManFan6.Checked = False
            txtbxManFan6.Enabled = False

            chkbManFan7.Enabled = False
            chkbManFan7.Checked = False
            txtbxManFan7.Enabled = False

            chkbManFan8.Enabled = False
            chkbManFan8.Checked = False
            txtbxManFan8.Enabled = False

            chkbManFan9.Enabled = False
            chkbManFan9.Checked = False
            txtbxManFan9.Enabled = False

            chkbManFan10.Enabled = False
            chkbManFan10.Checked = False
            txtbxManFan10.Enabled = False
        Else
            chkbManFan1.Enabled = True
            txtbxManFan1.Enabled = True

            chkbManFan2.Enabled = True
            txtbxManFan2.Enabled = True

            chkbManFan3.Enabled = True
            txtbxManFan3.Enabled = True

            chkbManFan4.Enabled = True
            txtbxManFan4.Enabled = True

            chkbManFan5.Enabled = True
            txtbxManFan5.Enabled = True

            chkbManFan6.Enabled = True
            txtbxManFan6.Enabled = True

            chkbManFan7.Enabled = True
            txtbxManFan7.Enabled = True

            chkbManFan8.Enabled = True
            txtbxManFan8.Enabled = True

            chkbManFan9.Enabled = True
            txtbxManFan9.Enabled = True

            chkbManFan10.Enabled = True
            txtbxManFan10.Enabled = True
        End If
    End Sub

    Private Sub chkbAutoFan1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan1.CheckedChanged
        On Error Resume Next


        If chkbAutoFan1.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                And chkbAutoFan2.Checked = False _
                And chkbAutoFan3.Checked = False _
                And chkbAutoFan4.Checked = False _
                And chkbAutoFan5.Checked = False _
                And chkbAutoFan6.Checked = False _
                And chkbAutoFan7.Checked = False _
                And chkbAutoFan8.Checked = False _
                And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan2.CheckedChanged
        On Error Resume Next
        If chkbAutoFan2.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                           And chkbAutoFan1.Checked = False _
                           And chkbAutoFan3.Checked = False _
                           And chkbAutoFan4.Checked = False _
                           And chkbAutoFan5.Checked = False _
                           And chkbAutoFan6.Checked = False _
                           And chkbAutoFan7.Checked = False _
                           And chkbAutoFan8.Checked = False _
                           And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If

    End Sub

    Private Sub chkbAutoFan3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan3.CheckedChanged
        On Error Resume Next
        If chkbAutoFan3.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                           And chkbAutoFan2.Checked = False _
                           And chkbAutoFan1.Checked = False _
                           And chkbAutoFan4.Checked = False _
                           And chkbAutoFan5.Checked = False _
                           And chkbAutoFan6.Checked = False _
                           And chkbAutoFan7.Checked = False _
                           And chkbAutoFan8.Checked = False _
                           And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan4_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan4.CheckedChanged
        On Error Resume Next
        If chkbAutoFan4.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                           And chkbAutoFan2.Checked = False _
                           And chkbAutoFan3.Checked = False _
                           And chkbAutoFan1.Checked = False _
                           And chkbAutoFan5.Checked = False _
                           And chkbAutoFan6.Checked = False _
                           And chkbAutoFan7.Checked = False _
                           And chkbAutoFan8.Checked = False _
                           And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan5_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan5.CheckedChanged
        On Error Resume Next
        If chkbAutoFan5.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
               And chkbAutoFan2.Checked = False _
               And chkbAutoFan3.Checked = False _
               And chkbAutoFan4.Checked = False _
               And chkbAutoFan1.Checked = False _
               And chkbAutoFan6.Checked = False _
               And chkbAutoFan7.Checked = False _
               And chkbAutoFan8.Checked = False _
               And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan6_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan6.CheckedChanged
        On Error Resume Next
        If chkbAutoFan6.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                         And chkbAutoFan2.Checked = False _
                         And chkbAutoFan3.Checked = False _
                         And chkbAutoFan4.Checked = False _
                         And chkbAutoFan5.Checked = False _
                         And chkbAutoFan1.Checked = False _
                         And chkbAutoFan7.Checked = False _
                         And chkbAutoFan8.Checked = False _
                         And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan7_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan7.CheckedChanged
        On Error Resume Next
        If chkbAutoFan7.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                        And chkbAutoFan2.Checked = False _
                        And chkbAutoFan3.Checked = False _
                        And chkbAutoFan4.Checked = False _
                        And chkbAutoFan5.Checked = False _
                        And chkbAutoFan6.Checked = False _
                        And chkbAutoFan1.Checked = False _
                        And chkbAutoFan8.Checked = False _
                        And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan8_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan8.CheckedChanged
        On Error Resume Next
        If chkbAutoFan8.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                        And chkbAutoFan2.Checked = False _
                        And chkbAutoFan3.Checked = False _
                        And chkbAutoFan4.Checked = False _
                        And chkbAutoFan5.Checked = False _
                        And chkbAutoFan6.Checked = False _
                        And chkbAutoFan7.Checked = False _
                        And chkbAutoFan1.Checked = False _
                        And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan9_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan9.CheckedChanged
        On Error Resume Next
        If chkbAutoFan9.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan10.Checked = False _
                          And chkbAutoFan2.Checked = False _
                          And chkbAutoFan3.Checked = False _
                          And chkbAutoFan4.Checked = False _
                          And chkbAutoFan5.Checked = False _
                          And chkbAutoFan6.Checked = False _
                          And chkbAutoFan7.Checked = False _
                          And chkbAutoFan8.Checked = False _
                          And chkbAutoFan1.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbAutoFan10_CheckedChanged(sender As Object, e As EventArgs) Handles chkbAutoFan10.CheckedChanged
        On Error Resume Next
        If chkbAutoFan10.Checked Then
            chkbAutoAll.Enabled = False

        Else
            If chkbAutoFan1.Checked = False _
                         And chkbAutoFan2.Checked = False _
                         And chkbAutoFan3.Checked = False _
                         And chkbAutoFan4.Checked = False _
                         And chkbAutoFan5.Checked = False _
                         And chkbAutoFan6.Checked = False _
                         And chkbAutoFan7.Checked = False _
                         And chkbAutoFan8.Checked = False _
                         And chkbAutoFan9.Checked = False Then
                chkbAutoAll.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkbManFan1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan1.CheckedChanged

        On Error Resume Next
        If chkbManFan1.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan10.Checked = False _
                          And chkbManFan2.Checked = False _
                          And chkbManFan3.Checked = False _
                          And chkbManFan4.Checked = False _
                          And chkbManFan5.Checked = False _
                          And chkbManFan6.Checked = False _
                          And chkbManFan7.Checked = False _
                          And chkbManFan8.Checked = False _
                          And chkbManFan9.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If

    End Sub

    Private Sub chkbManFan2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan2.CheckedChanged
        On Error Resume Next
        If chkbManFan2.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
                           And chkbManFan3.Checked = False _
                           And chkbManFan4.Checked = False _
                           And chkbManFan5.Checked = False _
                           And chkbManFan6.Checked = False _
                           And chkbManFan7.Checked = False _
                           And chkbManFan8.Checked = False _
                           And chkbManFan9.Checked = False _
                           And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If

    End Sub

    Private Sub chkbManFan3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan3.CheckedChanged
        On Error Resume Next
        If chkbManFan3.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
                           And chkbManFan2.Checked = False _
                           And chkbManFan4.Checked = False _
                           And chkbManFan5.Checked = False _
                           And chkbManFan6.Checked = False _
                           And chkbManFan7.Checked = False _
                           And chkbManFan8.Checked = False _
                           And chkbManFan9.Checked = False _
                           And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkbManFan4_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan4.CheckedChanged
        On Error Resume Next
        If chkbManFan4.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
                          And chkbManFan2.Checked = False _
                          And chkbManFan3.Checked = False _
                          And chkbManFan5.Checked = False _
                          And chkbManFan6.Checked = False _
                          And chkbManFan7.Checked = False _
                          And chkbManFan8.Checked = False _
                          And chkbManFan9.Checked = False _
                          And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkbManFan5_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan5.CheckedChanged
        On Error Resume Next
        If chkbManFan5.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
                           And chkbManFan2.Checked = False _
                           And chkbManFan3.Checked = False _
                           And chkbManFan4.Checked = False _
                           And chkbManFan6.Checked = False _
                           And chkbManFan7.Checked = False _
                           And chkbManFan8.Checked = False _
                           And chkbManFan9.Checked = False _
                           And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkbManFan6_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan6.CheckedChanged
        On Error Resume Next
        If chkbManFan6.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
                          And chkbManFan2.Checked = False _
                          And chkbManFan3.Checked = False _
                          And chkbManFan4.Checked = False _
                          And chkbManFan5.Checked = False _
                          And chkbManFan7.Checked = False _
                          And chkbManFan8.Checked = False _
                          And chkbManFan9.Checked = False _
                          And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkbManFan7_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan7.CheckedChanged
        On Error Resume Next
        If chkbManFan7.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
                           And chkbManFan2.Checked = False _
                           And chkbManFan3.Checked = False _
                           And chkbManFan4.Checked = False _
                           And chkbManFan5.Checked = False _
                           And chkbManFan6.Checked = False _
                           And chkbManFan8.Checked = False _
                           And chkbManFan9.Checked = False _
                           And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkbManFan8_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan8.CheckedChanged
        On Error Resume Next
        If chkbManFan8.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
                        And chkbManFan2.Checked = False _
                        And chkbManFan3.Checked = False _
                        And chkbManFan4.Checked = False _
                        And chkbManFan5.Checked = False _
                        And chkbManFan6.Checked = False _
                        And chkbManFan7.Checked = False _
                        And chkbManFan9.Checked = False _
                        And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub 
(sender As Object, e As EventArgs) Handles chkbManFan9.CheckedChanged
        On Error Resume Next
        If chkbManFan9.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
               And chkbManFan2.Checked = False _
               And chkbManFan3.Checked = False _
               And chkbManFan4.Checked = False _
               And chkbManFan5.Checked = False _
               And chkbManFan6.Checked = False _
               And chkbManFan7.Checked = False _
               And chkbManFan8.Checked = False _
               And chkbManFan10.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkbManFan10_CheckedChanged(sender As Object, e As EventArgs) Handles chkbManFan10.CheckedChanged
        On Error Resume Next
        If chkbManFan10.Checked Then
            chkbManAll.Enabled = False
            txtbxManAll.Enabled = False
        Else
            If chkbManFan1.Checked = False _
               And chkbManFan2.Checked = False _
               And chkbManFan3.Checked = False _
               And chkbManFan4.Checked = False _
               And chkbManFan5.Checked = False _
               And chkbManFan6.Checked = False _
               And chkbManFan7.Checked = False _
               And chkbManFan8.Checked = False _
               And chkbManFan9.Checked = False Then
                chkbManAll.Enabled = True
                txtbxManAll.Enabled = True
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        '=== Notes ===VVV
        ''CheckState to ensure that we have another cycle to run
        '=== Notes ===^^^

        lblTimerCount.Text = Val(lblTimerCount.Text) - 1

        '=== Doing up and down until button "stop" is pressed ===VVV
        ' 1 is down 0 is up

        If rdobtnAutoUpDown.Checked = True And lblTimerCount.Text <= 0 Then
            If cyclenumber <= 0 Then
                cyclenumber = resetCyclenumber

                If updown = 0 Then
                    updown = 1
                Else : updown = 0
                End If
            End If

            If updown = 0 Then      'we are going up wich is more than normal
                lblUpDown.Text = "UP!"
                If dutycyclestart <> dutycyclestop Then
                    dutycyclestart = dutycyclestart + multiplex
                    cheater(sender, e)   'Loads PWM into Varible trueDutycycle

                End If
                ArduinoCommand = trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle _
                    & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & ","
                cyclenumber = cyclenumber - 1
                dutycycleM = dutycycleM + multiplex
                set_Fanspeed(sender, e)
                lblTimerCount.Text = txtbxAutoDwell.Text

            End If

            If updown = 1 Then      'we are going down is is opposite of normal
                lblUpDown.Text = "DOWN!"

                If dutycyclestart <> dutycyclestop Then
                    dutycyclestart = dutycyclestart - multiplex
                    cheater(sender, e)   'Loads PWM into Varible trueDutycycle

                End If
                ArduinoCommand = trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle _
                    & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & ","
                cyclenumber = cyclenumber - 1
                dutycycleM = dutycycleM - multiplex
                set_Fanspeed(sender, e)
                lblTimerCount.Text = txtbxAutoDwell.Text
            End If
        End If


        '=== Doing up and down until button "stop" is pressed ===^^^

        If rdobtnAutoUpDown.Checked = False And lblTimerCount.Text <= 0 Then
            If dutycyclestart <> dutycyclestop Then
                dutycyclestart = dutycyclestart + multiplex
                cheater(sender, e)   'Loads PWM into Varible trueDutycycle

            End If
            ArduinoCommand = trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle _
                & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & "," & trueDutycycle & ","


            cyclenumber = cyclenumber - 1
            dutycycleM = dutycycleM + multiplex
            set_Fanspeed(sender, e)
            lblTimerCount.Text = txtbxAutoDwell.Text         'lblTimerCount

        End If


        If rdobtnAutoUpDown.Checked = False And cyclenumber <= 0 Then
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
        ' For i = 1 To 10
        ' UserCommandArray(arrayindexer1) = dutycycleM
        ' arrayindexer1 = arrayindexer1 + 1
        ' Next
        ' arrayindexer1 = 0

        FanPWMSpeedLabels(sender, e)    'subroutine to change feedback labels on form "fan01= 100%" etc etc
    End Sub

    Private Sub btnResetAuto_Click(sender As Object, e As EventArgs) Handles btnResetAuto.Click
        On Error Resume Next
        ArduinoCommand = ""
        'reset was punched rebuild enviroment from beginiing
        operationTrue = 0
        updown = 0
        rtbReceived.Text = ""
        txtbxAutoDwell.Text = resetDwell

        If chkbAutoAll.Checked = True Then
            txtDutyStart.Text = resetStart
            txtDutystop.Text = resetStop
        End If
        '==== Reset has been pressed reloading vaules ===VVV
        If chkbAutoFan1.Checked = True Then
            txtbxAutoFan1.Text = resetStartF1
            txtbxAutoFanS1.Text = resetStopF1
        End If


        If chkbAutoFan2.Checked = True Then
            txtbxAutoFan2.Text = resetStartF2
            txtbxAutoFanS2.Text = resetStopF2
        End If

        If chkbAutoFan3.Checked = True Then
            txtbxAutoFan3.Text = resetStartF3
            txtbxAutoFanS3.Text = resetStopF3
        End If

        If chkbAutoFan4.Checked = True Then
            txtbxAutoFan4.Text = resetStartF4
            txtbxAutoFanS4.Text = resetStopF4
        End If

        If chkbAutoFan5.Checked = True Then
            txtbxAutoFan5.Text = resetStartF5
            txtbxAutoFanS5.Text = resetStopF5

        End If

        If chkbAutoFan6.Checked = True Then
            txtbxAutoFan6.Text = resetStartF6
            txtbxAutoFanS6.Text = resetStopF6
        End If

        If chkbAutoFan7.Checked = True Then
            txtbxAutoFan7.Text = resetStartF7
            txtbxAutoFanS7.Text = resetStopF7
        End If

        If chkbAutoFan8.Checked = True Then
            txtbxAutoFan8.Text = resetStartF8
            txtbxAutoFanS8.Text = resetStopF8
        End If

        If chkbAutoFan9.Checked = True Then
            txtbxAutoFan9.Text = resetStartF9
            txtbxAutoFanS9.Text = resetStopF9
        End If

        If chkbAutoFan10.Checked = True Then
            txtbxAutoFan10.Text = resetStartF10
            txtbxAutoFanS10.Text = resetStopF10
        End If
        '=== Reset has been pressed reloading vaules ===^^^

        lblTimerCount.Text = txtbxAutoDwell.Text

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
    Private Sub tenfanload(sender As Object, e As EventArgs)
        On Error Resume Next
        If chkbAutoAll.Checked = False Then

            '=== Loading Start and Stop Values into the array ===VVV
            If chkbAutoFan1.Checked = False And reversePol = 1 Then FanUserInput(0) = 242 _
             Else If reversePol = 0 And chkbAutoFan1.Checked = False Then FanUserInput(0) = 15


            If chkbAutoFan2.Checked = False And reversePol = 1 Then FanUserInput(1) = 242 _
            Else If reversePol = 0 And chkbAutoFan2.Checked = False Then FanUserInput(1) = 15

            If chkbAutoFan3.Checked = False And reversePol = 1 Then FanUserInput(2) = 242 _
                                  Else If reversePol = 0 And chkbAutoFan3.Checked = False Then FanUserInput(2) = 15


            If chkbAutoFan4.Checked = False And reversePol = 1 Then FanUserInput(3) = 242 _
            Else If reversePol = 0 And chkbAutoFan4.Checked = False Then FanUserInput(3) = 15


            If chkbAutoFan5.Checked = False And reversePol = 1 Then FanUserInput(4) = 242 _
              Else If reversePol = 0 And chkbAutoFan5.Checked = False Then FanUserInput(4) = 15

            If chkbAutoFan6.Checked = False And reversePol = 1 Then FanUserInput(5) = 242 _
                                  Else If reversePol = 0 And chkbAutoFan6.Checked = False Then FanUserInput(5) = 15


            If chkbAutoFan7.Checked = False And reversePol = 1 Then FanUserInput(6) = 242 _
            Else If reversePol = 0 And chkbAutoFan7.Checked = False Then FanUserInput(6) = 15


            If chkbAutoFan8.Checked = False And reversePol = 1 Then FanUserInput(7) = 242 _
            Else If reversePol = 0 And chkbAutoFan8.Checked = False Then FanUserInput(7) = 15


            If chkbAutoFan9.Checked = False And reversePol = 1 Then FanUserInput(8) = 242 _
            Else If reversePol = 0 And chkbAutoFan9.Checked = False Then FanUserInput(8) = 15


            If chkbAutoFan10.Checked = False And reversePol = 1 Then FanUserInput(9) = 242 _
            Else If reversePol = 0 And chkbAutoFan10.Checked = False Then FanUserInput(9) = 15

            '=== Loading Start and Stop Values into the array ===^^^

            '=== Checking values ===VVV
            
            '=== Checking values ===^^^
        End If

    End Sub
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        On Error Resume Next



        '=== getting the increment number by 5% or by 1% ===VVV
        If rdoAutoPercent5.Checked = True Then
            multiplex = 5
        Else : multiplex = 1
        End If
        '=== getting the increment number by 5% or by 1% ===^^^

        '=== routine to do user input verification ===VVV
        dutycyclechecker(sender, e) 'checks user individual fan inputs
        '=== routine to do user input verification ===^^^

        If TroubleFlag = 0 Then
            ' tenfanload(sender, e)       'loads user individual fan inputs into array

            '=== Loading idividual Fan Values for the reset routine ===VVV      
            resetRecord(sender, e)
            '=== Loading idividual Fan Values for the reset routine ===^^^

            operationTrue = 1   'used to indicate that the go button was pressed and _
            '                                           enables/disables the other buttons
            btnPause.Enabled = True
            btnResetAuto.Enabled = False
            btnPause.Visible = True
            btnUnpause.Visible = False


            If chkbAutoAll.Checked = True Then
                dutycyclestart = txtDutyStart.Text
                cheater(sender, e)   'Loads PWM into Varible trueDutycycle
                For i = 1 To 10
                    FanUserInput(arrayindexer1) = trueDutycycle
                    arrayindexer1 = arrayindexer1 + 1
                Next
                arrayindexer1 = 0
                tenfanload(sender, e)

            End If
            lblTimerCount.Text = txtbxAutoDwell.Text
            dutycyclestart = txtDutyStart.Text  'start point
            'dutycyclestart = dutycyclestart - multiplex
            dutycyclestop = txtDutystop.Text 'stop point
            cyclenumber = (dutycyclestop - dutycyclestart) \ multiplex  'figure number of loops



            If rdobtnAutoUpDown.Checked = True Then
                cyclenumber = cyclenumber
            Else : cyclenumber = cyclenumber + 1
            End If


            resetCyclenumber = cyclenumber - 1

            'cheater(sender, e)   'Loads PWM into Varible trueDutycycle 'this was a second call for some reason 
            dutycycleM = dutycyclestart
            Timer1.Enabled = True
            btnGo.Enabled = False
            btnStop.Enabled = True

        End If
        TroubleFlag = 0
    End Sub
    
    Sub resetRecord(sender As Object, e As EventArgs)
        On Error Resume Next
        '=== Records input so that form can be rebuilt  when reset is pressed ===VVV
        If txtbxAutoDwell.Text > 0 Then
            resetDwell = txtbxAutoDwell.Text
        End If

        '=== Auto All ===VVV
        If chkbAutoAll.Checked = True And txtDutyStart.Text > 0 And _
                                            txtDutystop.Text > 0 And txtbxAutoDwell.Text > 0 Then
            resetStart = txtDutyStart.Text
            resetStop = txtDutystop.Text
        End If
        '=== Auto All ===^^^


    End Sub
    Private Sub dutycyclechecker(sender As Object, e As EventArgs)
        On Error Resume Next
        NotReady = 0

        'Checking for needed user input
        If txtbxAutoDwell.Text = 0 Then
            eMessage = "You Need A Valid Dwell Time Value"
            trouble(sender, e)
            NotReady = 1
        End If

      


        If NotReady = 0 Then
            If chkbAutoAll.Checked = True And txtDutyStart.Text = "" Then
                eMessage = "You Need a Valid Duty Start Value"
                trouble(sender, e)
                NotReady = 1
            End If
        End If


        If NotReady = 0 Then
            If chkbAutoAll.Checked = True And txtDutystop.Text = "" Then
                eMessage = "You Need a Valid Duty Stop Value"
                trouble(sender, e)
                NotReady = 1
            End If
        End If



   

 

        NotReady = 0


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

    Private Sub lblTimerCount_Click(sender As Object, e As EventArgs) Handles lblTimerCount.Click
        On Error Resume Next
        'To increase one unit per second
        'Label8.Text = txtDwell.Text
    End Sub

    Private Sub rdoAutoramp_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAutoramp.CheckedChanged
        On Error Resume Next


        If rdoAutoramp.Checked Then
            txtbxManAll.Text = ""
            rtbReceived.ResetText()
            rdoDirectConnect.Checked = False
            btnSend.Enabled = False
            txtTransmit.Enabled = False
            rdoManualEnable.Checked = False
            gpbAuto.Enabled = True
            gpbManual.Enabled = False
        End If
    End Sub

    Private Sub rdoManualEnable_CheckedChanged(sender As Object, e As EventArgs) Handles rdoManualEnable.CheckedChanged
        On Error Resume Next


        If rdoManualEnable.Checked Then
            lblTimerCount.Text = "Timer"
            txtbxAutoDwell.Text = ""
            txtDutyStart.Text = ""
            txtDutystop.Text = ""
            rtbReceived.ResetText()
            rdoDirectConnect.Checked = False
            btnSend.Enabled = False
            txtTransmit.Enabled = False
            rdoAutoramp.Checked = False
            gpbAuto.Enabled = False
            gpbManual.Enabled = True
            rdobtnManBy5.Checked = True
            txtbxManAll.Text = ""

        End If
    End Sub

    Private Sub btnAutoClear_Click(sender As Object, e As EventArgs) Handles btnAutoClear.Click
        On Error Resume Next

        ArduinoCommand = ""
        For i = 1 To 10
            UserCommandArray(arrayindexer1) = ""
            UserCommandArrayS(arrayindexer1) = ""
            arrayindexer1 = arrayindexer1 + 1
        Next
        arrayindexer1 = 0

        rtbReceived.Text = ""
        chkbAutoAll.Checked = False


        chkbAutoFan1.Checked = False
        txtbxAutoFan1.Text = ""
        txtbxAutoFanS1.Text = ""

        chkbAutoFan2.Checked = False
        txtbxAutoFan2.Text = ""
        txtbxAutoFanS2.Text = ""

        chkbAutoFan3.Checked = False
        txtbxAutoFan3.Text = ""
        txtbxAutoFanS3.Text = ""

        chkbAutoFan4.Checked = False
        txtbxAutoFan4.Text = ""
        txtbxAutoFanS4.Text = ""

        chkbAutoFan5.Checked = False
        txtbxAutoFan5.Text = ""
        txtbxAutoFanS5.Text = ""

        chkbAutoFan6.Checked = False
        txtbxAutoFan6.Text = ""
        txtbxAutoFanS6.Text = ""

        chkbAutoFan7.Checked = False
        txtbxAutoFan7.Text = ""
        txtbxAutoFanS7.Text = ""

        chkbAutoFan8.Checked = False
        txtbxAutoFan8.Text = ""
        txtbxAutoFanS8.Text = ""

        chkbAutoFan9.Checked = False
        txtbxAutoFan9.Text = ""
        txtbxAutoFanS9.Text = ""

        chkbAutoFan10.Checked = False
        txtbxAutoFan10.Text = ""
        txtbxAutoFanS10.Text = ""

        txtbxAutoDwell.Text = ""
        txtDutyStart.Text = ""
        txtDutystop.Text = ""

    End Sub

    Private Sub btnManClear_Click(sender As Object, e As EventArgs) Handles btnManClear.Click
        On Error Resume Next

        chkbManAll.Checked = False
        txtbxManAll.Text = ""

        chkbManFan1.Checked = False
        txtbxManFan1.Text = ""

        chkbManFan2.Checked = False
        txtbxManFan2.Text = ""

        chkbManFan3.Checked = False
        txtbxManFan3.Text = ""

        chkbManFan4.Checked = False
        txtbxManFan4.Text = ""

        chkbManFan5.Checked = False
        txtbxManFan5.Text = ""

        chkbManFan6.Checked = False
        txtbxManFan6.Text = ""

        chkbManFan7.Checked = False
        txtbxManFan7.Text = ""

        chkbManFan8.Checked = False
        txtbxManFan8.Text = ""

        chkbManFan9.Checked = False
        txtbxManFan9.Text = ""

        chkbManFan10.Checked = False
        txtbxManFan10.Text = ""

        chkbManFan1.Checked = False
        txtbxManFan1.Text = ""

        chkbManFan2.Checked = False
        txtbxManFan2.Text = ""

        chkbManFan3.Checked = False
        txtbxManFan3.Text = ""

        chkbManFan4.Checked = False
        txtbxManFan4.Text = ""

        chkbManFan5.Checked = False
        txtbxManFan5.Text = ""

        chkbManFan6.Checked = False
        txtbxManFan6.Text = ""

        chkbManFan7.Checked = False
        txtbxManFan7.Text = ""

        chkbManFan8.Checked = False
        txtbxManFan8.Text = ""

        chkbManFan9.Checked = False
        txtbxManFan9.Text = ""

        chkbManFan10.Checked = False
        txtbxManFan10.Text = ""
    End Sub

    Private Sub rdoDirectConnect_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDirectConnect.CheckedChanged
        If rdoDirectConnect.Checked = True Then
            rdoAutoramp.Checked = False
            gpbAuto.Enabled = False
            rdoManualEnable.Checked = False
            gpbManual.Enabled = False
            txtTransmit.Enabled = True
            btnSend.Enabled = True
        End If

    End Sub

    Private Sub SpyGlassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpyGlassToolStripMenuItem.Click
        On Error Resume Next
        If labelEnable <> 0 Then
            '==========VVV These are used for debug and should be visible during normal use VVV==================
            lblUpDown.Visible = False
            lblManualTrue.Visible = False
            lblmanualup.Visible = False
            lblCycleCount.Visible = False
            '==========^^^ These are used for debug and should be visible during normal use ^^^==================
        End If

        If labelEnable = 0 Then
            '==========VVV These are used for debug and should be visible during normal use VVV==================
            lblReversed.Visible = True
            lblManualTrue.Visible = True
            lblmanualup.Visible = True
            lblCycleCount.Visible = True
            '==========^^^ These are used for debug and should be visible during normal use ^^^==================
            On Error Resume Next

            '============ Legacy code =============VVV
            ' If labelEnable = 0 Then DebugToolStripMenuItem_Click(sender, e) : labelEnable = 1 Else DebugToolStripMenuItem_Click(sender, e) : labelEnable = 0
            '============ Legacy code =============^^^

        End If
    End Sub

    Private Sub rdobtnPolarityRev_CheckedChanged(sender As Object, e As EventArgs) Handles rdobtnPolarityRev.CheckedChanged
        On Error Resume Next

        If rdobtnPolarityRev.Checked = True Then reversePol = 0
        lblReversed.Text = "reversePol = " & reversePol    'xcxc
    End Sub

    Private Sub rdoPolarityNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPolarityNormal.CheckedChanged
        On Error Resume Next

        If rdoPolarityNormal.Checked = True Then reversePol = 1
        lblReversed.Text = "reversePol = " & reversePol    'xcxc
    End Sub

    Private Sub FanPWMSpeedLabels(sender As Object, e As EventArgs)
        'rtbReceived.Text = "Setting fan speed to: " & vbCrLf & _
        lblFanPWMp1.Text = UserCommandArray(0) & "%"
        lblFanPWMp6.Text = UserCommandArray(5) & "%"
        lblFanPWMp2.Text = UserCommandArray(1) & "%"
        lblFanPWMp7.Text = UserCommandArray(6) & "%"
        lblFanPWMp3.Text = UserCommandArray(2) & "%"
        lblFanPWMp8.Text = UserCommandArray(7) & "%"
        lblFanPWMp4.Text = UserCommandArray(3) & "%"
        lblFanPWMp9.Text = UserCommandArray(8) & "%"
        lblFanPWMp5.Text = UserCommandArray(4) & "%"
        lblFanPWMp10.Text = UserCommandArray(9) & "%"
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        On Error Resume Next

        eAboutMessage = "Windows Control For Arduino Fan Control Device" & vbLf & "Written For EMESC By EmigJ" & vbLf & "Version 2.00.01 08-12-2014" & vbLf & "Now With Continous Ramp & " & vbLf & "Black Hole/Time Travel Control"
        MsgBox(eAboutMessage, MsgBoxStyle.OkOnly)


    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        On Error Resume Next
        eAboutMessage = "Nothing To See Here" & vbLf & "Move Along" & vbLf & "This Will Be Written When The Program Is Finalized (Ver 2.00.10)"
        MsgBox(eAboutMessage, MsgBoxStyle.OkOnly)

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        On Error Resume Next
        btnResetAuto_Click(sender, e)
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        On Error Resume Next
        btnStop_Click(sender, e)
    End Sub

    Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click
        On Error Resume Next
        btnGo_Click(sender, e)
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        On Error Resume Next
        btnPause_Click(sender, e)
    End Sub

    Private Sub EnableManualRampToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableManualRampToolStripMenuItem.Click
        On Error Resume Next
        rdoManualEnable.Checked = True
        rdoManualEnable_CheckedChanged(sender, e)
    End Sub

    Private Sub EnableAutoRampToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableAutoRampToolStripMenuItem.Click
        On Error Resume Next
        rdoAutoramp.Checked = True
        rdoAutoramp_CheckedChanged(sender, e)
    End Sub



End Class
