<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1332, 656)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Stencil", 26F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(448, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 61)
        Label1.TabIndex = 1
        Label1.Text = "ADMIN LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(438, 302)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 40)
        Label2.TabIndex = 2
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(438, 404)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 40)
        Label3.TabIndex = 3
        Label3.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(671, 311)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(671, 413)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(438, 550)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 50)
        Button1.TabIndex = 6
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Salmon
        Button2.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(671, 550)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 50)
        Button2.TabIndex = 7
        Button2.Text = "CANCEL"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Plum
        Button3.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(47, 122)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 50)
        Button3.TabIndex = 8
        Button3.Text = "BACK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 648)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
