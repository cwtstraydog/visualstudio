Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Public Class frmMain

    Private Property myPort As String()




    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When our form loads, auto detect all serial ports in the system and populate the cmbPort Combo box.
        myPort = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available
        cmbBaud.Items.Add(9600)     'Populate the cmbBaud Combo box to common baud rates used
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)
        'Other Serial Port Property
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        ' txtTransmit.Text = ""
        'SerialPort1.Open() 'Open our serial port

        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)    'Set cmbPort text to the first COM port detected
        cmbBaud.Text = cmbBaud.Items.Item(0)    'Set cmbBaud text to the first Baud rate on the list

        btnDisconnect.Enabled = False           'Initially Disconnect Button is Disabled
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text         'Set SerialPort1 to the selected COM port at startup
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on

        'Other Serial Port Property Most of this was moved to the frm_Load sub to try and fix a problem it did not fix anything
        ' SerialPort1.Parity = IO.Ports.Parity.None
        ' SerialPort1.StopBits = IO.Ports.StopBits.One
        ' SerialPort1.DataBits = 8            
        'SerialPort1.Handshake = Handshake.None     'thought this would fix a problem
        SerialPort1.Open()                          'Open our serial port
        SerialPort1.Write(txtTransmit.Text & vbLf)
        SerialPort1.Write(txtTransmit.Text & vbLf)

        'Add the following in a attempt to stop an open loop
        'SerialPort1.Write("99" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
        'SerialPort1.Write("99" & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii

        btnConnect.Enabled = False          'Disable Connect button
        btnDisconnect.Enabled = True        'and Enable Disconnect button
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()             'Close our Serial Port

        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        SerialPort1.Write(txtTransmit.Text & vbLf) 'The text contained in the txtText will be sent to the serial port as ascii
        'plus the Line feed (New Line) as arduino is in need of that to know when the message is over.
    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())    'Automatically called every time a data is received at the serialPort
    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New ContextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.rtbReceived.Text &= [text]
        End If
    End Sub

    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPort.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text         'pop a message box to user if he is changing ports
        Else                                                                               'without disconnecting first.
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub

    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBaud.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text         'pop a message box to user if he is changing baud rate
        Else                                                                                'without disconnecting first.
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub

    Private Sub txtTransmit_TextChanged(sender As Object, e As EventArgs) Handles txtTransmit.TextChanged

    End Sub
End Class
