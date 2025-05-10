Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FreeClientsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Back = New Button()
        meteordl = New Button()
        Catleandl = New Button()
        earthhackdl = New Button()
        liquidbouncedl = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Back
        ' 
        Back.BackColor = Color.DarkSlateGray
        Back.ForeColor = Color.White
        Back.Location = New Point(260, 359)
        Back.Name = "Back"
        Back.Size = New Size(75, 23)
        Back.TabIndex = 0
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = False
        ' 
        ' meteordl
        ' 
        meteordl.BackColor = Color.DarkSlateGray
        meteordl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        meteordl.ForeColor = SystemColors.Control
        meteordl.Location = New Point(199, 68)
        meteordl.Name = "meteordl"
        meteordl.Size = New Size(75, 23)
        meteordl.TabIndex = 1
        meteordl.Text = "Download"
        meteordl.UseVisualStyleBackColor = False
        ' 
        ' Catleandl
        ' 
        Catleandl.BackColor = Color.DarkSlateGray
        Catleandl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Catleandl.ForeColor = SystemColors.Control
        Catleandl.Location = New Point(199, 309)
        Catleandl.Name = "Catleandl"
        Catleandl.Size = New Size(75, 23)
        Catleandl.TabIndex = 2
        Catleandl.Text = "Download"
        Catleandl.UseVisualStyleBackColor = False
        ' 
        ' earthhackdl
        ' 
        earthhackdl.BackColor = Color.DarkSlateGray
        earthhackdl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        earthhackdl.ForeColor = SystemColors.Control
        earthhackdl.Location = New Point(199, 235)
        earthhackdl.Name = "earthhackdl"
        earthhackdl.Size = New Size(75, 23)
        earthhackdl.TabIndex = 3
        earthhackdl.Text = "Download"
        earthhackdl.UseVisualStyleBackColor = False
        ' 
        ' liquidbouncedl
        ' 
        liquidbouncedl.BackColor = Color.DarkSlateGray
        liquidbouncedl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        liquidbouncedl.ForeColor = SystemColors.Control
        liquidbouncedl.Location = New Point(199, 143)
        liquidbouncedl.Name = "liquidbouncedl"
        liquidbouncedl.Size = New Size(75, 23)
        liquidbouncedl.TabIndex = 4
        liquidbouncedl.Text = "Download"
        liquidbouncedl.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(26, 313)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 15)
        Label1.TabIndex = 5
        Label1.Text = "Catlean (Safe FABRIC 1.21.4)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(26, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 15)
        Label2.TabIndex = 6
        Label2.Text = "Meteor [Safe FABRIC 1.21.5]"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(46, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 15)
        Label3.TabIndex = 7
        Label3.Text = "Liquidbounce [Safe 1.8x]"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(16, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 15)
        Label4.TabIndex = 8
        Label4.Text = "3arthh4ck (Safe 1.12.2 Forge?)"
        ' 
        ' FreeClientsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(347, 394)
        Controls.Add(Label2)
        Controls.Add(meteordl)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(liquidbouncedl)
        Controls.Add(earthhackdl)
        Controls.Add(Catleandl)
        Controls.Add(Back)
        FormBorderStyle = FormBorderStyle.None
        Name = "FreeClientsForm"
        Text = "Free_1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Variables to track mouse position
    Private isDragging As Boolean = False
    Private startPoint As Point

    Private Sub FreeClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Me.Text = "Free Clients Anarchy"
    End Sub

    ' Handle MouseDown event
    Private Sub FreeClientsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = e.Location
        End If
    End Sub

    ' Handle MouseMove event
    Private Sub FreeClientsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isDragging Then
            Dim newPoint As Point = Me.Location + (e.Location - startPoint)
            Me.Location = newPoint
        End If
    End Sub

    ' Handle MouseUp event to stop dragging
    Private Sub FreeClientsForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private WithEvents Back As Button

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        ' Return to the main form
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Close() ' Close the current form
    End Sub

    Friend WithEvents meteordl As Button

    Private Sub meteordl_Click(sender As Object, e As EventArgs) Handles meteordl.Click
        DownloadFile("https://meteorclient.com/api/download", "meteor.jar")
    End Sub

    Friend WithEvents Catleandl As Button
    Friend WithEvents earthhackdl As Button
    Friend WithEvents liquidbouncedl As Button

    Private Sub liquidbouncedl_Click(sender As Object, e As EventArgs) Handles liquidbouncedl.Click
        DownloadFile("https://github.com/CCBlueX/LiquidLauncher/releases/download/v0.4.3/LiquidLauncher_0.4.3_x64_en-US.msi")
    End Sub

    Private Sub earthhackdl_Click(sender As Object, e As EventArgs) Handles earthhackdl.Click
        DownloadFile("https://github.com/3arthqu4ke/3arthh4ck/releases/download/1.8.5/3arthh4ck-1.8.5-release.jar")
    End Sub

    Private Sub Catleandl_Click(sender As Object, e As EventArgs) Handles Catleandl.Click
        DownloadFile("https://github.com/vb-ps/CLDL/releases/download/Clpicker/catlean.jar")
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private Sub DownloadFile(url As String, Optional fileName As String = Nothing)
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
            If String.IsNullOrEmpty(fileName) Then
                fileName = IO.Path.GetFileName(New Uri(url).LocalPath)
            End If
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
