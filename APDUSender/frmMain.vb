Imports PCSC.Iso7816

Public Class frmMain
    Private SmartPCSC As New SmartPCSC
    Private firstRun As Boolean = False
    Private latestResponse As Byte()

    Private Sub refreshReaderList() Handles MyBase.Load, btnRefesh.Click
        cbxReader.Items.Clear()

        Dim readerList As String()
        readerList = SmartPCSC.getReaderList
        For Each reader In readerList
            cbxReader.Items.Add(reader)
        Next
        cbxReader.SelectedIndex = 0

        If firstRun <> False Then
            MessageBox.Show("Refresh Reader List Complete!, " & readerList.Length & " Reader Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            firstRun = True
        End If
    End Sub

    Private Sub btnSendAPDU_Click(sender As Object, e As EventArgs) Handles btnSendAPDU.Click
        txtRecievedAPDU.Clear()
        txtSW1SW2.Clear()
        txtASCII.Clear()

        latestResponse = Nothing

        If txtSendAPDU.Text <> "" Then
            Dim APDUstring As String
            APDUstring = txtSendAPDU.Text.Replace(" ", "")

            'Temporary Solution
            Dim APDUcase As IsoCase
            APDUcase = IsoCase.Case4Short

            Dim APDUbyte As Byte()
            Try
                APDUbyte = SmartPCSC.getByteArrayfromString(APDUstring)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "TranslatingAPDU : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLog.AppendText(vbNewLine & vbNewLine & "TranslatingAPDU : ERROR" & vbNewLine & "::: " & ex.Message)
                Exit Sub
            End Try

            Dim APDUstr As String
            APDUstr = BitConverter.ToString(APDUbyte)
            APDUstr = APDUstr.Replace("-", " ")

            Dim responseObj As Object
            Try
                responseObj = SmartPCSC.trasmitAPDU(cbxReader.Text, APDUbyte, APDUcase)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "TransmitAPDU : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLog.AppendText(vbNewLine & vbNewLine & "TransmitAPDU : ERROR" & vbNewLine & "<< " & APDUstr & vbNewLine & "::: " & ex.Message)
                Exit Sub
            End Try

            Dim responseByte As Byte()
            Dim responseStr As String

            If responseObj(0) IsNot Nothing Then
                If responseObj(0).Length > 0 Then
                    responseByte = responseObj(0)
                    latestResponse = responseByte

                    responseStr = BitConverter.ToString(responseByte)
                    responseStr = responseStr.Replace("-", " ")

                    txtRecievedAPDU.Text = responseStr
                Else
                    txtRecievedAPDU.Text = "NO RESPONSE DATA"
                End If
            End If

            Dim SW1 As Byte = responseObj(1)
            Dim SW2 As Byte = responseObj(2)

            Dim SWarray As Byte() = {&H0, &H0}
            SWarray(0) = SW1
            SWarray(1) = SW2

            Dim SWstr As String
            SWstr = BitConverter.ToString(SWarray)
            SWstr = SWstr.Replace("-", " ")

            txtSW1SW2.Text = SWstr

            txtLog.AppendText(vbNewLine & vbNewLine & "TrasmitAPDU : SUCCESS" & vbNewLine & "<< " & APDUstr & vbNewLine & ">> " & txtRecievedAPDU.Text & vbNewLine & "(" & SWstr & ")")
        Else
            MessageBox.Show("APDU Command cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnGetATR_Click(sender As Object, e As EventArgs) Handles btnGetATR.Click
        txtATRValue.Clear()

        Try
            Dim cardATR As Byte() = SmartPCSC.getCardATR(cbxReader.Text)
            Dim cardATRstr As String

            If Not cardATR Is Nothing Then
                cardATRstr = BitConverter.ToString(cardATR)
                cardATRstr = cardATRstr.Replace("-", " ")

                txtATRValue.Text = cardATRstr

                MessageBox.Show("Get Card ATR Complete", "GetCardATR : Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtLog.AppendText(vbNewLine & vbNewLine & "GetCardATR : SUCCESS" & vbNewLine & ">> " & cardATRstr)
            Else
                txtLog.AppendText(vbNewLine & vbNewLine & "GetCardATR : Failed")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GetCardATR : Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLog.AppendText(vbNewLine & vbNewLine & "GetCardATR : Failed" & vbNewLine & "::: " & ex.Message)
        End Try
    End Sub

    Private Sub btnByteToASCII_Click(sender As Object, e As EventArgs) Handles btnByteToASCII.Click
        If txtRecievedAPDU.Text <> "" AndAlso txtRecievedAPDU.Text <> "NO RESPONSE DATA" Then
            txtASCII.Text = SmartPCSC.getTextfromASCII(latestResponse)
        End If
    End Sub

    Private Sub btnByteToThaiASCII_Click(sender As Object, e As EventArgs) Handles btnByteToThaiASCII.Click
        If txtRecievedAPDU.Text <> "" AndAlso txtRecievedAPDU.Text <> "NO RESPONSE DATA" Then
            txtASCII.Text = SmartPCSC.getTextfromThaiASCII(latestResponse)
        End If
    End Sub
End Class
