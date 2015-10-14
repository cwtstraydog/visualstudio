Public Class frm1

    Private Sub btbExit_Click(sender As Object, e As EventArgs) Handles btbExit.Click
        On Error Resume Next
        End
    End Sub

    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        '        TabPage1.Text = "Pick 3!"
        '        TabPage2.Text = "Texas 2 Step!"
        '        TabPage3.Text = "Texas Lotto!"
        '        TabPage4.Text = "Power Ball!"
        '        TabPage5.Text = "Mega Millions"
        '        TabPage6.Text = "Daily 4"
        '        TabPage7.Text = "All Or Nothing"
        '        TabPage8.Text = "Cash Five! "

        
    End Sub

 
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        grpP3Display.Text = TabPage1.Text
    End Sub

    Private Sub chkP3Box1_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box1.CheckedChanged
        txtP3Box1a.Enabled = True
        txtP3Box1b.Enabled = True
        txtP3Box1c.Enabled = True
        If chkP3Box1.Checked = False Then
            txtP3Box1a.Text = ""
            txtP3Box1b.Text = ""
            txtP3Box1c.Text = ""
            chkP3Box2.Checked = False
            chkP3Box2.Enabled = False

        End If


    End Sub

    Private Sub txtP3Box1c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box1c.TextChanged
        On Error Resume Next
        If txtP3Box1a.Text <> "" And txtP3Box1b.Text <> "" And txtP3Box1c.Text <> "" Then chkP3Box2.Enabled = True
    End Sub

    Private Sub txtP3Box2c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box2c.TextChanged
        On Error Resume Next
        If txtP3Box2a.Text <> "" And txtP3Box2b.Text <> "" And txtP3Box2c.Text <> "" Then chkP3Box3.Enabled = True

        
    End Sub

    Private Sub txtP3Box3c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box3c.TextChanged
        On Error Resume Next
        If txtP3Box3a.Text <> "" And txtP3Box3b.Text <> "" And txtP3Box3c.Text <> "" Then chkP3Box4.Enabled = True

       
    End Sub

    Private Sub txtP3Box4c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box4c.TextChanged
        On Error Resume Next
        If txtP3Box4a.Text <> "" And txtP3Box4b.Text <> "" And txtP3Box4c.Text <> "" Then chkP3Box5.Enabled = True

        
    End Sub

    Private Sub txtP3Box5c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box5c.TextChanged
        On Error Resume Next
        If txtP3Box5a.Text <> "" And txtP3Box5b.Text <> "" And txtP3Box5c.Text <> "" Then chkP3Box6.Enabled = True

        
    End Sub

    Private Sub txtP3Box6c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box6c.TextChanged
        On Error Resume Next
        If txtP3Box6a.Text <> "" And txtP3Box6b.Text <> "" And txtP3Box6c.Text <> "" Then chkP3Box7.Enabled = True

        
    End Sub

    Private Sub txtP3Box7c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box7c.TextChanged
        On Error Resume Next
        If txtP3Box7a.Text <> "" And txtP3Box7b.Text <> "" And txtP3Box7c.Text <> "" Then chkP3Box8.Enabled = True

        
    End Sub

    Private Sub txtP3Box8c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box8c.TextChanged
        On Error Resume Next
        If txtP3Box8a.Text <> "" And txtP3Box8b.Text <> "" And txtP3Box8c.Text <> "" Then chkP3Box9.Enabled = True

       
    End Sub

    Private Sub txtP3Box9c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box9c.TextChanged
        On Error Resume Next
        If txtP3Box9a.Text <> "" And txtP3Box9b.Text <> "" And txtP3Box9c.Text <> "" Then chkP3Box10.Enabled = True

       
    End Sub

    Private Sub txtP3Box10c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box10c.TextChanged
        On Error Resume Next
        If txtP3Box10a.Text <> "" And txtP3Box10b.Text <> "" And txtP3Box10c.Text <> "" Then chkP3Box11.Enabled = True


    End Sub

    Private Sub txtP3Box11c_TextChanged(sender As Object, e As EventArgs) Handles txtP3Box11c.TextChanged
        On Error Resume Next
        If txtP3Box11a.Text <> "" And txtP3Box11b.Text <> "" And txtP3Box11c.Text <> "" Then chkP3Box12.Enabled = True
    End Sub

    Private Sub chkP3Box2_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box2.CheckedChanged
        On Error Resume Next
        txtP3Box2a.Enabled = True
        txtP3Box2b.Enabled = True
        txtP3Box2c.Enabled = True

        If chkP3Box2.Checked = False Then
            txtP3Box2a.Text = ""
            txtP3Box2b.Text = ""
            txtP3Box2c.Text = ""
            chkP3Box3.Checked = False
            chkP3Box3.Enabled = False
            txtP3Box2a.Enabled = False
            txtP3Box2b.Enabled = False
            txtP3Box2c.Enabled = False

        End If


    End Sub

    Private Sub chkP3Box3_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box3.CheckedChanged
        On Error Resume Next
        txtP3Box3a.Enabled = True
        txtP3Box3b.Enabled = True
        txtP3Box3c.Enabled = True
        If chkP3Box3.Checked = False Then
            txtP3Box3a.Text = ""
            txtP3Box3b.Text = ""
            txtP3Box3c.Text = ""
            chkP3Box4.Checked = False
            chkP3Box4.Enabled = False
            txtP3Box3a.Enabled = False
            txtP3Box3b.Enabled = False
            txtP3Box3c.Enabled = False
        End If
    End Sub

    Private Sub chkP3Box4_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box4.CheckedChanged
        On Error Resume Next
        txtP3Box4a.Enabled = True
        txtP3Box4b.Enabled = True
        txtP3Box4c.Enabled = True
        If chkP3Box4.Checked = False Then
            txtP3Box4a.Text = ""
            txtP3Box4b.Text = ""
            txtP3Box4c.Text = ""
            chkP3Box5.Checked = False
            chkP3Box5.Enabled = False
            txtP3Box4a.Enabled = False
            txtP3Box4b.Enabled = False
            txtP3Box4c.Enabled = False
        End If
    End Sub

    Private Sub chkP3Box5_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box5.CheckedChanged
        On Error Resume Next
        txtP3Box5a.Enabled = True
        txtP3Box5b.Enabled = True
        txtP3Box5c.Enabled = True
        If chkP3Box5.Checked = False Then
            txtP3Box5a.Text = ""
            txtP3Box5b.Text = ""
            txtP3Box5c.Text = ""
            chkP3Box6.Checked = False
            chkP3Box6.Enabled = False
            txtP3Box5a.Enabled = False
            txtP3Box5b.Enabled = False
            txtP3Box5c.Enabled = False
        End If

    End Sub

    Private Sub chkP3Box6_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box6.CheckedChanged
        On Error Resume Next
        txtP3Box6a.Enabled = True
        txtP3Box6b.Enabled = True
        txtP3Box6c.Enabled = True
        If chkP3Box6.Checked = False Then
            txtP3Box6a.Text = ""
            txtP3Box6b.Text = ""
            txtP3Box6c.Text = ""
            chkP3Box7.Checked = False
            chkP3Box7.Enabled = False
            txtP3Box6a.Enabled = False
            txtP3Box6b.Enabled = False
            txtP3Box6c.Enabled = False
        End If

    End Sub

    Private Sub chkP3Box7_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box7.CheckedChanged
        On Error Resume Next
        txtP3Box7a.Enabled = True
        txtP3Box7b.Enabled = True
        txtP3Box7c.Enabled = True
        If chkP3Box7.Checked = False Then
            txtP3Box7a.Text = ""
            txtP3Box7b.Text = ""
            txtP3Box7c.Text = ""
            chkP3Box8.Checked = False
            chkP3Box8.Enabled = False
            txtP3Box7a.Enabled = False
            txtP3Box7b.Enabled = False
            txtP3Box7c.Enabled = False
        End If

    End Sub

    Private Sub chkP3Box8_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box8.CheckedChanged
        On Error Resume Next
        txtP3Box8a.Enabled = True
        txtP3Box8b.Enabled = True
        txtP3Box8c.Enabled = True
        If chkP3Box8.Checked = False Then
            txtP3Box8a.Text = ""
            txtP3Box8b.Text = ""
            txtP3Box8c.Text = ""
            chkP3Box9.Checked = False
            chkP3Box9.Enabled = False
            txtP3Box8a.Enabled = False
            txtP3Box8b.Enabled = False
            txtP3Box8c.Enabled = False
        End If

    End Sub

    Private Sub chkP3Box9_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box9.CheckedChanged
        On Error Resume Next
        txtP3Box9a.Enabled = True
        txtP3Box9b.Enabled = True
        txtP3Box9c.Enabled = True
        If chkP3Box9.Checked = False Then
            txtP3Box9a.Text = ""
            txtP3Box9b.Text = ""
            txtP3Box9c.Text = ""
            chkP3Box10.Checked = False
            chkP3Box10.Enabled = False
            txtP3Box9a.Enabled = False
            txtP3Box9b.Enabled = False
            txtP3Box9c.Enabled = False
        End If
    End Sub

    Private Sub chkP3Box10_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box10.CheckedChanged
        On Error Resume Next
        txtP3Box10a.Enabled = True
        txtP3Box10b.Enabled = True
        txtP3Box10c.Enabled = True
        If chkP3Box10.Checked = False Then
            txtP3Box10a.Text = ""
            txtP3Box10b.Text = ""
            txtP3Box10c.Text = ""
            chkP3Box11.Checked = False
            chkP3Box11.Enabled = False
            txtP3Box10a.Enabled = False
            txtP3Box10b.Enabled = False
            txtP3Box10c.Enabled = False
        End If

    End Sub

    Private Sub chkP3Box11_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box11.CheckedChanged
        On Error Resume Next
        txtP3Box11a.Enabled = True
        txtP3Box11b.Enabled = True
        txtP3Box11c.Enabled = True
        If chkP3Box11.Checked = False Then
            txtP3Box11a.Text = ""
            txtP3Box11b.Text = ""
            txtP3Box11c.Text = ""
            chkP3Box12.Checked = False
            chkP3Box12.Enabled = False
            txtP3Box11a.Enabled = False
            txtP3Box11b.Enabled = False
            txtP3Box11c.Enabled = False
        End If
    End Sub

    Private Sub chkP3Box12_CheckedChanged(sender As Object, e As EventArgs) Handles chkP3Box12.CheckedChanged
        On Error Resume Next

        txtP3Box12a.Enabled = True
        txtP3Box12b.Enabled = True
        txtP3Box12c.Enabled = True
        If chkP3Box12.Checked = False Then
            txtP3Box12a.Text = ""
            txtP3Box12b.Text = ""
            txtP3Box12c.Text = ""
            txtP3Box12a.Enabled = False
            txtP3Box12b.Enabled = False
            txtP3Box12c.Enabled = False

        End If
    End Sub
End Class
