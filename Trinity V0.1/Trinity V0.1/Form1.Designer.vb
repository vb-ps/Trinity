<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Icon = New PictureBox()
        Label1 = New Label()
        crackedclients = New Button()
        freeclients = New Button()
        crackedpre19clients = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DATE2 = New Label()
        ext = New Button()
        CType(Icon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Icon
        ' 
        Icon.Image = My.Resources.Resources.Minecraft_creeper_face_modified
        Icon.Location = New Point(12, 12)
        Icon.Name = "Icon"
        Icon.Size = New Size(58, 50)
        Icon.SizeMode = PictureBoxSizeMode.StretchImage
        Icon.TabIndex = 0
        Icon.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 339)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 1
        Label1.Text = "made by vb-ps"
        ' 
        ' crackedclients
        ' 
        crackedclients.BackColor = Color.DarkSlateGray
        crackedclients.ForeColor = Color.Snow
        crackedclients.Location = New Point(168, 83)
        crackedclients.Name = "crackedclients"
        crackedclients.Size = New Size(75, 23)
        crackedclients.TabIndex = 2
        crackedclients.Text = "Open"
        crackedclients.UseVisualStyleBackColor = False
        ' 
        ' freeclients
        ' 
        freeclients.BackColor = Color.DarkSlateGray
        freeclients.ForeColor = SystemColors.Control
        freeclients.Location = New Point(168, 169)
        freeclients.Name = "freeclients"
        freeclients.Size = New Size(75, 23)
        freeclients.TabIndex = 3
        freeclients.Text = "Open"
        freeclients.UseVisualStyleBackColor = False
        ' 
        ' crackedpre19clients
        ' 
        crackedpre19clients.BackColor = Color.DarkSlateGray
        crackedpre19clients.ForeColor = SystemColors.Control
        crackedpre19clients.Location = New Point(168, 268)
        crackedpre19clients.Name = "crackedpre19clients"
        crackedpre19clients.Size = New Size(75, 23)
        crackedpre19clients.TabIndex = 4
        crackedpre19clients.Text = "Open"
        crackedpre19clients.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(7, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 13)
        Label2.TabIndex = 5
        Label2.Text = "Cracked 1.12.2 - 1.21.5 Client's"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 13)
        Label3.TabIndex = 6
        Label3.Text = "Free 1.12.2 - 1.21.5 Client's"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 13)
        Label4.TabIndex = 7
        Label4.Text = "Cracked 1.7.10 - 1.8.9 Client's"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(64, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 13)
        Label5.TabIndex = 8
        Label5.Text = "Trinity DL v0.1"
        ' 
        ' DATE2
        ' 
        DATE2.AutoSize = True
        DATE2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DATE2.ForeColor = Color.White
        DATE2.Location = New Point(150, 12)
        DATE2.Name = "DATE2"
        DATE2.Size = New Size(34, 13)
        DATE2.TabIndex = 9
        DATE2.Text = "DATE"
        ' 
        ' ext
        ' 
        ext.BackColor = Color.DarkSlateGray
        ext.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ext.ForeColor = SystemColors.ControlLight
        ext.Location = New Point(257, 7)
        ext.Name = "ext"
        ext.Size = New Size(23, 23)
        ext.TabIndex = 10
        ext.Text = "X"
        ext.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(292, 363)
        Controls.Add(ext)
        Controls.Add(DATE2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(crackedpre19clients)
        Controls.Add(freeclients)
        Controls.Add(crackedclients)
        Controls.Add(Label1)
        Controls.Add(Icon)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        CType(Icon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Icon As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents crackedclients As Button
    Friend WithEvents freeclients As Button
    Friend WithEvents crackedpre19clients As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DATE2 As Label
    Friend WithEvents ext As Button

End Class
