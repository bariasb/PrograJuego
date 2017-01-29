Public Class InterfazPicDice
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicDado.Click



    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles Button1.Click





        Dim dado As Integer = CInt(Int((6 * Rnd() + 1)))
        Dim ptotal As Integer = 0


        Select Case dado


            Case 1



                PicDado.Image = Image.FromFile("Dadocara1.jpeg")
                lbldado1.Text = dado.ToString()
                ptotal = 0
                Puntaje.Text = ptotal.ToString()
                MessageBox.Show("Perdio su turno, su puntuacion es cero,  Bazinga")




            Case 2


                PicDado.Image = Image.FromFile("Dadocara2.jpeg")
                lbldado1.Text = dado.ToString()
                'ptotal = ptotal + 2
                'Puntaje.Text = ptotal.ToString()

            Case 3



                PicDado.Image = Image.FromFile("Dadocara3.jpeg")
                lbldado1.Text = dado.ToString()
                'ptotal = ptotal + 3
                'Puntaje.Text = ptotal.ToString()

            Case 4


                PicDado.Image = Image.FromFile("Dadocara4.jpeg")
                lbldado1.Text = dado.ToString()
                'ptotal = ptotal + 4
                'Puntaje.Text = ptotal.ToString()




            Case 5



                PicDado.Image = Image.FromFile("Dadocara5.jpeg")
                lbldado1.Text = dado.ToString()
                'ptotal = ptotal + 5
                'Puntaje.Text = ptotal.ToString()

            Case 6


                PicDado.Image = Image.FromFile("dadocara6.jpeg")
                lbldado1.Text = dado.ToString()
                'ptotal = ptotal + 6
                'Puntaje.Text = ptotal.ToString()






        End Select

        If dado <> 1 Then



            Puntaje.Text = ptotal.ToString()


        End If



    End Sub






    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Jugador.Click

    End Sub

    Private Sub Sumatoria_Click(sender As Object, e As EventArgs) Handles Sumatoria.Click

        Dim temporal As Integer


        ' lbldado1.Text = 

    End Sub

    Private Sub Jugador1_TextChanged(sender As Object, e As EventArgs) Handles Jugador1.TextChanged




    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dado As Integer = CInt(Int((6 * Rnd() + 1)))

    End Sub

    Private Sub Puntaje_TextChanged(sender As Object, e As EventArgs) Handles Puntaje.TextChanged




    End Sub
End Class
