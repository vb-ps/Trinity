<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FreeClientsForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        meteordl = New Button()
        liquiddl = New Button()
        earthdl = New Button()
        catdl = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 15)
        Label1.TabIndex = 0
        Label1.Text = " Download Meteor [Checked Safe FABRIC 1.21.5]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(21, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(257, 15)
        Label2.TabIndex = 1
        Label2.Text = "Download LiquidBounce [Safe FABRIC 1.21.4]"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(39, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(239, 15)
        Label3.TabIndex = 2
        Label3.Text = "Download 3arthh4ck [Safe FABRIC 1.12.2]"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(55, 255)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 15)
        Label4.TabIndex = 3
        Label4.Text = "Download Catlean [Safe FABRIC 1.21.4]"
        ' 
        ' meteordl
        ' 
        meteordl.BackColor = Color.DarkSlateGray
        meteordl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        meteordl.ForeColor = SystemColors.Control
        meteordl.Location = New Point(284, 48)
        meteordl.Name = "meteordl"
        meteordl.Size = New Size(75, 23)
        meteordl.TabIndex = 4
        meteordl.Text = "Download"
        meteordl.UseVisualStyleBackColor = False
        ' 
        ' liquiddl
        ' 
        liquiddl.BackColor = Color.DarkSlateGray
        liquiddl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        liquiddl.ForeColor = SystemColors.Control
        liquiddl.Location = New Point(284, 114)
        liquiddl.Name = "liquiddl"
        liquiddl.Size = New Size(75, 23)
        liquiddl.TabIndex = 5
        liquiddl.Text = "Download"
        liquiddl.UseVisualStyleBackColor = False
        ' 
        ' earthdl
        ' 
        earthdl.BackColor = Color.DarkSlateGray
        earthdl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        earthdl.ForeColor = SystemColors.Control
        earthdl.Location = New Point(284, 178)
        earthdl.Name = "earthdl"
        earthdl.Size = New Size(75, 23)
        earthdl.TabIndex = 6
        earthdl.Text = "Download"
        earthdl.UseVisualStyleBackColor = False
        ' 
        ' catdl
        ' 
        catdl.BackColor = Color.DarkSlateGray
        catdl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        catdl.ForeColor = SystemColors.Control
        catdl.Location = New Point(284, 251)
        catdl.Name = "catdl"
        catdl.Size = New Size(75, 23)
        catdl.TabIndex = 7
        catdl.Text = "Download"
        catdl.UseVisualStyleBackColor = False
        ' 
        ' FreeClientsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(490, 333)
        Controls.Add(catdl)
        Controls.Add(earthdl)
        Controls.Add(liquiddl)
        Controls.Add(meteordl)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FreeClientsForm"
        Text = "FreeClientsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents meteordl As Button
    Friend WithEvents liquiddl As Button
    Friend WithEvents earthdl As Button
    Friend WithEvents catdl As Button
End Class
