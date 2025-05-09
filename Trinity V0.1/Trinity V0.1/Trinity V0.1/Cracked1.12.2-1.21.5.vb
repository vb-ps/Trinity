Imports System.Drawing.Drawing2D

Public Class CrackedClientsForm
    ' Variables to track mouse position
    Private isDragging As Boolean = False
    Private startPoint As Point

    Private Sub CrackedClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Me.Text = "Cracked Clients Anarchy"

    End Sub

    ' Handle MouseDown event
    Private Sub CrackedClientsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = e.Location
        End If
    End Sub

    ' Handle MouseMove event
    Private Sub CrackedClientsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isDragging Then
            Dim newPoint As Point = Me.Location + (e.Location - startPoint)
            Me.Location = newPoint
        End If
    End Sub

    ' Handle MouseUp event to stop dragging
    Private Sub CrackedClientsForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    ' Back button click handler
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        ' Return to the main form
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Close() ' Close the current form
    End Sub

    Private Sub miodl_Click(sender As Object, e As EventArgs) Handles miodl.Click
        DownloadFile("https://github.com/TwoNick/mio/releases/download/v2.1.7-patch2/mio-loader.jar")
        DownloadFile("https://github.com/TwoNick/mio/releases/download/v2.1.7-patch2/mio.jar")
    End Sub

    Private Sub rusherdl_Click(sender As Object, e As EventArgs) Handles rusherdl.Click
        DownloadFile("https://crystalpvp.ru/rusherhack/rushercrack-2.0.jar")
    End Sub

    Private Sub futuredl_Click(sender As Object, e As EventArgs) Handles futuredl.Click
        DownloadFile("https://crystalpvp.ru/future/Installer.jar")
    End Sub

    Private Sub rusherolddl_Click(sender As Object, e As EventArgs) Handles rusherolddl.Click
        DownloadFile("https://crystalpvp.ru/rusherhack/rushercrack.jar")
    End Sub

    Private Sub boze12_Click(sender As Object, e As EventArgs) Handles boze12.Click
        DownloadFile("https://crystalpvp.ru/bozeupdate/bozecrack.zip")
    End Sub

    Private Sub bozev61_Click(sender As Object, e As EventArgs) Handles bozev61.Click
        DownloadFile("https://crystalpvp.ru/boze/finalboze.zip")
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
End Class