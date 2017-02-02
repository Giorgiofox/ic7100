Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Text

Public Class Terminal
    Dim myPort As Array
    Dim Count As Integer = 0
    Dim prcCount As Integer = 0
    Dim comBuffer As Byte()
    Dim prcBuffer(2048) As Byte
    Dim s0sub1(512) As Byte
    Dim s0sub1Cnt As Integer
    Private Delegate Sub UpdateFormDelegate(ByRef buff As Byte())
    Dim UpdateformDelegate1 As UpdateFormDelegate

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        CmbPort.Items.AddRange(myPort)
        CmbPort.Text = "COM6"
        CmbBaud.Text = "38400"
        BtnWrite.Enabled = False
        Count = 0
        prcCount = 0
        Screen.Show()
    End Sub

    Private Sub BtnInit_Click(sender As Object, e As EventArgs) Handles BtnInit.Click
        RtxOutput.Text = ""
        SerialPort.PortName = CmbPort.Text
        SerialPort.BaudRate = CmbBaud.Text
        SerialPort.DataBits = 8
        SerialPort.StopBits = StopBits.One
        SerialPort.Parity = Parity.None
        SerialPort.Handshake = Handshake.None
        SerialPort.Open()

        AddHandler SerialPort.DataReceived, AddressOf SerialPort_DataReceived

        BtnInit.Enabled = False
        BtnWrite.Enabled = True
        BtnClose.Enabled = True
    End Sub

    Private Sub BtnWrite_Click(sender As Object, e As EventArgs) Handles BtnWrite.Click
        Dim i, j As Integer
        Dim value As Integer = 0
        Dim numHex As Integer = 0
        Dim byte1() As Byte = {0}

        j = InStr(RtxInput.Text, "FD")
        For i = 0 To j + 1
            If numHex = 2 Then
                SerialPort.Write(byte1, 0, 1)
                byte1(0) = 0
                numHex = 0
                Continue For
            End If
            If (RtxInput.Text(i) >= "0" And RtxInput.Text(i) <= "9" And numHex < 2) Then
                byte1(0) = byte1(0) * 16 + Asc(RtxInput.Text(i)) - Asc("0")
                numHex += 1
            ElseIf (RtxInput.Text(i) >= "A" And RtxInput.Text(i) <= "F" And numHex < 2) Then
                byte1(0) = byte1(0) * 16 + Asc(RtxInput.Text(i)) - Asc("A") + 10
                numHex += 1
            End If
        Next
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        SerialPort.Close()
        BtnInit.Enabled = True
        BtnWrite.Enabled = False
        BtnClose.Enabled = False
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        'Handles SerialPort Data Received Events
        UpdateformDelegate1 = New UpdateFormDelegate(AddressOf UpdateDisplay)
        Count = SerialPort.BytesToRead  'We wouldn't be here if = 0
        comBuffer = New Byte(Count - 1) {}  'Re dimension comBuffer
        SerialPort.Read(comBuffer, 0, Count)
        Me.Invoke(UpdateformDelegate1, comBuffer)  'Call UpdateDisplay() from this thread
    End Sub

    Private Sub UpdateDisplay(ByRef buffer As Byte())
        Dim value As Short
        Dim i As Integer

        For i = 1 To Count
            value = buffer(i - 1)
            If Len(RtxOutput.Text) < 8192 Then
                If value < 16 Then  'If < 16, add a zero
                    RtxOutput.Text &= "0" & Format(value, "X")  'Put out hex digit
                Else
                    RtxOutput.Text &= Format(value, "X")    '>= 16, put out two hex digits
                End If
                If value >= 32 And value < 128 Then 'Put out ASCII character
                    RtxOutput.Text &= Chr(value)
                Else
                    RtxOutput.Text &= " "   'If not ASCII, put out space
                End If
                RtxOutput.Text &= " "   'Space between bytes
                If value = &HFD Then
                    RtxOutput.Text &= vbCr  'End of line, put out Carriage Return
                End If
            End If
            prcBuffer(prcCount) = CByte(value)
            If prcBuffer(prcCount) = &HFD Then
                ProcessLine()
                prcCount = 0
            Else
                prcCount = prcCount + 1
            End If
        Next
    End Sub

    Private Sub ProcessLine()
        Dim i As Integer

        'For i = 1 To (prcCount - 1)
        Select Case prcBuffer(1)
            Case 0
                ProcessScreen0(2)
            Case Else
                '    Thread.Sleep(5)
        End Select
        'Next
    End Sub
    Private Sub ProcessScreen0(ByVal pos As Integer)
        Select Case (prcBuffer(pos))
            Case &HA
                Select Case (prcBuffer(pos + 1))
                    Case &H1
                        ProcessScreen0sub1(pos + 2)
                End Select
        End Select
    End Sub
    Private Sub ProcessScreen0sub1(ByVal pos As Integer)
        Dim i As Integer

        's0sub1Cnt = 0
        'For i = pos To (prcCount - 1)
        ' s0sub1(s0sub1Cnt) = prcBuffer(i)
        's0sub1Cnt = s0sub1Cnt + 1
        'Next
        Screen.BtnButton1.Text = Encoding.ASCII.GetString(prcBuffer, 119, 5)
        Screen.btnButton2.Text = Encoding.ASCII.GetString(prcBuffer, 124, 5)
        Screen.btnButton3.Text = Encoding.ASCII.GetString(prcBuffer, 129, 5)
        Screen.btnButton4.Text = Encoding.ASCII.GetString(prcBuffer, 134, 5)
        Screen.btnButton5.Text = Encoding.ASCII.GetString(prcBuffer, 139, 5)
    End Sub
End Class
