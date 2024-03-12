Imports System.Data.SqlClient

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView
        LoadFlightsData()
    End Sub
    Private Sub LoadFlightsData()
        ' Connect to the database and fetch train data
        Dim connectionString As String = "Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True"
        Dim query As String = "SELECT * FROM [dbo].[FlightsData]"

        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                ' Bind data to DataGridView
                DataGridView1.DataSource = dataTable
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add new train record
        Dim con As New SqlConnection("Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("
     SET IDENTITY_INSERT [dbo].[FlightsData] ON;
     INSERT INTO [dbo].[FlightsData]
     ([FlightID]
     ,[SourceAirport]
     ,[DestinationAirport]
     ,[DepartureTime]
     ,[ArrivalTime]
     ,[AirlineType]
     ,[BasePriceEconomy]
     ,[BasePriceBusiness]
     ,[BasePriceFirstClass])
     VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "','" + TextBox8.Text + "',  '" + TextBox9.Text + "');
     ", con)

        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

        ' Reload data in DataGridView
        LoadFlightsData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Delete train record
        Dim con As New SqlConnection("Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SET IDENTITY_INSERT [dbo].[FlightsData] ON;
       DELETE FROM [dbo].[FlightsData] WHERE [FlightID] = '" + TextBox1.Text + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

        ' Reload data in DataGridView
        LoadFlightsData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Update train record
        Dim connectionString As String = "Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True"

        Using con As New SqlConnection(connectionString)
            con.Open()

            Dim cmd As New SqlCommand("
            UPDATE [dbo].[FlightsData] 
            SET [SourceAirport] = @SourceAirport, 
                [DestinationAirport] = @DestinationAirport, 
                [DepartureTime] = @DepartureTime, 
                [ArrivalTime] = @ArrivalTime, 
                [AirlineType] = @AirlineType, 
                [BasePriceEconomy] = @BasePriceEconomy, 
                [BasePriceBusiness] = @BasePriceBusiness, 
                [BasePriceFirstClass] = @BasePriceFirstClass
            WHERE [FlightID] = @FlightID", con)

            cmd.Parameters.AddWithValue("@SourceAirport", TextBox2.Text)
            cmd.Parameters.AddWithValue("@DestinationAirport", TextBox3.Text)
            cmd.Parameters.AddWithValue("@DepartureTime", TextBox4.Text)
            cmd.Parameters.AddWithValue("@ArrivalTime", TextBox5.Text)
            cmd.Parameters.AddWithValue("@AirlineType", TextBox6.Text)
            cmd.Parameters.AddWithValue("@BasePriceEconomy", TextBox7.Text)
            cmd.Parameters.AddWithValue("@BasePriceBusiness", TextBox8.Text)
            cmd.Parameters.AddWithValue("@BasePriceFirstClass", TextBox9.Text)
            cmd.Parameters.AddWithValue("@FlightID", TextBox1.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using

        ' Reload data in DataGridView
        LoadFlightsData()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

    End Sub
End Class