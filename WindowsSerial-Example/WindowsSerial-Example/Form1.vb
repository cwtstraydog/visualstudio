Public Class Form1
    Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
    Public Class frmMain
        Dim myPort As Array  'COM Ports detected on the system will be stored here
        Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            End

        End Sub

        Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        End Sub
    End Class
