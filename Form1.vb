Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height As Integer
        Dim weight As Decimal
        Dim bmi As Decimal

        weight = TextBox1.Text
        height = TextBox2.Text
        bmi = weight / (height * height)

        lblresult.Text = "Your BMI is " + Format(bmi, "0.0")

        If bmi < 18.5 Then
            MessageBox.Show("Underweight")
        ElseIf bmi >= 18.5 And bmi <= 24.9 Then
            MessageBox.Show("Normal Weight")
        ElseIf bmi >= 25 And bmi <= 29.9 Then
            MessageBox.Show("Overweight")
        ElseIf bmi >= 30 Then
            MessageBox.Show("Obesity")
        End If
    End Sub
End Class