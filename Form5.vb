Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Data.SqlClient

Public Class Form5
    Private sourceAirport As String
    Private destinationAirport As String
    Private selectedDate As Date
    Private totalFare As Decimal ' Declare totalFare at the class level
    Private departureTime As DateTime ' Declare departureTime at the class level
    Private arrivalTime As DateTime

    Public Sub New(source As String, destination As String, dateSelected As Date)
        InitializeComponent()
        sourceAirport = source
        destinationAirport = destination
        selectedDate = dateSelected

        ' Debugging code
        MessageBox.Show($"Source: {sourceAirport}, Destination: {destinationAirport}, Selected Date: {selectedDate}")
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        RichTextBox1.Visible = False
        Button2.Visible = False
        Try
            ' Establish a connection to the database
            Using con As New SqlConnection("Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True")
                con.Open()  ' Open the connection

                ' Construct the SQL query to retrieve available flights
                Dim query As String = "SELECT FlightID, SourceAirport, DestinationAirport, DepartureTime, ArrivalTime, AirlineType, BasePriceEconomy, BasePriceBusiness, BasePriceFirstClass FROM FlightsData WHERE SourceAirport = @source AND DestinationAirport = @destination"

                ' Create and execute the command with parameters
                Dim command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@source", sourceAirport)
                command.Parameters.AddWithValue("@destination", destinationAirport)

                ' Create a data adapter to fill a DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                If dataTable.Rows.Count > 0 Then
                    MessageBox.Show("Data loaded successfully.")
                Else
                    MessageBox.Show("No data found for the selected airports.")
                End If

                ' Populate the DataGridView with the retrieved flight information
                DataGridView1.DataSource = dataTable
            End Using ' Connection automatically closed here

            ' Populate ComboBox for number of seats
            ComboBox1.Items.AddRange({"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            ComboBox1.Text = "Select No OF Seats"
            ' Populate ComboBox for class
            ComboBox2.Items.AddRange({"Economy", "Business", "First Class"})
            ComboBox2.Text = "Select The Class"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handle the event when the user clicks a button to book the flight
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Retrieve the selected flight information from the DataGridView
            Dim selectedFlightIndex As Integer = DataGridView1.CurrentRow.Index
            Dim selectedFlightRow As DataGridViewRow = DataGridView1.Rows(selectedFlightIndex)
            Dim basePrice As Decimal

            ' Determine the base price based on the selected class
            Select Case ComboBox2.SelectedItem.ToString()
                Case "Economy"
                    basePrice = Convert.ToDecimal(selectedFlightRow.Cells("BasePriceEconomy").Value)
                Case "Business"
                    basePrice = Convert.ToDecimal(selectedFlightRow.Cells("BasePriceBusiness").Value)
                Case "First Class"
                    basePrice = Convert.ToDecimal(selectedFlightRow.Cells("BasePriceFirstClass").Value)
            End Select

            ' Calculate the total fare based on the number of seats and base price
            Dim selectedSeats As Integer = Convert.ToInt32(ComboBox1.SelectedItem)
            totalFare = basePrice * selectedSeats ' Assign totalFare here

            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Extract the values from the DataGridView row
                Dim arrivalTime As String = selectedRow.Cells("ArrivalTime").Value.ToString()
                Dim departureTime As String = selectedRow.Cells("DepartureTime").Value.ToString()
                ' Display booking summary in the rich text box
                Dim bookingSummary As String = $"Source Airport: {sourceAirport}" & vbCrLf &
                                           $"Destination Airport: {destinationAirport}" & vbCrLf &
                                           $"Date: {Form4.DateTimePicker1.Value.ToShortDateString}" & vbCrLf &
                                           $"Number of Seats: {selectedSeats}" & vbCrLf &
                                           $"Class: {ComboBox2.SelectedItem.ToString()}" & vbCrLf &
                                           $"Departure Time: {departureTime}" & vbCrLf &
                                           $"Arrival Time: {arrivalTime}" & vbCrLf &
                                           $"Total Fare: {totalFare.ToString("C")}"

                RichTextBox1.Text = bookingSummary

                Label2.Visible = True
                RichTextBox1.Visible = True
                Button2.Visible = True
            Else
                MessageBox.Show("Please select a row in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form6Instance As New Form6(totalFare) ' Assuming totalFare is accessible in this context
        form6Instance.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class
