Imports System.Data.SqlClient
Public Class Form3
    Dim constr As String = "Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True;Connect Timeout=30;"
    Dim adapter As New SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Using con As New SqlConnection(constr)
                con.Open()
                Dim sql As String = "SELECT * FROM userlogin WHERE username=@username AND password=@password"
                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@username", TextBox1.Text)
                cmd.Parameters.AddWithValue("@password", TextBox2.Text)
                adapter = New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim flightSelectionForm As New Form4()
                    flightSelectionForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Username or password invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class