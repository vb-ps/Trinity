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
        Label5 = New Label()
        DATE2 = New Label()
        ext = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1 = New Panel()
        userpanelr = New Panel()
        MENUNAME = New Label()
        SelectionBOx = New Panel()
        opnmodsfolder = New Button()
        CType(Icon, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        userpanelr.SuspendLayout()
        SuspendLayout()
        ' 
        ' Icon
        ' 
        Icon.Image = My.Resources.Resources.Minecraft_creeper_face_modified
        Icon.Location = New Point(42, 6)
        Icon.Name = "Icon"
        Icon.Size = New Size(53, 50)
        Icon.SizeMode = PictureBoxSizeMode.StretchImage
        Icon.TabIndex = 0
        Icon.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 339)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 1
        Label1.Text = "made by vb-ps"
        ' 
        ' crackedclients
        ' 
        crackedclients.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        crackedclients.FlatAppearance.BorderSize = 0
        crackedclients.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(50))
        crackedclients.FlatStyle = FlatStyle.Flat
        crackedclients.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        crackedclients.ForeColor = Color.Snow
        crackedclients.Location = New Point(3, 160)
        crackedclients.Name = "crackedclients"
        crackedclients.Size = New Size(141, 44)
        crackedclients.TabIndex = 2
        crackedclients.Text = "Cracked Clients"
        crackedclients.UseVisualStyleBackColor = False
        ' 
        ' freeclients
        ' 
        freeclients.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        freeclients.FlatAppearance.BorderSize = 0
        freeclients.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(50))
        freeclients.FlatStyle = FlatStyle.Flat
        freeclients.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        freeclients.ForeColor = SystemColors.Control
        freeclients.Location = New Point(3, 110)
        freeclients.Name = "freeclients"
        freeclients.Size = New Size(141, 44)
        freeclients.TabIndex = 3
        freeclients.Text = "Free Clients"
        freeclients.UseVisualStyleBackColor = False
        ' 
        ' crackedpre19clients
        ' 
        crackedpre19clients.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        crackedpre19clients.FlatAppearance.BorderSize = 0
        crackedpre19clients.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(50))
        crackedpre19clients.FlatStyle = FlatStyle.Flat
        crackedpre19clients.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        crackedpre19clients.ForeColor = SystemColors.Control
        crackedpre19clients.Location = New Point(3, 210)
        crackedpre19clients.Name = "crackedpre19clients"
        crackedpre19clients.Size = New Size(141, 44)
        crackedpre19clients.TabIndex = 4
        crackedpre19clients.Text = "Pre 1.9 Cracked Clients"
        crackedpre19clients.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(10, 326)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 13)
        Label5.TabIndex = 8
        Label5.Text = "Trinity Build 5142025"
        ' 
        ' DATE2
        ' 
        DATE2.AutoSize = True
        DATE2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DATE2.ForeColor = Color.White
        DATE2.Location = New Point(33, 69)
        DATE2.Name = "DATE2"
        DATE2.Size = New Size(33, 13)
        DATE2.TabIndex = 9
        DATE2.Text = "TIME"
        ' 
        ' ext
        ' 
        ext.BackColor = Color.DarkSlateGray
        ext.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ext.ForeColor = SystemColors.ControlLight
        ext.Location = New Point(613, 3)
        ext.Name = "ext"
        ext.Size = New Size(23, 23)
        ext.TabIndex = 10
        ext.Text = "X"
        ext.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel1.Controls.Add(userpanelr)
        Panel1.Controls.Add(crackedpre19clients)
        Panel1.Controls.Add(freeclients)
        Panel1.Controls.Add(crackedclients)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-4, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(144, 368)
        Panel1.TabIndex = 11
        ' 
        ' userpanelr
        ' 
        userpanelr.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        userpanelr.Controls.Add(Icon)
        userpanelr.Controls.Add(DATE2)
        userpanelr.Location = New Point(3, 4)
        userpanelr.Name = "userpanelr"
        userpanelr.Size = New Size(141, 100)
        userpanelr.TabIndex = 12
        ' 
        ' MENUNAME
        ' 
        MENUNAME.AutoSize = True
        MENUNAME.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MENUNAME.ForeColor = SystemColors.Control
        MENUNAME.Location = New Point(287, 11)
        MENUNAME.Name = "MENUNAME"
        MENUNAME.Size = New Size(132, 15)
        MENUNAME.TabIndex = 43
        MENUNAME.Text = "|| Free Client's Menu ||"
        ' 
        ' SelectionBOx
        ' 
        SelectionBOx.Location = New Point(146, 29)
        SelectionBOx.Name = "SelectionBOx"
        SelectionBOx.Size = New Size(490, 333)
        SelectionBOx.TabIndex = 44
        ' 
        ' opnmodsfolder
        ' 
        opnmodsfolder.BackColor = Color.DarkSlateGray
        opnmodsfolder.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        opnmodsfolder.ForeColor = SystemColors.ControlLight
        opnmodsfolder.Location = New Point(507, 3)
        opnmodsfolder.Name = "opnmodsfolder"
        opnmodsfolder.Size = New Size(100, 23)
        opnmodsfolder.TabIndex = 45
        opnmodsfolder.Text = "Mods Folder"
        opnmodsfolder.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(639, 363)
        Controls.Add(opnmodsfolder)
        Controls.Add(SelectionBOx)
        Controls.Add(MENUNAME)
        Controls.Add(Panel1)
        Controls.Add(ext)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        CType(Icon, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        userpanelr.ResumeLayout(False)
        userpanelr.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Icon As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents crackedclients As Button
    Friend WithEvents freeclients As Button
    Friend WithEvents crackedpre19clients As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DATE2 As Label
    Friend WithEvents ext As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents userpanelr As Panel
    Friend WithEvents MENUNAME As Label
    Friend WithEvents SelectionBOx As Panel
    Friend WithEvents opnmodsfolder As Button

End Class
