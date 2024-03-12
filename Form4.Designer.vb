<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, -58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1354, 818)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(46, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(846, 57)
        Label1.TabIndex = 1
        Label1.Text = "SELECT YOUR PREFERRED DETAILS"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.GradientActiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(46, 244)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(233, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.GradientActiveCaption
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(355, 244)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(235, 33)
        ComboBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(355, 482)
        Button1.Name = "Button1"
        Button1.Size = New Size(245, 55)
        Button1.TabIndex = 6
        Button1.Text = "SEARCH FLIGHTS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSalmon
        Button2.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(46, 482)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 55)
        Button2.TabIndex = 7
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(46, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 35)
        Label3.TabIndex = 9
        Label3.Text = "FROM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientActiveCaption
        Label4.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(355, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 35)
        Label4.TabIndex = 10
        Label4.Text = "TO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(46, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(284, 35)
        Label2.TabIndex = 11
        Label2.Text = "Enter your Date Of Travel " & vbCrLf
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(355, 355)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 13
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1332, 649)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
