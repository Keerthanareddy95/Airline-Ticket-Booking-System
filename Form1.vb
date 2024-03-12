Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Visible = True
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button4.Visible = True
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Get the username and password entered by the user
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Validate If the username And password are Not empty
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save the user registration details in the database
        Try
            Using con As New SqlConnection("Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True")
                con.Open()

                Dim query As String = "INSERT INTO userlogin (username, password) VALUES (@username, @password)"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Show success message
            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Redirect to Form3 for login
            Dim form3Instance As New Form3()
            form3Instance.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An error occurred while registering the user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button4.Visible = False
    End Sub
End Class
