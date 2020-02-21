Public Class frmAverageUnitsShipped
    ' Private Class variable for Day counter
    Private counterDay As Integer = 1
    ' Private Class array for units each day
    Private intEntered(6) As Integer

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim flag As Boolean = True
        Dim value As Integer
        ' Catches exception on int32 conversion, changes flag variable and displays error message
        Try
            value = Convert.ToInt32(txtUnitsEntered.Text.Trim)
        Catch ex As Exception
            MsgBox("ERROR: Value entered was not a whole number.")
            flag = False
            txtUnitsEntered.SelectAll()
        End Try

        Dim boolrangeCheck As Boolean = value > 0 And value < 1000
        If flag AndAlso Not boolrangeCheck Then
            MsgBox("ERROR: Enter a value in the range 0 to 1000 inclusive.")
            flag = False
        End If

        ' Logic to add integers to array, increment Day counter and update entered values textbox
        If flag AndAlso counterDay <= 7 Then
            txtEnteredValues.AppendText(value & vbCrLf)
            intEntered(counterDay - 1) = value
            ' Int32.TryParse(txtUnitsEntered.Text.Trim, intEntered(counterDay - 1))
            counterDay += 1
            lblDay.Text = "Day " & counterDay.ToString
        End If

        txtUnitsEntered.SelectAll()

        ' Logic to disable buttons and textbox and calculate average using LINQ
        If counterDay > 7 Then
            lblDay.Text = "Day 7"
            txtUnitsEntered.Text = String.Empty
            btnAccept.Enabled = False
            txtUnitsEntered.Enabled = False
            txtDisplay.Text = "Average per day: " _
                & Convert.ToDecimal(intEntered.Average()).ToString("N2")
        End If
    End Sub

    ' Resets Form level variables and input controls
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDisplay.Text = String.Empty
        txtEnteredValues.Text = String.Empty
        txtUnitsEntered.Text = String.Empty
        lblDay.Text = "Day 1:"
        counterDay = 1
        btnAccept.Enabled = True
        txtUnitsEntered.Enabled = True
        intEntered.Initialize()
    End Sub

    'Function getAverage(array As Integer()) As Double
    '    Dim total As Double
    '    Dim totalString As String = ""
    '    For Each i As Double In array
    '        total += i
    '        totalString &= array(i).ToString & vbCrLf
    '    Next
    '    MessageBox.Show(totalString, "Array Test")
    '    Return total / array.Length
    'End Function
End Class
