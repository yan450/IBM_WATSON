Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form1
    Public pArrCalls As String()

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Watson_Tone("")

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim pArrCalls(23)

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



    End Sub

#Region "Function"

    Public Sub Send_Bulk_Wav(ByVal ArrCalls As String())
        Dim sCall As String
        Dim Sentiment_Value As String = ""


        For Each sCall In ArrCalls

            Me.txtResponse.Text &= "-==" Watson_Sentiment(sCall)

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

        txtResponse.Text = "SENT!"
        Me.Refresh()

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

#End Region

End Class
