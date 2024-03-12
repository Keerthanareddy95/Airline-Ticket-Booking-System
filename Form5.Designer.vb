<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        RichTextBox1 = New RichTextBox()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-41, -22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1421, 736)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(107, 100)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(948, 116)
        DataGridView1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Wheat
        Button1.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(677, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(304, 48)
        Button1.TabIndex = 2
        Button1.Text = "VIEW BOOKING SUMMARY"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(107, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(837, 52)
        Label1.TabIndex = 3
        Label1.Text = "CHOOSE FROM THE AVAILABLE FLIGHTS"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(107, 254)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(396, 254)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Sitka Display", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(107, 325)
        Label2.Name = "Label2"
        Label2.Size = New Size(355, 40)
        Label2.TabIndex = 7
        Label2.Text = "Summary Of Your Booking - "
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Thistle
        RichTextBox1.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(107, 392)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(505, 250)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = ""
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumAquamarine
        Button2.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(989, 570)
        Button2.Name = "Button2"
        Button2.Size = New Size(295, 59)
        Button2.TabIndex = 9
        Button2.Text = "PROCEED TO PAYMENT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightSalmon
        Button3.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(1161, 61)
        Button3.Name = "Button3"
        Button3.Size = New Size(123, 48)
        Button3.TabIndex = 10
        Button3.Text = "BACK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1377, 654)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
