Imports System.Text
Imports PCSC
Imports PCSC.Iso7816
Imports PCSC.Utils

Public Class SmartPCSC
    Private contextFactory As ContextFactory = ContextFactory.Instance

    Function getReaderList() As String()
        Using context = contextFactory.Establish(SCardScope.System)
            Dim readerList As String()
            readerList = context.GetReaders()

            Return readerList
        End Using
    End Function

    Function trasmitAPDU(ByVal readerName As String, ByVal APDUcommand As Byte(), ByVal APDUcase As IsoCase) As Object
        Using context = contextFactory.Establish(SCardScope.System)
            Using reader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any)
                Using reader.Transaction(SCardReaderDisposition.Leave)
                    Dim sendPci = SCardPCI.GetPci(reader.Protocol)
                    Dim receivePci = New SCardPCI()

                    Dim receiveBuffer = New Byte(256) {}
                    Dim command = APDUcommand
                    Dim bytesReceived = reader.Transmit(sendPci, command, command.Length, receivePci, receiveBuffer, receiveBuffer.Length)
                    Dim responseApdu = New ResponseApdu(receiveBuffer, bytesReceived, APDUcase, reader.Protocol)

                    If responseApdu.HasData Then
                        Return {responseApdu.GetData, responseApdu.SW1, responseApdu.SW2}
                    Else
                        Dim noData As Byte() = {}
                        Return {noData, responseApdu.SW1, responseApdu.SW2}
                    End If
                End Using
            End Using
        End Using
    End Function

    Function getCardATR(ByVal readerName As String) As Byte()
        Using hContext = contextFactory.Establish(SCardScope.System)
            Using reader = New SCardReader(hContext)
                Dim connection As SCardError
                connection = reader.Connect(readerName, SCardShareMode.Shared, SCardProtocol.Any)
                If connection <> SCardError.Success Then
                    Throw New Exception(SCardHelper.StringifyError(connection))
                End If

                Dim sc = hContext.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any)
                Dim cardAtr As Byte() = sc.GetAttrib(SCardAttribute.AtrString)

                Return cardAtr
            End Using
        End Using
    End Function

    Function getByteArrayfromString(str As String) As Byte()
        Dim bytes As Byte() = New Byte(str.Length \ 2 - 1) {}
        For i As Integer = 0 To str.Length - 1 Step 2
            bytes(i \ 2) = Byte.Parse(str(i).ToString() & str(i + 1).ToString(), Globalization.NumberStyles.HexNumber)
        Next
        Return bytes
    End Function

    Function getTextfromASCII(ByVal byteArray As Byte())
        Return Encoding.ASCII.GetString(byteArray)
    End Function

    Function getTextfromThaiASCII(ByVal byteArray As Byte())
        Return Encoding.UTF8.GetString(Encoding.Convert(Encoding.GetEncoding("TIS-620"), Encoding.UTF8, byteArray))
    End Function
End Class
