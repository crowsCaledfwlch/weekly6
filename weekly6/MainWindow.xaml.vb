Imports System.Collections.Generics
Class MainWindow
    Private Sub btnEnter_Click(sender As Object, e As RoutedEventArgs) Handles btnEnter.Click
        lstSpeeds.Items.Clear()
        Dim SpeedsList As New List(Of Decimal)()
        For index = 1 To 10
            Dim myValue, num
            myValue = InputBox("Plase enter the speed of your internet in Mbps")
            If myValue.ToString.Length.Equals(0) Then
                Exit For
            End If
            Try
                num = Convert.ToDecimal(myValue)
                If num > 0 Then
                    lstSpeeds.Items.Add(myValue)
                    SpeedsList.Add(num)
                Else
                    MsgBox("Please enter a positive value.")
                    index -= 1
                End If
            Catch ex As Exception
                MsgBox("Please enter a numeric value.")
                index -= 1
            End Try
        Next
        If SpeedsList.Count > 0 Then
            Dim total As Decimal
            For Each item In SpeedsList
                total += item
            Next
            Dim SpeedAverage As Decimal
            SpeedAverage = total / SpeedsList.Count
            SpeedAverage = Math.Round(100 * SpeedAverage) / 100
            lblSpeed.Content = Convert.ToString(SpeedAverage) + " Mbps"
        Else
            lblSpeed.Content = "No Speeds Entered!!!"
        End If

    End Sub

    Private Sub Form_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
