Public Class Form1
    Dim x As Integer = 0

    Private Sub sleep(ByVal interval As Integer)
        Dim stopWatch As New Stopwatch
        stopWatch.Start()
        Do While stopWatch.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        stopWatch.Stop()
    End Sub

    Private Sub Zero()
        TextBox1.BackColor = Color.Red
        TextBox2.BackColor = Color.Red
        TextBox3.BackColor = Color.Red
        TextBox4.BackColor = Color.Red
        TextBox5.BackColor = Color.Red
        TextBox6.BackColor = Color.Red
        TextBox10.BackColor = Color.Red
        TextBox11.BackColor = Color.Red
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        TextBox15.BackColor = Color.Red
        TextBox16.BackColor = Color.Red
        TextBox20.BackColor = Color.Red
        TextBox21.BackColor = Color.Red
        TextBox22.BackColor = Color.Red
        TextBox23.BackColor = Color.Red
        TextBox24.BackColor = Color.Red
        TextBox25.BackColor = Color.Red
        x += 1
    End Sub


    Private Sub One()
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox5.BackColor = Color.Red
        TextBox6.BackColor = Color.White
        TextBox10.BackColor = Color.Red
        TextBox11.BackColor = Color.White
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        TextBox15.BackColor = Color.Red
        TextBox16.BackColor = Color.White
        TextBox20.BackColor = Color.Red
        TextBox21.BackColor = Color.White
        TextBox22.BackColor = Color.White
        TextBox23.BackColor = Color.White
        TextBox24.BackColor = Color.White
        TextBox25.BackColor = Color.Red
        x += 1
    End Sub
    Private Sub Two()
        TextBox1.BackColor = Color.Red
        TextBox2.BackColor = Color.Red
        TextBox3.BackColor = Color.Red
        TextBox4.BackColor = Color.Red
        TextBox11.BackColor = Color.Red
        TextBox12.BackColor = Color.Red
        TextBox13.BackColor = Color.Red
        TextBox14.BackColor = Color.Red
        TextBox16.BackColor = Color.Red
        TextBox20.BackColor = Color.White
        TextBox21.BackColor = Color.Red
        TextBox22.BackColor = Color.Red
        TextBox23.BackColor = Color.Red
        TextBox24.BackColor = Color.Red
        x += 1
    End Sub

    Private Sub Three()
        TextBox16.BackColor = Color.White
        TextBox20.BackColor = Color.Red
        x += 1
    End Sub

    Private Sub Four()
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox6.BackColor = Color.Red
        TextBox21.BackColor = Color.White
        TextBox22.BackColor = Color.White
        TextBox23.BackColor = Color.White
        TextBox24.BackColor = Color.White
        x += 1
    End Sub
    Private Sub Five()
        TextBox2.BackColor = Color.Red
        TextBox3.BackColor = Color.Red
        TextBox4.BackColor = Color.Red
        TextBox10.BackColor = Color.White
        TextBox20.BackColor = Color.Red
        TextBox21.BackColor = Color.Red
        TextBox22.BackColor = Color.Red
        TextBox23.BackColor = Color.Red
        TextBox24.BackColor = Color.Red
        x += 1
    End Sub
    Private Sub Six()
        TextBox16.BackColor = Color.Red
        x += 1
    End Sub
    Private Sub Seven()
        TextBox6.BackColor = Color.White
        TextBox10.BackColor = Color.Red
        TextBox11.BackColor = Color.White
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        TextBox16.BackColor = Color.White
        TextBox21.BackColor = Color.White
        TextBox22.BackColor = Color.White
        TextBox23.BackColor = Color.White
        TextBox24.BackColor = Color.White
        x += 1
    End Sub
    Private Sub Eight()
        TextBox6.BackColor = Color.Red
        TextBox11.BackColor = Color.Red
        TextBox12.BackColor = Color.Red
        TextBox13.BackColor = Color.Red
        TextBox14.BackColor = Color.Red
        TextBox16.BackColor = Color.Red
        TextBox20.BackColor = Color.Red
        TextBox21.BackColor = Color.Red
        TextBox22.BackColor = Color.Red
        TextBox23.BackColor = Color.Red
        TextBox24.BackColor = Color.Red
        x += 1
    End Sub
    Private Sub Nine()
        TextBox16.BackColor = Color.White
        x = 0
    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
        While True
            Zero()
            sleep(1000)

            One()
            sleep(1000)

            Two()
            sleep(1000)

            Three()
            sleep(1000)

            Four()
            sleep(1000)

            Five()
            sleep(1000)

            Six()
            sleep(1000)

            Seven()
            sleep(1000)

            Eight()
            sleep(1000)

            Nine()
            sleep(1000)
        End While
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
