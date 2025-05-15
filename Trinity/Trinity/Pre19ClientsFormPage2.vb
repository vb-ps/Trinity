Public Class Pre19ClientsFormPage2
    Private Sub page1_Click(sender As Object, e As EventArgs) Handles page1.Click
        Form1.switchpanel(Pre19ClientsForm)
    End Sub

    Private Sub moondl_Click(sender As Object, e As EventArgs) Handles moondl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/moon/Moon.rar")
    End Sub

    Private Sub augdl_Click(sender As Object, e As EventArgs) Handles augdl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/dsafsdf/Augustus.b2.6.rar")
    End Sub

    Private Sub azuradl_Click(sender As Object, e As EventArgs) Handles azuradl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/fdas/Azazaaa.zip")
    End Sub

    Private Sub sigmadl_Click(sender As Object, e As EventArgs) Handles sigmadl.Click
        DownloadFile("https://github.com/Sigma-Skidder-Team/SigmaArchive/raw/refs/heads/main/Sigma5-b11%5B2020%5D.tar.xz")
    End Sub

    Private Sub fdpdl_Click(sender As Object, e As EventArgs) Handles fdpdl.Click
        DownloadFile("https://github.com/SkidderMC/FDPClient/releases/download/b14/FDPClient-b14.jar")
    End Sub

    Private Sub dortdl_Click(sender As Object, e As EventArgs) Handles dortdl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/dsafdsfa/Dortware.zip")
    End Sub

    Private Sub ravenbsdl_Click(sender As Object, e As EventArgs) Handles ravenbsdl.Click
        DownloadFile("https://github.com/Strangerrrs/Raven-bS/releases/download/12/raven-bS-12.jar")
    End Sub

    Private Sub risesrcdl_Click(sender As Object, e As EventArgs) Handles risesrcdl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/fgdasdsdfg/Client-release2.1.zip")
    End Sub

    Private Sub liquidlegacydl_Click(sender As Object, e As EventArgs) Handles liquidlegacydl.Click
        DownloadFile("https://github.com/CCBlueX/LiquidBounce/archive/refs/tags/b100.zip")
    End Sub

    Private Sub vapelitedl_Click(sender As Object, e As EventArgs) Handles vapelitedl.Click
        MsgBox("Vape Lite is not available for download at the moment.", MsgBoxStyle.Information, "Notice")
    End Sub

    Private Sub crossdl_Click(sender As Object, e As EventArgs) Handles crossdl.Click
        DownloadFile("https://github.com/shxp3/CrossSine/releases/download/B47/CrossSine-b47.jar")
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