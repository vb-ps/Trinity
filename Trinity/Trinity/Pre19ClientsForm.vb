﻿Imports System.Drawing.Drawing2D

Public Class Pre19ClientsForm
    ' Variables to track mouse position
    Private isDragging As Boolean = False
    Private startPoint As Point

    Private Sub Pre19ClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a GraphicsPath to define the rounded rectangle
        Dim path As New GraphicsPath()
        Dim radius As Integer = 30 ' Adjust the radius for roundness
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        ' Add rounded rectangle to the path
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Apply the path as the form's region
        Me.Region = New Region(path)

        Me.Text = "Cracked Clients Pre 1.9"
    End Sub


    Private Sub Back_Click(sender As Object, e As EventArgs)
        ' Return to the main form
        Dim mainForm As New Form1
        mainForm.Show
        Close ' Close the current form
    End Sub

    Private Sub risedl_Click(sender As Object, e As EventArgs) Handles risedl.Click
        MsgBox("After running for the first time, put the --no-update back since the update check is broken.", MsgBoxStyle.Critical, Title:="Attention")
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/hgfdc/Rise.6.5.3.zip")
    End Sub

    Private Sub vapedl_Click(sender As Object, e As EventArgs) Handles vapedl.Click
        DownloadFile("https://github.com/vb-ps/vapecrack/releases/download/gdfdfgs/1.8.9.Lunar.vape-v4.17-cracked.zip")
    End Sub

    Private Sub slinkydl_Click(sender As Object, e As EventArgs) Handles slinkydl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/hdfghfg/slinkycrack.1.zip")
    End Sub

    Private Sub myaudl_Click(sender As Object, e As EventArgs) Handles myaudl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/etr/Myau-240925-cr.zip")
    End Sub

    Private Sub opaldl_Click(sender As Object, e As EventArgs) Handles opaldl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/ads/1.21.Fabric.Opal.011225.cracked.2.zip")
    End Sub
    Private Sub DownloadFile(url As String)
        Try
            ' Retrieve the download directory from the registry
            ' Retrieve the Downloads folder path from the registry using VBScript equivalent logic
            Dim downloadPath As String = Nothing
            Try
                Dim shell As Object = CreateObject("WScript.Shell")
                Dim regValue As Object = shell.RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders\{374DE290-123F-4565-9164-39C4925E467B}")
                If regValue IsNot Nothing Then
                    downloadPath = regValue.ToString()
                End If
            Catch ex As Exception
                ' If the registry key is not found, fallback to default Downloads folder
                downloadPath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                MsgBox("Failed to retrieve download directory from registry. Defaulting to Downloads folder.", MsgBoxStyle.Information, "Notice")
            End Try

            ' If the directory is not found, use the default Downloads folder
            If String.IsNullOrEmpty(downloadPath) Then
                downloadPath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                MsgBox("Failed to retrieve download directory from registry. Defaulting to Downloads folder.", MsgBoxStyle.Information, "Notice")
            End If

            ' Define the output file path
            Dim fileName As String = IO.Path.GetFileName(New Uri(url).LocalPath)
            Dim outputPath As String = IO.Path.Combine(downloadPath, fileName)

            ' Use HttpClient to download the file
            Using client As New Net.Http.HttpClient()
                Dim fileBytes As Byte() = client.GetByteArrayAsync(url).Result
                IO.File.WriteAllBytes(outputPath, fileBytes)
            End Using

            MsgBox("Download completed successfully!", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("Download failed: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub page2_Click(sender As Object, e As EventArgs) Handles page2.Click
        Form1.switchpanel(Pre19ClientsFormPage2)
    End Sub
End Class
