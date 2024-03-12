<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkOrange
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-25, -60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1405, 700)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(266, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 61)
        Button1.TabIndex = 1
        Button1.Text = "ADMIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SandyBrown
        Button2.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(985, 129)
        Button2.Name = "Button2"
        Button2.Size = New Size(247, 55)
        Button2.TabIndex = 2
        Button2.Text = "USER LOGIN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSlateGray
        Label1.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Thistle
        Label1.Location = New Point(266, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(901, 57)
        Label1.TabIndex = 3
        Label1.Text = "AIRLINE TICKET BOOKING PLATFORM"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RosyBrown
        Button3.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(559, 129)
        Button3.Name = "Button3"
        Button3.Size = New Size(317, 55)
        Button3.TabIndex = 4
        Button3.Text = "USER REGISTERATION"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkSeaGreen
        Label2.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(517, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 35)
        Label2.TabIndex = 5
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkSeaGreen
        Label3.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(517, 342)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 35)
        Label3.TabIndex = 6
        Label3.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(726, 270)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(726, 346)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 8
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.AppWorkspace
        Button4.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(616, 461)
        Button4.Name = "Button4"
        Button4.Size = New Size(193, 53)
        Button4.TabIndex = 9
        Button4.Text = "REGISTER"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1392, 616)
        Controls.Add(Button4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
End Class
