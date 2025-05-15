Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Public Class Form1
    ' Variables to track mouse position
    Private isDragging As Boolean = False
    Private startPoint As Point
    Private WithEvents timer As New Timer()

    ' Hide all sections except navigation buttons

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        DATE2.Text = DateTime.Now.ToString("hh:mm:ss tt")
        ' Initialize and start the timer
        timer.Interval = 1000 ' Update every second
        timer.Start()

        Me.Text = "Main Menu"

        ' Initially show the main menu
        switchpanel(FreeClientsForm)
        MENUNAME.Text = "|| Free Client's Menu ||"
    End Sub

    ' Timer tick event to update the time
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        DATE2.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    ' Handle MouseDown event
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = e.Location
        End If
    End Sub

    ' Handle MouseMove event
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isDragging Then
            Dim newPoint As Point = Me.Location + (e.Location - startPoint)
            Me.Location = newPoint
        End If
    End Sub

    ' Handle MouseUp event
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub



    Private Sub risedl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/vb-ps/RiseCrack/releases/download/rise/RISE.CRSCK.rar")
    End Sub

    Private Sub vapedl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/vb-ps/vapecrack/releases/download/gdfdfgs/1.8.9.Lunar.vape-v4.17-cracked.zip")
    End Sub

    Private Sub slinkydl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/hdfghfg/slinkycrack.1.zip")
    End Sub

    Private Sub myaudl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/etr/Myau-240925-cr.zip")
    End Sub

    Private Sub opaldl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/vb-ps/Clientene/releases/download/ads/1.21.Fabric.Opal.011225.cracked.2.zip")
    End Sub

    Private Sub liquidbouncedl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/CCBlueX/LiquidLauncher/releases/download/v0.4.3/LiquidLauncher_0.4.3_x64_en-US.msi")
    End Sub

    Private Sub earthhackdl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/3arthqu4ke/3arthh4ck/releases/download/1.8.5/3arthh4ck-1.8.5-release.jar")
    End Sub

    Private Sub Catleandl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/vb-ps/CLDL/releases/download/Clpicker/catlean.jar")
    End Sub
    Private Sub meteordl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://meteorclient.com/api/download", "meteor.jar")
    End Sub

    Private Sub miodl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://github.com/TwoNick/mio/releases/download/v2.1.7-patch2/mio-loader.jar")
        DownloadFile("https://github.com/TwoNick/mio/releases/download/v2.1.7-patch2/mio.jar")
    End Sub

    Private Sub rusherdlr_Click(sender As Object, e As EventArgs)
        DownloadFile("https://crystalpvp.ru/rusherhack/rushercrack-2.0.jar")
    End Sub

    Private Sub futuredl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://crystalpvp.ru/future/Installer.jar")
    End Sub

    Private Sub rusherolddl_Click(sender As Object, e As EventArgs)
        DownloadFile("https://crystalpvp.ru/rusherhack/rushercrack.jar")
    End Sub

    Private Sub boze12_Click(sender As Object, e As EventArgs)
        DownloadFile("https://crystalpvp.ru/bozeupdate/bozecrack.zip")
    End Sub

    Private Sub bozev61_Click(sender As Object, e As EventArgs)
        DownloadFile("https://crystalpvp.ru/boze/finalboze.zip")
    End Sub

    ' Download File Method
    Private Sub DownloadFile(url As String, Optional customFileName As String = Nothing)
        Try
            Dim downloadPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
            Dim fileName As String = If(customFileName, IO.Path.GetFileName(New Uri(url).LocalPath))
            Dim outputPath As String = IO.Path.Combine(downloadPath, fileName)

            Using client As New Net.Http.HttpClient()
                Dim fileBytes As Byte() = client.GetByteArrayAsync(url).Result
                IO.File.WriteAllBytes(outputPath, fileBytes)
            End Using

            MsgBox("Download completed successfully!", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("Download failed: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        Application.Exit()
    End Sub

    Private Sub freeclients_Click(sender As Object, e As EventArgs) Handles freeclients.Click 'Thank you for the multi form's in one form's i could not figure this out thank you. - phy234 on youtube
        switchpanel(FreeClientsForm)
        MENUNAME.Text = "|| Free Client's Menu ||"
    End Sub
    Sub switchpanel(ByVal panel As Form)
        SelectionBOx.Controls.Clear()
        panel.TopLevel = False
        SelectionBOx.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub crackedclients_Click(sender As Object, e As EventArgs) Handles crackedclients.Click
        switchpanel(CrackedClientsForm)
        MENUNAME.Text = "|| Cracked Client's Menu ||"
    End Sub

    Private Sub crackedpre19clients_Click(sender As Object, e As EventArgs) Handles crackedpre19clients.Click
        switchpanel(Pre19ClientsForm)
        MENUNAME.Text = "|| Pre 1.9 Cracked Client's Menu ||"
    End Sub

    Private Sub opnmodsfolder_Click(sender As Object, e As EventArgs) Handles opnmodsfolder.Click
        Try
            ' Get the path to the Minecraft mods folder
            Dim modsFolderPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "mods")

            ' Check if the folder exists
            If IO.Directory.Exists(modsFolderPath) Then
                ' Open the folder in File Explorer
                Process.Start("explorer.exe", modsFolderPath)
            Else
                ' Notify the user if the folder does not exist
                MsgBox("The Minecraft mods folder does not exist on this system.", MsgBoxStyle.Exclamation, "Folder Not Found")
            End If
        Catch ex As Exception
            ' Handle any errors
            MsgBox("An error occurred while trying to open the mods folder: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class