Imports System.Data.SqlClient

Public Class Form6
    Private totalCost As Decimal
    Private paymentID As Integer ' Add a field to store payment ID

    Public Sub New(totalCost As Decimal)
        InitializeComponent()
        Me.totalCost = totalCost
        ' Initialize your form with the totalCost value
        TextBox5.Text = totalCost.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate payment details (add your validation logic here)
        Dim cardHolderName As String = TextBox1.Text.Trim()
        Dim cardNumber As String = TextBox2.Text.Trim()
        Dim expiryDate As String = TextBox3.Text.Trim()
        Dim phoneNumber As String = TextBox4.Text.Trim()
        Dim cvv As String = TextBox6.Text.Trim()

        ' Validate if any field is empty
        If String.IsNullOrWhiteSpace(cardHolderName) OrElse
           String.IsNullOrWhiteSpace(cardNumber) OrElse
           String.IsNullOrWhiteSpace(expiryDate) OrElse
           String.IsNullOrWhiteSpace(phoneNumber) OrElse
           String.IsNullOrWhiteSpace(cvv) Then

            MessageBox.Show("Please enter all details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate Card Holder Name
        For Each c As Char In TextBox1.Text
            If Char.IsDigit(c) Then
                MessageBox.Show("Please enter a valid Card Holder Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        ' Validate CardNumber
        For Each c As Char In TextBox2.Text
            If Not Char.IsDigit(c) Then
                MessageBox.Show("Please enter a valid Card Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        ' Validate Expiry Date
        Dim expiryDateTime As Date
        If Not TryParseExpiryDate(expiryDate, expiryDateTime) Then
            MessageBox.Show("Please enter a valid expiry date in the format MM/YYYY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the expiry date is in the future
        If expiryDateTime <= Date.Today Then
            MessageBox.Show("Please enter a valid expiry date in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate Phone Number
        If phoneNumber.Length <> 10 OrElse Not IsNumeric(phoneNumber) Then
            MessageBox.Show("Please enter a valid 10-digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate CVV
        For Each c As Char In TextBox6.Text
            If Not Char.IsDigit(c) Then
                MessageBox.Show("Please enter a valid CVV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        ' Insert payment information into the database
        Try
            Using con As New SqlConnection("Data Source=LAPTOP-CERS49PL\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True")
                con.Open()

                Dim query As String = "INSERT INTO Payment (CardHolderName, CardNumber, ExpiryDate, PhoneNumber, TotalCost, CVV) VALUES (@CardHolderName, @CardNumber, @ExpiryDate, @PhoneNumber, @TotalCost, @CVV); SELECT SCOPE_IDENTITY();"

                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@CardHolderName", cardHolderName)
                    command.Parameters.AddWithValue("@CardNumber", cardNumber)
                    command.Parameters.AddWithValue("@ExpiryDate", expiryDateTime)
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    command.Parameters.AddWithValue("@TotalCost", totalCost)
                    command.Parameters.AddWithValue("@CVV", cvv)

                    ' Get the payment ID of the newly inserted record
                    paymentID = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using

            ' Show success message
            MessageBox.Show("Payment successful. Your ticket is confirmed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form5Instance As Form5 = CType(Application.OpenForms("Form5"), Form5)

            If form5Instance IsNot Nothing Then
                Dim form7Instance As New Form7(form5Instance.RichTextBox1.Text) ' Create an instance of Form7
                form7Instance.Show() ' Show Form7
                Me.Hide() ' Hide the current form (Form6)
            End If


            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An error occurred while processing the payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function TryParseExpiryDate(expiryDate As String, ByRef expiryDateTime As Date) As Boolean
        Dim parts() As String = expiryDate.Split("/"c)
        If parts.Length <> 2 Then
            Return False
        End If

        Dim month As Integer
        Dim year As Integer
        If Not Integer.TryParse(parts(0), month) OrElse
           Not Integer.TryParse(parts(1), year) Then
            Return False
        End If

        ' Assuming that the day part is always the first day of the month
        expiryDateTime = New Date(year, month, 1)

        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Ensure that the original instance of Form5 is shown
        Dim form5Instance As Form5 = CType(Application.OpenForms("Form5"), Form5)

        ' Show the original instance of Form5
        If form5Instance IsNot Nothing Then
            form5Instance.Show()
        End If

        ' Hide the current form (Form6)
        Me.Hide()

    End Sub
End Class
