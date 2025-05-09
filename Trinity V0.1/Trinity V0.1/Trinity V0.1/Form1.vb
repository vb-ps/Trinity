Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Form1
    ' Variables to track mouse position
    Private isDragging As Boolean = False
    Private startPoint As Point
    Private WithEvents timer As New Timer()

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

    Private Sub crackedclients_Click(sender As Object, e As EventArgs) Handles crackedclients.Click
        ' Open CrackedClientsForm
        Dim crackedClientsForm As New CrackedClientsForm()
        crackedClientsForm.Show()
        Me.Hide() ' Hide the current form
    End Sub

    Private Sub freeclients_Click(sender As Object, e As EventArgs) Handles freeclients.Click
        ' Open FreeClientsForm
        Dim freeClientsForm As New FreeClientsForm()
        freeClientsForm.Show()
        Me.Hide() ' Hide the current form
    End Sub

    Private Sub crackedpre19clients_Click(sender As Object, e As MouseEventArgs) Handles crackedpre19clients.Click
        ' Open Pre19ClientsForm
        Dim pre19ClientsForm As New Pre19ClientsForm()
        pre19ClientsForm.Show()
        Me.Hide() ' Hide the current form
    End Sub

    Private Shared Sub [Exit]()
        Throw New NotImplementedException()
    End Sub
    Private Sub Ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        Application.Exit()
    End Sub
End Class
