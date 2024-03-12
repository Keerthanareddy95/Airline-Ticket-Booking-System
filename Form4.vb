Imports System.Data.SqlClient

Public Class Form4

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get user selections
        Dim source As String = ComboBox1.Text
        Dim destination As String = ComboBox2.Text
        Dim selectedDate As Date = DateTimePicker1.Value.Date

        ' Check if the selected date is in the past
        If selectedDate < DateTime.Today Then
            MessageBox.Show("Please select a present or future date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if source and destination airports are the same
        If source = destination Then
            MessageBox.Show("Source and destination airports cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Launch Form5 and pass user selections as arguments
        Dim frm5 As New Form5(source, destination, selectedDate)
        frm5.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Establish a connection to the database
            Using con As New SqlConnection("Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True")
                con.Open()  ' Open the connection

                ' Query to retrieve distinct source airport names
                Dim sourceQuery As String = "SELECT DISTINCT SourceAirport FROM FlightsData"
                Dim sourceAdapter As New SqlDataAdapter(sourceQuery, con)
                Dim sourceTable As New DataTable()
                sourceAdapter.Fill(sourceTable)

                ' Query to retrieve distinct destination airport names
                Dim destinationQuery As String = "SELECT DISTINCT DestinationAirport FROM FlightsData"
                Dim destinationAdapter As New SqlDataAdapter(destinationQuery, con)
                Dim destinationTable As New DataTable()
                destinationAdapter.Fill(destinationTable)

                ' Set the DataSource and DisplayMember for ComboBox1
                ComboBox1.DataSource = sourceTable
                ComboBox1.DisplayMember = "SourceAirport"
                ComboBox1.Text = "Select Source"

                ' Set the DataSource and DisplayMember for ComboBox2
                ComboBox2.DataSource = destinationTable
                ComboBox2.DisplayMember = "DestinationAirport"
                ComboBox2.Text = "Select Destination"

            End Using ' Connection automatically closed here
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
