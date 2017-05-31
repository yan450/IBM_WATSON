Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form1
    Public NbrSec As Integer = 0
    Public Structure SplitCall
        Public Property Nbr_Splits As Integer
        Public Property Arr_Calls As String()
    End Structure

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim MySplitCall As New SplitCall

        MySplitCall = Get_Call_Array("1002625786")

        Send_Bulk_Wav(MySplitCall.Arr_Calls)

        MsgBox("Done!")

    End Sub

    Public Function Get_Call_Array(ByVal Name As String) As SplitCall
        Dim MySplitCall As New SplitCall
        Dim pArrCalls As String()

        If Name = "67110002355133" Then
            ReDim pArrCalls(22)
            pArrCalls(0) = "67110002355133_01.wav"
            pArrCalls(1) = "67110002355133_02.wav"
            pArrCalls(2) = "67110002355133_03.wav"
            pArrCalls(3) = "67110002355133_04.wav"
            pArrCalls(4) = "67110002355133_05.wav"
            pArrCalls(5) = "67110002355133_06.wav"
            pArrCalls(6) = "67110002355133_07.wav"
            pArrCalls(7) = "67110002355133_08.wav"
            pArrCalls(8) = "67110002355133_09.wav"
            pArrCalls(9) = "67110002355133_10.wav"
            pArrCalls(10) = "67110002355133_11.wav"
            pArrCalls(11) = "67110002355133_12.wav"
            pArrCalls(12) = "67110002355133_13.wav"
            pArrCalls(13) = "67110002355133_14.wav"
            pArrCalls(14) = "67110002355133_15.wav"
            pArrCalls(15) = "67110002355133_16.wav"
            pArrCalls(16) = "67110002355133_17.wav"
            pArrCalls(17) = "67110002355133_18.wav"
            pArrCalls(18) = "67110002355133_19.wav"
            pArrCalls(19) = "67110002355133_20.wav"
            pArrCalls(20) = "67110002355133_21.wav"
            pArrCalls(21) = "67110002355133_22.wav"
            pArrCalls(22) = "67110002355133_23.wav"
            pArrCalls(23) = "67110002355133_24.wav"

        ElseIf Name = "939509" Then
            ReDim pArrCalls(21)

            pArrCalls(0) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(1) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(2) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(3) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(4) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(5) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(6) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(7) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(8) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(9) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(10) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(11) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(12) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(13) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(14) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(15) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(16) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(17) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(18) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(19) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(20) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(21) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(22) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"

        ElseIf Name = "1002623198" Then
            ReDim pArrCalls(25)

            pArrCalls(0) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(1) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_02.wav"
            pArrCalls(2) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_03.wav"
            pArrCalls(3) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_04.wav"
            pArrCalls(4) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_05.wav"
            pArrCalls(5) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_06.wav"
            pArrCalls(6) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_07.wav"
            pArrCalls(7) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_08.wav"
            pArrCalls(8) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_09.wav"
            pArrCalls(9) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_10.wav"
            pArrCalls(10) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_11.wav"
            pArrCalls(11) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_12.wav"
            pArrCalls(12) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_13.wav"
            pArrCalls(13) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_14.wav"
            pArrCalls(14) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_15.wav"
            pArrCalls(15) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_16.wav"
            pArrCalls(16) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_17.wav"
            pArrCalls(17) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_18.wav"
            pArrCalls(18) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_19.wav"
            pArrCalls(19) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_20.wav"
            pArrCalls(20) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_21.wav"
            pArrCalls(21) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_22.wav"
            pArrCalls(22) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_23.wav"
            pArrCalls(23) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_24.wav"
            pArrCalls(24) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_25.wav"
            pArrCalls(25) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_26.wav"

        ElseIf Name = "1002625786" Then
            ReDim pArrCalls(20)

            pArrCalls(0) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_01.wav"
            pArrCalls(1) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_02.wav"
            pArrCalls(2) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_03.wav"
            pArrCalls(3) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_04.wav"
            pArrCalls(4) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_05.wav"
            pArrCalls(5) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_06.wav"
            pArrCalls(6) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_07.wav"
            pArrCalls(7) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_08.wav"
            pArrCalls(8) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_09.wav"
            pArrCalls(9) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_10.wav"
            pArrCalls(10) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_11.wav"
            pArrCalls(11) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_12.wav"
            pArrCalls(12) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_13.wav"
            pArrCalls(13) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_14.wav"
            pArrCalls(14) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_15.wav"
            pArrCalls(15) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_16.wav"
            pArrCalls(16) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_17.wav"
            pArrCalls(17) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_18.wav"
            pArrCalls(18) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_19.wav"
            pArrCalls(19) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_20.wav"
            pArrCalls(20) = "Step4_1002625786_1002625749_cd16a01963444d7432faa37c_21.wav"


        ElseIf Name = "952085" Then

            ReDim pArrCalls(12)

            pArrCalls(0) = "1905_952085-20170411-081835-2268082098_01.wav"
            pArrCalls(1) = "1905_952085-20170411-081835-2268082098_02.wav"
            pArrCalls(2) = "1905_952085-20170411-081835-2268082098_03.wav"
            pArrCalls(3) = "1905_952085-20170411-081835-2268082098_04.wav"
            pArrCalls(4) = "1905_952085-20170411-081835-2268082098_05.wav"
            pArrCalls(5) = "1905_952085-20170411-081835-2268082098_06.wav"
            pArrCalls(6) = "1905_952085-20170411-081835-2268082098_07.wav"
            pArrCalls(7) = "1905_952085-20170411-081835-2268082098_08.wav"
            pArrCalls(8) = "1905_952085-20170411-081835-2268082098_09.wav"
            pArrCalls(9) = "1905_952085-20170411-081835-2268082098_10.wav"
            pArrCalls(10) = "1905_952085-20170411-081835-2268082098_11.wav"
            pArrCalls(11) = "1905_952085-20170411-081835-2268082098_12.wav"
            pArrCalls(12) = "1905_952085-20170411-081835-2268082098_13.wav"


        End If


        MySplitCall.Arr_Calls = pArrCalls
        MySplitCall.Nbr_Splits = pArrCalls.Length

        Return MySplitCall

    End Function

    Public Sub Send_Bulk_Wav(ByVal ArrCalls As String())
        Dim sCall As String
        Dim Sentiment_Value As String = ""


        For Each sCall In ArrCalls

            Me.txtResponse.Text &= "====================================================" & vbCrLf & Watson_Tone(sCall) & vbCrLf & "===================================================="
            Me.Refresh()
            NbrSec += 1
            Me.Text = NbrSec
            Me.Refresh()

            Threading.Thread.Sleep(2000)

        Next

    End Sub

    Private Function Watson_Sentiment(ByVal WAVE_LINK As String) As String
        Dim Sentiment_Value As String = ""

        ' Create a request using a URL that can receive a post.   
        Dim request As WebRequest = WebRequest.Create("https://belrontest1.eu-gb.mybluemix.net/SEND_AUDIO_FILE_LINK_SENTIMENT")

        request.Method = "POST"
        request.Timeout = 1000 * 60 * 10

        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "{""url"": ""https://github.com/yan450/IBM_WATSON/blob/master/" & WAVE_LINK & "?raw=true""}"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        ' Set the ContentType property of the WebRequest.  
        request.ContentType = "application/json"
        ' Set the ContentLength property of the WebRequest.  
        request.ContentLength = byteArray.Length
        ' Get the request stream.  
        Dim dataStream As Stream = request.GetRequestStream()
        ' Write the data to the request stream.  
        dataStream.Write(byteArray, 0, byteArray.Length)
        ' Close the Stream object.  

        dataStream.Close()
        'Get the response.  

        Dim response As WebResponse = request.GetResponse()

        ' Get the stream containing content returned by the server.  
        dataStream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.  
        Dim reader As New StreamReader(dataStream)
        ' Read the content.  
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.  
        Sentiment_Value = responseFromServer
        ' Clean up the streams.  
        reader.Close()
        dataStream.Close()
        response.Close()

        Return Sentiment_Value

    End Function

    Private Function Watson_Tone(ByVal WAVE_LINK As String) As String
        Dim Tone_Value As String = ""

        ' Create a request using a URL that can receive a post.   https://belrontest1.eu-gb.mybluemix.net/red/#2017_ibm_hackathon
        Dim request As WebRequest = WebRequest.Create("https://y450.mybluemix.net/SEND_AUDIO_FILE_LINK_TONE")

        request.Method = "POST"
        request.Timeout = 1000 * 60 * 10

        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "{""url"": ""https://github.com/yan450/IBM_WATSON/blob/master/" & WAVE_LINK & "?raw=true""}"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        ' Set the ContentType property of the WebRequest.  
        request.ContentType = "application/json"
        ' Set the ContentLength property of the WebRequest.  
        request.ContentLength = byteArray.Length
        ' Get the request stream.  
        Dim dataStream As Stream = request.GetRequestStream()
        ' Write the data to the request stream.  
        dataStream.Write(byteArray, 0, byteArray.Length)
        ' Close the Stream object.  

        dataStream.Close()
        'Get the response.  

        Dim response As WebResponse = request.GetResponse()

        ' Get the stream containing content returned by the server.  
        dataStream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.  
        Dim reader As New StreamReader(dataStream)
        ' Read the content.  
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.  
        Tone_Value = responseFromServer
        ' Clean up the streams.  
        reader.Close()
        dataStream.Close()
        response.Close()

        Return Tone_Value

    End Function


End Class
