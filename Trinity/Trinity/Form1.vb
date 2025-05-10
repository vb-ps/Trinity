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
        ShowMainMenu()

        meteordl.Visible = True
        Catleandl.Visible = True
        liquidbouncedl.Visible = True
        earthhackdl.Visible = True
        meteorlabel.Visible = True
        catleanlabel.Visible = True
        liquidlabel.Visible = True
        earthhacklabel.Visible = True
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

    ' Show Main Menu
    Private Sub ShowMainMenu()
        ' Hide all other sections except navigation buttons
        HideAllSections()

        ' Show main menu controls
        crackedclients.Visible = True
        freeclients.Visible = True
        crackedpre19clients.Visible = True
    End Sub

    ' Show Pre 1.9 Clients Section
    Private Sub ShowPre19Clients()
        HideAllSections()

        ' Show Pre 1.9 Clients controls
        risedl.Visible = True
        vapedl.Visible = True
        slinkydl.Visible = True
        myaudl.Visible = True
        opaldl.Visible = True
        riselabel.Visible = True
        vapelabel.Visible = True
        Slinky.Visible = True
        myaulabel.Visible = True
        opallabel.Visible = True
        MENUNAME.Text = "|| Pre 1.9 Cracked Client's ||"
    End Sub

    ' Show Cracked Clients Section
    Private Sub ShowCrackedClients()
        HideAllSections()

        ' Show Cracked Clients controls
        miodl.Visible = True
        rusherdlr.Visible = True
        futuredl.Visible = True
        rusherolddl.Visible = True
        boze12.Visible = True
        bozev61.Visible = True
        miolabel.Visible = True
        rusherlabel.Visible = True
        futurelabel.Visible = True
        oldrusherlabel.Visible = True
        boze12label.Visible = True
        boze61label.Visible = True
        MENUNAME.Text = "|| Cracked Client's Menu ||"
    End Sub

    ' Show Free Clients Section
    Private Sub ShowFreeClients()
        HideAllSections()

        ' Show Free Clients controls
        meteordl.Visible = True
        Catleandl.Visible = True
        liquidbouncedl.Visible = True
        earthhackdl.Visible = True
        meteorlabel.Visible = True
        catleanlabel.Visible = True
        liquidlabel.Visible = True
        earthhacklabel.Visible = True
        MENUNAME.Text = "|| Free Client's Menu ||"
    End Sub

    ' Hide all sections except navigation buttons
    Private Sub HideAllSections()
        ' Do not hide navigation buttons
        ' Hide Pre 1.9 Clients controls
        risedl.Visible = False
        vapedl.Visible = False
        slinkydl.Visible = False
        myaudl.Visible = False
        opaldl.Visible = False
        riselabel.Visible = False
        vapelabel.Visible = False
        Slinky.Visible = False
        myaulabel.Visible = False
        opallabel.Visible = False
        ' Hide Cracked Clients controls
        miodl.Visible = False
        rusherdlr.Visible = False
        futuredl.Visible = False
        rusherolddl.Visible = False
        boze12.Visible = False
        bozev61.Visible = False
        miolabel.Visible = False
        rusherlabel.Visible = False
        futurelabel.Visible = False
        oldrusherlabel.Visible = False
        boze12label.Visible = False
        boze61label.Visible = False

        ' Hide Free Clients controls
        meteordl.Visible = False
        Catleandl.Visible = False
        liquidbouncedl.Visible = False
        earthhackdl.Visible = False
        meteorlabel.Visible = False
        catleanlabel.Visible = False
        liquidlabel.Visible = False
        earthhacklabel.Visible = False
    End Sub

    ' Button Click Handlers
    Private Sub crackedclients_Click(sender As Object, e As EventArgs) Handles crackedclients.Click
        ShowCrackedClients()
    End Sub

    Private Sub freeclients_Click(sender As Object, e As EventArgs) Handles freeclients.Click
        ShowFreeClients()
    End Sub

    Private Sub crackedpre19clients_Click(sender As Object, e As EventArgs) Handles crackedpre19clients.Click
        ShowPre19Clients()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs)
        ShowMainMenu()
    End Sub

    Private Sub risedl_Click(sender As Object, e As EventArgs) Handles risedl.Click
        DownloadFile("https://github.com/vb-ps/RiseCrack/releases/download/rise/RISE.CRSCK.rar")
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

    Private Sub liquidbouncedl_Click(sender As Object, e As EventArgs) Handles liquidbouncedl.Click
        DownloadFile("https://github.com/CCBlueX/LiquidLauncher/releases/download/v0.4.3/LiquidLauncher_0.4.3_x64_en-US.msi")
    End Sub

    Private Sub earthhackdl_Click(sender As Object, e As EventArgs) Handles earthhackdl.Click
        DownloadFile("https://github.com/3arthqu4ke/3arthh4ck/releases/download/1.8.5/3arthh4ck-1.8.5-release.jar")
    End Sub

    Private Sub Catleandl_Click(sender As Object, e As EventArgs) Handles Catleandl.Click
        DownloadFile("https://github.com/vb-ps/CLDL/releases/download/Clpicker/catlean.jar")
    End Sub
    Private Sub meteordl_Click(sender As Object, e As EventArgs) Handles meteordl.Click
        DownloadFile("https://meteorclient.com/api/download", "meteor.jar")
    End Sub

    Private Sub miodl_Click(sender As Object, e As EventArgs) Handles miodl.Click
        DownloadFile("https://github.com/TwoNick/mio/releases/download/v2.1.7-patch2/mio-loader.jar")
        DownloadFile("https://github.com/TwoNick/mio/releases/download/v2.1.7-patch2/mio.jar")
    End Sub

    Private Sub rusherdlr_Click(sender As Object, e As EventArgs) Handles rusherdlr.Click
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
End Class