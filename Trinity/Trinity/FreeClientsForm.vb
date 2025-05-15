Public Class FreeClientsForm
    Private Sub meteordl_Click(sender As Object, e As EventArgs) Handles meteordl.Click
        DownloadFile("https://meteorclient.com/api/download", "meteor-latest.jar")
    End Sub

    Private Sub liquiddl_Click(sender As Object, e As EventArgs) Handles liquiddl.Click
        DownloadFile("https://github.com/CCBlueX/LiquidLauncher/releases/download/v0.4.3/LiquidLauncher_0.4.3_x64_en-US.msi")
    End Sub

    Private Sub earthdl_Click(sender As Object, e As EventArgs) Handles earthdl.Click
        DownloadFile("https://github.com/3arthqu4ke/3arthh4ck/releases/download/1.8.5/3arthh4ck-1.8.5-release.jar")
    End Sub

    Private Sub catdl_Click(sender As Object, e As EventArgs) Handles catdl.Click
        DownloadFile("https://github.com/vb-ps/CLDL/releases/download/Clpicker/catlean.jar")
    End Sub

    Private Sub DownloadFile(url As String, Optional customFileName As String = Nothing)
        Try
            ' Retrieve the download directory from the registry
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
            Dim fileName As String = If(customFileName, IO.Path.GetFileName(New Uri(url).LocalPath))
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