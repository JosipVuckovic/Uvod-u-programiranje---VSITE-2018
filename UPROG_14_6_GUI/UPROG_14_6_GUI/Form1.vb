Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim stranicaA As Double = Convert.ToDouble(TextBox1.Text.Replace("."c, ","c))
        Dim stranicaB As Double = Convert.ToDouble(TextBox2.Text.Replace("."c, ","c))

        Select Case True
            Case CheckBox1.Checked AndAlso CheckBox2.Checked AndAlso CheckBox3.Checked
                MessageBox.Show("Hipotenuza iznosi: " & Math.Round(Hipotenuza(stranicaA, stranicaB), 2) & ". " & "Površina iznosi: " & Math.Round(Povrsina(stranicaA, stranicaB), 2) & ". " & "Opseg iznosi: " & Math.Round(Opseg(stranicaA, stranicaB), 2) & ".")
                Exit Select
            Case CheckBox1.Checked AndAlso CheckBox2.Checked
                MessageBox.Show("Hipotenuza iznosi: " & Math.Round(Hipotenuza(stranicaA, stranicaB), 2) & ". " & "Površina iznosi: " & Math.Round(Povrsina(stranicaA, stranicaB), 2) & ".")
                Exit Select
            Case CheckBox1.Checked AndAlso CheckBox3.Checked
                MessageBox.Show("Hipotenuza iznosi: " & Math.Round(Hipotenuza(stranicaA, stranicaB), 2) & ". " & "Opseg iznosi: " & Math.Round(Opseg(stranicaA, stranicaB), 2) & ".")
                Exit Select
            Case CheckBox2.Checked AndAlso CheckBox3.Checked
                MessageBox.Show("Površina iznosi: " & Math.Round(Povrsina(stranicaA, stranicaB), 2) & ". " & "Opseg iznosi: " & Math.Round(Opseg(stranicaA, stranicaB), 2) & ".")
                Exit Select
            Case CheckBox1.Checked
                MessageBox.Show("Hipotenuza iznosi: " & Math.Round(Hipotenuza(stranicaA, stranicaB), 2) & ".")
                Exit Select
            Case CheckBox2.Checked
                MessageBox.Show("Površina iznosi: " & Math.Round(Povrsina(stranicaA, stranicaB), 2) & ".")
                Exit Select
            Case CheckBox3.Checked
                MessageBox.Show("Opseg iznosi: " & Math.Round(Opseg(stranicaA, stranicaB), 2) & ".")
                Exit Select
            Case Else
                MessageBox.Show("Molim Vas izaberite što želite računati.")


        End Select
    End Sub
    Private Function Hipotenuza(ByVal stranicaA As Double, ByVal stranicaB As Double) As Double
        Return Math.Sqrt(stranicaA ^ 2 + stranicaB ^ 2)
    End Function
    Private Function Povrsina(ByVal stranicaA As Double, ByVal stranicaB As Double) As Double
        Return ((stranicaA * stranicaB) / 2)
    End Function
    Private Function Opseg(ByVal stranicaA As Double, ByVal stranicaB As Double) As Double
        Return stranicaA + stranicaB + Hipotenuza(stranicaA, stranicaB)
    End Function


End Class
