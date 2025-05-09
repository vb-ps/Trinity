<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pre19ClientsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Back = New Button()
        risedl = New Button()
        vapedl = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
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
        ' risedl
        ' 
        risedl.BackColor = Color.DarkSlateGray
        risedl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        risedl.ForeColor = SystemColors.Control
        risedl.Location = New Point(189, 86)
        risedl.Name = "risedl"
        risedl.Size = New Size(75, 23)
        risedl.TabIndex = 1
        risedl.Text = "Download"
        risedl.UseVisualStyleBackColor = False
        ' 
        ' vapedl
        ' 
        vapedl.BackColor = Color.DarkSlateGray
        vapedl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        vapedl.ForeColor = SystemColors.Control
        vapedl.Location = New Point(189, 255)
        vapedl.Name = "vapedl"
        vapedl.Size = New Size(75, 23)
        vapedl.TabIndex = 2
        vapedl.Text = "Download"
        vapedl.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(19, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 15)
        Label1.TabIndex = 3
        Label1.Text = "Rise 6.5.1 (Unchecked 1.8.9)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(19, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 15)
        Label2.TabIndex = 4
        Label2.Text = "Vape 4.17 (Unchecked 1.8.9)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 5.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(306, 10)
        Label3.TabIndex = 5
        Label3.Text = "Dev note : These take a while to download so it might not say download complete instantly"
        ' 
        ' Pre19ClientsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(347, 394)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(vapedl)
        Controls.Add(risedl)
        Controls.Add(Back)
        FormBorderStyle = FormBorderStyle.None
        Name = "Pre19ClientsForm"
        Text = "Pre19ClientsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents risedl As Button
    Friend WithEvents vapedl As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
