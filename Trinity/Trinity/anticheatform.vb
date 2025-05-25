Public Class anticheatform
    Private Sub anticheatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub intavedl_Click(sender As Object, e As EventArgs) Handles intavedl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/dsafsda33/Intave-14.5.6.jar")
    End Sub

    Private Sub ncpdl_Click(sender As Object, e As EventArgs) Handles ncpdl.Click
        DownloadFile("https://ci.codemc.io/job/Updated-NoCheatPlus/job/Updated-NoCheatPlus/lastSuccessfulBuild/artifact/target/NoCheatPlus.jar")
    End Sub

    Private Sub aacdl_Click(sender As Object, e As EventArgs) Handles aacdl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/34trgesa/AAC.5.2.1.jar")
    End Sub

    Private Sub grimdl_Click(sender As Object, e As EventArgs) Handles grimdl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/f23/grimac-2.3.49-patch1.jar")
    End Sub

    Private Sub vulcdl_Click(sender As Object, e As EventArgs) Handles vulcdl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/dsag43/Vulcan-2.8.7.jar")
    End Sub

    Private Sub matrixdl_Click(sender As Object, e As EventArgs) Handles matrixdl.Click
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/2435dfg/Matrix_7.5.1.jar")
    End Sub
End Class
