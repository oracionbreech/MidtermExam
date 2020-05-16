Public Class current
    Private Sub compute_voltage_Click(sender As Object, e As EventArgs) Handles compute_voltage.Click




        Dim VoltageCalculated As Double
        Dim resval, currval As Boolean



        If resistance_value.Text.Length = 0 Then
            resistance_value.BackColor = Color.Red
            resistance_value.ForeColor = Color.White
            resval = False
        Else
            resval = True
        End If


        If current_value.Text.Length = 0 Then
            current_value.BackColor = Color.Red
            current_value.ForeColor = Color.White
            currval = False
        Else
            currval = True
        End If

        If resval = False And currval = False Then
            MessageBox.Show("Please Fix All The Input Errors")
        Else
            Dim resIsDouble, currIsDouble As Boolean
            Dim unused1 = Double.TryParse(resistance_value.Text, resIsDouble)
            Dim unused = Double.TryParse(current_value.Text, currIsDouble)




            If resIsDouble And currIsDouble Then
                resistance_value.BackColor = Color.White
                resistance_value.ForeColor = Color.Black

                current_value.BackColor = Color.White
                current_value.ForeColor = Color.Black

                VoltageCalculated = resistance_value.Text / current_value.Text
                Console.WriteLine(VoltageCalculated)
                voltage_label.Text = VoltageCalculated
            Else

                If resIsDouble = False Then
                    resistance_value.BackColor = Color.Red
                    resistance_value.ForeColor = Color.White

                End If

                If currIsDouble = False Then
                    current_value.BackColor = Color.Red
                    current_value.ForeColor = Color.White

                End If

                MessageBox.Show("You Entered a non-numeric literal")
            End If
        End If

    End Sub

    Private Sub clear_voltage_Click(sender As Object, e As EventArgs) Handles clear_voltage.Click

        resistance_value.BackColor = Color.White
        resistance_value.ForeColor = Color.Black

        current_value.BackColor = Color.White
        current_value.ForeColor = Color.Black

        resistance_value.Text = String.Empty
        current_value.Text = String.Empty
    End Sub
End Class
