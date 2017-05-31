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

        MySplitCall = Get_Call_Array("952085")

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

            pArrCalls(0) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(1) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(2) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(3) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(4) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(5) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(6) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(7) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(8) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(9) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(10) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(11) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(12) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(13) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(14) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(15) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(16) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(17) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(18) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(19) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(20) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(21) = "1137_939509-20170404-080750-5199645900_01.wav"
            pArrCalls(22) = "1137_939509-20170404-080750-5199645900_01.wav"

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
        Dim request As WebRequest = WebRequest.Create("https://y450.mybluemix.net/SEND_AUDIO_FILE_LINK_SENTIMENT")

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

        ' Create a request using a URL that can receive a post.   
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
