﻿Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.txtResponse.Text = Watson_Tone("")

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Function"

    Private Function Watson_Sentiment(ByVal WAVE_LINK As String) As String
        Dim Sentiment_Value As String = ""

        ' Create a request using a URL that can receive a post.   
        Dim request As WebRequest = WebRequest.Create("https://y450.mybluemix.net/SEND_AUDIO_FILE_LINK_SENTIMENT")

        request.Method = "POST"
        request.Timeout = 1000 * 60 * 10

        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "{""url"": ""https://github.com/yan450/IBM_WATSON/blob/master/67110002355133_01.wav?raw=true""}"
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
        Sentiment_Value = responseFromServer
        ' Clean up the streams.  
        reader.Close()
        dataStream.Close()
        response.Close()

        Return Sentiment_Value

    End Function

    Private Function Watson_Tone(ByVal WAVE_LINK As String) As String
        Dim Sentiment_Value As String = ""

        ' Create a request using a URL that can receive a post.   
        Dim request As WebRequest = WebRequest.Create("https://y450.mybluemix.net/SEND_AUDIO_FILE_LINK_SENTIMENT")

        request.Method = "POST"
        request.Timeout = 1000 * 60 * 10

        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "{""url"": ""https://github.com/yan450/IBM_WATSON/blob/master/67110002355133_01.wav?raw=true""}"
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
        Sentiment_Value = responseFromServer
        ' Clean up the streams.  
        reader.Close()
        dataStream.Close()
        response.Close()

        Return Sentiment_Value

    End Function

#End Region

End Class
